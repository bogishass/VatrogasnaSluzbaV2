using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using VatrogasnaSluzba.DTO;
using VatrogasnaSluzba.Entiteti;
using VatrogasnaSluzba.Helpers;

namespace VatrogasnaSluzba.Forms
{
    public enum FormMode { Default, Creating, Editing }

    public partial class ZaposleniForm : Form
    {
        private readonly Dictionary<string, (DataGridView Grid, GroupBox Box)> pozicijeMap;
        private readonly Point infoBoxPosition = new Point(12, 492);

        private LiceDTO? currentLice;
        private FormMode CurrentMode = FormMode.Default;

        public ZaposleniForm()
        {
            InitializeComponent();

            pozicijeMap = new()
            {
                ["Vatrogasac"] = (dataGridVatrogasci, gbInfoVatrogasac),
                ["Tehnicar"] = (dataGridTehnicari, gbInfoTehnicar),
                ["Dispecer"] = (dataGridDispeceri, gbInfoDispecer),
                ["Volonter"] = (dataGridVolonteri, gbInfoVolonter)
            };

            InitUI();
            SetMode(FormMode.Default);
            PopulateStanice();
            PopulateLica();
        }

        // ---------------- UI inicijalizacija ----------------

        private void InitUI()
        {
            foreach (var pair in pozicijeMap.Values)
            {
                var grid = pair.Grid;
                var box = pair.Box;

                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grid.MultiSelect = false;
                grid.ReadOnly = true;
                grid.AllowUserToAddRows = false;
                grid.AllowUserToDeleteRows = false;
                grid.SelectionChanged += DataGrid_SelectionChanged;

                box.Location = infoBoxPosition;
                box.Visible = false;
            }

            gbInfoVatrogasac.Visible = true;

            comboPol.Items.AddRange(new[] { "M", "Z" });
            comboPozicija.Items.AddRange(pozicijeMap.Keys.ToArray());

            btnSpisakVozila.Click += btnSpisakVozila_Click;
            btnAlati.Click += btnAlati_Click;

            // dugmici sacuvaj, otkazi
            btnSacuvaj.Click += btnSacuvaj_Click;
            btnOtkazi.Click += btnOtkazi_Click;
            btnSacuvaj.Visible = false;
            btnOtkazi.Visible = false;
        }

        private void PopulateStanice()
        {
            var stanice = StanicaDTOManager.GetSveStaniceSimple();
            comboStanica.DataSource = stanice;
            comboStanica.DisplayMember = "Naziv";
            comboStanica.ValueMember = "IdStanice";
            comboStanica.SelectedIndex = -1;
        }

        private void PopulateLica()
        {
            foreach (var valuePair in pozicijeMap.Values)
            {
                valuePair.Grid.Rows.Clear();
                valuePair.Grid.DataSource = null;
            }

            var svaLica = LiceDTOManager.GetSvaLicaList();

            foreach (var pair in pozicijeMap)
            {
                var list = svaLica.Where(l => l.Pozicija == pair.Key).ToList();
                pair.Value.Grid.DataSource = new BindingList<LiceListDTO>(list);
                pair.Value.Grid.Columns["Pozicija"].Visible = false;
            }
        }

        // ---------------- Stanja forme ----------------

        private void SetMode(FormMode mode)
        {
            CurrentMode = mode;
            bool active = mode != FormMode.Default;

            btnSacuvaj.Visible = active;
            btnOtkazi.Visible = active;

            btnNovi.Enabled = !active;
            btnIzmeni.Enabled = !active;
            btnObrisi.Enabled = !active;
            txbPretraga.Enabled = !active;
            tabControl.Enabled = !active;
            btnSpisakVozila.Enabled = ((currentLice is VolonterDTO || currentLice == null) && mode != FormMode.Creating); // spisak vozila moze da se otvori u FormMode.Default (samo pregled) i FormMode.Editing (dozvoljene izmene)
            btnAlati.Enabled = ((currentLice is TehnicarDTO || currentLice == null) && mode != FormMode.Creating);

            foreach (var pair in pozicijeMap.Values)
            {
                pair.Grid.Enabled = !active;
            }

            if (mode == FormMode.Creating)
            {
                ClearSelection();
                ClearInfoBox();
                txbMatbr.Enabled = true;
                comboPozicija.SelectedIndex = -1;
                comboPol.SelectedIndex = -1;
                comboStanica.SelectedIndex = -1;
                currentLice = null;
            }
            else if (mode == FormMode.Editing)
            {
                txbMatbr.Enabled = false; // Ne moze da se menja uopste ako je false?
            }
        }

        // ---------------- Dugmad ----------------

        private void btnNovi_Click(object sender, EventArgs e)
        {
            SetMode(FormMode.Creating);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (currentLice == null)
            {
                MessageBox.Show("Izaberite zaposlenog za izmenu.");
                return;
            }

            SetMode(FormMode.Editing);
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            ClearSelection();
            ClearInfoBox();
            currentLice = null;
            SetMode(FormMode.Default);
            PopulateLica();
        }

