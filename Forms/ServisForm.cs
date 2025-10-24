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
    public partial class ServisiForm : Form
    {
        private readonly string _regBroj;

        public ServisiForm(string regBroj)
        {
            InitializeComponent();
            _regBroj = regBroj;
            Text = $"Servisi za vozilo: {_regBroj}";
            Load += ServisiForm_Load;
        }

        private void ServisiForm_Load(object? sender, EventArgs e)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    // Učitaj servise za dato vozilo (po registraciji)
                    var podaci = s.Query<Servis>()
                        .Where(x => x.Vozilo.RegBroj == _regBroj)
                        .OrderByDescending(x => x.DatumServisa)
                        .Select(x => new
                        {
                            Datum = x.DatumServisa,
                            Tip = x.TipServisa,
                            Tehničar = x.Tehnicar != null
                                       ? (x.Tehnicar.Ime + " " + x.Tehnicar.Prezime)
                                       : "(nepoznat)",
                            IdServisa = x.IdServisa
                        })
                        .ToList();

                    dgvServisi.AutoGenerateColumns = true;
                    dgvServisi.ReadOnly = true;
                    dgvServisi.DataSource = podaci;

                    // (opciono) sakrij ID kolonu
                    if (dgvServisi.Columns.Contains("IdServisa"))
                        dgvServisi.Columns["IdServisa"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju servisa: " + ex.Message,
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }
    }
}
