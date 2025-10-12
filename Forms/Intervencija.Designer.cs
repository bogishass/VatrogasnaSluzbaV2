namespace VatrogasnaSluzba.Forms
{
    partial class Intervencija
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            VrstaIntervencije = new DataGridViewTextBoxColumn();
            AdresaIntervencije = new DataGridViewTextBoxColumn();
            DatumPocetka = new DataGridViewTextBoxColumn();
            DatumKraja = new DataGridViewTextBoxColumn();
            OpisSituacije = new DataGridViewTextBoxColumn();
            BrojVatrogasaca = new DataGridViewTextBoxColumn();
            VremeDolaska = new DataGridViewTextBoxColumn();
            DatumPromene = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Smene = new DataGridViewTextBoxColumn();
            Zaposleni = new DataGridViewTextBoxColumn();
            Vozila = new DataGridViewTextBoxColumn();
            Volonteri = new DataGridViewTextBoxColumn();
            VozilaVolontera = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label7 = new Label();
            txbEmail = new TextBox();
            txbMatbr = new TextBox();
            label3 = new Label();
            label5 = new Label();
            txbAdresa = new TextBox();
            datumRodjenja = new DateTimePicker();
            txbIme = new TextBox();
            label4 = new Label();
            label6 = new Label();
            txbPrezime = new TextBox();
            label8 = new Label();
            label10 = new Label();
            txbTelefoni = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Intervencija";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, VrstaIntervencije, AdresaIntervencije, DatumPocetka, DatumKraja, OpisSituacije, BrojVatrogasaca, VremeDolaska, DatumPromene, Status, Smene, Zaposleni, Vozila, Volonteri, VozilaVolontera });
            dataGridView1.Location = new Point(12, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1550, 251);
            dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // VrstaIntervencije
            // 
            VrstaIntervencije.HeaderText = "VrstaIntervencije";
            VrstaIntervencije.Name = "VrstaIntervencije";
            // 
            // AdresaIntervencije
            // 
            AdresaIntervencije.HeaderText = "AdresaIntervencije";
            AdresaIntervencije.Name = "AdresaIntervencije";
            // 
            // DatumPocetka
            // 
            DatumPocetka.HeaderText = "DatumPocetka";
            DatumPocetka.Name = "DatumPocetka";
            // 
            // DatumKraja
            // 
            DatumKraja.HeaderText = "DatumKraja";
            DatumKraja.Name = "DatumKraja";
            // 
            // OpisSituacije
            // 
            OpisSituacije.HeaderText = "OpisSituacije";
            OpisSituacije.Name = "OpisSituacije";
            // 
            // BrojVatrogasaca
            // 
            BrojVatrogasaca.HeaderText = "BrojVatrogasaca";
            BrojVatrogasaca.Name = "BrojVatrogasaca";
            // 
            // VremeDolaska
            // 
            VremeDolaska.HeaderText = "VremeDolaska";
            VremeDolaska.Name = "VremeDolaska";
            // 
            // DatumPromene
            // 
            DatumPromene.HeaderText = "DatumPromene";
            DatumPromene.Name = "DatumPromene";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // Smene
            // 
            Smene.HeaderText = "Smene";
            Smene.Name = "Smene";
            // 
            // Zaposleni
            // 
            Zaposleni.HeaderText = "Zaposleni";
            Zaposleni.Name = "Zaposleni";
            // 
            // Vozila
            // 
            Vozila.HeaderText = "Vozila";
            Vozila.Name = "Vozila";
            // 
            // Volonteri
            // 
            Volonteri.HeaderText = "Volonteri";
            Volonteri.Name = "Volonteri";
            // 
            // VozilaVolontera
            // 
            VozilaVolontera.HeaderText = "VozilaVolontera";
            VozilaVolontera.Name = "VozilaVolontera";
            // 
            // button1
            // 
            button1.Location = new Point(650, 306);
            button1.Name = "button1";
            button1.Size = new Size(146, 31);
            button1.TabIndex = 2;
            button1.Text = "Dodaj intervenciju";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(802, 306);
            button2.Name = "button2";
            button2.Size = new Size(146, 31);
            button2.TabIndex = 3;
            button2.Text = "Obrisi intervenciju";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(954, 306);
            button3.Name = "button3";
            button3.Size = new Size(146, 31);
            button3.TabIndex = 4;
            button3.Text = "Izmeni intervenciju";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(12, 306);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(632, 308);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodaj intervenciju";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 182F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(txbEmail, 1, 6);
            tableLayoutPanel1.Controls.Add(txbMatbr, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(txbAdresa, 1, 5);
            tableLayoutPanel1.Controls.Add(datumRodjenja, 1, 4);
            tableLayoutPanel1.Controls.Add(txbIme, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(txbPrezime, 1, 2);
            tableLayoutPanel1.Controls.Add(label8, 0, 5);
            tableLayoutPanel1.Controls.Add(label10, 0, 7);
            tableLayoutPanel1.Controls.Add(txbTelefoni, 1, 7);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(619, 277);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(113, 105);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(155, 23);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.Value = new DateTime(2025, 8, 18, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 8;
            label2.Text = "ID";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 213);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 14;
            label7.Text = "BrojVatrogasaca";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(113, 207);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(155, 23);
            txbEmail.TabIndex = 4;
            // 
            // txbMatbr
            // 
            txbMatbr.Location = new Point(113, 3);
            txbMatbr.Name = "txbMatbr";
            txbMatbr.Size = new Size(155, 23);
            txbMatbr.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 43);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 9;
            label3.Text = "VrstaInterkacije";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 145);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 12;
            label5.Text = "DatumKraj";
            // 
            // txbAdresa
            // 
            txbAdresa.Location = new Point(113, 173);
            txbAdresa.Name = "txbAdresa";
            txbAdresa.Size = new Size(155, 23);
            txbAdresa.TabIndex = 3;
            // 
            // datumRodjenja
            // 
            datumRodjenja.CustomFormat = "";
            datumRodjenja.Format = DateTimePickerFormat.Short;
            datumRodjenja.Location = new Point(113, 139);
            datumRodjenja.Name = "datumRodjenja";
            datumRodjenja.Size = new Size(155, 23);
            datumRodjenja.TabIndex = 5;
            datumRodjenja.Value = new DateTime(2025, 8, 18, 0, 0, 0, 0);
            // 
            // txbIme
            // 
            txbIme.Location = new Point(113, 37);
            txbIme.Name = "txbIme";
            txbIme.Size = new Size(155, 23);
            txbIme.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 111);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 11;
            label4.Text = "DatumPocetka";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 77);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 10;
            label6.Text = "AdresaIntervencije";
            // 
            // txbPrezime
            // 
            txbPrezime.Location = new Point(113, 71);
            txbPrezime.Name = "txbPrezime";
            txbPrezime.Size = new Size(155, 23);
            txbPrezime.TabIndex = 2;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 179);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 13;
            label8.Text = "OpisSituacije";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(3, 250);
            label10.Name = "label10";
            label10.Size = new Size(91, 15);
            label10.TabIndex = 18;
            label10.Text = "BrojVatrogasaca";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbTelefoni
            // 
            txbTelefoni.Location = new Point(113, 241);
            txbTelefoni.Name = "txbTelefoni";
            txbTelefoni.PlaceholderText = "60 1234, 60 5678...";
            txbTelefoni.Size = new Size(155, 23);
            txbTelefoni.TabIndex = 19;
            // 
            // Intervencija
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1568, 626);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Intervencija";
            Text = "Intervencija";
            Load += Intervencija_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn VrstaIntervencije;
        private DataGridViewTextBoxColumn AdresaIntervencije;
        private DataGridViewTextBoxColumn DatumPocetka;
        private DataGridViewTextBoxColumn DatumKraja;
        private DataGridViewTextBoxColumn OpisSituacije;
        private DataGridViewTextBoxColumn BrojVatrogasaca;
        private DataGridViewTextBoxColumn VremeDolaska;
        private DataGridViewTextBoxColumn DatumPromene;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Smene;
        private DataGridViewTextBoxColumn Zaposleni;
        private DataGridViewTextBoxColumn Vozila;
        private DataGridViewTextBoxColumn Volonteri;
        private DataGridViewTextBoxColumn VozilaVolontera;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label7;
        private TextBox txbEmail;
        private TextBox txbMatbr;
        private Label label3;
        private Label label5;
        private TextBox txbAdresa;
        private DateTimePicker datumRodjenja;
        private TextBox txbIme;
        private Label label4;
        private Label label6;
        private TextBox txbPrezime;
        private Label label8;
        private Label label10;
        private TextBox txbTelefoni;
    }
}