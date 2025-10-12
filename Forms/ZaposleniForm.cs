using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using VatrogasnaSluzba.DTO;
using VatrogasnaSluzba.Entiteti;
using VatrogasnaSluzba.Helpers;

// TODO: izbaci validaciju za polja koja nisu obavezna
// TODO: volonteri nemaju stanicu?

namespace VatrogasnaSluzba.Forms
{
    public partial class ZaposleniForm : Form
    {
        private readonly Dictionary<string, (DataGridView Grid, GroupBox Box)> pozicijeMap;
        private readonly Point infoBoxPosition = new Point(12, 492);
        private bool isCreatingNew = false;

        public ZaposleniForm()
        {
            InitializeComponent();

            // cuvanje dinamickih UI elemenata
            pozicijeMap = new()
            {
                ["Vatrogasac"] = (dataGridVatrogasci, gbInfoVatrogasac),
                ["Tehnicar"] = (dataGridTehnicari, gbInfoTehnicar),
                ["Dispecer"] = (dataGridDispeceri, gbInfoDispecer),
                ["Volonter"] = (dataGridVolonteri, gbInfoVolonter)
            };

            // pripremanje UI elemenata
            InitUI();

            // ucitavanje podataka u ui elemente
            PopulateStanice();
            PopulateLica();
        }

        private void InitUI()
        {
            foreach (var pair in pozicijeMap.Values)
            {
                var grid = pair.Grid;
                var box = pair.Box;

                // podesavanje gridova

                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grid.MultiSelect = false;
                grid.ReadOnly = true;
                grid.AllowUserToAddRows = false;
                grid.AllowUserToDeleteRows = false;

                // event handler za promenu selekcije u svakom gridu
                grid.SelectionChanged += DataGrid_SelectionChanged;

                // podesavanje group boxova
                box.Location = infoBoxPosition;
                box.Visible = false;
            }

            gbInfoVatrogasac.Visible = true;

            comboPol.Items.AddRange(new[] { "M", "Ž" });
            comboPozicija.Items.AddRange(pozicijeMap.Keys.ToArray());

            // dodavanje event handlera za btnSpisakVozila i btnAlati
            btnSpisakVozila.Click += btnSpisakVozila_Click;
        }

        private void PopulateStanice()
        {
            var stanice = StanicaDTOManager.GetSveStaniceSimple();
            comboStanica.DataSource = stanice;
            comboStanica.DisplayMember = "Naziv";   // prikazuje korisniku
            comboStanica.ValueMember = "IdStanice";        // u pozadini cuva ID
            comboStanica.SelectedIndex = -1;
        }

        private void PopulateLica()
        {
            // ocisti svaki datagrid za svaki slucaj
            foreach (var valuePair in pozicijeMap.Values) // valuePair je svaki par (DataGridView Grid, GroupBox Box)
            {
                valuePair.Grid.Rows.Clear();
                valuePair.Grid.DataSource = null;
            }

            // vraca sva lica iz baze u obliku dto i pravi listu
            var svaLica = LiceDTOManager.GetSvaLicaList();

            // odvajanje po poziciji
            foreach (var pair in pozicijeMap)
            {
                var list = svaLica.Where(l => l.Pozicija == pair.Key).ToList();
                pair.Value.Grid.DataSource = new BindingList<LiceListDTO>(list);
                pair.Value.Grid.Columns["Pozicija"].Visible = false;
            }

            //var vatrogasci = svaLica.Where(l => l.Pozicija == "Vatrogasac").ToList();
            //var tehnicari = svaLica.Where(l => l.Pozicija == "Tehnicar").ToList();
            //var dispeceri = svaLica.Where(l => l.Pozicija == "Dispecer").ToList();
            //var volonteri = svaLica.Where(l => l.Pozicija == "Volonter").ToList();

            //pozicijeMap["Vatrogasac"].Grid.DataSource = new BindingList<LiceListDTO>(vatrogasci);
            //pozicijeMap["Vatrogasac"].Grid.Columns["Pozicija"].Visible = false;

            //pozicijeMap["Tehnicar"].Grid.DataSource = new BindingList<LiceListDTO>(tehnicari);
            //pozicijeMap["Tehnicar"].Grid.Columns["Pozicija"].Visible = false;

            //pozicijeMap["Dispecer"].Grid.DataSource = new BindingList<LiceListDTO>(dispeceri);
            //pozicijeMap["Dispecer"].Grid.Columns["Pozicija"].Visible = false;

            //pozicijeMap["Volonter"].Grid.DataSource = new BindingList<LiceListDTO>(volonteri);
            //pozicijeMap["Volonter"].Grid.Columns["Pozicija"].Visible = false;
        }

