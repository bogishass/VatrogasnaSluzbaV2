// File: Forms/OpremaForm.Designer.cs  (DESIGNER – BEZ kolone "Intervencija")
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
            label1 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            INVBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PodTip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LokacijaOpreme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DatumNabavke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnDodajOpremu = new System.Windows.Forms.Button();
            btnUkloniOpremu = new System.Windows.Forms.Button();
            btnEditujOpremu = new System.Windows.Forms.Button();
            btnSacuvaj = new System.Windows.Forms.Button();
            btnOtkazi = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            textBoxLokacijaOpreme = new System.Windows.Forms.TextBox();
            dateTimePickerDatumNabavke = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txbNaziv = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txbAdresa = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txbInvBroj = new System.Windows.Forms.TextBox();
            comboTip = new System.Windows.Forms.ComboBox();
            comboBoxPodTip = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Oprema";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            INVBroj,
            Naziv,
            Tip,
            PodTip,
            LokacijaOpreme,
            Status,
            DatumNabavke});
            dataGridView1.Location = new System.Drawing.Point(12, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(920, 392);
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
            btnDodajOpremu.Location = new System.Drawing.Point(960, 46);
            btnDodajOpremu.Name = "btnDodajOpremu";
            btnDodajOpremu.Size = new System.Drawing.Size(110, 40);
            btnDodajOpremu.TabIndex = 2;
            btnDodajOpremu.Text = "Dodaj";
            btnDodajOpremu.UseVisualStyleBackColor = true;
            // 
            // btnUkloniOpremu
            // 
            btnUkloniOpremu.Location = new System.Drawing.Point(960, 97);
            btnUkloniOpremu.Name = "btnUkloniOpremu";
            btnUkloniOpremu.Size = new System.Drawing.Size(110, 40);
            btnUkloniOpremu.TabIndex = 3;
            btnUkloniOpremu.Text = "Ukloni";
            btnUkloniOpremu.UseVisualStyleBackColor = true;
            // 
            // btnEditujOpremu
            // 
            btnEditujOpremu.Location = new System.Drawing.Point(960, 148);
            btnEditujOpremu.Name = "btnEditujOpremu";
            btnEditujOpremu.Size = new System.Drawing.Size(110, 40);
            btnEditujOpremu.TabIndex = 4;
            btnEditujOpremu.Text = "Izmeni…";
            btnEditujOpremu.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new System.Drawing.Point(960, 199);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new System.Drawing.Size(110, 40);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Visible = false;
            // 
            // btnOtkazi
            // 
            btnOtkazi.Location = new System.Drawing.Point(960, 245);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new System.Drawing.Size(110, 40);
            btnOtkazi.TabIndex = 6;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            btnOtkazi.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new System.Drawing.Point(12, 464);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1058, 300);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
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
            tableLayoutPanel1.Location = new System.Drawing.Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.7F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.7F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.7F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1046, 270);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // textBoxLokacijaOpreme
            // 
            textBoxLokacijaOpreme.Location = new System.Drawing.Point(265, 183);
            textBoxLokacijaOpreme.Name = "textBoxLokacijaOpreme";
            textBoxLokacijaOpreme.Size = new System.Drawing.Size(200, 23);
            textBoxLokacijaOpreme.TabIndex = 28;
            // 
            // dateTimePickerDatumNabavke
            // 
            dateTimePickerDatumNabavke.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePickerDatumNabavke.Location = new System.Drawing.Point(786, 3);
            dateTimePickerDatumNabavke.Name = "dateTimePickerDatumNabavke";
            dateTimePickerDatumNabavke.Size = new System.Drawing.Size(200, 23);
            dateTimePickerDatumNabavke.TabIndex = 27;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 11);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 15);
            label2.TabIndex = 8;
            label2.Text = "Inventarski broj";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 56);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(36, 15);
            label3.TabIndex = 9;
            label3.Text = "Naziv";
            // 
            // txbNaziv
            // 
            txbNaziv.Location = new System.Drawing.Point(265, 48);
            txbNaziv.Name = "txbNaziv";
            txbNaziv.Size = new System.Drawing.Size(200, 23);
            txbNaziv.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(3, 100);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(24, 15);
            label4.TabIndex = 10;
            label4.Text = "Tip";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 144);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(48, 15);
            label5.TabIndex = 12;
            label5.Text = "PodTip";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(3, 188);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(96, 15);
            label6.TabIndex = 11;
            label6.Text = "LokacijaOpreme";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(3, 233);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(39, 15);
            label7.TabIndex = 13;
            label7.Text = "Status";
            label7.Click += label7_Click;
            // 
            // txbAdresa
            // 
            txbAdresa.Location = new System.Drawing.Point(265, 223);
            txbAdresa.Name = "txbAdresa";
            txbAdresa.Size = new System.Drawing.Size(200, 23);
            txbAdresa.TabIndex = 3;
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(525, 11);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(98, 15);
            label8.TabIndex = 14;
            label8.Text = "DatumNabavke";
            label8.Click += label8_Click;
            // 
            // txbInvBroj
            // 
            txbInvBroj.Location = new System.Drawing.Point(265, 3);
            txbInvBroj.MaxLength = 13;
            txbInvBroj.Name = "txbInvBroj";
            txbInvBroj.Size = new System.Drawing.Size(200, 23);
            txbInvBroj.TabIndex = 0;
            // 
            // comboTip
            // 
            comboTip.FormattingEnabled = true;
            comboTip.Location = new System.Drawing.Point(265, 93);
            comboTip.Name = "comboTip";
            comboTip.Size = new System.Drawing.Size(200, 23);
            comboTip.TabIndex = 23;
            // 
            // comboBoxPodTip
            // 
            comboBoxPodTip.FormattingEnabled = true;
            comboBoxPodTip.Location = new System.Drawing.Point(265, 138);
            comboBoxPodTip.Name = "comboBoxPodTip";
            comboBoxPodTip.Size = new System.Drawing.Size(200, 23);
            comboBoxPodTip.TabIndex = 25;
            // 
            // OpremaForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1082, 780);
            Controls.Add(groupBox1);
            Controls.Add(btnOtkazi);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnEditujOpremu);
            Controls.Add(btnUkloniOpremu);
            Controls.Add(btnDodajOpremu);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "OpremaForm";
            Text = "Oprema";
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
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
