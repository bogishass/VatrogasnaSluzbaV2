using System;
using VatrogasnaSluzba.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using VatrogasnaSluzba.DTO;

namespace VatrogasnaSluzba.Forms
{
    public partial class VoziloForm : Form
    {
        private bool _editMode = false;
        private string _editingReg = null;
        private BindingList<VoziloDTO> vozila = new();

        
        private readonly Dictionary<string, List<string>> _podtipi = new(StringComparer.OrdinalIgnoreCase)
        {
            { "Vatrogasno",       new List<string>{ "Cisterna", "Platforma", "Vozilo za gašenje šuma" } },
            { "Spasilačko",       new List<string>{ "Za poplave", "Za saobraćajne nesreće" } },
            { "Tehnička podrška", new List<string>{ "Prevoz opreme", "Prevoz tehničara" } }
        };

        private readonly string[] _katalogSertifikata =
        {
            "ADR – prevoz opasnih materija",
            "Atest pumpe za vodu",
            "Atest penog (foam) sistema",
            "Sertifikat radne platforme",
            "Sertifikat za šumsko gašenje",
            "Sertifikat stabilnosti vozila/karoserije",
            "RED/R&TTE usklađenost radio-opreme",
            "Kalibracija merača protoka",
            "Ispitivanje vatrogasnih creva i nastavaka",
            "Sertifikat za hidrauličnu/spasilačku opremu",
            "Sertifikat o zaštitnoj opremi u vozilu"
        };

        public VoziloForm()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = vozila;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

            btnDodajVozilo.Click += btnDodajVozilo_Click;
            btnObrisiVozilo.Click += btnObrisiVozilo_Click;
            btnIzmeniVozilo.Click += btnIzmeniVozilo_Click;
            button1.Click += btnSacuvaj_Click;     
            btnOtkazi.Click += btnOtkazi_Click;    
            btnServis.Click += btnPrikaziServise_Click;
            comboTip.SelectedIndexChanged += (_, __) => LoadPodtip();

            
            clbSertifikati.Items.AddRange(_katalogSertifikata);

            SetEditButtons(false);
            LoadList();
        }

        private void LoadPodtip()
        {
            var tip = comboTip.Text?.Trim();
            comboPodtip.BeginUpdate();
            comboPodtip.Items.Clear();

            if (!string.IsNullOrWhiteSpace(tip) && _podtipi.TryGetValue(tip, out var lst))
                comboPodtip.Items.AddRange(lst.Cast<object>().ToArray());

            comboPodtip.SelectedIndex = comboPodtip.Items.Count > 0 ? 0 : -1;
            comboPodtip.EndUpdate();
        }

        private void LoadList()
        {
            var data = VoziloDTOManager.GetSvaVozila();

            vozila = new BindingList<VoziloDTO>(data);
            dataGridView1.DataSource = vozila;

            
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.Visible = new[]
                {
                    "RegBroj", "Tip", "Podtip", "Proizvodjac", "Status", "DatIstekaReg"
                }.Contains(col.DataPropertyName);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (_editMode) return;
            if (dataGridView1.SelectedRows.Count == 0) { ClearForm(); return; }

            var dto = dataGridView1.SelectedRows[0].DataBoundItem as VoziloDTO;
            if (dto != null)
                FillForm(VoziloDTOManager.GetVozilo(dto.RegBroj));
        }

        private VoziloDTO ReadForm() => new VoziloDTO
        {
            RegBroj = txbReg.Text?.Trim() ?? "",
            Tip = comboTip.Text?.Trim() ?? "",
            Podtip = comboPodtip.Text?.Trim() ?? "",
            Proizvodjac = txbProiz.Text?.Trim() ?? "",
            GodProizvodnje = int.TryParse(txbGodProiz.Text, out var g) ? g : (int?)null,
            Status = "Operativno",
            Kapacitet = int.TryParse(txbKapacitet.Text, out var k) ? k : (int?)null,
            DatIstekaReg = dateTimeIstek.Value.Date,
            Sertifikati = clbSertifikati.CheckedItems.Cast<object>()
                                 .Select(o => o?.ToString())
                                 .Where(s => !string.IsNullOrWhiteSpace(s))
                                 .ToList()
        };