        // -------------- Search -----------------
        private void txbPretraga_TextChanged(object sender, EventArgs e)
        {
            if (CurrentMode != FormMode.Default)
                return;

            string filterText = txbPretraga.Text.Trim().ToLower();
            bool isFilterEmpty = string.IsNullOrEmpty(filterText);

            foreach (var item in pozicijeMap.Values)
            {
                var grid = item.Grid;
                var cm = (CurrencyManager)BindingContext[grid.DataSource];

                cm.SuspendBinding();
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (isFilterEmpty)
                    {
                        row.Visible = true;
                        continue;
                    }

                    bool match = FilterRow(row, filterText, new List<int> { 0, 1, 2, 4 });
                    row.Visible = match;
                }
                cm.ResumeBinding();
            }
        }

        private bool FilterRow(DataGridViewRow row, string filterText, List<int> columnIndices)
        {
            foreach (var index in columnIndices)
            {
                var targetString = row.Cells[index].Value.ToString()?.ToLower() ?? "";
                if (targetString.Contains(filterText))
                {
                    return true;
                }
            }

            return false;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (!LiceValidator.ValidateLiceForm(
                    txbMatbr, txbIme, txbPrezime,
                    comboPol, txbAdresa, txbEmail,
                    comboPozicija, comboStanica))
                {
                    return;
                }

                StanicaSimpleDTO selektovanaStanica = (StanicaSimpleDTO)comboStanica.SelectedItem;
                string pozicija = comboPozicija.SelectedItem?.ToString() ?? "";

                if (CurrentMode == FormMode.Creating)
                {
                    var newLice = CreateLiceDTOFromForm(pozicija, selektovanaStanica);
                    if (LiceDTOManager.AddLice(newLice))
                        MessageBox.Show("Zaposleni uspešno dodat.");
                }
                else if (CurrentMode == FormMode.Editing)
                {
                    if (currentLice == null)
                    {
                        MessageBox.Show("Nema selektovanog zaposlenog.");
                        return;
                    }

                    var updatedLice = CreateLiceDTOFromForm(pozicija, selektovanaStanica, currentLice);
                    if (LiceDTOManager.UpdateLice(updatedLice))
                        MessageBox.Show("Podaci uspešno izmenjeni.");
                }

                ClearSelection();
                ClearInfoBox();
                currentLice = null;
                SetMode(FormMode.Default);
                PopulateLica();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentLice == null)
                {
                    MessageBox.Show("Izaberite zaposlenog za brisanje.");
                    return;
                }

