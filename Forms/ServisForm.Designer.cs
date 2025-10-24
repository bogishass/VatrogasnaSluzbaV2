namespace VatrogasnaSluzba.Forms
{
    partial class ServisiForm
    {
        /// <summary>Required designer variable.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Clean up any resources being used.</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panelTop = new Panel();
            lblNaslov = new Label();
            lblOd = new Label();
            dtpOd = new DateTimePicker();
            lblDo = new Label();
            dtpDo = new DateTimePicker();
            lblTip = new Label();
            cbTip = new ComboBox();
            txtTehnicar = new TextBox();
            btnOsvezi = new Button();
            btnReset = new Button();
            btnNovi = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            btnZatvori = new Button();
            gbLista = new GroupBox();
            dgvServisi = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panelTop.SuspendLayout();
            gbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServisi).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panelTop, 0, 0);
            tableLayoutPanel1.Controls.Add(gbLista, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(900, 560);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lblNaslov);
            panelTop.Controls.Add(lblOd);
            panelTop.Controls.Add(dtpOd);
            panelTop.Controls.Add(lblDo);
            panelTop.Controls.Add(dtpDo);
            panelTop.Controls.Add(lblTip);
            panelTop.Controls.Add(cbTip);
            panelTop.Controls.Add(txtTehnicar);
            panelTop.Controls.Add(btnOsvezi);
            panelTop.Controls.Add(btnReset);
            panelTop.Controls.Add(btnNovi);
            panelTop.Controls.Add(btnIzmeni);
            panelTop.Controls.Add(btnObrisi);
            panelTop.Controls.Add(btnZatvori);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(3, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(894, 74);
            panelTop.TabIndex = 0;
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblNaslov.Location = new Point(10, 8);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(207, 23);
            lblNaslov.TabIndex = 0;
            lblNaslov.Text = "Servisi za vozilo: (regbroj)";
            // 
            // lblOd
            // 
            lblOd.AutoSize = true;
            lblOd.Location = new Point(10, 45);
            lblOd.Name = "lblOd";
            lblOd.Size = new Size(32, 20);
            lblOd.TabIndex = 1;
            lblOd.Text = "Od:";
            // 
            // dtpOd
            // 
            dtpOd.CustomFormat = "dd.MM.yyyy";
            dtpOd.Format = DateTimePickerFormat.Custom;
            dtpOd.Location = new Point(40, 41);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(120, 27);
            dtpOd.TabIndex = 2;
            // 
            // lblDo
            // 
            lblDo.AutoSize = true;
            lblDo.Location = new Point(170, 45);
            lblDo.Name = "lblDo";
            lblDo.Size = new Size(32, 20);
            lblDo.TabIndex = 3;
            lblDo.Text = "Do:";
            // 
            // dtpDo
            // 
            dtpDo.CustomFormat = "dd.MM.yyyy";
            dtpDo.Format = DateTimePickerFormat.Custom;
            dtpDo.Location = new Point(198, 41);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(120, 27);
            dtpDo.TabIndex = 4;
            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.Location = new Point(330, 45);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(33, 20);
            lblTip.TabIndex = 5;
            lblTip.Text = "Tip:";
            // 
            // cbTip
            // 
            cbTip.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTip.Location = new Point(360, 41);
            cbTip.Name = "cbTip";
            cbTip.Size = new Size(140, 28);
            cbTip.TabIndex = 6;
            // 
            // txtTehnicar
            // 
            txtTehnicar.Location = new Point(510, 41);
            txtTehnicar.Name = "txtTehnicar";
            txtTehnicar.PlaceholderText = "Tehničar";
            txtTehnicar.Size = new Size(140, 27);
            txtTehnicar.TabIndex = 7;
            // 
            // btnOsvezi
            // 
            btnOsvezi.Location = new Point(660, 39);
            btnOsvezi.Name = "btnOsvezi";
            btnOsvezi.Size = new Size(70, 27);
            btnOsvezi.TabIndex = 8;
            btnOsvezi.Text = "Osveži";
            btnOsvezi.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(736, 39);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(70, 27);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnNovi
            // 
            btnNovi.Location = new Point(660, 6);
            btnNovi.Name = "btnNovi";
            btnNovi.Size = new Size(70, 27);
            btnNovi.TabIndex = 10;
            btnNovi.Text = "Novi";
            btnNovi.UseVisualStyleBackColor = true;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(736, 6);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(70, 27);
            btnIzmeni.TabIndex = 11;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(812, 6);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(70, 27);
            btnObrisi.TabIndex = 12;
            btnObrisi.Text = "Obriši";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnZatvori
            // 
            btnZatvori.Location = new Point(812, 39);
            btnZatvori.Name = "btnZatvori";
            btnZatvori.Size = new Size(70, 27);
            btnZatvori.TabIndex = 13;
            btnZatvori.Text = "Zatvori";
            btnZatvori.UseVisualStyleBackColor = true;
            // 
            // gbLista
            // 
            gbLista.Controls.Add(dgvServisi);
            gbLista.Dock = DockStyle.Fill;
            gbLista.Location = new Point(3, 83);
            gbLista.Name = "gbLista";
            gbLista.Size = new Size(894, 474);
            gbLista.TabIndex = 1;
            gbLista.Text = "Istorija servisa";
            // 
            // dgvServisi
            // 
            dgvServisi.AllowUserToAddRows = false;
            dgvServisi.AllowUserToDeleteRows = false;
            dgvServisi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServisi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServisi.Dock = DockStyle.Fill;
            dgvServisi.Location = new Point(3, 19);
            dgvServisi.MultiSelect = false;
            dgvServisi.Name = "dgvServisi";
            dgvServisi.ReadOnly = true;
            dgvServisi.RowHeadersVisible = false;
            dgvServisi.RowHeadersWidth = 51;
            dgvServisi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServisi.Size = new Size(888, 452);
            dgvServisi.TabIndex = 0;
            // 
            // ServisiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 560);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ServisiForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Servisi";
            tableLayoutPanel1.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            gbLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvServisi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.TextBox txtTehnicar;
        private System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.GroupBox gbLista;
        private System.Windows.Forms.DataGridView dgvServisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTehnicar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
    }
}
