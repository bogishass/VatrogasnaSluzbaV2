using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using VatrogasnaSluzba.DTO;

namespace VatrogasnaSluzba.Forms
{
    public partial class AlatiTehnicaraForm : Form
    {
        private TehnicarDTO tehnicar;
        private BindingList<string> tempAlati;

        public AlatiTehnicaraForm(TehnicarDTO lice, bool isViewOnly)
        {
            InitializeComponent();

            tehnicar = lice;

            tempAlati = new BindingList<string>(lice.Alati.ToList());
            listBoxAlati.DataSource = tempAlati;

            var viewModeFormat = $"{ (isViewOnly ? "pregled" : "izmena")}";
            this.Text = $"Alati tehničara ({viewModeFormat})";
            groupBox1.Text = $"Lista alata tehničara {tehnicar.Ime} {tehnicar.Prezime}";

            if (isViewOnly)
            {
                btnPotvrdi.Enabled = false;
                btnDodaj.Visible = false;
                btnUkloni.Visible = false;
                txbNaziv.Visible = false;
            }

            btnDodaj.Click += btnDodaj_Click;
            btnUkloni.Click += btnUkloni_Click;
            btnPotvrdi.Click += btnPotvrdi_Click;
            btnOtkazi.Click += btnOtkazi_Click;
            txbNaziv.KeyDown += txbNaziv_KeyDown;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string noviAlat = txbNaziv.Text.Trim();
            if (string.IsNullOrEmpty(noviAlat))
            {
                MessageBox.Show("Unesite naziv alata.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tempAlati.Add(noviAlat);
            listBoxAlati.Refresh();
            txbNaziv.Clear();
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            if (listBoxAlati.SelectedItem == null)
            {
                MessageBox.Show("Odaberite alat koji želite da uklonite.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var alat = listBoxAlati.SelectedItem.ToString();
            tempAlati.Remove(alat);
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            tehnicar.Alati = tempAlati.ToList(); 

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txbNaziv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnDodaj.PerformClick();
            }
        }
    }
}
