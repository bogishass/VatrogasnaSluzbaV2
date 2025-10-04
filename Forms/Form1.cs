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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void btnZaposleni_Click(object sender, EventArgs e)
        //{
        //    ZaposleniForm forma = new ZaposleniForm();
        //    forma.ShowDialog();
        //}

        //private void btnVolonteri_Click(object sender, EventArgs e)
        //{
        //    VolonteriForm forma = new VolonteriForm();
        //    forma.ShowDialog();
        //}

        private void BtnTest_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
