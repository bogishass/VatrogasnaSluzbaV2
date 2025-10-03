namespace VatrogasnaSluzba.Forms
{
    partial class ZaposleniDodajForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            txbMatbr = new TextBox();
            txbIme = new TextBox();
            txbPrezime = new TextBox();
            txbAdresa = new TextBox();
            txbEmail = new TextBox();
            datumRodjenja = new DateTimePicker();
            comboPol = new ComboBox();
            datumPocetka = new DateTimePicker();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label8 = new Label();
            label1 = new Label();
            label7 = new Label();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label9 = new Label();
            comboPozicija = new ComboBox();
            label10 = new Label();
            txbTelefoni = new TextBox();
            btnDodaj = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txbMatbr
            // 
            txbMatbr.Location = new Point(121, 3);
            txbMatbr.Name = "txbMatbr";
            txbMatbr.Size = new Size(155, 23);
            txbMatbr.TabIndex = 0;
            // 
            // txbIme
            // 
            txbIme.Location = new Point(121, 33);
            txbIme.Name = "txbIme";
            txbIme.Size = new Size(155, 23);
            txbIme.TabIndex = 1;
            // 
            // txbPrezime
            // 
            txbPrezime.Location = new Point(121, 63);
            txbPrezime.Name = "txbPrezime";
            txbPrezime.Size = new Size(155, 23);
            txbPrezime.TabIndex = 2;
            // 
            // txbAdresa
            // 
            txbAdresa.Location = new Point(121, 153);
            txbAdresa.Name = "txbAdresa";
            txbAdresa.Size = new Size(155, 23);
            txbAdresa.TabIndex = 3;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(121, 183);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(155, 23);
            txbEmail.TabIndex = 4;
            // 
            // datumRodjenja
            // 
            datumRodjenja.CustomFormat = "";
            datumRodjenja.Format = DateTimePickerFormat.Short;
            datumRodjenja.Location = new Point(121, 123);
            datumRodjenja.Name = "datumRodjenja";
            datumRodjenja.Size = new Size(155, 23);
            datumRodjenja.TabIndex = 5;
            datumRodjenja.Value = new DateTime(2025, 8, 18, 0, 0, 0, 0);
            // 
            // comboPol
            // 
            comboPol.FormattingEnabled = true;
            comboPol.Items.AddRange(new object[] { "M", "Z" });
            comboPol.Location = new Point(121, 93);
            comboPol.Name = "comboPol";
            comboPol.Size = new Size(155, 23);
            comboPol.TabIndex = 6;
            // 
            // datumPocetka
            // 
            datumPocetka.Format = DateTimePickerFormat.Short;
            datumPocetka.Location = new Point(121, 213);
            datumPocetka.Name = "datumPocetka";
            datumPocetka.Size = new Size(155, 23);
            datumPocetka.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 338);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(datumPocetka, 1, 7);
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(txbEmail, 1, 6);
            tableLayoutPanel1.Controls.Add(txbMatbr, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(txbAdresa, 1, 5);
            tableLayoutPanel1.Controls.Add(datumRodjenja, 1, 4);
            tableLayoutPanel1.Controls.Add(txbIme, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(comboPol, 1, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txbPrezime, 1, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label9, 0, 8);
            tableLayoutPanel1.Controls.Add(comboPozicija, 1, 8);
            tableLayoutPanel1.Controls.Add(label10, 0, 9);
            tableLayoutPanel1.Controls.Add(txbTelefoni, 1, 9);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0006647F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0006628F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.997354F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.997354F));
            tableLayoutPanel1.Size = new Size(281, 302);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 217);
            label8.Name = "label8";
            label8.Size = new Size(112, 15);
            label8.TabIndex = 15;
            label8.Text = "Datum angazovanja";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 8;
            label1.Text = "JMBG";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 187);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 14;
            label7.Text = "Email";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 37);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 9;
            label2.Text = "Ime";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 127);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 12;
            label5.Text = "Datum rodjenja";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 97);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 11;
            label4.Text = "Pol";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 67);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 10;
            label3.Text = "Prezime";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 157);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 13;
            label6.Text = "Adresa";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(3, 247);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 16;
            label9.Text = "Pozicija";
            // 
            // comboPozicija
            // 
            comboPozicija.FormattingEnabled = true;
            comboPozicija.Items.AddRange(new object[] { "Vatrogasac", "Dispecer", "Tehnicar" });
            comboPozicija.Location = new Point(121, 243);
            comboPozicija.Name = "comboPozicija";
            comboPozicija.Size = new Size(155, 23);
            comboPozicija.TabIndex = 17;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(3, 278);
            label10.Name = "label10";
            label10.Size = new Size(89, 15);
            label10.TabIndex = 18;
            label10.Text = "Brojevi telefona";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbTelefoni
            // 
            txbTelefoni.Location = new Point(121, 273);
            txbTelefoni.Name = "txbTelefoni";
            txbTelefoni.PlaceholderText = "60 1234, 60 5678...";
            txbTelefoni.Size = new Size(155, 23);
            txbTelefoni.TabIndex = 19;
            // 
            // btnDodaj
            // 
            btnDodaj.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDodaj.Location = new Point(93, 359);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(129, 37);
            btnDodaj.TabIndex = 9;
            btnDodaj.Text = "Dodaj zaposlenog";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // ZaposleniDodajForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 407);
            Controls.Add(btnDodaj);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ZaposleniDodajForm";
            Text = "Dodaj zaposlenog";
            Load += ZaposleniDodajForm_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txbMatbr;
        private TextBox txbIme;
        private TextBox txbPrezime;
        private TextBox txbAdresa;
        private TextBox txbEmail;
        private DateTimePicker datumRodjenja;
        private ComboBox comboPol;
        private DateTimePicker datumPocetka;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label9;
        private ComboBox comboPozicija;
        private Button btnDodaj;
        private Label label10;
        private TextBox txbTelefoni;
    }
}