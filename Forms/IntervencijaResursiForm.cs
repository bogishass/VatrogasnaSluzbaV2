using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VatrogasnaSluzba.DTO;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.Forms
{
    public partial class IntervencijaResursiForm : Form
    {
        private FormMode currentMode = FormMode.Default;

        private List<VatrogasacDTO> vatrogasci = new();
        private List<DispecerDTO> dispeceri = new();
        private List<TehnicarDTO> tehnicari = new();
        private List<VolonterDTO> volonteri = new();
        private List<VoziloDTO> vozila = new();
        private List<OpremaDTO> oprema = new();
        private List<VoziloVolonteraSimpleDTO> vozilaVolontera = new();

        public List<LiceDTO> IzabranaLica { get; private set; } = new();
        public List<VoziloDTO> IzabranaVozila { get; private set; } = new();
        public List<OpremaDTO> IzabranaOprema { get; private set; } = new();
        public List<VoziloVolonteraSimpleDTO> IzabranaVozilaVolontera { get; private set; } = new();

        private Dictionary<DataGridView, HashSet<int>> backupChecks = new();

        public IntervencijaResursiForm(IntervencijaDTO intervencija)
        {
            if (intervencija == null) return;

            InitializeComponent();

            btnIzmeni.Click += btnIzmeni_Click;
            btnOdbaci.Click += btnOdbaci_Click;
            btnOK.Click += btnOK_Click;
            btnOtkazi.Click += btnOtkazi_Click;

            // Inicijalizacija kolona
            PostaviKoloneLica(dgvVatrogasci);
            PostaviKoloneLica(dgvDispeceri);
            PostaviKoloneLica(dgvTehnicari);
            PostaviKoloneLica(dgvVolonteri);
            PostaviKoloneVozila(dgvVozila);
            PostaviKoloneOprema(dgvOprema);
            PostaviKoloneVozilaVolontera(dgvVozilaVolontera);

            UcitajPodatke();
            PostaviMode(FormMode.Default);

            // ucitaj sta je checkirano
            LoadSelections(dgvVatrogasci, vatrogasci.Cast<LiceDTO>().ToList(), intervencija.Lica);
            LoadSelections(dgvDispeceri, dispeceri.Cast<LiceDTO>().ToList(), intervencija.Lica);
            LoadSelections(dgvTehnicari, tehnicari.Cast<LiceDTO>().ToList(), intervencija.Lica);
            LoadSelections(dgvVolonteri, volonteri.Cast<LiceDTO>().ToList(), intervencija.Lica);
            LoadSelections(dgvVozila, vozila, intervencija.Vozila);
            LoadSelections(dgvOprema, oprema, intervencija.Oprema);
            LoadSelections(dgvVozilaVolontera, vozilaVolontera, intervencija.VozilaVolontera);
        }

        private void PostaviKoloneLica(DataGridView dgv)
        {
            dgv.Columns.Clear();

            var chkCol = new DataGridViewCheckBoxColumn
            {
                HeaderText = "",
                Width = 28,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };

            dgv.Columns.Add(chkCol);
            dgv.Columns.Add("Ime", "Ime");
            dgv.Columns.Add("Prezime", "Prezime");
            dgv.Columns.Add("JMBG", "JMBG");
            dgv.Columns.Add("Stanica", "Stanica");
            dgv.Columns.Add("IDstanice", "ID stanice");
        }

        private void PostaviKoloneVozila(DataGridView dgv)
        {
            dgv.Columns.Clear();

            var chkCol = new DataGridViewCheckBoxColumn
            {
                HeaderText = "",
                Width = 28,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };

            dgv.Columns.Add(chkCol);
            dgv.Columns.Add("RegBroj", "Reg. broj");
            dgv.Columns.Add("Tip", "Tip");
            dgv.Columns.Add("Podtip", "Podtip");
            dgv.Columns.Add("Proizvodjac", "Proizvođač");
            dgv.Columns.Add("GodProizvodnje", "God. proizvodnje");
            dgv.Columns.Add("Status", "Status");
        }

        private void PostaviKoloneOprema(DataGridView dgv)
        {
            dgv.Columns.Clear();

            var chkCol = new DataGridViewCheckBoxColumn
            {
                HeaderText = "",
                Width = 28,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };

            dgv.Columns.Add(chkCol);
            dgv.Columns.Add("InventarskiBroj", "Inventarski broj");
            dgv.Columns.Add("Naziv", "Naziv");
            dgv.Columns.Add("Tip", "Tip");
            dgv.Columns.Add("Podtip", "Podtip");
            dgv.Columns.Add("LokacijaOpreme", "Lokacija");
            dgv.Columns.Add("Status", "Status");
        }

        private void PostaviKoloneVozilaVolontera(DataGridView dgv)
        {
            dgv.Columns.Clear();

            var chkCol = new DataGridViewCheckBoxColumn
            {
                HeaderText = "",
                Width = 28,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };

            dgv.Columns.Add(chkCol);
            dgv.Columns.Add("RegBroj", "Reg. broj");
            dgv.Columns.Add("Tip", "Tip");
            dgv.Columns.Add("Proizvodjac", "Proizvođač");
            dgv.Columns.Add("VlasnikImePrezime", "Vlasnik");
            dgv.Columns.Add("VlasnikJMBG", "JMBG vlasnika");
        }

        private void UcitajPodatke()
        {
            // --- LICA ---
            var svaLica = LiceDTOManager.GetSvaLica();

            vatrogasci = svaLica.OfType<VatrogasacDTO>()
                .OrderBy(v => v.Stanica?.Naziv)
                .ThenBy(v => v.Prezime)
                .ToList();

            dispeceri = svaLica.OfType<DispecerDTO>()
                .OrderBy(v => v.Stanica?.Naziv)
                .ThenBy(v => v.Prezime)
                .ToList();

            tehnicari = svaLica.OfType<TehnicarDTO>()
                .OrderBy(v => v.Stanica?.Naziv)
                .ThenBy(v => v.Prezime)
                .ToList();

            volonteri = svaLica.OfType<VolonterDTO>()
                .OrderBy(v => v.Stanica?.Naziv)
                .ThenBy(v => v.Prezime)
                .ToList();

            // --- VOZILA ---
            vozila = VoziloDTOManager.GetSvaVozila()
                .OrderBy(v => v.Tip)
                .ThenBy(v => v.RegBroj)
                .ToList();

            // --- OPREMA ---
            oprema = OpremaDTOManager.GetSvaOprema()
                .OrderBy(o => o.Naziv)
                .ThenBy(o => o.InventarskiBroj)
                .ToList();

            // --- VOZILA VOLONTERA ---
            vozilaVolontera = VoziloVolonteraDTOManager.GetSvaVozilaVolontera()
                .OrderBy(v => v.Tip)
                .ThenBy(v => v.RegBroj)
                .ToList();

            PopuniGridLica(dgvVatrogasci, vatrogasci);
            PopuniGridLica(dgvDispeceri, dispeceri);
            PopuniGridLica(dgvTehnicari, tehnicari);
            PopuniGridLica(dgvVolonteri, volonteri);
            PopuniGridVozila(dgvVozila, vozila);
            PopuniGridOprema(dgvOprema, oprema);
            PopuniGridVozilaVolontera(dgvVozilaVolontera, vozilaVolontera);
        }

        private void PopuniGridLica<T>(DataGridView dgv, IEnumerable<T> lista) where T : LiceDTO
        {
            dgv.Rows.Clear();
            foreach (var l in lista)
            {
                var nazivStanice = l.Stanica?.Naziv ?? "Nepoznata stanica";
                var idStanice = l.Stanica?.IdStanice.ToString() ?? "—";
                dgv.Rows.Add(false, l.Ime, l.Prezime, l.MaticniBroj, nazivStanice, idStanice);
            }
        }

        private void PopuniGridVozila(DataGridView dgv, IEnumerable<VoziloDTO> lista)
        {
            dgv.Rows.Clear();
            foreach (var v in lista)
            {
                dgv.Rows.Add(false, v.RegBroj, v.Tip, v.Podtip, v.Proizvodjac,
                    v.GodProizvodnje, v.Status);
            }
        }

        private void PopuniGridOprema(DataGridView dgv, IEnumerable<OpremaDTO> lista)
        {
            dgv.Rows.Clear();
            foreach (var o in lista)
            {
                dgv.Rows.Add(false, o.InventarskiBroj, o.Naziv, o.Tip, o.Podtip,
                    o.LokacijaOpreme, o.Status);
            }
        }

        private void PopuniGridVozilaVolontera(DataGridView dgv, IEnumerable<VoziloVolonteraSimpleDTO> lista)
        {
            dgv.Rows.Clear();
            foreach (var v in lista)
            {
                var volonter = volonteri.Where(x => x.MaticniBroj == v.VlasnikJMBG).FirstOrDefault();
                dgv.Rows.Add(false, v.RegBroj, v.Tip, v.Proizvodjac, $"{volonter?.Ime ?? ""} {volonter?.Prezime ?? ""}", v.VlasnikJMBG);
            }
        }

        private void PostaviMode(FormMode mode)
        {
            currentMode = mode;
            bool edit = mode == FormMode.Edit;

            SetReadOnly(dgvVatrogasci, !edit);
            SetReadOnly(dgvDispeceri, !edit);
            SetReadOnly(dgvTehnicari, !edit);
            SetReadOnly(dgvVolonteri, !edit);
            SetReadOnly(dgvVozila, !edit);
            SetReadOnly(dgvOprema, !edit);
            SetReadOnly(dgvVozilaVolontera, !edit);

            btnOdbaci.Enabled = edit;
            btnIzmeni.Text = edit ? "Sačuvaj" : "Izmeni";

            btnOK.Enabled = !edit;
        }

        private void SetReadOnly(DataGridView dgv, bool readOnly)
        {
            dgv.ReadOnly = readOnly;

            if (!readOnly)
            {
                dgv.Columns[0].ReadOnly = false;
                for (int i = 1; i < dgv.Columns.Count; i++)
                    dgv.Columns[i].ReadOnly = true;
            }
        }

        private void LoadSelections<T>(DataGridView dgv, List<T> svi, List<T> selektovani) where T : class
        {
            if (selektovani == null || selektovani.Count == 0) return;

            for (int i = 0; i < svi.Count; i++)
            {
                var item = svi[i];
                if (selektovani.Any(sel => CompareResurs(item, sel)))
                    dgv.Rows[i].Cells[0].Value = true;
            }
        }

        private bool CompareResurs(object a, object b)
        {
            if (a is LiceDTO la && b is LiceDTO lb)
                return la.MaticniBroj == lb.MaticniBroj;
            if (a is VoziloDTO va && b is VoziloDTO vb)
                return va.RegBroj == vb.RegBroj;
            if (a is OpremaDTO oa && b is OpremaDTO ob)
                return oa.InventarskiBroj == ob.InventarskiBroj;
            if (a is VoziloVolonteraSimpleDTO vva && b is VoziloVolonteraSimpleDTO vvb)
                return vva.RegBroj == vvb.RegBroj;

            return false;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (currentMode == FormMode.Default)
            {
                NapraviBackup();
                PostaviMode(FormMode.Edit);
            }
            else
            {
                SacuvajIzmene();
                PostaviMode(FormMode.Default);
            }
        }

        private void btnOdbaci_Click(object sender, EventArgs e)
        {
            VratiBackup();
            PostaviMode(FormMode.Default);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                IzabranaLica = DohvatiIzabranaLica();
                IzabranaVozila = DohvatiIzabranaVozila();
                IzabranaOprema = DohvatiIzabranaOprema();
                IzabranaVozilaVolontera = DohvatiIzabranaVozilaVolontera();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri prikupljanju resursa: {ex.Message}");
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private List<LiceDTO> DohvatiIzabranaLica()
        {
            var lista = new List<LiceDTO>();

            void DodajIz<T>(DataGridView dgv, List<T> izvori) where T : LiceDTO
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    bool selected = Convert.ToBoolean(dgv.Rows[i].Cells[0].Value);
                    if (selected)
                        lista.Add(izvori[i]);
                }
            }

            DodajIz(dgvVatrogasci, vatrogasci);
            DodajIz(dgvDispeceri, dispeceri);
            DodajIz(dgvTehnicari, tehnicari);
            DodajIz(dgvVolonteri, volonteri);

            return lista;
        }

        private List<VoziloDTO> DohvatiIzabranaVozila()
        {
            var lista = new List<VoziloDTO>();

            for (int i = 0; i < dgvVozila.Rows.Count; i++)
            {
                bool selected = Convert.ToBoolean(dgvVozila.Rows[i].Cells[0].Value);
                if (selected)
                    lista.Add(vozila[i]);
            }

            return lista;
        }

        private List<OpremaDTO> DohvatiIzabranaOprema()
        {
            var lista = new List<OpremaDTO>();

            for (int i = 0; i < dgvOprema.Rows.Count; i++)
            {
                bool selected = Convert.ToBoolean(dgvOprema.Rows[i].Cells[0].Value);
                if (selected)
                    lista.Add(oprema[i]);
            }

            return lista;
        }

        private List<VoziloVolonteraSimpleDTO> DohvatiIzabranaVozilaVolontera()
        {
            var lista = new List<VoziloVolonteraSimpleDTO>();

            for (int i = 0; i < dgvVozilaVolontera.Rows.Count; i++)
            {
                bool selected = Convert.ToBoolean(dgvVozilaVolontera.Rows[i].Cells[0].Value);
                if (selected)
                    lista.Add(vozilaVolontera[i]);
            }

            return lista;
        }

        private void NapraviBackup()
        {
            backupChecks[dgvVatrogasci] = DohvatiCheckove(dgvVatrogasci);
            backupChecks[dgvDispeceri] = DohvatiCheckove(dgvDispeceri);
            backupChecks[dgvTehnicari] = DohvatiCheckove(dgvTehnicari);
            backupChecks[dgvVolonteri] = DohvatiCheckove(dgvVolonteri);
            backupChecks[dgvVozila] = DohvatiCheckove(dgvVozila);
            backupChecks[dgvOprema] = DohvatiCheckove(dgvOprema);
            backupChecks[dgvVozilaVolontera] = DohvatiCheckove(dgvVozilaVolontera);
        }

        private HashSet<int> DohvatiCheckove(DataGridView dgv)
        {
            var set = new HashSet<int>();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                bool val = Convert.ToBoolean(dgv.Rows[i].Cells[0].Value);
                if (val) set.Add(i);
            }
            return set;
        }

        private void VratiBackup()
        {
            foreach (var pair in backupChecks)
                VratiCheckove(pair.Key, pair.Value);
        }

        private void VratiCheckove(DataGridView dgv, HashSet<int> set)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
                dgv.Rows[i].Cells[0].Value = set.Contains(i);
        }

        private void SacuvajIzmene()
        {
            try
            {
                var aktivniTab = tabControlResursi.SelectedTab;
                DataGridView dgv = aktivniTab == tabVatrogasci ? dgvVatrogasci :
                                   aktivniTab == tabDispeceri ? dgvDispeceri :
                                   aktivniTab == tabTehnicari ? dgvTehnicari :
                                   aktivniTab == tabVolonteri ? dgvVolonteri :
                                   aktivniTab == tabVozila ? dgvVozila :
                                   aktivniTab == tabVozilaVolontera ? dgvVozilaVolontera :
                                   dgvOprema;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri čuvanju: {ex.Message}");
            }
        }
    }

    public enum FormMode
    {
        Default,
        Edit
    }
}
