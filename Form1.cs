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

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            ZaposleniForm forma = new ZaposleniForm();
            forma.ShowDialog();
        }

        private void btnVolonteri_Click(object sender, EventArgs e)
        {
            VolonterForm forma = new VolonterForm();
            forma.ShowDialog();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            try
            {
                using (var s = DataLayer.GetSession())
                {
                    var lica = s.Query<Lice>().ToList();
                    s.Close();
                    MessageBox.Show($"Lica u bazi: {lica.Count}");
                }

            }
            catch (Exception ex)
            {
                var details = new StringBuilder();
                details.AppendLine("Database Error: " + ex.Message);

                if (ex.InnerException != null)
                {
                    details.AppendLine("\nInner Exception:");
                    details.AppendLine(ex.InnerException.Message);
                }

                if (ex is NHibernate.HibernateException hEx && hEx.InnerException != null)
                {
                    details.AppendLine("\nNHibernate Details:");
                    details.AppendLine(hEx.InnerException.ToString());
                }

                MessageBox.Show(details.ToString());
            }
        }
    }
}
