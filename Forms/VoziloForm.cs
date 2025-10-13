// Forms/VoziloForm.cs  (CODE-BEHIND) — Tip/Podtip kaskadni izbor + CheckedListBox sertifikata ostaje
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VatrogasnaSluzba.DTO;

namespace VatrogasnaSluzba.Forms
{
    public partial class VoziloForm : Form
    {
        private bool _editMode = false;
        private string _editingReg = null;

        // Mapa tip → dozvoljeni podtipovi
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

            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            RedefinisiKolone();

            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            btnDodajVozilo.Click += btnDodajVozilo_Click;
            btnObrisiVozilo.Click += btnObrisiVozilo_Click;
            btnIzmeniVozilo.Click += btnIzmeniVozilo_Click;
            button1.Click += btnSacuvaj_Click;     // Sačuvaj
            btnOtkazi.Click += btnOtkazi_Click;    // Otkaži
            comboTip.SelectedIndexChanged += (_, __) => LoadPodtipOptions();

            // Sertifikati – katalog
            clbSertifikati.Items.AddRange(_katalogSertifikata);

            // Popuni podtipove za inicijalni tip (ako je predefinisan u designeru)
            LoadPodtipOptions();

            SetEditButtons(false);
            LoadList();
        }

        private void RedefinisiKolone()
        {
            listView1.Columns.Clear();
            listView1.Columns.Add("RegBroj", 110);
            listView1.Columns.Add("Tip", 120);
            listView1.Columns.Add("Podtip", 160);
            listView1.Columns.Add("Proizvođač", 130);
            listView1.Columns.Add("GodProizvodnje", 110);
            listView1.Columns.Add("Status", 110);
            listView1.Columns.Add("Kapacitet", 90);
            listView1.Columns.Add("DatIstekaReg", 110);
            listView1.Columns.Add("Sertifikati", 220);
        }

        private void LoadPodtipOptions()
        {
            var tip = comboTip.Text?.Trim();
            comboPodtip.BeginUpdate();
            comboPodtip.Items.Clear();

            if (!string.IsNullOrWhiteSpace(tip) && _podtipi.TryGetValue(tip, out var lst))
                comboPodtip.Items.AddRange(lst.Cast<object>().ToArray());

            // Ako je prazno, ne postavljaj SelectedIndex; ako ima vrednosti, izaberi prvu
            comboPodtip.SelectedIndex = comboPodtip.Items.Count > 0 ? 0 : -1;
            comboPodtip.EndUpdate();
        }

        private void LoadList()
        {
            var data = VoziloDTOManager.GetSvaVozila();

            listView1.BeginUpdate();
            listView1.Items.Clear();

            foreach (var v in data)
            {
                var it = new ListViewItem(v.RegBroj);
                it.SubItems.Add(v.Tip);
                it.SubItems.Add(v.Podtip);
                it.SubItems.Add(v.Proizvodjac);
                it.SubItems.Add(v.GodProizvodnje?.ToString() ?? "");
                it.SubItems.Add(string.IsNullOrWhiteSpace(v.Status) ? "Operativno" : v.Status);
                it.SubItems.Add(v.Kapacitet?.ToString() ?? "");
                it.SubItems.Add(v.DatIstekaReg.HasValue ? v.DatIstekaReg.Value.ToShortDateString() : "");
                it.SubItems.Add(string.Join(", ", v.Sertifikati ?? new List<string>()));
                it.Tag = v.RegBroj;
                listView1.Items.Add(it);
            }

            listView1.EndUpdate();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_editMode) return;
            if (listView1.SelectedItems.Count == 0) { ClearForm(); return; }

            var reg = listView1.SelectedItems[0].Tag as string;
            var dto = VoziloDTOManager.GetVozilo(reg);
            FillForm(dto);
        }

        private VoziloDTO ReadForm() => new VoziloDTO
        {
            RegBroj = txbReg.Text?.Trim(),
            Tip = comboTip.Text?.Trim(),
            Podtip = comboPodtip.Text?.Trim(),   // ← ComboBox
            Proizvodjac = txbProiz.Text?.Trim(),
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

            // prvo osveži listu podtipova za taj tip, pa postavi konkretan izbor
            LoadPodtipOptions();
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
            if (listView1.SelectedItems.Count == 0) return;

            var reg = listView1.SelectedItems[0].Tag as string;
            if (VoziloDTOManager.DeleteVozilo(reg))
            {
                LoadList();
                ClearForm();
            }
        }

        private void btnIzmeniVozilo_Click(object sender, EventArgs e)
        {
            if (_editMode) return;
            if (listView1.SelectedItems.Count == 0) return;

            _editMode = true;
            _editingReg = listView1.SelectedItems[0].Tag as string;

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

            if (listView1.SelectedItems.Count > 0)
            {
                var reg = listView1.SelectedItems[0].Tag as string;
                FillForm(VoziloDTOManager.GetVozilo(reg));
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
            button1.Visible = editing;   // Sačuvaj
            btnOtkazi.Visible = editing; // Otkaži

            btnDodajVozilo.Enabled = !editing;
            btnObrisiVozilo.Enabled = !editing;
            btnIzmeniVozilo.Enabled = !editing;
        }
    }
}
