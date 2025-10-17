using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VatrogasnaSluzba.DTO;

namespace VatrogasnaSluzba.Forms
{
    public partial class VatrogasnaStanicaForm : Form
    {
        public enum FormMode { Default, Creating, Editing }
        private FormMode CurrentMode = FormMode.Default;
        private int _editingId = 0;

        private readonly string[] _infraKatalog = new[]
        {
            "Garaže","Sala za obuku","Skladišta","Servisna radionica",
            "Punjač aparata","Toranj za vežbe","Rezervoar vode","Komunikacioni centar"
        };

        public VatrogasnaStanicaForm()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            btnSacuvaj.Click += btnSacuvaj_Click;
            btnOtkazi.Click += btnOtkazi_Click;
            btnSmene.Click += btnSmene_Click;

            comboDostupnaInfrastruktura.Items.Clear();
            comboDostupnaInfrastruktura.Items.AddRange(_infraKatalog);
            comboDostupnaInfrastruktura.SelectedIndex = -1;

            SetFormMode(FormMode.Default);
            LoadGrid();
        }

        private void LoadGrid()
        {
            var list = StanicaDTOManager.GetSveStaniceList();
            dataGridView1.Rows.Clear();

            foreach (var s in list)
            {
                var idx = dataGridView1.Rows.Add();
                var r = dataGridView1.Rows[idx];
                r.Cells["ID_Stanice"].Value = s.IdStanice;
                r.Cells["Adresa"].Value = s.Adresa;
                r.Cells["BrojZaposlenih"].Value = s.BrojZaposlenih;
                r.Cells["BrojVozila"].Value = s.BrojVozila;
            }
        }

        private StanicaDTO ReadForm()
        {
            var infra = new List<string>();
            if (comboDostupnaInfrastruktura.SelectedItem is string one)
                infra.Add(one);

            return new StanicaDTO
            {
                IdStanice = _editingId,
                Adresa = tbxAdresa.Text?.Trim(),
                BrojZaposlenih = int.TryParse(txbBrojZaposlenih.Text, out var bz) ? bz : (int?)null,
                BrojVozila = int.TryParse(tbxBrojVozila.Text, out var bv) ? bv : (int?)null,
                PovrsinaObjekta = double.TryParse(txbPovrsinaObjekta.Text, out var pov) ? pov : (double?)null,
                KomandirMbr = string.IsNullOrWhiteSpace(txbKomandir.Text) ? null : txbKomandir.Text.Trim(),
                Infrastruktura = infra
            };
        }

        private void FillForm(StanicaDTO? s)
        {
            txbID_Stanice.Text = s?.IdStanice.ToString() ?? "";
            tbxAdresa.Text = s?.Adresa ?? "";
            txbBrojZaposlenih.Text = s?.BrojZaposlenih?.ToString() ?? "";
            tbxBrojVozila.Text = s?.BrojVozila?.ToString() ?? "";
            txbPovrsinaObjekta.Text = s?.PovrsinaObjekta?.ToString() ?? "";
            txbKomandir.Text = s?.KomandirMbr ?? "";

            if (s != null && s.Infrastruktura != null && s.Infrastruktura.Count > 0)
                comboDostupnaInfrastruktura.SelectedItem =
                    _infraKatalog.FirstOrDefault(x => string.Equals(x, s.Infrastruktura[0], StringComparison.OrdinalIgnoreCase));
            else
                comboDostupnaInfrastruktura.SelectedIndex = -1;
        }

        private void ClearForm()
        {
            txbID_Stanice.Clear();
            tbxAdresa.Clear();
            txbBrojZaposlenih.Clear();
            tbxBrojVozila.Clear();
            txbPovrsinaObjekta.Clear();
            txbKomandir.Clear();
            comboDostupnaInfrastruktura.SelectedIndex = -1;
        }

        private void SetFormMode(FormMode mode)
        {
            CurrentMode = mode;
            btnSacuvaj.Visible = mode != FormMode.Default;
            btnOtkazi.Visible = mode != FormMode.Default;
            button1.Enabled = mode == FormMode.Default;
            button2.Enabled = mode == FormMode.Default;
            button3.Enabled = mode == FormMode.Default;
            txbID_Stanice.Enabled = mode == FormMode.Creating;
        }

        private void EnterEditMode(int id)
        {
            _editingId = id;
            SetFormMode(FormMode.Editing);
        }

        private void EnterCreateMode()
        {
            _editingId = 0;
            SetFormMode(FormMode.Creating);
        }

        private void ExitMode()
        {
            _editingId = 0;
            SetFormMode(FormMode.Default);
        }

        private void dataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            if (CurrentMode != FormMode.Default) return;
            if (dataGridView1.SelectedRows.Count == 0) { ClearForm(); return; }

            var idObj = dataGridView1.SelectedRows[0].Cells["ID_Stanice"].Value;
            if (idObj == null) { ClearForm(); return; }

            var id = Convert.ToInt32(idObj);
            var dto = StanicaDTOManager.GetStanica(id);
            FillForm(dto);
        }

        private void btnSmene_Click(object? sender, EventArgs e)
        {
            var idObj = dataGridView1.SelectedRows[0].Cells["ID_Stanice"].Value;
            if (idObj == null) { MessageBox.Show("Izaberite stanicu za evidenciju smena!"); }

            var id = Convert.ToInt32(idObj);
            var stanica = StanicaDTOManager.GetStanica(id);

            using var f = new SmeneForm(stanica);
            f.ShowDialog(this);
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            if (CurrentMode != FormMode.Default) return;
            EnterCreateMode();
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            if (CurrentMode != FormMode.Default) return;
            if (dataGridView1.SelectedRows.Count == 0) return;

            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_Stanice"].Value);
            if (StanicaDTOManager.DeleteStanica(id))
            {
                LoadGrid();
                ClearForm();
            }
        }

        private void button3_Click(object? sender, EventArgs e)
        {
            if (CurrentMode != FormMode.Default) return;
            if (dataGridView1.SelectedRows.Count == 0) return;

            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_Stanice"].Value);
            EnterEditMode(id);
        }

        private void btnSacuvaj_Click(object? sender, EventArgs e)
        {
            if (CurrentMode == FormMode.Default) return;

            var dto = ReadForm();
            if (CurrentMode == FormMode.Creating)
            {
                if (StanicaDTOManager.AddStanica(dto))
                {
                    ExitMode();
                    LoadGrid();
                    ClearForm();
                }
            }
            else if (CurrentMode == FormMode.Editing)
            {
                if (StanicaDTOManager.UpdateStanica(dto))
                {
                    ExitMode();
                    LoadGrid();
                }
            }
        }

        private void btnOtkazi_Click(object? sender, EventArgs e)
        {
            if (CurrentMode == FormMode.Default) return;

            ExitMode();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_Stanice"].Value);
                FillForm(StanicaDTOManager.GetStanica(id));
            }
            else
            {
                ClearForm();
            }
        }
    }
}
