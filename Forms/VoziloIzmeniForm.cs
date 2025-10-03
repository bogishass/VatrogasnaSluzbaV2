using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VatrogasnaSluzba.Forms
{
    public partial class VoziloIzmeniForm : Form
    {
        public VoziloIzmeniForm()
        {
            InitializeComponent();
        }

        private void VoziloIzmeniForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vozilo vozilo = new Vozilo();
            vozilo.RegBroj = txbReg.Text;
            vozilo.Tip = comboTip.SelectedItem.ToString();
            vozilo.Podtip = txbPodtip.Text;
            vozilo.Proizvodjac = txbProiz.Text;
            vozilo.GodProizvodnje = Int32.Parse(txbGodProiz.Text);
            vozilo.Kapacitet = Int32.Parse(txbKapacitet.Text);
            vozilo.DatIstekaReg = dateTimeIstek.Value;

            //DTOManager.dodajVozilo(vozilo);

            MessageBox.Show("Uspesno ste dodali vozilo!");
        }
    }
}