                var result = MessageBox.Show(
                    $"Da li ste sigurni da želite da obrišete {currentLice.Ime} {currentLice.Prezime}?",
                    "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes && LiceDTOManager.DeleteLice(currentLice.MaticniBroj))
                {
                    MessageBox.Show("Lice uspešno obrisano.");
                    PopulateLica();
                    ClearSelection();
                    ClearInfoBox();
                    currentLice = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void btnSpisakVozila_Click(object sender, EventArgs e)
        {
            if (currentLice is not VolonterDTO lice)
            {
                MessageBox.Show("Izaberite volontera za pregled vozila.");
                return;
            }

            bool isViewOnly = CurrentMode == FormMode.Default;
            using (var form = new VozilaVolonteraForm(lice, isViewOnly))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show($"Novi spisak zabeležn. Ukupan broj vozila sada: {lice.Vozila.Count}. Sačuvajte izmene volontera kako bi se sačuvala nova vozila.");
                }
            }
        }
        private void btnAlati_Click(object sender, EventArgs e)
        {
            if (currentLice is not TehnicarDTO lice)
            {
                MessageBox.Show("Izaberite tehnicara za izmenu alata.");
                return;
            }

            bool isViewOnly = CurrentMode == FormMode.Default;
            using (var form = new AlatiTehnicaraForm(lice, isViewOnly))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show($"Novi spisak alata zabeležen. Sačuvajte izmene zaposlenog kako bi se sačuvao spisak alata.");
                }
            }
        }

        // ---------------- Helpers ----------------

        private LiceDTO CreateLiceDTOFromForm(string pozicija, StanicaSimpleDTO stanica, LiceDTO? baseLice = null)
        {
            // pravimo novo prazno lice 
            LiceDTO lice = baseLice switch
            {
                VatrogasacDTO => new VatrogasacDTO(),
                TehnicarDTO => new TehnicarDTO(),
                DispecerDTO => new DispecerDTO(),
                VolonterDTO => new VolonterDTO(),
                _ => pozicija switch
                {
                    "Vatrogasac" => new VatrogasacDTO(),
                    "Tehnicar" => new TehnicarDTO(),
                    "Dispecer" => new DispecerDTO(),
                    "Volonter" => new VolonterDTO(),
                    _ => new LiceDTO()
                }
            };

            lice.MaticniBroj = baseLice?.MaticniBroj ?? txbMatbr.Text.Trim();
            lice.Ime = txbIme.Text.Trim();
            lice.Prezime = txbPrezime.Text.Trim();
            lice.Pol = comboPol.SelectedItem?.ToString();
            lice.Adresa = txbAdresa.Text.Trim();
            lice.Email = txbEmail.Text.Trim();
            lice.DatumRodjenja = dateRodjenje.Value;
            lice.DatPocetkaAngaz = dateAngazovanje.Value;
            lice.Stanica = stanica;
            lice.Pozicija = pozicija;
            lice.Telefoni = txbTelefoni.Text.Split(',')
                .Select(t => t.Trim())
                .Where(t => !string.IsNullOrEmpty(t))
                .ToList();

            if (lice is VatrogasacDTO v)
            {
                v.NivoObucenosti = comboObucenost.SelectedItem?.ToString();
                v.FizickaSprema = txbSprema.Text;
                v.BrojSertifikata = int.TryParse(txbSertifikati.Text, out int b) ? b : 0;
            }

            if (lice is TehnicarDTO t)
            {
                t.Specijalizacija = txbSpecijalizacija.Text;
                t.Alati = (baseLice as TehnicarDTO).Alati ?? new List<string>();
            }

            if (lice is DispecerDTO d)
            {
                d.TipKomunikacioneOpreme = txbTipOpreme.Text;
                d.BrojSmenaMesecno = int.TryParse(txbBrSmena.Text, out int s) ? s : null;
            }

            if (lice is VolonterDTO vol)
            {
                vol.Vozila = (baseLice as VolonterDTO).Vozila ?? new List<VoziloVolonteraSimpleDTO>();
            }

            return lice;
        }

        private LiceDTO? GetSelectedLice()
        {
            if (tabControl.SelectedTab == null) return null;

            var key = tabControl.SelectedTab.Name;
            var grid = pozicijeMap[key].Grid;
            if (grid.CurrentRow?.DataBoundItem is not LiceListDTO data)
                return null;

            return LiceDTOManager.GetLice(data.MaticniBroj);
        }

        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (CurrentMode != FormMode.Default) return;
            UpdateSelection();
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentMode != FormMode.Default) return;
            UpdateSelection();
        }

        private void comboPozicija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentMode == FormMode.Default)
                return;

            var selected = comboPozicija.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selected))
            {
                return;
            }

            if (selected == tabControl.SelectedTab?.Name)
            {
                ClearInfoBox();
            }

            DisplayInfoBox(selected);
        }

        private void UpdateSelection(LiceDTO? lice = null)
        {
            currentLice = lice ?? GetSelectedLice();
            if (currentLice == null) return;

            txbMatbr.Enabled = false;

            txbMatbr.Text = currentLice.MaticniBroj;
            txbIme.Text = currentLice.Ime;
            txbPrezime.Text = currentLice.Prezime;
            txbAdresa.Text = currentLice.Adresa;
            txbEmail.Text = currentLice.Email;
            txbTelefoni.Text = string.Join(", ", currentLice.Telefoni ?? new List<string>());
            comboPol.SelectedItem = currentLice.Pol;
            comboPozicija.SelectedItem = currentLice.Pozicija;
            comboStanica.SelectedValue = currentLice.Stanica.IdStanice;
            dateRodjenje.Value = currentLice.DatumRodjenja;
            dateAngazovanje.Value = currentLice.DatPocetkaAngaz ?? DateTime.Today;

            DisplayInfoBox(currentLice.Pozicija);
            UpdateInfoBox(currentLice);
        }

        private void DisplayInfoBox(string pozicija)
        {
            foreach (var item in pozicijeMap.Values)
            {
                item.Box.Visible = item.Box == pozicijeMap[pozicija].Box;
            }
        }

        private void UpdateInfoBox(LiceDTO selected)
        {
            switch (selected)
            {
                case VatrogasacDTO v:
                    comboObucenost.SelectedItem = v.NivoObucenosti;
                    txbSprema.Text = v.FizickaSprema;
                    txbSertifikati.Text = v.BrojSertifikata.ToString();
                    break;
                case TehnicarDTO t:
                    txbSpecijalizacija.Text = t.Specijalizacija;
                    break;
                case DispecerDTO d:
                    txbTipOpreme.Text = d.TipKomunikacioneOpreme;
                    txbBrSmena.Text = d.BrojSmenaMesecno?.ToString();
                    break;
                case VolonterDTO:
                    break;
            }
        }

        private void ClearSelection()
        {
            txbMatbr.Clear();
            txbIme.Clear();
            txbPrezime.Clear();
            txbAdresa.Clear();
            txbEmail.Clear();
            txbTelefoni.Clear();
            dateRodjenje.Value = DateTime.Today;
            dateAngazovanje.Value = DateTime.Today;
            comboPol.SelectedIndex = -1;
            comboPozicija.SelectedIndex = -1;
            comboStanica.SelectedIndex = -1;
        }

        private void ClearInfoBox(string? pozicija = null)
        {
            if (pozicija == "Vatrogasac" || pozicija == null)
            {
                txbSprema.Clear();
                txbSertifikati.Clear();
                comboObucenost.SelectedIndex = -1;
            }

            if (pozicija == "Tehnicar" || pozicija == null)
                txbSpecijalizacija.Clear();

            if (pozicija == "Dispecer" || pozicija == null)
            {
                txbTipOpreme.Clear();
                txbBrSmena.Clear();
            }
        }
    }
}
