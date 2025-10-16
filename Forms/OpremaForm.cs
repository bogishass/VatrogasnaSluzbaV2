// File: Forms/OpremaForm.cs  (CODE-BEHIND)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VatrogasnaSluzba.DTO;

namespace VatrogasnaSluzba.Forms
{
    public partial class OpremaForm : Form
    {
        private bool _editMode = false;
        private int _editingId = 0;

        // Tipovi i podtipovi
        private readonly Dictionary<string, List<string>> _katalog =
            new(StringComparer.OrdinalIgnoreCase)
            {
                { "Zaštitna oprema",   new List<string>{ "Odelo", "Kaciga", "Čizme" } },
                { "Oprema za gašenje", new List<string>{ "Crevo", "Pumpa", "Aparat" } },
                { "Tehnička oprema",   new List<string>{ "Testera", "Hidraulične makaze", "Radio stanica" } },
                { "Specijalna oprema", new List<string>{ "Termovizijska kamera", "Dron", "Detektor gasa" } }
            };

        public OpremaForm()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            INVBroj.DataPropertyName = "InventarskiBroj";
            Naziv.DataPropertyName = "Naziv";
            Tip.DataPropertyName = "Tip";
            PodTip.DataPropertyName = "Podtip";
            LokacijaOpreme.DataPropertyName = "LokacijaOpreme";
            Status.DataPropertyName = "Status";
            DatumNabavke.DataPropertyName = "DatumNabavke";

            DatumNabavke.DefaultCellStyle.Format = "dd.MM.yyyy";
            DatumNabavke.DefaultCellStyle.NullValue = "";

            comboStatus.Items.AddRange(new[] { "Ispravno", "Oštećeno", "Rashodovano" });

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            btnDodajOpremu.Click += btnDodajOpremu_Click;
            btnUkloniOpremu.Click += button2_Click;
            btnEditujOpremu.Click += btnEditujOpremu_Click;
            btnSacuvaj.Click += btnSacuvaj_Click;
            btnOtkazi.Click += btnOtkazi_Click;
            comboTip.SelectedIndexChanged += (_, __) => PopulatePodtip();

            SetEditButtonsVisible(false);

            LoadGrid();
            LoadTipovi();
            PopulatePodtip();
        }

        private void LoadGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = OpremaDTOManager.GetSvaOpremaList();
        }

        private void dataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            if (_editMode) return;
            if (dataGridView1.CurrentRow?.DataBoundItem is not OpremaListDTO row) return;
            var full = OpremaDTOManager.GetOprema(row.InventarskiBroj);
            FillForm(full);
        }

        private OpremaDTO ReadForm() => new()
        {
            InventarskiBroj = int.TryParse(txbInvBroj.Text, out var v) ? v : 0,
            Naziv = txbNaziv.Text?.Trim() ?? "",
            Tip = comboTip.Text?.Trim() ?? "",
            Podtip = comboPodTip.Text?.Trim() ?? "",
            LokacijaOpreme = txbLokacija.Text?.Trim() ?? "",
            Status = comboStatus.SelectedItem?.ToString() ?? "",
            DatumNabavke = dateTimePickerDatumNabavke.Value.Date
        };

        private void FillForm(OpremaDTO? dto)
        {
            if (dto == null) { ClearForm(); return; }

            txbInvBroj.Text = dto.InventarskiBroj.ToString();
            txbNaziv.Text = dto.Naziv;

            SelectComboValue(comboTip, dto.Tip);
            PopulatePodtip();
            SelectComboValue(comboPodTip, dto.Podtip);

            txbLokacija.Text = dto.LokacijaOpreme;
            comboStatus.SelectedItem = dto.Status;

            dateTimePickerDatumNabavke.Value = dto.DatumNabavke ?? DateTime.MinValue;
        }

        private void ClearForm()
        {
            txbInvBroj.Clear();
            txbNaziv.Clear();
            comboTip.SelectedIndex = -1;
            comboPodTip.SelectedIndex = -1;
            txbLokacija.Clear();
            dateTimePickerDatumNabavke.Value = DateTime.Today;
        }

        private static void SelectComboValue(ComboBox cb, string? val)
        {
            if (string.IsNullOrWhiteSpace(val)) { cb.SelectedIndex = -1; return; }
            var i = cb.FindStringExact(val);
            cb.SelectedIndex = i;
        }

        private void btnDodajOpremu_Click(object? sender, EventArgs e)
        {
            if (_editMode) return;

            var dto = ReadForm();
            if (dto.InventarskiBroj == 0) { MessageBox.Show("Inventarski broj je obavezan."); return; }

            if (OpremaDTOManager.AddOprema(dto))
            {
                LoadGrid();
                ClearForm();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (_editMode) return;
            if (dataGridView1.CurrentRow?.DataBoundItem is not OpremaListDTO row) return;

            if (OpremaDTOManager.DeleteOprema(row.InventarskiBroj))
            {
                LoadGrid();
                ClearForm();
            }
        }
        private void btnEditujOpremu_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is not OpremaListDTO row) return;

            _editMode = true;
            _editingId = row.InventarskiBroj;

            var full = OpremaDTOManager.GetOprema(_editingId);
            FillForm(full);

            txbInvBroj.ReadOnly = true;
            SetEditButtonsVisible(true);

            btnDodajOpremu.Enabled = false;
            btnUkloniOpremu.Enabled = false;
            btnEditujOpremu.Enabled = false;
        }
        private void btnSacuvaj_Click(object? sender, EventArgs e)
        {
            if (!_editMode) return;

            var dto = ReadForm();
            dto.InventarskiBroj = _editingId;

            if (OpremaDTOManager.UpdateOprema(dto))
            {
                ExitEditMode();
                LoadGrid();
            }
        }

        private void btnOtkazi_Click(object? sender, EventArgs e)
        {
            if (!_editMode) return;

            ExitEditMode();

            if (dataGridView1.CurrentRow?.DataBoundItem is OpremaListDTO row)
                FillForm(OpremaDTOManager.GetOprema(row.InventarskiBroj));
            else
                ClearForm();
        }

        private void ExitEditMode()
        {
            _editMode = false;
            _editingId = 0;

            txbInvBroj.ReadOnly = false;
            SetEditButtonsVisible(false);

            btnDodajOpremu.Enabled = true;
            btnUkloniOpremu.Enabled = true;
            btnEditujOpremu.Enabled = true;
        }

        private void SetEditButtonsVisible(bool visible)
        {
            btnSacuvaj.Visible = visible;
            btnOtkazi.Visible = visible;
        }

        private void LoadTipovi()
        {
            comboTip.BeginUpdate();
            comboTip.DataSource = _katalog.Keys.OrderBy(s => s).ToList();
            comboTip.EndUpdate();
        }

        private void PopulatePodtip()
        {
            var tip = comboTip.Text;
            var pods = _katalog.TryGetValue(tip, out var lst) ? lst : new List<string>();

            comboPodTip.BeginUpdate();
            comboPodTip.DataSource = pods;
            comboPodTip.EndUpdate();

            if (comboPodTip.Items.Count > 0 && comboPodTip.SelectedIndex < 0)
                comboPodTip.SelectedIndex = 0;
        }
    }
}
