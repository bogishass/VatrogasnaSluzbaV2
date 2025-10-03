using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VatrogasnaSluzba.Entiteti;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VatrogasnaSluzba.Forms
{
    public partial class VolonterDodajForm : Form
    {
        public VolonterDodajForm()
        {
            InitializeComponent();
        }

        protected bool CheckFields()
        {
            return (txbMatbr.Text != String.Empty &&
                    txbIme.Text != String.Empty &&
                    txbPrezime.Text != String.Empty &&
                    comboPol.Text != String.Empty &&
                    txbAdresa.Text != String.Empty &&
                    txbEmail.Text != String.Empty &&
                    comboPozicija.Text != String.Empty &&
                    txbTelefoni.Text != String.Empty);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            List<string> telefoniList = txbTelefoni.Text
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => item.Trim())
                .ToList();

            SessionHelper.WithSession(s =>
            {
                var o = new VatrogasnaSluzba.Entiteti.Lice
                {
                    MaticniBroj = txbMatbr.Text,
                    Ime = txbIme.Text,
                    Prezime = txbPrezime.Text,
                    Pol = comboPol.Text,
                    DatumRodjenja = datumRodjenja.Value,
                    Adresa = txbAdresa.Text,
                    Email = txbEmail.Text,
                    DatPocetkaAngaz = datumPocetka.Value,
                    Pozicija = comboPozicija.Text,
                    Telefoni = telefoniList
                };

                // id smene smo zajebali, jer su zaposleni u vise smena a ne u jednoj

                s.SaveOrUpdate(o);
            });
        }

        private void ZaposleniDodajForm_Load(object sender, EventArgs e)
        {

        }
    }
}
