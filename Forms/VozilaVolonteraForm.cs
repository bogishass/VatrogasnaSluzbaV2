using System.ComponentModel;
using VatrogasnaSluzba.DTO;
using VatrogasnaSluzba.Entiteti;
using VatrogasnaSluzba.Helpers;

namespace VatrogasnaSluzba.Forms
{
    public enum WorkStatus { Default, Editing, Creating };

    public partial class VozilaVolonteraForm : Form
    {
        private VoziloVolonteraSimpleDTO VoziloInEdit;
        private List<VoziloVolonteraSimpleDTO> VozilaTempList;
        private WorkStatus Status;
        public VolonterDTO Volonter;

        public VozilaVolonteraForm() { }

        public VozilaVolonteraForm(VolonterDTO volonter, bool isViewOnly)
        {
            InitializeComponent();

            this.Volonter = volonter;

            // kopija liste vozila selektovanog volontera
            VozilaTempList = Volonter.Vozila.Select(v => new VoziloVolonteraSimpleDTO
            {
                RegBroj = v.RegBroj,
                Tip = v.Tip,
                Proizvodjac = v.Proizvodjac,
                VlasnikJMBG = Volonter.MaticniBroj
            }).ToList();

            PopulateGrid();

            this.Text = $"Vozila volontera {Volonter.Ime} {Volonter.Prezime} ({(isViewOnly ? "pregled" : "izmena")})";

            // ne dozvoljavamo unos jer smo u default modu
            ManageControls(false);

            // ne dozvoljavamo ni bilo kakve izmene ako je forma otvorena u modu za pregled
            if (isViewOnly)
            {
                btnNovo.Enabled = false ;
                btnIzmeni.Enabled = false ;
                btnObrisi.Enabled = false ;
                btnPotvrdi.Enabled = false ;
            }
        }

        private void PopulateGrid()
        {
            dataGridVozila.DataSource = null;
            dataGridVozila.DataSource = new BindingList<VoziloVolonteraSimpleDTO>(VozilaTempList);
            dataGridVozila.Columns["VlasnikJMBG"].Visible = false;
        }

        private VoziloVolonteraSimpleDTO? GetSelectedVozilo()
        {
            if (dataGridVozila.CurrentRow?.DataBoundItem is VoziloVolonteraSimpleDTO vozilo)
                return vozilo;
            return null;
        }

        private bool SelectForEdit()
        {
            var vozilo = GetSelectedVozilo();
            if (vozilo == null) return false;

            VoziloInEdit = vozilo;
            txbRegBroj.Text = vozilo.RegBroj;
            txbTip.Text = vozilo.Tip;
            txbProizvodjac.Text = vozilo.Proizvodjac;
            return true;
        }

        private void ClearSelection()
        {
            txbRegBroj.Clear();
            txbTip.Clear();
            txbProizvodjac.Clear();
        }

        private void ManageControls(bool allowInput)
        {
            txbRegBroj.Enabled = allowInput;
            txbTip.Enabled = allowInput;
            txbProizvodjac.Enabled = allowInput;
            btnOcisti.Enabled = allowInput;
            btnUpisi.Enabled = allowInput;

            btnPotvrdi.Enabled = !allowInput;
            btnNovo.Enabled = !allowInput;
            btnIzmeni.Enabled = !allowInput;
            btnObrisi.Enabled = !allowInput;
            dataGridVozila.Enabled = !allowInput;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            var vozilo = GetSelectedVozilo();
            if (vozilo == null)
            {
                MessageBox.Show("Niste izabrali vozilo za brisanje.");
                return;
            }

            var result = MessageBox.Show(
                $"Da li ste sigurni da želite da obrišete vozilo {vozilo.RegBroj}?",
                "Brisanje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                VozilaTempList.Remove(vozilo);
                PopulateGrid();
                ClearSelection();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (Status == WorkStatus.Default)
            {
                Status = WorkStatus.Creating;
                ManageControls(true);
                ClearSelection();
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (Status == WorkStatus.Default && SelectForEdit())
            {
                Status = WorkStatus.Editing;
                ManageControls(true);
            }
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            if (!ControlValidator.IsValid(txbRegBroj, "Unesite registarski broj vozila.")) return;
            if (!ControlValidator.IsValid(txbTip, "Unesite tip vozila.")) return;
            if (!ControlValidator.IsValid(txbProizvodjac, "Unesite naziv proizvođača vozila.")) return;

            if (Status == WorkStatus.Creating)
            {
                var novo = new VoziloVolonteraSimpleDTO
                {
                    RegBroj = txbRegBroj.Text,
                    Tip = txbTip.Text,
                    Proizvodjac = txbProizvodjac.Text,
                    VlasnikJMBG = Volonter.MaticniBroj
                };
                VozilaTempList.Add(novo);
            }
            else if (Status == WorkStatus.Editing && VoziloInEdit != null)
            {
                VoziloInEdit.RegBroj = txbRegBroj.Text;
                VoziloInEdit.Tip = txbTip.Text;
                VoziloInEdit.Proizvodjac = txbProizvodjac.Text;
            }

            Status = WorkStatus.Default;
            VoziloInEdit = null;
            PopulateGrid();
            ClearSelection();
            ManageControls(false);
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            Status = WorkStatus.Default;
            VoziloInEdit = null;
            ClearSelection();
            ManageControls(false);
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            Volonter.Vozila = VozilaTempList;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
