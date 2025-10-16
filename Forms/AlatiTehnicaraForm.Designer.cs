namespace VatrogasnaSluzba.Forms
{
    partial class AlatiTehnicaraForm
    {
        
        private System.ComponentModel.IContainer components = null;

        
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlatiTehnicaraForm));
            listBoxAlati = new ListBox();
            btnPotvrdi = new Button();
            btnOtkazi = new Button();
            txbNaziv = new TextBox();
            groupBox1 = new GroupBox();
            btnUkloni = new Button();
            btnDodaj = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxAlati
            // 
            listBoxAlati.FormattingEnabled = true;
            listBoxAlati.ItemHeight = 15;
            listBoxAlati.Location = new Point(6, 22);
            listBoxAlati.Name = "listBoxAlati";
            listBoxAlati.Size = new Size(249, 139);
            listBoxAlati.TabIndex = 0;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.BackColor = Color.DarkSeaGreen;
            btnPotvrdi.Location = new Point(56, 269);
            btnPotvrdi.Name = "btnPotvrdi";
            btnPotvrdi.Size = new Size(85, 31);
            btnPotvrdi.TabIndex = 1;
            btnPotvrdi.Text = "OK";
            btnPotvrdi.UseVisualStyleBackColor = false;
            // 
            // btnOtkazi
            // 
            btnOtkazi.BackColor = Color.LightCoral;
            btnOtkazi.Location = new Point(147, 269);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(85, 31);
            btnOtkazi.TabIndex = 2;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = false;
            // 
            // txbNaziv
            // 
            txbNaziv.Location = new Point(12, 220);
            txbNaziv.Name = "txbNaziv";
            txbNaziv.PlaceholderText = "Naziv alata";
            txbNaziv.Size = new Size(165, 23);
            txbNaziv.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(btnUkloni);
            groupBox1.Controls.Add(listBoxAlati);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 201);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista alata";
            // 
            // btnUkloni
            // 
            btnUkloni.Location = new Point(176, 167);
            btnUkloni.Name = "btnUkloni";
            btnUkloni.Size = new Size(79, 23);
            btnUkloni.TabIndex = 6;
            btnUkloni.Text = "Ukloni";
            btnUkloni.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(183, 219);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(90, 23);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // AlatiTehnicaraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(287, 307);
            Controls.Add(btnDodaj);
            Controls.Add(txbNaziv);
            Controls.Add(groupBox1);
            Controls.Add(btnOtkazi);
            Controls.Add(btnPotvrdi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AlatiTehnicaraForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Alati tehničara";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxAlati;
        private Button btnPotvrdi;
        private Button btnOtkazi;
        private TextBox txbNaziv;
        private GroupBox groupBox1;
        private Button btnDodaj;
        private Button btnUkloni;
    }
}