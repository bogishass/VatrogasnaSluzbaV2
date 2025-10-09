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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1543, 737);
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
            button1.Location = new Point(1575, 27);
            button1.Name = "button1";
            button1.Size = new Size(146, 93);
            button1.TabIndex = 2;
            button1.Text = "Dodaj intervenciju";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1575, 126);
            button2.Name = "button2";
            button2.Size = new Size(146, 93);
            button2.TabIndex = 3;
            button2.Text = "Obrisi intervenciju";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1575, 225);
            button3.Name = "button3";
            button3.Size = new Size(146, 93);
            button3.TabIndex = 4;
            button3.Text = "Izmeni intervenciju";
            button3.UseVisualStyleBackColor = true;
            // 
            // Intervencija
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1754, 776);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Intervencija";
            Text = "Intervencija";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}