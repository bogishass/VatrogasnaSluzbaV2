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
            label1 = new Label();
            lblNaslov = new Label();
            lblOd = new Label();
            dtpDatum = new DateTimePicker();
            lblTip = new Label();
            cbTip = new ComboBox();
            txtTehnicar = new TextBox();
            gbLista = new GroupBox();
            dgvServisi = new DataGridView();
            btnNovi = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            btnSacuvaj = new Button();
            btnOtkazi = new Button();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(535, 420);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.BackColor = SystemColors.GradientActiveCaption;
            panelTop.Controls.Add(label1);
            panelTop.Controls.Add(lblNaslov);
            panelTop.Controls.Add(lblOd);
            panelTop.Controls.Add(dtpDatum);
            panelTop.Controls.Add(lblTip);
            panelTop.Controls.Add(cbTip);
            panelTop.Controls.Add(txtTehnicar);
            panelTop.Location = new Point(3, 2);
            panelTop.Margin = new Padding(3, 2, 3, 2);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(529, 64);
            panelTop.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 37);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 14;
            label1.Text = "Tehničar:";
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblNaslov.Location = new Point(9, 6);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(173, 19);
            lblNaslov.TabIndex = 0;
            lblNaslov.Text = "Servisi za vozilo: (regbroj)";
            // 
            // lblOd
            // 
            lblOd.AutoSize = true;
            lblOd.Location = new Point(9, 34);
            lblOd.Name = "lblOd";
            lblOd.Size = new Size(46, 15);
            lblOd.TabIndex = 1;
            lblOd.Text = "Datum:";
            // 
            // dtpDatum
            // 
            dtpDatum.CustomFormat = "dd.MM.yyyy";
            dtpDatum.Format = DateTimePickerFormat.Custom;
            dtpDatum.Location = new Point(61, 31);
            dtpDatum.Margin = new Padding(3, 2, 3, 2);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(106, 23);
            dtpDatum.TabIndex = 2;
            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.Location = new Point(173, 37);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(27, 15);
            lblTip.TabIndex = 5;
            lblTip.Text = "Tip:";
            // 
            // cbTip
            // 
            cbTip.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTip.Location = new Point(206, 31);
            cbTip.Margin = new Padding(3, 2, 3, 2);
            cbTip.Name = "cbTip";
            cbTip.Size = new Size(123, 23);
            cbTip.TabIndex = 6;
            // 
            // txtTehnicar
            // 
            txtTehnicar.Location = new Point(396, 31);
            txtTehnicar.Margin = new Padding(3, 2, 3, 2);
            txtTehnicar.Name = "txtTehnicar";
            txtTehnicar.PlaceholderText = "Tehničar";
            txtTehnicar.Size = new Size(123, 23);
            txtTehnicar.TabIndex = 7;
            // 
            // gbLista
            // 
            gbLista.BackColor = SystemColors.Highlight;
            gbLista.Controls.Add(dgvServisi);
            gbLista.Controls.Add(btnNovi);
            gbLista.Controls.Add(btnIzmeni);
            gbLista.Controls.Add(btnObrisi);
            gbLista.Controls.Add(btnSacuvaj);
            gbLista.Controls.Add(btnOtkazi);
            gbLista.Dock = DockStyle.Fill;
            gbLista.Location = new Point(3, 83);
            gbLista.Margin = new Padding(3, 2, 3, 2);
            gbLista.Name = "gbLista";
            gbLista.Padding = new Padding(3, 2, 3, 2);
            gbLista.Size = new Size(529, 335);
            gbLista.TabIndex = 1;
            gbLista.TabStop = false;
            gbLista.Text = "Istorija servisa";
            // 
            // dgvServisi
            // 
            dgvServisi.AllowUserToAddRows = false;
            dgvServisi.AllowUserToDeleteRows = false;
            dgvServisi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvServisi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServisi.Location = new Point(3, 18);
            dgvServisi.Margin = new Padding(3, 2, 3, 2);
            dgvServisi.MultiSelect = false;
            dgvServisi.Name = "dgvServisi";
            dgvServisi.ReadOnly = true;
            dgvServisi.RowHeadersVisible = false;
            dgvServisi.RowHeadersWidth = 51;
            dgvServisi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServisi.Size = new Size(373, 313);
            dgvServisi.TabIndex = 0;
            // 
            // btnNovi
            // 
            btnNovi.Location = new Point(396, 18);
            btnNovi.Margin = new Padding(3, 2, 3, 2);
            btnNovi.Name = "btnNovi";
            btnNovi.Size = new Size(116, 40);
            btnNovi.TabIndex = 10;
            btnNovi.Text = "Dodaj";
            btnNovi.UseVisualStyleBackColor = true;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(396, 62);
            btnIzmeni.Margin = new Padding(3, 2, 3, 2);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(116, 40);
            btnIzmeni.TabIndex = 11;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(396, 106);
            btnObrisi.Margin = new Padding(3, 2, 3, 2);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(116, 40);
            btnObrisi.TabIndex = 12;
            btnObrisi.Text = "Obriši";
            btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(396, 249);
            btnSacuvaj.Margin = new Padding(3, 2, 3, 2);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(116, 40);
            btnSacuvaj.TabIndex = 9;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // btnOtkazi
            // 
            btnOtkazi.Location = new Point(396, 291);
            btnOtkazi.Margin = new Padding(3, 2, 3, 2);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(116, 40);
            btnOtkazi.TabIndex = 13;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // ServisiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(535, 420);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.TextBox txtTehnicar;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.GroupBox gbLista;
        private System.Windows.Forms.DataGridView dgvServisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTehnicar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private Label label1;
    }
}
