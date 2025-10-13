// Forms/VatrogasnaStanicaForm.Designer.cs
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
            this.groupBox1 = new GroupBox();
            this.btnOtkazi = new Button();
            this.btnSacuvaj = new Button();
            this.button3 = new Button();
            this.button2 = new Button();
            this.button1 = new Button();
            this.dataGridView1 = new DataGridView();
            this.ID_Stanice = new DataGridViewTextBoxColumn();
            this.Adresa = new DataGridViewTextBoxColumn();
            this.BrojZaposlenih = new DataGridViewTextBoxColumn();
            this.BrojVozila = new DataGridViewTextBoxColumn();
            this.DostupnaInfrastruktura = new DataGridViewTextBoxColumn();
            this.PovrsinaObjekta = new DataGridViewTextBoxColumn();
            this.Komandir = new DataGridViewTextBoxColumn();
            this.groupBox2 = new GroupBox();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.label1 = new Label();
            this.txbID_Stanice = new TextBox();
            this.label2 = new Label();
            this.tbxAdresa = new TextBox();
            this.label3 = new Label();
            this.txbBrojZaposlenih = new TextBox();
            this.label5 = new Label();
            this.tbxBrojVozila = new TextBox();
            this.label4 = new Label();
            this.comboDostupnaInfrastruktura = new ComboBox();
            this.label6 = new Label();
            this.txbPovrsinaObjekta = new TextBox();
            this.label7 = new Label();
            this.txbKomandir = new TextBox();
            this.Smena = new Label();
            this.btnSmene = new Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOtkazi);
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(883, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VatrogasnaStanica";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new Point(755, 344);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new Size(122, 39);
            this.btnOtkazi.TabIndex = 25;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new Point(755, 299);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new Size(122, 39);
            this.btnSacuvaj.TabIndex = 24;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new Point(755, 196);
            this.button3.Name = "button3";
            this.button3.Size = new Size(122, 81);
            this.button3.TabIndex = 3;
            this.button3.Text = "Izmeni Stanicu";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new Point(755, 109);
            this.button2.Name = "button2";
            this.button2.Size = new Size(122, 81);
            this.button2.TabIndex = 2;
            this.button2.Text = "Obrisi Stanicu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += button2_Click;
            // 
            // button1
            // 
            this.button1.Location = new Point(755, 22);
            this.button1.Name = "button1";
            this.button1.Size = new Size(122, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj Stanicu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
            this.ID_Stanice,
            this.Adresa,
            this.BrojZaposlenih,
            this.BrojVozila,
            this.DostupnaInfrastruktura,
            this.PovrsinaObjekta,
            this.Komandir});
            this.dataGridView1.Location = new Point(6, 22);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new Size(743, 416);
            this.dataGridView1.TabIndex = 0;
            // 
            // columns
            // 
            this.ID_Stanice.HeaderText = "ID_Stanice";
            this.ID_Stanice.Name = "ID_Stanice";
            this.ID_Stanice.ReadOnly = true;

            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;

            this.BrojZaposlenih.HeaderText = "BrojZaposlenih";
            this.BrojZaposlenih.Name = "BrojZaposlenih";
            this.BrojZaposlenih.ReadOnly = true;

            this.BrojVozila.HeaderText = "BrojVozila";
            this.BrojVozila.Name = "BrojVozila";
            this.BrojVozila.ReadOnly = true;

            this.DostupnaInfrastruktura.HeaderText = "DostupnaInfrastruktura";
            this.DostupnaInfrastruktura.Name = "DostupnaInfrastruktura";
            this.DostupnaInfrastruktura.ReadOnly = true;

            this.PovrsinaObjekta.HeaderText = "PovrsinaObjekta";
            this.PovrsinaObjekta.Name = "PovrsinaObjekta";
            this.PovrsinaObjekta.ReadOnly = true;

            this.Komandir.HeaderText = "Komandir";
            this.Komandir.Name = "Komandir";
            this.Komandir.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new Point(12, 481);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(883, 293);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodaj/Edituj";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txbID_Stanice, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxAdresa, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txbBrojZaposlenih, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbxBrojVozila, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboDostupnaInfrastruktura, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txbPovrsinaObjekta, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txbKomandir, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Smena, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSmene, 3, 1);
            this.tableLayoutPanel1.Location = new Point(6, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.8F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.0F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.4F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.8F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.8F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.8F));
            this.tableLayoutPanel1.Size = new Size(871, 197);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // labels/inputs
            // 
            this.label1.Anchor = AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Text = "ID_Stanice";

            this.txbID_Stanice.MaxLength = 13;
            this.txbID_Stanice.Size = new Size(211, 23);

            this.label2.Anchor = AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Text = "Adresa";

            this.tbxAdresa.Size = new Size(211, 23);

            this.label3.Anchor = AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Text = "BrojZaposlenih";

            this.txbBrojZaposlenih.Size = new Size(211, 23);

            this.label5.Anchor = AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Text = "Broj vozila";

            this.tbxBrojVozila.Size = new Size(211, 23);

            this.label4.Anchor = AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Text = "Dostupna Infrastruktura";

            this.comboDostupnaInfrastruktura.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboDostupnaInfrastruktura.Size = new Size(211, 23);

            this.label6.AutoSize = true;
            this.label6.Text = "PovrsinaObjekta";

            this.txbPovrsinaObjekta.Size = new Size(211, 23);

            this.label7.Anchor = AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Text = "Komandir";

            this.txbKomandir.Size = new Size(214, 23);

            this.Smena.Anchor = AnchorStyles.Left;
            this.Smena.AutoSize = true;
            this.Smena.Text = "Smene";

            this.btnSmene.Text = "Smene";
            this.btnSmene.Size = new Size(214, 27);
            // 
            // VatrogasnaStanicaForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(912, 724);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VatrogasnaStanicaForm";
            this.Text = "VatrogasnaStanica";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
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