        private LiceDTO? GetSelectedLice()
        {
            if (tabControl.SelectedTab == null) { return null; }

            var key = tabControl.SelectedTab.Name; // naziv pozicije: Vatrogasac/Tehnicar/Dispecer/Volonter
            var grid = pozicijeMap[key].Grid;

            if (grid.SelectedCells.Count == 0 || grid.SelectedCells[0].Visible == false)
            {
                ClearSelection();
                ClearInfoBox();
                return null;
            }

            if (grid.CurrentRow?.DataBoundItem is not LiceListDTO data)
            {
                return null;
            }

            return LiceDTOManager.GetLice(data.MaticniBroj); // trazimo LiceDTO na osnovu LiceListDTO iz selektovanog reda koji nema sve podatke
        }

        private void SelectForEdit()
        {
            LiceDTO? selectedLice = GetSelectedLice();
            if (selectedLice == null) { return; }

            txbMatbr.Text = selectedLice.MaticniBroj;
            txbMatbr.Enabled = false;

            txbIme.Text = selectedLice.Ime;
            txbPrezime.Text = selectedLice.Prezime;
            txbAdresa.Text = selectedLice.Adresa;
            txbEmail.Text = selectedLice.Email;
            txbTelefoni.Text = selectedLice.Telefoni != null ? string.Join(", ", selectedLice.Telefoni) : "";

            comboPol.SelectedItem = selectedLice.Pol;
            comboPozicija.SelectedItem = selectedLice.Pozicija;
            comboStanica.SelectedValue = selectedLice.Stanica.IdStanice;

            dateRodjenje.Value = selectedLice.DatumRodjenja;
            dateAngazovanje.Value = selectedLice.DatPocetkaAngaz ?? DateTime.MinValue;

            DisplayInfoBox(selectedLice.Pozicija);
            UpdateInfoBox(selectedLice);
        }