        private void FillForm(VoziloDTO v)
        {
            if (v == null) { ClearForm(); return; }

            txbReg.Text = v.RegBroj;
            comboTip.Text = v.Tip;
            LoadPodtip();
            comboPodtip.Text = v.Podtip;

            txbProiz.Text = v.Proizvodjac;
            txbGodProiz.Text = v.GodProizvodnje?.ToString() ?? "";
            txbKapacitet.Text = v.Kapacitet?.ToString() ?? "";
            dateTimeIstek.Value = v.DatIstekaReg ?? DateTime.Today;

            for (int i = 0; i < clbSertifikati.Items.Count; i++)
            {
                var name = clbSertifikati.Items[i]?.ToString();
                clbSertifikati.SetItemChecked(i, v.Sertifikati?.Contains(name) == true);
            }
        }
        private void ClearForm()
        {
            txbReg.Clear();
            comboTip.SelectedIndex = -1;
            comboPodtip.Items.Clear();
            comboPodtip.SelectedIndex = -1;
            txbProiz.Clear();
            txbGodProiz.Clear();
            txbKapacitet.Clear();
            dateTimeIstek.Value = DateTime.Today;

            for (int i = 0; i < clbSertifikati.Items.Count; i++)
                clbSertifikati.SetItemChecked(i, false);
        }
        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            if (_editMode) return;

            var dto = ReadForm();
            if (VoziloDTOManager.AddVozilo(dto))
            {
                LoadList();
                ClearForm();
            }
        }
        private void btnObrisiVozilo_Click(object sender, EventArgs e)
        {
            if (_editMode) return;
            if (dataGridView1.SelectedRows.Count == 0) return;

            var dto = dataGridView1.SelectedRows[0].DataBoundItem as VoziloDTO;
            if (dto == null) return;

            if (VoziloDTOManager.DeleteVozilo(dto.RegBroj))
            {
                LoadList();
                ClearForm();
            }
        }
        private void btnIzmeniVozilo_Click(object sender, EventArgs e)
        {
            if (_editMode) return;
            if (dataGridView1.SelectedRows.Count == 0) return;

            _editMode = true;
            var dto = dataGridView1.SelectedRows[0].DataBoundItem as VoziloDTO;
            _editingReg = dto?.RegBroj;

            txbReg.ReadOnly = true;
            SetEditButtons(true);
        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!_editMode) return;

            var dto = ReadForm();
            dto.RegBroj = _editingReg;

            if (VoziloDTOManager.UpdateVozilo(dto))
            {
                ExitEditMode();
                LoadList();
            }
        }
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            if (!_editMode) return;

            ExitEditMode();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var dto = dataGridView1.SelectedRows[0].DataBoundItem as VoziloDTO;
                if (dto != null)
                    FillForm(VoziloDTOManager.GetVozilo(dto.RegBroj));
            }
            else
            {
                ClearForm();
            }
        }
        private void ExitEditMode()
        {
            _editMode = false;
            _editingReg = null;

            txbReg.ReadOnly = false;
            SetEditButtons(false);
        }
        private void SetEditButtons(bool editing)
        {
            button1.Visible = editing;   
            btnOtkazi.Visible = editing; 

            btnDodajVozilo.Enabled = !editing;
            btnObrisiVozilo.Enabled = !editing;
            btnIzmeniVozilo.Enabled = !editing;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnPrikaziServise_Click(object sender, EventArgs e)
        {
            var grid = dataGridView1; 
            if (grid == null || grid.SelectedRows.Count == 0) return;

            string regBroj = grid.SelectedRows[0].Cells[0].Value?.ToString() ?? "";
            if (string.IsNullOrWhiteSpace(regBroj)) return;

            using (var frm = new ServisiForm(regBroj))
                frm.ShowDialog(this);
        }

    }
}
