namespace VatrogasnaSluzba.Forms
{
    partial class ZaposleniForm
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
            btnIzmeni = new Button();
            btnNovi = new Button();
            btnObrisi = new Button();
            txbPretraga = new TextBox();
            tabControl = new TabControl();
            Vatrogasac = new TabPage();
            dataGridVatrogasci = new DataGridView();
            Tehnicar = new TabPage();
            dataGridTehnicari = new DataGridView();
            Dispecer = new TabPage();
            dataGridDispeceri = new DataGridView();
            Volonter = new TabPage();
            dataGridVolonteri = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            comboStanica = new ComboBox();
            label1 = new Label();
            txbMatbr = new TextBox();
            label2 = new Label();
            txbIme = new TextBox();
            label3 = new Label();
            txbPrezime = new TextBox();
            dateRodjenje = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            comboPol = new ComboBox();
            label6 = new Label();
            txbAdresa = new TextBox();
            label7 = new Label();
            txbEmail = new TextBox();
            label10 = new Label();
            txbTelefoni = new TextBox();
            label17 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboPozicija = new ComboBox();
            dateAngazovanje = new DateTimePicker();
            tableLayoutPanel2 = new TableLayoutPanel();
            label11 = new Label();
            label12 = new Label();
            txbSprema = new TextBox();
            label13 = new Label();
            txbSertifikati = new TextBox();
            comboObucenost = new ComboBox();
            gbInfoVatrogasac = new GroupBox();
            groupBox4 = new GroupBox();
            label14 = new Label();
            gbInfoTehnicar = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label15 = new Label();
            txbSpecijalizacija = new TextBox();
            label16 = new Label();
            btnAlati = new Button();
            gbInfoDispecer = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label18 = new Label();
            txbTipOpreme = new TextBox();
            label19 = new Label();
            txbBrSmena = new TextBox();
            gbInfoVolonter = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label21 = new Label();
            btnSpisakVozila = new Button();
            btnSacuvaj = new Button();
            btnOtkazi = new Button();
            tabControl.SuspendLayout();
            Vatrogasac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVatrogasci).BeginInit();
            Tehnicar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTehnicari).BeginInit();
            Dispecer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDispeceri).BeginInit();
            Volonter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVolonteri).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            gbInfoVatrogasac.SuspendLayout();
            groupBox4.SuspendLayout();
            gbInfoTehnicar.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            gbInfoDispecer.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            gbInfoVolonter.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(407, 263);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(124, 23);
            btnIzmeni.TabIndex = 2;
            btnIzmeni.Text = "Izmeni zaposlenog";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnNovi
            // 
            btnNovi.Location = new Point(277, 263);
            btnNovi.Name = "btnNovi";
            btnNovi.Size = new Size(124, 23);
            btnNovi.TabIndex = 0;
            btnNovi.Text = "Novi zaposleni";
            btnNovi.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(537, 263);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(120, 23);
            btnObrisi.TabIndex = 1;
            btnObrisi.Text = "Obrisi zaposlenog";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // txbPretraga
            // 
            txbPretraga.Location = new Point(56, 263);
            txbPretraga.Name = "txbPretraga";
            txbPretraga.PlaceholderText = "Pretraga";
            txbPretraga.Size = new Size(213, 23);
            txbPretraga.TabIndex = 0;
            txbPretraga.TextChanged += txbPretraga_TextChanged;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(Vatrogasac);
            tabControl.Controls.Add(Tehnicar);
            tabControl.Controls.Add(Dispecer);
            tabControl.Controls.Add(Volonter);
            tabControl.Location = new Point(12, 11);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(649, 245);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // Vatrogasac
            // 
            Vatrogasac.Controls.Add(dataGridVatrogasci);
            Vatrogasac.Location = new Point(4, 24);
            Vatrogasac.Name = "Vatrogasac";
            Vatrogasac.Padding = new Padding(3);
            Vatrogasac.Size = new Size(641, 217);
            Vatrogasac.TabIndex = 0;
            Vatrogasac.Text = "Vatrogasci";
            Vatrogasac.UseVisualStyleBackColor = true;
            // 
            // dataGridVatrogasci
            // 
            dataGridVatrogasci.AllowUserToAddRows = false;
            dataGridVatrogasci.AllowUserToDeleteRows = false;
            dataGridVatrogasci.AllowUserToResizeRows = false;
            dataGridVatrogasci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridVatrogasci.BorderStyle = BorderStyle.Fixed3D;
            dataGridVatrogasci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridVatrogasci.Location = new Point(0, 0);
            dataGridVatrogasci.MultiSelect = false;
            dataGridVatrogasci.Name = "dataGridVatrogasci";
            dataGridVatrogasci.ReadOnly = true;
            dataGridVatrogasci.RowHeadersVisible = false;
            dataGridVatrogasci.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridVatrogasci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVatrogasci.Size = new Size(641, 217);
            dataGridVatrogasci.TabIndex = 3;
            // 
            // Tehnicar
            // 
            Tehnicar.Controls.Add(dataGridTehnicari);
            Tehnicar.Location = new Point(4, 24);
            Tehnicar.Name = "Tehnicar";
            Tehnicar.Padding = new Padding(3);
            Tehnicar.Size = new Size(641, 217);
            Tehnicar.TabIndex = 1;
            Tehnicar.Text = "Tehnicari";
            Tehnicar.UseVisualStyleBackColor = true;
            // 
            // dataGridTehnicari
            // 
            dataGridTehnicari.AllowUserToAddRows = false;
            dataGridTehnicari.AllowUserToDeleteRows = false;
            dataGridTehnicari.AllowUserToResizeRows = false;
            dataGridTehnicari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridTehnicari.BorderStyle = BorderStyle.Fixed3D;
            dataGridTehnicari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridTehnicari.Location = new Point(0, 0);
            dataGridTehnicari.MultiSelect = false;
            dataGridTehnicari.Name = "dataGridTehnicari";
            dataGridTehnicari.ReadOnly = true;
            dataGridTehnicari.RowHeadersVisible = false;
            dataGridTehnicari.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridTehnicari.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTehnicari.Size = new Size(641, 217);
            dataGridTehnicari.TabIndex = 4;
            // 
            // Dispecer
            // 
            Dispecer.Controls.Add(dataGridDispeceri);
            Dispecer.Location = new Point(4, 24);
            Dispecer.Name = "Dispecer";
            Dispecer.Padding = new Padding(3);
            Dispecer.Size = new Size(641, 217);
            Dispecer.TabIndex = 2;
            Dispecer.Text = "Dispeceri";
            Dispecer.UseVisualStyleBackColor = true;
            // 
            // dataGridDispeceri
            // 
            dataGridDispeceri.AllowUserToAddRows = false;
            dataGridDispeceri.AllowUserToDeleteRows = false;
            dataGridDispeceri.AllowUserToResizeRows = false;
            dataGridDispeceri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridDispeceri.BorderStyle = BorderStyle.Fixed3D;
            dataGridDispeceri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridDispeceri.Location = new Point(0, 0);
            dataGridDispeceri.MultiSelect = false;
            dataGridDispeceri.Name = "dataGridDispeceri";
            dataGridDispeceri.ReadOnly = true;
            dataGridDispeceri.RowHeadersVisible = false;
            dataGridDispeceri.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridDispeceri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDispeceri.Size = new Size(641, 217);
            dataGridDispeceri.TabIndex = 4;
            // 
            // Volonter
            // 
            Volonter.Controls.Add(dataGridVolonteri);
            Volonter.Location = new Point(4, 24);
            Volonter.Name = "Volonter";
            Volonter.Padding = new Padding(3);
            Volonter.Size = new Size(641, 217);
            Volonter.TabIndex = 3;
            Volonter.Text = "Volonteri";
            Volonter.UseVisualStyleBackColor = true;
            // 
            // dataGridVolonteri
            // 
            dataGridVolonteri.AllowUserToAddRows = false;
            dataGridVolonteri.AllowUserToDeleteRows = false;
            dataGridVolonteri.AllowUserToResizeRows = false;
            dataGridVolonteri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridVolonteri.BorderStyle = BorderStyle.Fixed3D;
            dataGridVolonteri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridVolonteri.Location = new Point(0, 0);
            dataGridVolonteri.MultiSelect = false;
            dataGridVolonteri.Name = "dataGridVolonteri";
            dataGridVolonteri.ReadOnly = true;
            dataGridVolonteri.RowHeadersVisible = false;
            dataGridVolonteri.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridVolonteri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVolonteri.Size = new Size(641, 217);
            dataGridVolonteri.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(comboStanica, 3, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txbMatbr, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txbIme, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txbPrezime, 1, 2);
            tableLayoutPanel1.Controls.Add(dateRodjenje, 1, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(comboPol, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(txbAdresa, 1, 5);
            tableLayoutPanel1.Controls.Add(label7, 2, 0);
            tableLayoutPanel1.Controls.Add(txbEmail, 3, 0);
            tableLayoutPanel1.Controls.Add(label10, 2, 1);
            tableLayoutPanel1.Controls.Add(txbTelefoni, 3, 1);
            tableLayoutPanel1.Controls.Add(label17, 2, 2);
            tableLayoutPanel1.Controls.Add(label8, 2, 3);
            tableLayoutPanel1.Controls.Add(label9, 2, 4);
            tableLayoutPanel1.Controls.Add(comboPozicija, 3, 4);
            tableLayoutPanel1.Controls.Add(dateAngazovanje, 3, 3);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.8699188F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.07317F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.4634151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.85366F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.8699188F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.8699188F));
            tableLayoutPanel1.Size = new Size(633, 166);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // comboStanica
            // 
            comboStanica.FormattingEnabled = true;
            comboStanica.Location = new Point(477, 59);
            comboStanica.Name = "comboStanica";
            comboStanica.Size = new Size(153, 23);
            comboStanica.TabIndex = 21;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 8;
            label1.Text = "JMBG";
            // 
            // txbMatbr
            // 
            txbMatbr.Location = new Point(161, 3);
            txbMatbr.MaxLength = 13;
            txbMatbr.Name = "txbMatbr";
            txbMatbr.Size = new Size(152, 23);
            txbMatbr.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 34);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 9;
            label2.Text = "Ime";
            // 
            // txbIme
            // 
            txbIme.Location = new Point(161, 31);
            txbIme.Name = "txbIme";
            txbIme.Size = new Size(152, 23);
            txbIme.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 62);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 10;
            label3.Text = "Prezime";
            // 
            // txbPrezime
            // 
            txbPrezime.Location = new Point(161, 59);
            txbPrezime.Name = "txbPrezime";
            txbPrezime.Size = new Size(152, 23);
            txbPrezime.TabIndex = 2;
            // 
            // dateRodjenje
            // 
            dateRodjenje.CustomFormat = "";
            dateRodjenje.Format = DateTimePickerFormat.Short;
            dateRodjenje.Location = new Point(161, 86);
            dateRodjenje.Name = "dateRodjenje";
            dateRodjenje.Size = new Size(152, 23);
            dateRodjenje.TabIndex = 5;
            dateRodjenje.Value = new DateTime(2025, 8, 18, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 88);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 12;
            label5.Text = "Datum rodjenja";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 115);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 11;
            label4.Text = "Pol";
            // 
            // comboPol
            // 
            comboPol.FormattingEnabled = true;
            comboPol.Location = new Point(161, 112);
            comboPol.Name = "comboPol";
            comboPol.Size = new Size(152, 23);
            comboPol.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 144);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 13;
            label6.Text = "Adresa";
            // 
            // txbAdresa
            // 
            txbAdresa.Location = new Point(161, 140);
            txbAdresa.Name = "txbAdresa";
            txbAdresa.Size = new Size(152, 23);
            txbAdresa.TabIndex = 3;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(319, 6);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 14;
            label7.Text = "Email";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(477, 3);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(153, 23);
            txbEmail.TabIndex = 4;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(319, 34);
            label10.Name = "label10";
            label10.Size = new Size(89, 15);
            label10.TabIndex = 18;
            label10.Text = "Brojevi telefona";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbTelefoni
            // 
            txbTelefoni.Location = new Point(477, 31);
            txbTelefoni.Name = "txbTelefoni";
            txbTelefoni.PlaceholderText = "60 1234, 60 5678...";
            txbTelefoni.Size = new Size(153, 23);
            txbTelefoni.TabIndex = 19;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Location = new Point(319, 62);
            label17.Name = "label17";
            label17.Size = new Size(45, 15);
            label17.TabIndex = 20;
            label17.Text = "Stanica";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(319, 88);
            label8.Name = "label8";
            label8.Size = new Size(112, 15);
            label8.TabIndex = 15;
            label8.Text = "Datum angazovanja";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(319, 115);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 16;
            label9.Text = "Pozicija";
            // 
            // comboPozicija
            // 
            comboPozicija.FormattingEnabled = true;
            comboPozicija.Location = new Point(477, 112);
            comboPozicija.Name = "comboPozicija";
            comboPozicija.Size = new Size(153, 23);
            comboPozicija.TabIndex = 17;
            comboPozicija.SelectedIndexChanged += comboPozicija_SelectedIndexChanged;
            // 
            // dateAngazovanje
            // 
            dateAngazovanje.Format = DateTimePickerFormat.Short;
            dateAngazovanje.Location = new Point(477, 86);
            dateAngazovanje.Name = "dateAngazovanje";
            dateAngazovanje.Size = new Size(153, 23);
            dateAngazovanje.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 2627F));
            tableLayoutPanel2.Controls.Add(label11, 0, 0);
            tableLayoutPanel2.Controls.Add(label12, 0, 1);
            tableLayoutPanel2.Controls.Add(txbSprema, 1, 1);
            tableLayoutPanel2.Controls.Add(label13, 0, 2);
            tableLayoutPanel2.Controls.Add(txbSertifikati, 1, 2);
            tableLayoutPanel2.Controls.Add(comboObucenost, 1, 0);
            tableLayoutPanel2.Location = new Point(6, 22);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0006647F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0006628F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.997354F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.997354F));
            tableLayoutPanel2.Size = new Size(262, 82);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(3, 6);
            label11.Name = "label11";
            label11.Size = new Size(94, 15);
            label11.TabIndex = 8;
            label11.Text = "Nivo obucenosti";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Location = new Point(3, 33);
            label12.Name = "label12";
            label12.Size = new Size(84, 15);
            label12.TabIndex = 9;
            label12.Text = "Fizicka sprema";
            // 
            // txbSprema
            // 
            txbSprema.Location = new Point(103, 30);
            txbSprema.Name = "txbSprema";
            txbSprema.Size = new Size(155, 23);
            txbSprema.TabIndex = 1;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Location = new Point(3, 60);
            label13.Name = "label13";
            label13.Size = new Size(82, 15);
            label13.TabIndex = 10;
            label13.Text = "Broj sertifikata";
            // 
            // txbSertifikati
            // 
            txbSertifikati.Location = new Point(103, 57);
            txbSertifikati.Name = "txbSertifikati";
            txbSertifikati.Size = new Size(155, 23);
            txbSertifikati.TabIndex = 2;
            // 
            // comboObucenost
            // 
            comboObucenost.FormattingEnabled = true;
            comboObucenost.Items.AddRange(new object[] { "Osnovni", "Srednji", "Specijalni" });
            comboObucenost.Location = new Point(103, 3);
            comboObucenost.Name = "comboObucenost";
            comboObucenost.Size = new Size(155, 23);
            comboObucenost.TabIndex = 11;
            // 
            // gbInfoVatrogasac
            // 
            gbInfoVatrogasac.Controls.Add(tableLayoutPanel2);
            gbInfoVatrogasac.Location = new Point(12, 492);
            gbInfoVatrogasac.Name = "gbInfoVatrogasac";
            gbInfoVatrogasac.Size = new Size(270, 111);
            gbInfoVatrogasac.TabIndex = 12;
            gbInfoVatrogasac.TabStop = false;
            gbInfoVatrogasac.Text = "Informacije o vatrogascu";
            gbInfoVatrogasac.Visible = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel1);
            groupBox4.Location = new Point(12, 292);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(645, 194);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Podaci";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 266);
            label14.Name = "label14";
            label14.Size = new Size(36, 15);
            label14.TabIndex = 14;
            label14.Text = "Filter:";
            // 
            // gbInfoTehnicar
            // 
            gbInfoTehnicar.Controls.Add(tableLayoutPanel3);
            gbInfoTehnicar.Location = new Point(12, 642);
            gbInfoTehnicar.Name = "gbInfoTehnicar";
            gbInfoTehnicar.Size = new Size(270, 84);
            gbInfoTehnicar.TabIndex = 13;
            gbInfoTehnicar.TabStop = false;
            gbInfoTehnicar.Text = "Informacije o tehnicaru";
            gbInfoTehnicar.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 2627F));
            tableLayoutPanel3.Controls.Add(label15, 0, 0);
            tableLayoutPanel3.Controls.Add(txbSpecijalizacija, 1, 0);
            tableLayoutPanel3.Controls.Add(label16, 0, 1);
            tableLayoutPanel3.Controls.Add(btnAlati, 1, 1);
            tableLayoutPanel3.Location = new Point(6, 22);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0006647F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0006628F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.997354F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.997354F));
            tableLayoutPanel3.Size = new Size(262, 55);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Location = new Point(3, 6);
            label15.Name = "label15";
            label15.Size = new Size(79, 15);
            label15.TabIndex = 8;
            label15.Text = "Specijalizacija";
            // 
            // txbSpecijalizacija
            // 
            txbSpecijalizacija.Location = new Point(88, 3);
            txbSpecijalizacija.Name = "txbSpecijalizacija";
            txbSpecijalizacija.Size = new Size(155, 23);
            txbSpecijalizacija.TabIndex = 0;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Location = new Point(3, 33);
            label16.Name = "label16";
            label16.Size = new Size(31, 15);
            label16.TabIndex = 9;
            label16.Text = "Alati";
            // 
            // btnAlati
            // 
            btnAlati.Location = new Point(88, 30);
            btnAlati.Name = "btnAlati";
            btnAlati.Size = new Size(92, 22);
            btnAlati.TabIndex = 10;
            btnAlati.Text = "Spisak alata";
            btnAlati.UseVisualStyleBackColor = true;
            // 
            // gbInfoDispecer
            // 
            gbInfoDispecer.Controls.Add(tableLayoutPanel4);
            gbInfoDispecer.Location = new Point(12, 792);
            gbInfoDispecer.Name = "gbInfoDispecer";
            gbInfoDispecer.Size = new Size(270, 83);
            gbInfoDispecer.TabIndex = 14;
            gbInfoDispecer.TabStop = false;
            gbInfoDispecer.Text = "Informacije o dispeceru";
            gbInfoDispecer.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 2627F));
            tableLayoutPanel4.Controls.Add(label18, 0, 0);
            tableLayoutPanel4.Controls.Add(txbTipOpreme, 1, 0);
            tableLayoutPanel4.Controls.Add(label19, 0, 1);
            tableLayoutPanel4.Controls.Add(txbBrSmena, 1, 1);
            tableLayoutPanel4.Location = new Point(6, 22);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0006647F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0006628F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 9.997354F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 9.997354F));
            tableLayoutPanel4.Size = new Size(262, 53);
            tableLayoutPanel4.TabIndex = 11;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Left;
            label18.AutoSize = true;
            label18.Location = new Point(3, 5);
            label18.Name = "label18";
            label18.Size = new Size(134, 15);
            label18.TabIndex = 8;
            label18.Text = "Komunikaciona oprema";
            // 
            // txbTipOpreme
            // 
            txbTipOpreme.Location = new Point(143, 3);
            txbTipOpreme.Name = "txbTipOpreme";
            txbTipOpreme.Size = new Size(115, 23);
            txbTipOpreme.TabIndex = 0;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Left;
            label19.AutoSize = true;
            label19.Location = new Point(3, 32);
            label19.Name = "label19";
            label19.Size = new Size(117, 15);
            label19.TabIndex = 9;
            label19.Text = "Broj smena mesecno";
            // 
            // txbBrSmena
            // 
            txbBrSmena.Location = new Point(143, 29);
            txbBrSmena.Name = "txbBrSmena";
            txbBrSmena.Size = new Size(114, 23);
            txbBrSmena.TabIndex = 1;
            // 
            // gbInfoVolonter
            // 
            gbInfoVolonter.Controls.Add(tableLayoutPanel5);
            gbInfoVolonter.Location = new Point(12, 729);
            gbInfoVolonter.Name = "gbInfoVolonter";
            gbInfoVolonter.Size = new Size(270, 57);
            gbInfoVolonter.TabIndex = 15;
            gbInfoVolonter.TabStop = false;
            gbInfoVolonter.Text = "Informacije o volonteru";
            gbInfoVolonter.Visible = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 2627F));
            tableLayoutPanel5.Controls.Add(label21, 0, 0);
            tableLayoutPanel5.Controls.Add(btnSpisakVozila, 1, 0);
            tableLayoutPanel5.Location = new Point(6, 22);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0006647F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10.000659F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0006628F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 9.997354F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 9.997354F));
            tableLayoutPanel5.Size = new Size(262, 28);
            tableLayoutPanel5.TabIndex = 11;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Left;
            label21.AutoSize = true;
            label21.Location = new Point(3, 6);
            label21.Name = "label21";
            label21.Size = new Size(90, 15);
            label21.TabIndex = 8;
            label21.Text = "Vozila volontera";
            // 
            // btnSpisakVozila
            // 
            btnSpisakVozila.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSpisakVozila.Location = new Point(99, 3);
            btnSpisakVozila.Name = "btnSpisakVozila";
            btnSpisakVozila.Size = new Size(92, 22);
            btnSpisakVozila.TabIndex = 11;
            btnSpisakVozila.Text = "Spisak vozila";
            btnSpisakVozila.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(459, 596);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(98, 23);
            btnSacuvaj.TabIndex = 16;
            btnSacuvaj.Text = "Sačuvaj zaposlenog";
            btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // btnOtkazi
            // 
            btnOtkazi.Location = new Point(563, 596);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(98, 23);
            btnOtkazi.TabIndex = 17;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // ZaposleniForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 625);
            Controls.Add(btnOtkazi);
            Controls.Add(btnSacuvaj);
            Controls.Add(gbInfoVolonter);
            Controls.Add(gbInfoTehnicar);
            Controls.Add(gbInfoDispecer);
            Controls.Add(gbInfoVatrogasac);
            Controls.Add(btnIzmeni);
            Controls.Add(label14);
            Controls.Add(btnNovi);
            Controls.Add(txbPretraga);
            Controls.Add(btnObrisi);
            Controls.Add(groupBox4);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ZaposleniForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Zaposleni";
            tabControl.ResumeLayout(false);
            Vatrogasac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridVatrogasci).EndInit();
            Tehnicar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridTehnicari).EndInit();
            Dispecer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridDispeceri).EndInit();
            Volonter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridVolonteri).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            gbInfoVatrogasac.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            gbInfoTehnicar.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            gbInfoDispecer.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            gbInfoVolonter.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnIzmeni;
        private Button btnNovi;
        private Button btnObrisi;
        private TabControl tabControl;
        private TabPage Vatrogasac;
        private TabPage Tehnicar;
        private TabPage Dispecer;
        private TabPage Volonter;
        private TextBox txbPretraga;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox txbMatbr;
        private Label label2;
        private TextBox txbIme;
        private Label label3;
        private TextBox txbPrezime;
        private Label label5;
        private DateTimePicker dateRodjenje;
        private Label label4;
        private ComboBox comboPol;
        private Label label6;
        private TextBox txbAdresa;
        private Label label7;
        private TextBox txbEmail;
        private Label label8;
        private Label label10;
        private DateTimePicker dateAngazovanje;
        private TextBox txbTelefoni;
        private Label label9;
        private ComboBox comboPozicija;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label11;
        private Label label12;
        private TextBox txbSprema;
        private Label label13;
        private TextBox txbSertifikati;
        private GroupBox gbInfoVatrogasac;
        private GroupBox groupBox4;
        private Label label14;
        private GroupBox gbInfoTehnicar;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label15;
        private TextBox txbSpecijalizacija;
        private GroupBox gbInfoDispecer;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label18;
        private TextBox txbTipOpreme;
        private Label label19;
        private TextBox txbBrSmena;
        private GroupBox gbInfoVolonter;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label21;
        private Label label16;
        private Button btnAlati;
        private Button btnSpisakVozila;
        private Label label17;
        private ComboBox comboStanica;
        private DataGridView dataGridVatrogasci;
        private DataGridView dataGridDispeceri;
        private DataGridView dataGridVolonteri;
        private DataGridView dataGridTehnicari;
        private ComboBox comboObucenost;
        private Button btnSacuvaj;
        private Button btnOtkazi;
    }
}