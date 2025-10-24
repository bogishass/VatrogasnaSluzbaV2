namespace VatrogasnaSluzba.Forms
{
    partial class SmeneForm
    {
        
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // ──────────────────────────  FIELDS  ──────────────────────────
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblStanicaF;
        private System.Windows.Forms.ComboBox cbStanicaFilter;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.SplitContainer splitMain;

        private System.Windows.Forms.GroupBox gbLista;
        private System.Windows.Forms.DataGridView dgvSmene;
        private System.Windows.Forms.FlowLayoutPanel flpListaBtns;
        private System.Windows.Forms.Button btnNova;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;

        private System.Windows.Forms.TabControl tabDetails;
        private System.Windows.Forms.TabPage tabDetalji;
        private System.Windows.Forms.TabPage tabInterv;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblStanica;
        private System.Windows.Forms.ComboBox cbStanica;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnSnimi;

        private System.Windows.Forms.DataGridView dgvIntervencije;
        private System.Windows.Forms.FlowLayoutPanel flpIntervBtns;

        /// <summary>Required method for Designer support.</summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmeneForm));
            panelFilter = new Panel();
            lblStanicaF = new Label();
            cbStanicaFilter = new ComboBox();
            lblOd = new Label();
            dtpOd = new DateTimePicker();
            lblDo = new Label();
            dtpDo = new DateTimePicker();
            btnOtkazi = new Button();
            btnSnimi = new Button();
            lblEnd = new Label();
            cbStanica = new ComboBox();
            dtpDatum = new DateTimePicker();
            dtpStart = new DateTimePicker();
            lblStanica = new Label();
            dtpEnd = new DateTimePicker();
            lblStart = new Label();
            lblDatum = new Label();
            gbLista = new GroupBox();
            dgvSmene = new DataGridView();
            flpListaBtns = new FlowLayoutPanel();
            btnObrisi = new Button();
            btnIzmeni = new Button();
            btnNova = new Button();
            splitMain = new SplitContainer();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelFilter.SuspendLayout();
            gbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSmene).BeginInit();
            flpListaBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelFilter
            // 
            panelFilter.BackColor = SystemColors.ActiveCaption;
            panelFilter.Controls.Add(lblStanicaF);
            panelFilter.Controls.Add(cbStanicaFilter);
            panelFilter.Controls.Add(lblOd);
            panelFilter.Controls.Add(dtpOd);
            panelFilter.Controls.Add(lblDo);
            panelFilter.Controls.Add(dtpDo);
            panelFilter.Dock = DockStyle.Top;
            panelFilter.Location = new Point(0, 0);
            panelFilter.Margin = new Padding(3, 2, 3, 2);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(714, 45);
            panelFilter.TabIndex = 1;
            // 
            // lblStanicaF
            // 
            lblStanicaF.AutoSize = true;
            lblStanicaF.Location = new Point(10, 14);
            lblStanicaF.Name = "lblStanicaF";
            lblStanicaF.Size = new Size(48, 15);
            lblStanicaF.TabIndex = 0;
            lblStanicaF.Text = "Stanica:";
            // 
            // cbStanicaFilter
            // 
            cbStanicaFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStanicaFilter.Location = new Point(58, 10);
            cbStanicaFilter.Margin = new Padding(3, 2, 3, 2);
            cbStanicaFilter.Name = "cbStanicaFilter";
            cbStanicaFilter.Size = new Size(118, 23);
            cbStanicaFilter.TabIndex = 1;
            // 
            // lblOd
            // 
            lblOd.AutoSize = true;
            lblOd.Location = new Point(182, 14);
            lblOd.Name = "lblOd";
            lblOd.Size = new Size(26, 15);
            lblOd.TabIndex = 2;
            lblOd.Text = "Od:";
            // 
            // dtpOd
            // 
            dtpOd.Format = DateTimePickerFormat.Short;
            dtpOd.Location = new Point(210, 10);
            dtpOd.Margin = new Padding(3, 2, 3, 2);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(118, 23);
            dtpOd.TabIndex = 3;
            // 
            // lblDo
            // 
            lblDo.AutoSize = true;
            lblDo.Location = new Point(336, 14);
            lblDo.Name = "lblDo";
            lblDo.Size = new Size(25, 15);
            lblDo.TabIndex = 4;
            lblDo.Text = "Do:";
            // 
            // dtpDo
            // 
            dtpDo.Format = DateTimePickerFormat.Short;
            dtpDo.Location = new Point(362, 10);
            dtpDo.Margin = new Padding(3, 2, 3, 2);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(113, 23);
            dtpDo.TabIndex = 5;
            // 
            // btnOtkazi
            // 
            btnOtkazi.BackColor = SystemColors.ButtonFace;
            btnOtkazi.Location = new Point(140, 182);
            btnOtkazi.Margin = new Padding(5, 6, 5, 6);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(123, 27);
            btnOtkazi.TabIndex = 1;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = false;
            // 
            // btnSnimi
            // 
            btnSnimi.BackColor = SystemColors.ButtonFace;
            btnSnimi.Location = new Point(6, 182);
            btnSnimi.Margin = new Padding(5, 6, 5, 6);
            btnSnimi.Name = "btnSnimi";
            btnSnimi.Size = new Size(123, 27);
            btnSnimi.TabIndex = 0;
            btnSnimi.Text = "Sačuvaj";
            btnSnimi.UseVisualStyleBackColor = false;
            // 
            // lblEnd
            // 
            lblEnd.Anchor = AnchorStyles.Left;
            lblEnd.Location = new Point(3, 80);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(66, 15);
            lblEnd.TabIndex = 4;
            lblEnd.Text = "Kraj:";
            lblEnd.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbStanica
            // 
            cbStanica.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStanica.Location = new Point(117, 107);
            cbStanica.Margin = new Padding(3, 2, 3, 2);
            cbStanica.Name = "cbStanica";
            cbStanica.Size = new Size(124, 23);
            cbStanica.TabIndex = 7;
            // 
            // dtpDatum
            // 
            dtpDatum.Format = DateTimePickerFormat.Short;
            dtpDatum.Location = new Point(117, 2);
            dtpDatum.Margin = new Padding(3, 2, 3, 2);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(124, 23);
            dtpDatum.TabIndex = 1;
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Time;
            dtpStart.Location = new Point(117, 37);
            dtpStart.Margin = new Padding(3, 2, 3, 2);
            dtpStart.Name = "dtpStart";
            dtpStart.ShowUpDown = true;
            dtpStart.Size = new Size(124, 23);
            dtpStart.TabIndex = 3;
            // 
            // lblStanica
            // 
            lblStanica.Anchor = AnchorStyles.Left;
            lblStanica.Location = new Point(3, 115);
            lblStanica.Name = "lblStanica";
            lblStanica.Size = new Size(66, 15);
            lblStanica.TabIndex = 6;
            lblStanica.Text = "Stanica:";
            lblStanica.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Time;
            dtpEnd.Location = new Point(117, 72);
            dtpEnd.Margin = new Padding(3, 2, 3, 2);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.ShowUpDown = true;
            dtpEnd.Size = new Size(124, 23);
            dtpEnd.TabIndex = 5;
            // 
            // lblStart
            // 
            lblStart.Anchor = AnchorStyles.Left;
            lblStart.BackColor = Color.Transparent;
            lblStart.Location = new Point(3, 45);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(66, 15);
            lblStart.TabIndex = 2;
            lblStart.Text = "Početak:";
            lblStart.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDatum
            // 
            lblDatum.Anchor = AnchorStyles.Left;
            lblDatum.BackColor = Color.Transparent;
            lblDatum.Location = new Point(3, 10);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(66, 15);
            lblDatum.TabIndex = 0;
            lblDatum.Text = "Datum:";
            lblDatum.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gbLista
            // 
            gbLista.BackColor = SystemColors.GradientActiveCaption;
            gbLista.Controls.Add(dgvSmene);
            gbLista.Controls.Add(flpListaBtns);
            gbLista.Location = new Point(10, 8);
            gbLista.Margin = new Padding(3, 2, 3, 2);
            gbLista.Name = "gbLista";
            gbLista.Padding = new Padding(3, 2, 3, 2);
            gbLista.Size = new Size(402, 415);
            gbLista.TabIndex = 0;
            gbLista.TabStop = false;
            gbLista.Text = "Evidencija smena";
            // 
            // dgvSmene
            // 
            dgvSmene.AllowUserToAddRows = false;
            dgvSmene.AllowUserToDeleteRows = false;
            dgvSmene.AllowUserToOrderColumns = true;
            dgvSmene.AllowUserToResizeRows = false;
            dgvSmene.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSmene.BackgroundColor = SystemColors.ButtonFace;
            dgvSmene.ColumnHeadersHeight = 29;
            dgvSmene.Location = new Point(6, 20);
            dgvSmene.Margin = new Padding(3, 2, 3, 2);
            dgvSmene.MultiSelect = false;
            dgvSmene.Name = "dgvSmene";
            dgvSmene.ReadOnly = true;
            dgvSmene.RowHeadersVisible = false;
            dgvSmene.RowHeadersWidth = 51;
            dgvSmene.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSmene.Size = new Size(388, 350);
            dgvSmene.TabIndex = 0;
            // 
            // flpListaBtns
            // 
            flpListaBtns.Controls.Add(btnObrisi);
            flpListaBtns.Controls.Add(btnIzmeni);
            flpListaBtns.Controls.Add(btnNova);
            flpListaBtns.Dock = DockStyle.Bottom;
            flpListaBtns.FlowDirection = FlowDirection.RightToLeft;
            flpListaBtns.Location = new Point(3, 379);
            flpListaBtns.Margin = new Padding(3, 2, 3, 2);
            flpListaBtns.Name = "flpListaBtns";
            flpListaBtns.Size = new Size(396, 34);
            flpListaBtns.TabIndex = 1;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = SystemColors.ButtonFace;
            btnObrisi.Location = new Point(290, 6);
            btnObrisi.Margin = new Padding(5, 6, 5, 6);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(101, 22);
            btnObrisi.TabIndex = 2;
            btnObrisi.Text = "Izbriši";
            btnObrisi.UseVisualStyleBackColor = false;
            // 
            // btnIzmeni
            // 
            btnIzmeni.BackColor = SystemColors.ButtonFace;
            btnIzmeni.Location = new Point(179, 6);
            btnIzmeni.Margin = new Padding(5, 6, 5, 6);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(101, 22);
            btnIzmeni.TabIndex = 1;
            btnIzmeni.Text = "Izmeni smenu";
            btnIzmeni.UseVisualStyleBackColor = false;
            // 
            // btnNova
            // 
            btnNova.BackColor = SystemColors.ButtonFace;
            btnNova.Location = new Point(68, 6);
            btnNova.Margin = new Padding(5, 6, 5, 6);
            btnNova.Name = "btnNova";
            btnNova.Size = new Size(101, 22);
            btnNova.TabIndex = 0;
            btnNova.Text = "Nova smena";
            btnNova.UseVisualStyleBackColor = false;
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 45);
            splitMain.Margin = new Padding(3, 2, 3, 2);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(gbLista);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(groupBox1);
            splitMain.Panel2.Controls.Add(btnOtkazi);
            splitMain.Panel2.Controls.Add(btnSnimi);
            splitMain.Size = new Size(714, 432);
            splitMain.SplitterDistance = 440;
            splitMain.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(6, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 165);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.93877F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.0612259F));
            tableLayoutPanel1.Controls.Add(lblStanica, 0, 3);
            tableLayoutPanel1.Controls.Add(cbStanica, 1, 3);
            tableLayoutPanel1.Controls.Add(lblStart, 0, 1);
            tableLayoutPanel1.Controls.Add(dtpDatum, 1, 0);
            tableLayoutPanel1.Controls.Add(dtpStart, 1, 1);
            tableLayoutPanel1.Controls.Add(dtpEnd, 1, 2);
            tableLayoutPanel1.Controls.Add(lblDatum, 0, 0);
            tableLayoutPanel1.Controls.Add(lblEnd, 0, 2);
            tableLayoutPanel1.Location = new Point(6, 17);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0000038F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0000038F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(245, 141);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // SmeneForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(714, 477);
            Controls.Add(splitMain);
            Controls.Add(panelFilter);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "SmeneForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vatrogasna služba - Smene";
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            gbLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSmene).EndInit();
            flpListaBtns.ResumeLayout(false);
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
