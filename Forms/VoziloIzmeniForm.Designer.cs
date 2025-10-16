namespace VatrogasnaSluzba.Forms
{
    partial class VoziloIzmeniForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txbReg = new TextBox();
            comboTip = new ComboBox();
            txbProiz = new TextBox();
            txbGodProiz = new TextBox();
            txbKapacitet = new TextBox();
            dateTimeIstek = new DateTimePicker();
            listBoxInter = new ListBox();
            listBoxSertifikati = new ListBox();
            txbPodtip = new TextBox();
            btnIzmeni = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 338);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.58719F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.41281F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(label9, 0, 8);
            tableLayoutPanel1.Controls.Add(txbReg, 1, 0);
            tableLayoutPanel1.Controls.Add(comboTip, 1, 1);
            tableLayoutPanel1.Controls.Add(txbProiz, 1, 3);
            tableLayoutPanel1.Controls.Add(txbGodProiz, 1, 4);
            tableLayoutPanel1.Controls.Add(txbKapacitet, 1, 5);
            tableLayoutPanel1.Controls.Add(dateTimeIstek, 1, 6);
            tableLayoutPanel1.Controls.Add(listBoxInter, 1, 7);
            tableLayoutPanel1.Controls.Add(listBoxSertifikati, 1, 8);
            tableLayoutPanel1.Controls.Add(txbPodtip, 1, 2);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.Size = new Size(281, 302);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "RegBroj";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 42);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 1;
            label2.Text = "Tip";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 75);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Podtip";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 108);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 3;
            label4.Text = "Proizvodjac";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 141);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 4;
            label5.Text = "GodProizvodnje";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 174);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 5;
            label6.Text = "Kapacitet";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 207);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 6;
            label7.Text = "DatIstekaReg";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 240);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 7;
            label8.Text = "Intervencije";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(3, 275);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 8;
            label9.Text = "Sertifikati";
            // 
            // txbReg
            // 
            txbReg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbReg.Location = new Point(103, 3);
            txbReg.Name = "txbReg";
            txbReg.Size = new Size(175, 23);
            txbReg.TabIndex = 9;
            // 
            // comboTip
            // 
            comboTip.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboTip.FormattingEnabled = true;
            comboTip.Items.AddRange(new object[] { "Vatrogasno", "Spasilacko", "Tehnicka podrska" });
            comboTip.Location = new Point(103, 36);
            comboTip.Name = "comboTip";
            comboTip.Size = new Size(175, 23);
            comboTip.TabIndex = 10;
            comboTip.Text = "Vatrogasno";
            // 
            // txbProiz
            // 
            txbProiz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbProiz.Location = new Point(103, 102);
            txbProiz.Name = "txbProiz";
            txbProiz.Size = new Size(175, 23);
            txbProiz.TabIndex = 12;
            // 
            // txbGodProiz
            // 
            txbGodProiz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbGodProiz.Location = new Point(103, 135);
            txbGodProiz.Name = "txbGodProiz";
            txbGodProiz.Size = new Size(175, 23);
            txbGodProiz.TabIndex = 13;
            // 
            // txbKapacitet
            // 
            txbKapacitet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbKapacitet.Location = new Point(103, 168);
            txbKapacitet.Name = "txbKapacitet";
            txbKapacitet.Size = new Size(175, 23);
            txbKapacitet.TabIndex = 14;
            // 
            // dateTimeIstek
            // 
            dateTimeIstek.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimeIstek.Format = DateTimePickerFormat.Short;
            dateTimeIstek.Location = new Point(103, 201);
            dateTimeIstek.Name = "dateTimeIstek";
            dateTimeIstek.Size = new Size(175, 23);
            dateTimeIstek.TabIndex = 15;
            // 
            // listBoxInter
            // 
            listBoxInter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxInter.FormattingEnabled = true;
            listBoxInter.ItemHeight = 15;
            listBoxInter.Location = new Point(103, 234);
            listBoxInter.Name = "listBoxInter";
            listBoxInter.Size = new Size(175, 19);
            listBoxInter.TabIndex = 16;
            // 
            // listBoxSertifikati
            // 
            listBoxSertifikati.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxSertifikati.FormattingEnabled = true;
            listBoxSertifikati.ItemHeight = 15;
            listBoxSertifikati.Location = new Point(103, 267);
            listBoxSertifikati.Name = "listBoxSertifikati";
            listBoxSertifikati.Size = new Size(175, 19);
            listBoxSertifikati.TabIndex = 17;
            // 
            // txbPodtip
            // 
            txbPodtip.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbPodtip.Location = new Point(103, 69);
            txbPodtip.Name = "txbPodtip";
            txbPodtip.Size = new Size(175, 23);
            txbPodtip.TabIndex = 18;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnIzmeni.Location = new Point(93, 358);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(129, 37);
            btnIzmeni.TabIndex = 1;
            btnIzmeni.Text = "Izmeni vozilo";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += button1_Click;
            // 
            // VoziloIzmeniForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(319, 407);
            Controls.Add(btnIzmeni);
            Controls.Add(groupBox1);
            Name = "VoziloIzmeniForm";
            Text = "VoziloIzmeniForm";
            Load += VoziloIzmeniForm_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txbReg;
        private ComboBox comboTip;
        private TextBox txbProiz;
        private TextBox txbGodProiz;
        private TextBox txbKapacitet;
        private DateTimePicker dateTimeIstek;
        private ListBox listBoxInter;
        private ListBox listBoxSertifikati;
        private Button btnIzmeni;
        private TextBox txbPodtip;
    }
}