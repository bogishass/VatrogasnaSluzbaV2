
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
            textBoxLokacijaOpreme = new TextBox();
            dateTimePickerDatumNabavke = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            txbNaziv = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txbAdresa = new TextBox();
            label8 = new Label();
            txbInvBroj = new TextBox();
            comboTip = new ComboBox();
            comboBoxPodTip = new ComboBox();
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
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Oprema";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { INVBroj, Naziv, Tip, PodTip, LokacijaOpreme, Status, DatumNabavke });
            dataGridView1.Location = new Point(12, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(744, 392);
            dataGridView1.TabIndex = 1;
            // 
            // INVBroj
            // 
            INVBroj.HeaderText = "Inventarski broj";
            INVBroj.Name = "INVBroj";
            // 
            // Naziv
            // 
            Naziv.HeaderText = "Naziv";
            Naziv.Name = "Naziv";
            // 
            // Tip
            // 
            Tip.HeaderText = "Tip";
            Tip.Name = "Tip";
            // 
            // PodTip
            // 
            PodTip.HeaderText = "PodTip";
            PodTip.Name = "PodTip";
            // 
            // LokacijaOpreme
            // 
            LokacijaOpreme.HeaderText = "LokacijaOpreme";
            LokacijaOpreme.Name = "LokacijaOpreme";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // DatumNabavke
            // 
            DatumNabavke.HeaderText = "DatumNabavke";
            DatumNabavke.Name = "DatumNabavke";
            // 
            // btnDodajOpremu
            // 
            btnDodajOpremu.Location = new Point(762, 46);
            btnDodajOpremu.Name = "btnDodajOpremu";
            btnDodajOpremu.Size = new Size(110, 40);
            btnDodajOpremu.TabIndex = 2;
            btnDodajOpremu.Text = "Dodaj";
            btnDodajOpremu.UseVisualStyleBackColor = true;
            // 
            // btnUkloniOpremu
            // 
            btnUkloniOpremu.Location = new Point(762, 92);
            btnUkloniOpremu.Name = "btnUkloniOpremu";
            btnUkloniOpremu.Size = new Size(110, 40);
            btnUkloniOpremu.TabIndex = 3;
            btnUkloniOpremu.Text = "Ukloni";
            btnUkloniOpremu.UseVisualStyleBackColor = true;
            // 
            // btnEditujOpremu
            // 
            btnEditujOpremu.Location = new Point(762, 138);
            btnEditujOpremu.Name = "btnEditujOpremu";
            btnEditujOpremu.Size = new Size(110, 40);
            btnEditujOpremu.TabIndex = 4;
            btnEditujOpremu.Text = "Izmeni…";
            btnEditujOpremu.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(762, 184);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(110, 40);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Visible = false;
            // 
            // btnOtkazi
            // 
            btnOtkazi.Location = new Point(762, 230);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(110, 40);
            btnOtkazi.TabIndex = 6;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            btnOtkazi.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(12, 464);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(744, 300);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(textBoxLokacijaOpreme, 1, 4);
            tableLayoutPanel1.Controls.Add(dateTimePickerDatumNabavke, 3, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(txbNaziv, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 5);
            tableLayoutPanel1.Controls.Add(txbAdresa, 1, 5);
            tableLayoutPanel1.Controls.Add(label8, 2, 0);
            tableLayoutPanel1.Controls.Add(txbInvBroj, 1, 0);
            tableLayoutPanel1.Controls.Add(comboTip, 1, 2);
            tableLayoutPanel1.Controls.Add(comboBoxPodTip, 1, 3);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.7F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.7F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.7F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tableLayoutPanel1.Size = new Size(738, 270);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // textBoxLokacijaOpreme
            // 
            textBoxLokacijaOpreme.Location = new Point(187, 181);
            textBoxLokacijaOpreme.Name = "textBoxLokacijaOpreme";
            textBoxLokacijaOpreme.Size = new Size(178, 23);
            textBoxLokacijaOpreme.TabIndex = 28;
            // 
            // dateTimePickerDatumNabavke
            // 
            dateTimePickerDatumNabavke.Format = DateTimePickerFormat.Short;
            dateTimePickerDatumNabavke.Location = new Point(555, 3);
            dateTimePickerDatumNabavke.Name = "dateTimePickerDatumNabavke";
            dateTimePickerDatumNabavke.Size = new Size(180, 23);
            dateTimePickerDatumNabavke.TabIndex = 27;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 15);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 8;
            label2.Text = "Inventarski broj";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 60);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 9;
            label3.Text = "Naziv";
            // 
            // txbNaziv
            // 
            txbNaziv.Location = new Point(187, 48);
            txbNaziv.Name = "txbNaziv";
            txbNaziv.Size = new Size(178, 23);
            txbNaziv.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 105);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 10;
            label4.Text = "Tip";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 149);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 12;
            label5.Text = "PodTip";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 192);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 11;
            label6.Text = "LokacijaOpreme";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 238);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 13;
            label7.Text = "Status";
            label7.Click += label7_Click;
            // 
            // txbAdresa
            // 
            txbAdresa.Location = new Point(187, 224);
            txbAdresa.Name = "txbAdresa";
            txbAdresa.Size = new Size(178, 23);
            txbAdresa.TabIndex = 3;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(371, 15);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 14;
            label8.Text = "DatumNabavke";
            label8.Click += label8_Click;
            // 
            // txbInvBroj
            // 
            txbInvBroj.Location = new Point(187, 3);
            txbInvBroj.MaxLength = 13;
            txbInvBroj.Name = "txbInvBroj";
            txbInvBroj.Size = new Size(178, 23);
            txbInvBroj.TabIndex = 0;
            // 
            // comboTip
            // 
            comboTip.FormattingEnabled = true;
            comboTip.Location = new Point(187, 93);
            comboTip.Name = "comboTip";
            comboTip.Size = new Size(178, 23);
            comboTip.TabIndex = 23;
            // 
            // comboBoxPodTip
            // 
            comboBoxPodTip.FormattingEnabled = true;
            comboBoxPodTip.Location = new Point(187, 138);
            comboBoxPodTip.Name = "comboBoxPodTip";
            comboBoxPodTip.Size = new Size(178, 23);
            comboBoxPodTip.TabIndex = 25;
            // 
            // OpremaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(874, 780);
            Controls.Add(groupBox1);
            Controls.Add(btnOtkazi);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnEditujOpremu);
            Controls.Add(btnUkloniOpremu);
            Controls.Add(btnDodajOpremu);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OpremaForm";
            Text = "Oprema";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn INVBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn PodTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn LokacijaOpreme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumNabavke;
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
        private System.Windows.Forms.TextBox txbAdresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbInvBroj;
        private System.Windows.Forms.ComboBox comboTip;
        private System.Windows.Forms.ComboBox comboBoxPodTip;
        private System.Windows.Forms.TextBox textBoxLokacijaOpreme;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumNabavke;
    }
}
