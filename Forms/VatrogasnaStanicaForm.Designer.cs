
using System.Drawing;
using System.Windows.Forms;

namespace VatrogasnaSluzba.Forms
{
    partial class VatrogasnaStanicaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VatrogasnaStanicaForm));
            groupBox1 = new GroupBox();
            btnOtkazi = new Button();
            btnSacuvaj = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ID_Stanice = new DataGridViewTextBoxColumn();
            Adresa = new DataGridViewTextBoxColumn();
            BrojZaposlenih = new DataGridViewTextBoxColumn();
            BrojVozila = new DataGridViewTextBoxColumn();
            DostupnaInfrastruktura = new DataGridViewTextBoxColumn();
            PovrsinaObjekta = new DataGridViewTextBoxColumn();
            Komandir = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            txbID_Stanice = new TextBox();
            label2 = new Label();
            tbxAdresa = new TextBox();
            label3 = new Label();
            txbBrojZaposlenih = new TextBox();
            label5 = new Label();
            tbxBrojVozila = new TextBox();
            label4 = new Label();
            comboDostupnaInfrastruktura = new ComboBox();
            label6 = new Label();
            txbPovrsinaObjekta = new TextBox();
            label7 = new Label();
            txbKomandir = new TextBox();
            Smena = new Label();
            btnSmene = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(btnOtkazi);
            groupBox1.Controls.Add(btnSacuvaj);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(842, 450);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "VatrogasnaStanica";
            // 
            // btnOtkazi
            // 
            btnOtkazi.Location = new Point(715, 344);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(122, 39);
            btnOtkazi.TabIndex = 25;
            btnOtkazi.Text = "Otkazi";
            btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(715, 299);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(122, 39);
            btnSacuvaj.TabIndex = 24;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(715, 196);
            button3.Name = "button3";
            button3.Size = new Size(122, 81);
            button3.TabIndex = 3;
            button3.Text = "Izmeni Stanicu";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(715, 109);
            button2.Name = "button2";
            button2.Size = new Size(122, 81);
            button2.TabIndex = 2;
            button2.Text = "Obrisi Stanicu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(715, 22);
            button1.Name = "button1";
            button1.Size = new Size(122, 81);
            button1.TabIndex = 1;
            button1.Text = "Dodaj Stanicu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID_Stanice, Adresa, BrojZaposlenih, BrojVozila, DostupnaInfrastruktura, PovrsinaObjekta, Komandir });
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(703, 416);
            dataGridView1.TabIndex = 0;
            // 
            // ID_Stanice
            // 
            ID_Stanice.HeaderText = "ID_Stanice";
            ID_Stanice.Name = "ID_Stanice";
            ID_Stanice.ReadOnly = true;
            // 
            // Adresa
            // 
            Adresa.HeaderText = "Adresa";
            Adresa.Name = "Adresa";
            Adresa.ReadOnly = true;
            // 
            // BrojZaposlenih
            // 
            BrojZaposlenih.HeaderText = "BrojZaposlenih";
            BrojZaposlenih.Name = "BrojZaposlenih";
            BrojZaposlenih.ReadOnly = true;
            // 
            // BrojVozila
            // 
            BrojVozila.HeaderText = "BrojVozila";
            BrojVozila.Name = "BrojVozila";
            BrojVozila.ReadOnly = true;
            // 
            // DostupnaInfrastruktura
            // 
            DostupnaInfrastruktura.HeaderText = "DostupnaInfrastruktura";
            DostupnaInfrastruktura.Name = "DostupnaInfrastruktura";
            DostupnaInfrastruktura.ReadOnly = true;
            // 
            // PovrsinaObjekta
            // 
            PovrsinaObjekta.HeaderText = "PovrsinaObjekta";
            PovrsinaObjekta.Name = "PovrsinaObjekta";
            PovrsinaObjekta.ReadOnly = true;
            // 
            // Komandir
            // 
            Komandir.HeaderText = "Komandir";
            Komandir.Name = "Komandir";
            Komandir.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Location = new Point(12, 481);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(842, 231);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dodaj/Edituj";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txbID_Stanice, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(tbxAdresa, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txbBrojZaposlenih, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(tbxBrojVozila, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(comboDostupnaInfrastruktura, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(txbPovrsinaObjekta, 1, 5);
            tableLayoutPanel1.Controls.Add(label7, 2, 0);
            tableLayoutPanel1.Controls.Add(txbKomandir, 3, 0);
            tableLayoutPanel1.Controls.Add(Smena, 2, 1);
            tableLayoutPanel1.Controls.Add(btnSmene, 3, 1);
            tableLayoutPanel1.Location = new Point(6, 32);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.8F));
            tableLayoutPanel1.Size = new Size(816, 197);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "ID_Stanice";
            // 
            // txbID_Stanice
            // 
            txbID_Stanice.Location = new Point(207, 3);
            txbID_Stanice.MaxLength = 13;
            txbID_Stanice.Name = "txbID_Stanice";
            txbID_Stanice.Size = new Size(198, 23);
            txbID_Stanice.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 42);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Adresa";
            // 
            // tbxAdresa
            // 
            tbxAdresa.Location = new Point(207, 36);
            tbxAdresa.Name = "tbxAdresa";
            tbxAdresa.Size = new Size(198, 23);
            tbxAdresa.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 74);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 4;
            label3.Text = "BrojZaposlenih";
            // 
            // txbBrojZaposlenih
            // 
            txbBrojZaposlenih.Location = new Point(207, 69);
            txbBrojZaposlenih.Name = "txbBrojZaposlenih";
            txbBrojZaposlenih.Size = new Size(198, 23);
            txbBrojZaposlenih.TabIndex = 5;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 106);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 6;
            label5.Text = "Broj vozila";
            // 
            // tbxBrojVozila
            // 
            tbxBrojVozila.Location = new Point(207, 101);
            tbxBrojVozila.Name = "tbxBrojVozila";
            tbxBrojVozila.Size = new Size(198, 23);
            tbxBrojVozila.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 138);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
            label4.TabIndex = 8;
            label4.Text = "Dostupna Infrastruktura";
            // 
            // comboDostupnaInfrastruktura
            // 
            comboDostupnaInfrastruktura.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDostupnaInfrastruktura.Location = new Point(207, 132);
            comboDostupnaInfrastruktura.Name = "comboDostupnaInfrastruktura";
            comboDostupnaInfrastruktura.Size = new Size(198, 23);
            comboDostupnaInfrastruktura.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 172);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 10;
            label6.Text = "PovrsinaObjekta";
            // 
            // txbPovrsinaObjekta
            // 
            txbPovrsinaObjekta.Location = new Point(207, 165);
            txbPovrsinaObjekta.Name = "txbPovrsinaObjekta";
            txbPovrsinaObjekta.Size = new Size(198, 23);
            txbPovrsinaObjekta.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(411, 9);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 12;
            label7.Text = "Komandir";
            // 
            // txbKomandir
            // 
            txbKomandir.Location = new Point(615, 3);
            txbKomandir.Name = "txbKomandir";
            txbKomandir.Size = new Size(198, 23);
            txbKomandir.TabIndex = 13;
            // 
            // Smena
            // 
            Smena.Anchor = AnchorStyles.Left;
            Smena.AutoSize = true;
            Smena.Location = new Point(411, 42);
            Smena.Name = "Smena";
            Smena.Size = new Size(43, 15);
            Smena.TabIndex = 14;
            Smena.Text = "Smene";
            // 
            // btnSmene
            // 
            btnSmene.Location = new Point(615, 36);
            btnSmene.Name = "btnSmene";
            btnSmene.Size = new Size(198, 27);
            btnSmene.TabIndex = 15;
            btnSmene.Text = "Smene";
            // 
            // VatrogasnaStanicaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(860, 724);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VatrogasnaStanicaForm";
            Text = "VatrogasnaStanica";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnOtkazi;
        private Button btnSacuvaj;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID_Stanice;
        private DataGridViewTextBoxColumn Adresa;
        private DataGridViewTextBoxColumn BrojZaposlenih;
        private DataGridViewTextBoxColumn BrojVozila;
        private DataGridViewTextBoxColumn DostupnaInfrastruktura;
        private DataGridViewTextBoxColumn PovrsinaObjekta;
        private DataGridViewTextBoxColumn Komandir;

        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox txbID_Stanice;
        private Label label2;
        private TextBox tbxAdresa;
        private Label label3;
        private TextBox txbBrojZaposlenih;
        private Label label5;
        private TextBox tbxBrojVozila;
        private Label label4;
        private ComboBox comboDostupnaInfrastruktura;
        private Label label6;
        private TextBox txbPovrsinaObjekta;
        private Label label7;
        private TextBox txbKomandir;
        private Label Smena;
        private Button btnSmene;
    }
}
