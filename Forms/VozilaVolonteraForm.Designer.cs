namespace VatrogasnaSluzba.Forms
{
    partial class VozilaVolonteraForm
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
            btnNovo = new Button();
            dataGridVozila = new DataGridView();
            btnObrisi = new Button();
            btnIzmeni = new Button();
            btnUpisi = new Button();
            groupBox2 = new GroupBox();
            btnOcisti = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            txbRegBroj = new TextBox();
            label2 = new Label();
            txbTip = new TextBox();
            label3 = new Label();
            txbProizvodjac = new TextBox();
            btnPotvrdi = new Button();
            btnOtkazi = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVozila).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNovo);
            groupBox1.Controls.Add(dataGridVozila);
            groupBox1.Controls.Add(btnObrisi);
            groupBox1.Controls.Add(btnIzmeni);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 279);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Spisak vozila volontera";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(6, 250);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(99, 23);
            btnNovo.TabIndex = 4;
            btnNovo.Text = "Novo vozilo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // dataGridVozila
            // 
            dataGridVozila.AllowUserToAddRows = false;
            dataGridVozila.AllowUserToDeleteRows = false;
            dataGridVozila.AllowUserToResizeRows = false;
            dataGridVozila.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridVozila.BorderStyle = BorderStyle.Fixed3D;
            dataGridVozila.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridVozila.Location = new Point(6, 22);
            dataGridVozila.MultiSelect = false;
            dataGridVozila.Name = "dataGridVozila";
            dataGridVozila.ReadOnly = true;
            dataGridVozila.RowHeadersVisible = false;
            dataGridVozila.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridVozila.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVozila.Size = new Size(388, 222);
            dataGridVozila.TabIndex = 1;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(216, 250);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(99, 23);
            btnObrisi.TabIndex = 3;
            btnObrisi.Text = "Obrisi vozilo";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(111, 250);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(99, 23);
            btnIzmeni.TabIndex = 2;
            btnIzmeni.Text = "Izmeni vozilo";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnUpisi
            // 
            btnUpisi.Dock = DockStyle.Bottom;
            btnUpisi.Location = new Point(3, 121);
            btnUpisi.Name = "btnUpisi";
            btnUpisi.Size = new Size(276, 23);
            btnUpisi.TabIndex = 9;
            btnUpisi.Text = "Upisi podatke";
            btnUpisi.UseVisualStyleBackColor = true;
            btnUpisi.Click += btnUpisi_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUpisi);
            groupBox2.Controls.Add(btnOcisti);
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Location = new Point(423, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(282, 170);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Podaci o vozilu";
            // 
            // btnOcisti
            // 
            btnOcisti.Dock = DockStyle.Bottom;
            btnOcisti.Location = new Point(3, 144);
            btnOcisti.Name = "btnOcisti";
            btnOcisti.Size = new Size(276, 23);
            btnOcisti.TabIndex = 8;
            btnOcisti.Text = "Otkazi upis";
            btnOcisti.UseVisualStyleBackColor = true;
            btnOcisti.Click += btnOcisti_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.02898F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.9710159F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txbRegBroj, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txbTip, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txbProizvodjac, 1, 2);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(273, 91);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 8;
            label1.Text = "Registarski broj";
            // 
            // txbRegBroj
            // 
            txbRegBroj.Location = new Point(117, 3);
            txbRegBroj.MaxLength = 13;
            txbRegBroj.Name = "txbRegBroj";
            txbRegBroj.Size = new Size(152, 23);
            txbRegBroj.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 37);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 9;
            label2.Text = "Tip";
            // 
            // txbTip
            // 
            txbTip.Location = new Point(117, 33);
            txbTip.Name = "txbTip";
            txbTip.Size = new Size(152, 23);
            txbTip.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 68);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 10;
            label3.Text = "Proizvodjac";
            // 
            // txbProizvodjac
            // 
            txbProizvodjac.Location = new Point(117, 63);
            txbProizvodjac.Name = "txbProizvodjac";
            txbProizvodjac.Size = new Size(152, 23);
            txbProizvodjac.TabIndex = 6;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.BackColor = Color.DarkSeaGreen;
            btnPotvrdi.Font = new Font("Segoe UI", 9F);
            btnPotvrdi.Location = new Point(501, 290);
            btnPotvrdi.Name = "btnPotvrdi";
            btnPotvrdi.Size = new Size(99, 30);
            btnPotvrdi.TabIndex = 11;
            btnPotvrdi.Text = "OK";
            btnPotvrdi.UseVisualStyleBackColor = false;
            btnPotvrdi.Click += btnPotvrdi_Click;
            // 
            // btnOtkazi
            // 
            btnOtkazi.BackColor = Color.LightCoral;
            btnOtkazi.Font = new Font("Segoe UI", 9F);
            btnOtkazi.Location = new Point(606, 290);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(99, 30);
            btnOtkazi.TabIndex = 10;
            btnOtkazi.Text = "Otkazi";
            btnOtkazi.UseVisualStyleBackColor = false;
            btnOtkazi.Click += btnOtkazi_Click;
            // 
            // VozilaVolonteraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 327);
            Controls.Add(btnOtkazi);
            Controls.Add(btnPotvrdi);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "VozilaVolonteraForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vozila volontera";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridVozila).EndInit();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridVozila;
        private Button btnIzmeni;
        private Button btnUpisi;
        private Button btnObrisi;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox txbRegBroj;
        private Label label2;
        private TextBox txbTip;
        private Label label3;
        private TextBox txbProizvodjac;
        private Button btnPotvrdi;
        private Button btnOtkazi;
        private Button btnOcisti;
        private Button btnNovo;
    }
}