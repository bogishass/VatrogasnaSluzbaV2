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

namespace VatrogasnaSluzba.Forms
{
    public partial class ZaposleniForm : Form
    {
        public ZaposleniForm()
        {
            InitializeComponent();

            // populisanje liste
            //using var session = DataLayer.GetSession();
            //var lica = session.CreateQuery("from Lice").List<Lice>();

            //listView1.Items.Clear();

            //foreach (var lice in lica)
            //{
            //    // Join all phone numbers as a single comma-separated string
            //    string telefoni = lice.Telefoni != null
            //        ? string.Join(", ", lice.Telefoni)
            //        : "";

            //    var item = new ListViewItem(lice.MaticniBroj);
            //    item.SubItems.Add(lice.Ime);
            //    item.SubItems.Add(lice.Prezime);
            //    item.SubItems.Add(lice.Pol);
            //    item.SubItems.Add(lice.DatumRodjenja.ToShortDateString());
            //    item.SubItems.Add(lice.Adresa);
            //    item.SubItems.Add(lice.Email);
            //    item.SubItems.Add(telefoni);
            //    item.SubItems.Add(lice.Pozicija);
            //    item.SubItems.Add(lice.DatPocetkaAngaz.ToShortDateString());

            //    listView1.Items.Add(item);
            //}
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ZaposleniDodajForm forma = new ZaposleniDodajForm();
            forma.ShowDialog();
        }
    }
}
