namespace VatrogasnaSluzba.Forms
{
    partial class IntervencijaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntervencijaForm));
            dataGridView1 = new DataGridView();
            buttonDodajIntervenciju = new Button();
            buttonObrisiIntervenciju = new Button();
            buttonIzmeniIntervenciju = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            txbVrstaInterakcije = new TextBox();
            label6 = new Label();
            txbAdresaIntervencije = new TextBox();
            label4 = new Label();
            dateTimePickerDatumPocetka = new DateTimePicker();
            label5 = new Label();
            dateTimePickerDatumKraj = new DateTimePicker();
            label12 = new Label();
            txbBrojVatrogasaca = new TextBox();
            label7 = new Label();
            label9 = new Label();
            label11 = new Label();
            dateTimePickerVremeDolaska = new DateTimePicker();
            dateTimePickerVremePromena = new DateTimePicker();
            label8 = new Label();
            txbOpisSituacije = new TextBox();
            comboStatus = new ComboBox();
            label2 = new Label();
            btnResursi = new Button();
            buttonSacuvaj = new Button();
            buttonOtkazi = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 22);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(608, 247);
            dataGridView1.TabIndex = 1;
            // 
            // buttonDodajIntervenciju
            // 
            buttonDodajIntervenciju.Location = new Point(623, 22);
            buttonDodajIntervenciju.Name = "buttonDodajIntervenciju";
            buttonDodajIntervenciju.Size = new Size(116, 40);
            buttonDodajIntervenciju.TabIndex = 2;
            buttonDodajIntervenciju.Text = "Dodaj intervenciju";
            buttonDodajIntervenciju.UseVisualStyleBackColor = true;
            // 
            // buttonObrisiIntervenciju
            // 
            buttonObrisiIntervenciju.Location = new Point(623, 114);
            buttonObrisiIntervenciju.Name = "buttonObrisiIntervenciju";
            buttonObrisiIntervenciju.Size = new Size(116, 40);
            buttonObrisiIntervenciju.TabIndex = 3;
            buttonObrisiIntervenciju.Text = "Obriši intervenciju";
            buttonObrisiIntervenciju.UseVisualStyleBackColor = true;
            // 
            // buttonIzmeniIntervenciju
            // 
            buttonIzmeniIntervenciju.Location = new Point(623, 68);
            buttonIzmeniIntervenciju.Name = "buttonIzmeniIntervenciju";
            buttonIzmeniIntervenciju.Size = new Size(116, 40);
            buttonIzmeniIntervenciju.TabIndex = 4;
            buttonIzmeniIntervenciju.Text = "Izmeni intervenciju";
            buttonIzmeniIntervenciju.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(12, 305);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(617, 207);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacije o intervenciji";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(txbVrstaInterakcije, 1, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(txbAdresaIntervencije, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(dateTimePickerDatumPocetka, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(dateTimePickerDatumKraj, 1, 3);
            tableLayoutPanel1.Controls.Add(label12, 2, 3);
            tableLayoutPanel1.Controls.Add(txbBrojVatrogasaca, 3, 0);
            tableLayoutPanel1.Controls.Add(label7, 2, 0);
            tableLayoutPanel1.Controls.Add(label9, 2, 1);
            tableLayoutPanel1.Controls.Add(label11, 2, 2);
            tableLayoutPanel1.Controls.Add(dateTimePickerVremeDolaska, 3, 1);
            tableLayoutPanel1.Controls.Add(dateTimePickerVremePromena, 3, 2);
            tableLayoutPanel1.Controls.Add(label8, 0, 4);
            tableLayoutPanel1.Controls.Add(txbOpisSituacije, 1, 4);
            tableLayoutPanel1.Controls.Add(comboStatus, 3, 3);
            tableLayoutPanel1.Controls.Add(label2, 2, 4);
            tableLayoutPanel1.Controls.Add(btnResursi, 3, 4);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel1.Size = new Size(601, 173);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 9;
            label3.Text = "Vrsta intervencije";
            // 
            // txbVrstaInterakcije
            // 
            txbVrstaInterakcije.Location = new Point(123, 3);
            txbVrstaInterakcije.Name = "txbVrstaInterakcije";
            txbVrstaInterakcije.Size = new Size(174, 23);
            txbVrstaInterakcije.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 43);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 10;
            label6.Text = "Adresa intervencije";
            // 
            // txbAdresaIntervencije
            // 
            txbAdresaIntervencije.Location = new Point(123, 37);
            txbAdresaIntervencije.Name = "txbAdresaIntervencije";
            txbAdresaIntervencije.Size = new Size(174, 23);
            txbAdresaIntervencije.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 77);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 11;
            label4.Text = "Datum početka";
            // 
            // dateTimePickerDatumPocetka
            // 
            dateTimePickerDatumPocetka.CustomFormat = "";
            dateTimePickerDatumPocetka.Format = DateTimePickerFormat.Short;
            dateTimePickerDatumPocetka.Location = new Point(123, 71);
            dateTimePickerDatumPocetka.Name = "dateTimePickerDatumPocetka";
            dateTimePickerDatumPocetka.Size = new Size(174, 23);
            dateTimePickerDatumPocetka.TabIndex = 20;
            dateTimePickerDatumPocetka.Value = new DateTime(2025, 8, 18, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 111);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 12;
            label5.Text = "Datum završetka";
            // 
            // dateTimePickerDatumKraj
            // 
            dateTimePickerDatumKraj.CustomFormat = "";
            dateTimePickerDatumKraj.Format = DateTimePickerFormat.Short;
            dateTimePickerDatumKraj.Location = new Point(123, 105);
            dateTimePickerDatumKraj.Name = "dateTimePickerDatumKraj";
            dateTimePickerDatumKraj.Size = new Size(174, 23);
            dateTimePickerDatumKraj.TabIndex = 5;
            dateTimePickerDatumKraj.Value = new DateTime(2025, 8, 18, 0, 0, 0, 0);
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Location = new Point(303, 111);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 27;
            label12.Text = "Status";
            // 
            // txbBrojVatrogasaca
            // 
            txbBrojVatrogasaca.Location = new Point(423, 3);
            txbBrojVatrogasaca.Name = "txbBrojVatrogasaca";
            txbBrojVatrogasaca.Size = new Size(174, 23);
            txbBrojVatrogasaca.TabIndex = 4;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(303, 9);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 14;
            label7.Text = "Broj vatrogasaca";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(303, 43);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 22;
            label9.Text = "Vreme dolaska";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(303, 77);
            label11.Name = "label11";
            label11.Size = new Size(107, 15);
            label11.TabIndex = 24;
            label11.Text = "Dat. posl. promene";
            // 
            // dateTimePickerVremeDolaska
            // 
            dateTimePickerVremeDolaska.Format = DateTimePickerFormat.Time;
            dateTimePickerVremeDolaska.Location = new Point(423, 37);
            dateTimePickerVremeDolaska.Name = "dateTimePickerVremeDolaska";
            dateTimePickerVremeDolaska.Size = new Size(174, 23);
            dateTimePickerVremeDolaska.TabIndex = 23;
            dateTimePickerVremeDolaska.Value = new DateTime(2025, 10, 16, 17, 54, 0, 0);
            // 
            // dateTimePickerVremePromena
            // 
            dateTimePickerVremePromena.Format = DateTimePickerFormat.Short;
            dateTimePickerVremePromena.Location = new Point(423, 71);
            dateTimePickerVremePromena.Name = "dateTimePickerVremePromena";
            dateTimePickerVremePromena.Size = new Size(174, 23);
            dateTimePickerVremePromena.TabIndex = 25;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 147);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 13;
            label8.Text = "Opis situacije";
            // 
            // txbOpisSituacije
            // 
            txbOpisSituacije.Location = new Point(123, 139);
            txbOpisSituacije.Name = "txbOpisSituacije";
            txbOpisSituacije.Size = new Size(174, 23);
            txbOpisSituacije.TabIndex = 3;
            // 
            // comboStatus
            // 
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatus.FormattingEnabled = true;
            comboStatus.Location = new Point(423, 105);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(175, 23);
            comboStatus.TabIndex = 30;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(303, 147);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 32;
            label2.Text = "Resursi";
            // 
            // btnResursi
            // 
            btnResursi.Location = new Point(423, 139);
            btnResursi.Name = "btnResursi";
            btnResursi.Size = new Size(174, 23);
            btnResursi.TabIndex = 31;
            btnResursi.Text = "Upravljanje resursima";
            btnResursi.UseVisualStyleBackColor = true;
            // 
            // buttonSacuvaj
            // 
            buttonSacuvaj.Location = new Point(636, 450);
            buttonSacuvaj.Name = "buttonSacuvaj";
            buttonSacuvaj.Size = new Size(123, 28);
            buttonSacuvaj.TabIndex = 6;
            buttonSacuvaj.Text = "Sačuvaj";
            buttonSacuvaj.UseVisualStyleBackColor = true;
            // 
            // buttonOtkazi
            // 
            buttonOtkazi.Location = new Point(635, 484);
            buttonOtkazi.Name = "buttonOtkazi";
            buttonOtkazi.Size = new Size(123, 28);
            buttonOtkazi.TabIndex = 7;
            buttonOtkazi.Text = "Otkaži";
            buttonOtkazi.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(buttonDodajIntervenciju);
            groupBox2.Controls.Add(buttonIzmeniIntervenciju);
            groupBox2.Controls.Add(buttonObrisiIntervenciju);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(747, 279);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Evidencija intervencija";
            // 
            // IntervencijaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(770, 523);
            Controls.Add(groupBox2);
            Controls.Add(buttonOtkazi);
            Controls.Add(groupBox1);
            Controls.Add(buttonSacuvaj);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "IntervencijaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vatrogasna služba - Intervencije";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button buttonDodajIntervenciju;
        private Button buttonObrisiIntervenciju;
        private Button buttonIzmeniIntervenciju;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker dateTimePickerDatumPocetka;
        private Label label3;
        private Label label5;
        private TextBox txbOpisSituacije;
        private DateTimePicker dateTimePickerDatumKraj;
        private TextBox txbVrstaInterakcije;
        private Label label4;
        private Label label6;
        private TextBox txbAdresaIntervencije;
        private Label label8;
        private Button buttonSacuvaj;
        private Button buttonOtkazi;
        private Label label12;
        private TextBox txbBrojVatrogasaca;
        private Label label7;
        private Label label9;
        private Label label11;
        private DateTimePicker dateTimePickerVremeDolaska;
        private DateTimePicker dateTimePickerVremePromena;
        private ComboBox comboStatus;
        private Button btnResursi;
        private Label label2;
        private GroupBox groupBox2;
    }
}