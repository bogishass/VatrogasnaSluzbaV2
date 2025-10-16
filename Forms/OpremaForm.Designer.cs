
namespace VatrogasnaSluzba.Forms
{
    partial class OpremaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpremaForm));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            INVBroj = new DataGridViewTextBoxColumn();
            Naziv = new DataGridViewTextBoxColumn();
            Tip = new DataGridViewTextBoxColumn();
            PodTip = new DataGridViewTextBoxColumn();
            LokacijaOpreme = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            DatumNabavke = new DataGridViewTextBoxColumn();
            btnDodajOpremu = new Button();
            btnUkloniOpremu = new Button();
            btnEditujOpremu = new Button();
            btnSacuvaj = new Button();
            btnOtkazi = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txbLokacija = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txbNaziv = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txbInvBroj = new TextBox();
            comboTip = new ComboBox();
            comboPodTip = new ComboBox();
            label8 = new Label();
            dateTimePickerDatumNabavke = new DateTimePicker();
            comboStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Spisak opreme službe";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { INVBroj, Naziv, Tip, PodTip, LokacijaOpreme, Status, DatumNabavke });
            dataGridView1.Location = new Point(12, 33);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(744, 332);
            dataGridView1.TabIndex = 1;
            // 
            // INVBroj
            // 
            INVBroj.HeaderText = "Inventarski broj";
            INVBroj.Name = "INVBroj";
            INVBroj.ReadOnly = true;
            // 
            // Naziv
            // 
            Naziv.HeaderText = "Naziv";
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Tip
            // 
            Tip.HeaderText = "Tip";
            Tip.Name = "Tip";
            Tip.ReadOnly = true;
            // 
            // PodTip
            // 
            PodTip.HeaderText = "PodTip";
            PodTip.Name = "PodTip";
            PodTip.ReadOnly = true;
            // 
            // LokacijaOpreme
            // 
            LokacijaOpreme.HeaderText = "Lokacija opreme";
            LokacijaOpreme.Name = "LokacijaOpreme";
            LokacijaOpreme.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // DatumNabavke
            // 
            DatumNabavke.HeaderText = "Datum nabavke";
            DatumNabavke.Name = "DatumNabavke";
            DatumNabavke.ReadOnly = true;
            // 
            // btnDodajOpremu
            // 
            btnDodajOpremu.Location = new Point(475, 371);
            btnDodajOpremu.Name = "btnDodajOpremu";
            btnDodajOpremu.Size = new Size(90, 26);
            btnDodajOpremu.TabIndex = 2;
            btnDodajOpremu.Text = "Dodaj";
            btnDodajOpremu.UseVisualStyleBackColor = true;
            // 
            // btnUkloniOpremu
            // 
            btnUkloniOpremu.Location = new Point(667, 371);
            btnUkloniOpremu.Name = "btnUkloniOpremu";
            btnUkloniOpremu.Size = new Size(90, 26);
            btnUkloniOpremu.TabIndex = 3;
            btnUkloniOpremu.Text = "Ukloni";
            btnUkloniOpremu.UseVisualStyleBackColor = true;
            // 
            // btnEditujOpremu
            // 
            btnEditujOpremu.Location = new Point(571, 371);
            btnEditujOpremu.Name = "btnEditujOpremu";
            btnEditujOpremu.Size = new Size(90, 26);
            btnEditujOpremu.TabIndex = 4;
            btnEditujOpremu.Text = "Izmeni…";
            btnEditujOpremu.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(552, 601);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(99, 24);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Visible = false;
            // 
            // btnOtkazi
            // 
            btnOtkazi.Location = new Point(657, 601);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(99, 24);
            btnOtkazi.TabIndex = 6;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            btnOtkazi.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(12, 378);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 235);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(txbLokacija, 1, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(txbNaziv, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 5);
            tableLayoutPanel1.Controls.Add(txbInvBroj, 1, 0);
            tableLayoutPanel1.Controls.Add(comboTip, 1, 2);
            tableLayoutPanel1.Controls.Add(comboPodTip, 1, 3);
            tableLayoutPanel1.Controls.Add(label8, 0, 6);
            tableLayoutPanel1.Controls.Add(dateTimePickerDatumNabavke, 1, 6);
            tableLayoutPanel1.Controls.Add(comboStatus, 1, 5);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(370, 205);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // txbLokacija
            // 
            txbLokacija.Location = new Point(188, 119);
            txbLokacija.Name = "txbLokacija";
            txbLokacija.Size = new Size(178, 23);
            txbLokacija.TabIndex = 28;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 8;
            label2.Text = "Inventarski broj";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 36);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 9;
            label3.Text = "Naziv";
            // 
            // txbNaziv
            // 
            txbNaziv.Location = new Point(188, 32);
            txbNaziv.Name = "txbNaziv";
            txbNaziv.Size = new Size(178, 23);
            txbNaziv.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 65);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 10;
            label4.Text = "Tip";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 94);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 12;
            label5.Text = "Podtip";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 123);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 11;
            label6.Text = "Lokacija opreme";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 152);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 13;
            label7.Text = "Status";
            // 
            // txbInvBroj
            // 
            txbInvBroj.Location = new Point(188, 3);
            txbInvBroj.MaxLength = 13;
            txbInvBroj.Name = "txbInvBroj";
            txbInvBroj.Size = new Size(178, 23);
            txbInvBroj.TabIndex = 0;
            // 
            // comboTip
            // 
            comboTip.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTip.FormattingEnabled = true;
            comboTip.Location = new Point(188, 61);
            comboTip.Name = "comboTip";
            comboTip.Size = new Size(178, 23);
            comboTip.TabIndex = 23;
            // 
            // comboPodTip
            // 
            comboPodTip.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPodTip.FormattingEnabled = true;
            comboPodTip.Location = new Point(188, 90);
            comboPodTip.Name = "comboPodTip";
            comboPodTip.Size = new Size(178, 23);
            comboPodTip.TabIndex = 25;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 182);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 14;
            label8.Text = "Datum nabavke";
            // 
            // dateTimePickerDatumNabavke
            // 
            dateTimePickerDatumNabavke.Format = DateTimePickerFormat.Short;
            dateTimePickerDatumNabavke.Location = new Point(188, 177);
            dateTimePickerDatumNabavke.Name = "dateTimePickerDatumNabavke";
            dateTimePickerDatumNabavke.Size = new Size(179, 23);
            dateTimePickerDatumNabavke.TabIndex = 27;
            // 
            // comboStatus
            // 
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatus.FormattingEnabled = true;
            comboStatus.Location = new Point(188, 148);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(178, 23);
            comboStatus.TabIndex = 29;
            // 
            // OpremaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(766, 631);
            Controls.Add(groupBox1);
            Controls.Add(btnOtkazi);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnEditujOpremu);
            Controls.Add(btnUkloniOpremu);
            Controls.Add(btnDodajOpremu);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OpremaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vatrogasna služba - Oprema";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDodajOpremu;
        private System.Windows.Forms.Button btnUkloniOpremu;
        private System.Windows.Forms.Button btnEditujOpremu;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbInvBroj;
        private System.Windows.Forms.ComboBox comboTip;
        private System.Windows.Forms.ComboBox comboPodTip;
        private System.Windows.Forms.TextBox txbLokacija;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumNabavke;
        private DataGridViewTextBoxColumn INVBroj;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Tip;
        private DataGridViewTextBoxColumn PodTip;
        private DataGridViewTextBoxColumn LokacijaOpreme;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn DatumNabavke;
        private ComboBox comboStatus;
    }
}
