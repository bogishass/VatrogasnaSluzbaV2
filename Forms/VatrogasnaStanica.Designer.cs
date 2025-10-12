namespace VatrogasnaSluzba.Forms
{
    partial class VatrogasnaStanica
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
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ID_Stanice = new DataGridViewTextBoxColumn();
            IdStanice = new DataGridViewTextBoxColumn();
            Adresa = new DataGridViewTextBoxColumn();
            BrojZaposlenih = new DataGridViewTextBoxColumn();
            BrojVozila = new DataGridViewTextBoxColumn();
            DostupnaInfrastruktura = new DataGridViewTextBoxColumn();
            PovrsinaObjekta = new DataGridViewTextBoxColumn();
            Komandir = new DataGridViewTextBoxColumn();
            Smene = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1525, 495);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "VatrogasnaStanica";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button3
            // 
            button3.Location = new Point(1397, 223);
            button3.Name = "button3";
            button3.Size = new Size(122, 81);
            button3.TabIndex = 3;
            button3.Text = "Izmeni Stanicu";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1397, 120);
            button2.Name = "button2";
            button2.Size = new Size(122, 81);
            button2.TabIndex = 2;
            button2.Text = "Obrisi Stanicu";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1397, 22);
            button1.Name = "button1";
            button1.Size = new Size(122, 81);
            button1.TabIndex = 1;
            button1.Text = "Dodaj Stanicu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID_Stanice, IdStanice, Adresa, BrojZaposlenih, BrojVozila, DostupnaInfrastruktura, PovrsinaObjekta, Komandir, Smene });
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1372, 416);
            dataGridView1.TabIndex = 0;
            // 
            // ID_Stanice
            // 
            ID_Stanice.HeaderText = "ID_Stanice";
            ID_Stanice.Name = "ID_Stanice";
            // 
            // IdStanice
            // 
            IdStanice.HeaderText = "IdStanice";
            IdStanice.Name = "IdStanice";
            // 
            // Adresa
            // 
            Adresa.HeaderText = "Adresa";
            Adresa.Name = "Adresa";
            // 
            // BrojZaposlenih
            // 
            BrojZaposlenih.HeaderText = "BrojZaposlenih";
            BrojZaposlenih.Name = "BrojZaposlenih";
            // 
            // BrojVozila
            // 
            BrojVozila.HeaderText = "BrojVozila";
            BrojVozila.Name = "BrojVozila";
            // 
            // DostupnaInfrastruktura
            // 
            DostupnaInfrastruktura.HeaderText = "DostupnaInfrastruktura";
            DostupnaInfrastruktura.Name = "DostupnaInfrastruktura";
            // 
            // PovrsinaObjekta
            // 
            PovrsinaObjekta.HeaderText = "PovrsinaObjekta";
            PovrsinaObjekta.Name = "PovrsinaObjekta";
            // 
            // Komandir
            // 
            Komandir.HeaderText = "Komandir";
            Komandir.Name = "Komandir";
            // 
            // Smene
            // 
            Smene.HeaderText = "Smene";
            Smene.Name = "Smene";
            // 
            // VatrogasnaStanica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1549, 564);
            Controls.Add(groupBox1);
            Name = "VatrogasnaStanica";
            Text = "VatrogasnaStanica";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID_Stanice;
        private DataGridViewTextBoxColumn IdStanice;
        private DataGridViewTextBoxColumn Adresa;
        private DataGridViewTextBoxColumn BrojZaposlenih;
        private DataGridViewTextBoxColumn BrojVozila;
        private DataGridViewTextBoxColumn DostupnaInfrastruktura;
        private DataGridViewTextBoxColumn PovrsinaObjekta;
        private DataGridViewTextBoxColumn Komandir;
        private DataGridViewTextBoxColumn Smene;
        private Button button1;
        private Button button3;
        private Button button2;
    }
}