        private void UpdateInfoBox(LiceDTO selectedLice)
        {
            switch (selectedLice)
            {
                case VatrogasacDTO v:
                    comboObucenost.SelectedItem = v.NivoObucenosti;
                    txbSprema.Text = v.FizickaSprema;
                    txbSertifikati.Text = v.BrojSertifikata.ToString();
                    break;

                case TehnicarDTO t:
                    txbSpecijalizacija.Text = t.Specijalizacija;
                    // TODO: alati dugme
                    break;

                case DispecerDTO d:
                    txbTipOpreme.Text = d.TipKomunikacioneOpreme;
                    txbBrSmena.Text = d.BrojSmenaMesecno?.ToString();
                    break;

                case VolonterDTO vol:
                    // TODO: vozila dugme
                    break;

                default:
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
            {
                txbSpecijalizacija.Clear();
            }

            if (pozicija == "Dispecer" || pozicija == null)
            {
                txbTipOpreme.Clear();
                txbBrSmena.Clear();
            }
        }

        private void DisplayInfoBox(string pozicija)
        {
            foreach (var item in pozicijeMap.Values)
            {
                item.Box.Visible = item.Box == pozicijeMap[pozicija].Box;
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectForEdit();
        }

        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            SelectForEdit();
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

        private void txbPretraga_TextChanged(object sender, EventArgs e)
        {
            string filterText = txbPretraga.Text.Trim().ToLower(); // tekst za pretragu
            bool isFilterEmpty = string.IsNullOrEmpty(filterText);

            foreach (var item in pozicijeMap.Values)
            {
                foreach (DataGridViewRow row in item.Grid.Rows)
                {
                    if (isFilterEmpty)
                    {
                        row.Visible = true;
                        continue;
                    }

                    bool match = FilterRow(row, filterText, [0, 1, 2, 4]);

                    CurrencyManager cm = (CurrencyManager)BindingContext[item.Grid.DataSource];
                    cm.SuspendBinding();
                    row.Visible = match; // ako nije match, red se sakrije
                    cm.ResumeBinding();
                }
            }
        }
        private void comboPozicija_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = comboPozicija.SelectedItem?.ToString();

            if (selected == tabControl.SelectedTab?.Name)
            {
                ClearInfoBox();
            }

            foreach (var (key, item) in pozicijeMap)
            {
                item.Box.Visible = (key == selected);
            }
        }

        private void RestrictControls(bool restrict)
        {
            btnIzmeni.Enabled = !restrict;
            btnObrisi.Enabled = !restrict;
            tabControl.Enabled = !restrict;
            txbPretraga.Enabled = !restrict;
            btnSpisakVozila.Enabled = !restrict;
            btnAlati.Enabled = !restrict;
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            try
            {
                // === 1️⃣ KLIK NA "Novi zaposleni" ===
                if (!isCreatingNew)
                {
                    isCreatingNew = true;
                    btnUpisi.Text = "Sačuvaj zaposlenog";

                    // ocisti formu i spremi za unos novog
                    ClearSelection();
                    ClearInfoBox();
                    DisplayInfoBox(tabControl.SelectedTab.Name);
                    comboPol.SelectedIndex = -1;
                    comboPozicija.SelectedIndex = -1;
                    comboStanica.SelectedIndex = -1;
                    txbMatbr.Enabled = true;

                    // onemogucavamo sve ostale ui elemente dok kreiramo lice
                    RestrictControls(true);

                    foreach (var pair in pozicijeMap.Values)
                    {
                        pair.Grid.ClearSelection();
                        pair.Grid.Enabled = false;
                    }

                    return;
                }

                // === 2️⃣ KLIK NA "Sačuvaj zaposlenog" ===
                // validacija osnovnih polja
                if (!LiceValidator.ValidateLiceForm(
                    txbMatbr, txbIme, txbPrezime,
                    comboPol, txbAdresa, txbEmail,
                    comboPozicija, comboStanica))
                {
                    return;
                }

                StanicaSimpleDTO selektovanaStanica = (StanicaSimpleDTO)comboStanica.SelectedItem;
                string pozicija = comboPozicija.SelectedItem.ToString();
                LiceDTO newLice;

                // kreiranje konkretnog DTO objekta u zavisnosti od pozicije
                switch (pozicija)
                {
                    case "Vatrogasac":
                        if (!LiceValidator.ValidateVatrogasac(comboObucenost, txbSprema, txbSertifikati))
                            return;
                        newLice = new VatrogasacDTO
                        {
                            NivoObucenosti = comboObucenost.SelectedItem?.ToString(),
                            FizickaSprema = txbSprema.Text,
                            BrojSertifikata = int.Parse(txbSertifikati.Text)
                        };
                        break;

                    case "Tehnicar":
                        if (!LiceValidator.ValidateTehnicar(txbSpecijalizacija))
                            return;
                        newLice = new TehnicarDTO
                        {
                            Specijalizacija = txbSpecijalizacija.Text,
                            Alati = new List<string>()
                        };
                        break;

                    case "Dispecer":
                        if (!LiceValidator.ValidateDispecer(txbTipOpreme, txbBrSmena))
                            return;
                        newLice = new DispecerDTO
                        {
                            TipKomunikacioneOpreme = txbTipOpreme.Text,
                            BrojSmenaMesecno = int.Parse(txbBrSmena.Text)
                        };
                        break;

                    case "Volonter":
                        newLice = new VolonterDTO
                        {
                            Vozila = new List<VoziloVolonteraSimpleDTO>()
                        };
                        break;

                    default:
                        MessageBox.Show("Nepoznata pozicija zaposlenog.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                // zajednička polja
                newLice.MaticniBroj = txbMatbr.Text.Trim();
                newLice.Ime = txbIme.Text.Trim();
                newLice.Prezime = txbPrezime.Text.Trim();
                newLice.Pol = comboPol.SelectedItem?.ToString();
                newLice.Adresa = txbAdresa.Text.Trim();
                newLice.Email = txbEmail.Text.Trim();
                newLice.DatPocetkaAngaz = dateAngazovanje.Value;
                newLice.DatumRodjenja = dateRodjenje.Value;
                newLice.Pozicija = pozicija;
                newLice.Stanica = selektovanaStanica;
                newLice.Telefoni = txbTelefoni.Text
                    .Split(',')
                    .Select(t => t.Trim())
                    .Where(t => !string.IsNullOrEmpty(t))
                    .ToList();

                // dodavanje u bazu
                bool isSuccess = LiceDTOManager.AddLice(newLice);

                if (isSuccess)
                {
                    MessageBox.Show("Zaposleni uspešno dodat.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateLica();

                    // vrati formu u normalno stanje
                    isCreatingNew = false;
                    btnUpisi.Text = "Novi zaposleni";
                    RestrictControls(false);

                    foreach (var pair in pozicijeMap.Values)
                    {
                        pair.Grid.Enabled = true;
                    }


                    ClearSelection();
                    ClearInfoBox();
                }
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
                LiceDTO? selectedLice = GetSelectedLice();

                if (selectedLice == null) { return; }

                var result = MessageBox.Show(
                    $"Da li ste sigurni da želite da obrišete zaposlenog {selectedLice.Ime} {selectedLice.Prezime}, JMBG {selectedLice.MaticniBroj}?",
                    "Potvrda",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    bool isSuccess = LiceDTOManager.DeleteLice(selectedLice.MaticniBroj);

                    if (isSuccess)
                    {
                        MessageBox.Show("Lice uspešno obrisano.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PopulateLica();
                        SelectForEdit();
                        ClearInfoBox();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void btnSpisakVozila_Click(object sender, EventArgs e)
        {
            var lice = GetSelectedLice() as VolonterDTO;
            if (lice == null)
            {
                MessageBox.Show("Izaberite volontera.");
                return;
            }

            using (var form = new VozilaVolonteraForm(lice))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Preuzmi ažurirani DTO (sa novim vozilima)
                    var azurirani = form.Volonter;
                    lice.Vozila = new List<VoziloVolonteraSimpleDTO>(azurirani.Vozila);

                    MessageBox.Show("Izmene su preuzete iz forme!");
                }
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                LiceDTO? selectedLice = GetSelectedLice();
                if (selectedLice == null)
                {
                    MessageBox.Show("Niste izabrali lice za izmenu.");
                    return;
                }

                if (!LiceValidator.ValidateLiceForm(
                    txbMatbr, txbIme, txbPrezime,
                    comboPol, txbAdresa, txbEmail,
                    comboPozicija, comboStanica))
                {
                    return;
                }

                StanicaSimpleDTO selektovanaStanica = (StanicaSimpleDTO)comboStanica.SelectedItem;
                string pozicija = comboPozicija.SelectedItem.ToString();

                LiceDTO updatedLice;

                switch (pozicija)
                {
                    case "Vatrogasac":
                        updatedLice = new VatrogasacDTO
                        {
                            NivoObucenosti = comboObucenost.SelectedItem?.ToString(),
                            FizickaSprema = txbSprema.Text,
                            BrojSertifikata = int.TryParse(txbSertifikati.Text, out int b) ? b : null
                        };
                        break;

                    case "Tehnicar":
                        updatedLice = new TehnicarDTO
                        {
                            Specijalizacija = txbSpecijalizacija.Text
                        };
                        break;

                    case "Dispecer":
                        updatedLice = new DispecerDTO
                        {
                            TipKomunikacioneOpreme = txbTipOpreme.Text,
                            BrojSmenaMesecno = int.TryParse(txbBrSmena.Text, out int s) ? s : null
                        };
                        break;

                    case "Volonter":
                        updatedLice = new VolonterDTO()
                        {
                            Vozila = ((VolonterDTO)selectedLice).Vozila
                        };
                        break;

                    default:
                        return;
                }

                // zajednička polja
                updatedLice.MaticniBroj = selectedLice.MaticniBroj; //txbMatbr.Text.Trim();
                updatedLice.Ime = txbIme.Text.Trim();
                updatedLice.Prezime = txbPrezime.Text.Trim();
                updatedLice.Pol = comboPol.SelectedItem?.ToString();
                updatedLice.Adresa = txbAdresa.Text.Trim();
                updatedLice.Email = txbEmail.Text.Trim();
                updatedLice.DatPocetkaAngaz = dateAngazovanje.Value;
                updatedLice.DatumRodjenja = dateRodjenje.Value;
                updatedLice.Pozicija = pozicija;
                updatedLice.Stanica = selektovanaStanica;
                updatedLice.Telefoni = txbTelefoni.Text
                    .Split(',')
                    .Select(t => t.Trim())
                    .Where(t => !string.IsNullOrEmpty(t))
                    .ToList();

                bool isSuccess = LiceDTOManager.UpdateLice(updatedLice);

                if (isSuccess)
                {
                    MessageBox.Show("Podaci uspešno izmenjeni.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateLica();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom izmene: " + ex.Message);
            }
        }
    }
}
