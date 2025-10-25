
using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VatrogasnaSluzba.DTO;

namespace VatrogasnaSluzba.Forms
{
    public partial class ServisiForm : Form
    {
        private enum FormMode { Default, Creating, Editing }

        private readonly string currentRegBroj;
        private readonly BindingList<ServisListDTO> model = new();
        private FormMode mode = FormMode.Default;
        private int editingId = 0;

        public ServisiForm(string regBroj)
        {
            InitializeComponent();

            currentRegBroj = regBroj;
            lblNaslov.Text = $"Servisi za vozilo: {currentRegBroj}";

            InitGrid();
            InitTipovi();
            SetMode(FormMode.Default);
            RefreshData();
            WireHandlers();
        }

        private void InitGrid()
        {
            dgvServisi.AutoGenerateColumns = false;
            dgvServisi.Columns.Clear();

            var colDatum = new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(ServisListDTO.Datum),
                HeaderText = "Datum",
                ReadOnly = true,
                DefaultCellStyle = { Format = "dd.MM.yyyy" }
            };
            var colTip = new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(ServisListDTO.Tip),
                HeaderText = "Tip",
                ReadOnly = true,

            };
            var colMbr = new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(ServisListDTO.TehnicarMbr),
                HeaderText = "MBR tehničara",
                ReadOnly = true,

            };
            var colId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(ServisListDTO.IdServisa),
                HeaderText = "ID",
                Visible = false
            };

            dgvServisi.Columns.AddRange(colDatum, colTip, colMbr, colId);
            dgvServisi.DataSource = model;
            dgvServisi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServisi.MultiSelect = false;
            dgvServisi.ReadOnly = true;
            dgvServisi.AllowUserToAddRows = false;
        }

        private void InitTipovi()
        {
            cbTip.Items.Clear();
            cbTip.Items.AddRange(new object[]
            {
                "Redovni servis",
                "Mali servis",
                "Veliki servis",
                "Kočioni sistem",
                "Elektronika",
                "Pneumatici",
                "Ostalo"
            });
            if (cbTip.Items.Count > 0) cbTip.SelectedIndex = 0;
        }

        private void WireHandlers()
        {
            btnNovi.Click += (_, __) => BeginCreate();
            btnIzmeni.Click += (_, __) => BeginEdit();
            btnObrisi.Click += (_, __) => DeleteSelected();
            btnSacuvaj.Click += (_, __) => Save();
            btnOtkazi.Click += (_, __) => CancelEdit();
            dgvServisi.SelectionChanged += (_, __) => SyncInputs();

            txtTehnicar.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            };

            txtTehnicar.TextChanged += (_, __) =>
            {
                if (txtTehnicar.Text.Length > 13)
                    txtTehnicar.Text = txtTehnicar.Text.Substring(0, 13);
                txtTehnicar.SelectionStart = txtTehnicar.Text.Length;
            };
        }

        private void SetMode(FormMode mode)
        {
            mode = mode;
            bool editing = mode != FormMode.Default;

            dtpDatum.Enabled = editing;
            cbTip.Enabled = editing;
            txtTehnicar.Enabled = editing;

            btnNovi.Enabled = !editing;
            btnIzmeni.Enabled = !editing && dgvServisi.SelectedRows.Count == 1;
            btnObrisi.Enabled = !editing && dgvServisi.SelectedRows.Count == 1;

            btnSacuvaj.Visible = editing;
            btnOtkazi.Visible = editing;
        }

        private void RefreshData()
        {
            model.Clear();
            foreach (var r in ServisDTOManager.GetServisiZaVozilo(currentRegBroj))
                model.Add(r);

            btnIzmeni.Enabled = dgvServisi.SelectedRows.Count == 1;
            btnObrisi.Enabled = dgvServisi.SelectedRows.Count == 1;
        }

        private void BeginCreate()
        {
            editingId = 0;
            dtpDatum.Value = DateTime.Today;
            if (cbTip.Items.Count > 0) cbTip.SelectedIndex = 0;
            txtTehnicar.Clear();
            SetMode(FormMode.Creating);
            txtTehnicar.Focus();
        }

        private void BeginEdit()
        {
            if (dgvServisi.CurrentRow?.DataBoundItem is not ServisListDTO row) return;

            editingId = row.IdServisa;
            dtpDatum.Value = row.Datum?.Date ?? DateTime.Today;
            cbTip.SelectedItem = cbTip.Items.Cast<object>().FirstOrDefault(x => x.ToString() == row.Tip) ?? cbTip.Items[0];
            txtTehnicar.Text = row.TehnicarMbr ?? "";
            SetMode(FormMode.Editing);
            txtTehnicar.Focus();
            txtTehnicar.SelectAll();
        }

        private void DeleteSelected()
        {
            if (dgvServisi.CurrentRow?.DataBoundItem is not ServisListDTO row) return;

            if (MessageBox.Show("Obrisati selektovani servis?", "Potvrda",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ServisDTOManager.DeleteServis(row.IdServisa))
                    RefreshData();
            }
        }

        private void Save()
        {
            var tip = cbTip.SelectedItem?.ToString() ?? "";
            var datum = dtpDatum.Value.Date;
            var mbr = (txtTehnicar.Text ?? "").Trim();

            if (!IsValidMbr(mbr))
            {
                MessageBox.Show("Unesite važeći MBR tehničara (tačno 13 cifara).");
                txtTehnicar.Focus();
                txtTehnicar.SelectAll();
                return;
            }

            var dto = new ServisDTO
            {
                IdServisa = editingId,
                RegBrojVozila = currentRegBroj,
                Datum = datum,
                Tip = tip,
                TehnicarMbr = mbr
            };

            bool ok = mode == FormMode.Creating
                ? ServisDTOManager.AddServis(dto)
                : ServisDTOManager.UpdateServis(dto);

            if (ok)
            {
                RefreshData();
                SetMode(FormMode.Default);
            }
        }

        private void CancelEdit()
        {
            SetMode(FormMode.Default);
            SyncInputs();
        }

        private void SyncInputs()
        {
            if (mode != FormMode.Default) return;

            if (dgvServisi.CurrentRow?.DataBoundItem is ServisListDTO row)
            {
                dtpDatum.Value = row.Datum?.Date ?? DateTime.Today;
                cbTip.SelectedItem = cbTip.Items.Cast<object>().FirstOrDefault(x => x.ToString() == row.Tip) ?? cbTip.Items[0];
                txtTehnicar.Text = row.TehnicarMbr ?? "";
            }

            btnIzmeni.Enabled = dgvServisi.SelectedRows.Count == 1;
            btnObrisi.Enabled = dgvServisi.SelectedRows.Count == 1;
        }

        private static bool IsValidMbr(string mbr)
            => !string.IsNullOrWhiteSpace(mbr) && Regex.IsMatch(mbr, @"^\d{13}$");
    }
}
