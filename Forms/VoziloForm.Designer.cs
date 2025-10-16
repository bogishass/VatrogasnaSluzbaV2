
using System.Drawing;
using System.Windows.Forms;

namespace VatrogasnaSluzba.Forms
{
    partial class VoziloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoziloForm));
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            groupBox2 = new GroupBox();
            button1 = new Button();
            btnOtkazi = new Button();
            btnIzmeniVozilo = new Button();
            btnObrisiVozilo = new Button();
            btnDodajVozilo = new Button();
            groupBox3 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            txbReg = new TextBox();
            comboTip = new ComboBox();
            comboPodtip = new ComboBox();
            txbProiz = new TextBox();
            txbGodProiz = new TextBox();
            txbKapacitet = new TextBox();
            dateTimeIstek = new DateTimePicker();
            clbSertifikati = new CheckedListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(643, 276);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista vozila";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader10 });
            listView1.Location = new Point(-16, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(631, 254);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "RegBroj";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tip";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Podtip";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Proizvođač";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "GodProizvodnje";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Status";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Kapacitet";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "DatIstekaReg";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Sertifikati";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(btnOtkazi);
            groupBox2.Controls.Add(btnIzmeniVozilo);
            groupBox2.Controls.Add(btnObrisiVozilo);
            groupBox2.Controls.Add(btnDodajVozilo);
            groupBox2.Location = new Point(661, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(164, 281);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Upravljanje vozilima";
            // 
            // button1
            // 
            button1.Location = new Point(6, 198);
            button1.Name = "button1";
            button1.Size = new Size(158, 28);
            button1.TabIndex = 4;
            button1.Text = "Sačuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // btnOtkazi
            // 
            btnOtkazi.Location = new Point(6, 232);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(158, 28);
            btnOtkazi.TabIndex = 3;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            btnOtkazi.Visible = false;
            // 
            // btnIzmeniVozilo
            // 
            btnIzmeniVozilo.Location = new Point(6, 104);
            btnIzmeniVozilo.Name = "btnIzmeniVozilo";
            btnIzmeniVozilo.Size = new Size(149, 35);
            btnIzmeniVozilo.TabIndex = 2;
            btnIzmeniVozilo.Text = "Izmeni vozilo";
            btnIzmeniVozilo.UseVisualStyleBackColor = true;
            // 
            // btnObrisiVozilo
            // 
            btnObrisiVozilo.Location = new Point(6, 63);
            btnObrisiVozilo.Name = "btnObrisiVozilo";
            btnObrisiVozilo.Size = new Size(149, 35);
            btnObrisiVozilo.TabIndex = 1;
            btnObrisiVozilo.Text = "Obriši vozilo";
            btnObrisiVozilo.UseVisualStyleBackColor = true;
            // 
            // btnDodajVozilo
            // 
            btnDodajVozilo.Location = new Point(6, 22);
            btnDodajVozilo.Name = "btnDodajVozilo";
            btnDodajVozilo.Size = new Size(149, 35);
            btnDodajVozilo.TabIndex = 0;
            btnDodajVozilo.Text = "Dodaj vozilo";
            btnDodajVozilo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.GradientActiveCaption;
            groupBox3.Controls.Add(tableLayoutPanel1);
            groupBox3.Location = new Point(12, 314);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(305, 332);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Podaci";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.5F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(label9, 0, 8);
            tableLayoutPanel1.Controls.Add(txbReg, 1, 0);
            tableLayoutPanel1.Controls.Add(comboTip, 1, 1);
            tableLayoutPanel1.Controls.Add(comboPodtip, 1, 2);
            tableLayoutPanel1.Controls.Add(txbProiz, 1, 3);
            tableLayoutPanel1.Controls.Add(txbGodProiz, 1, 4);
            tableLayoutPanel1.Controls.Add(txbKapacitet, 1, 5);
            tableLayoutPanel1.Controls.Add(dateTimeIstek, 1, 6);
            tableLayoutPanel1.Controls.Add(clbSertifikati, 1, 8);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel1.Size = new Size(281, 302);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 0;
            label1.Text = "RegBroj";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 1;
            label2.Text = "Tip";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.Location = new Point(3, 81);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 2;
            label3.Text = "Podtip";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.Location = new Point(3, 118);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 3;
            label4.Text = "Proizvođač";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.Location = new Point(3, 155);
            label5.Name = "label5";
            label5.Size = new Size(93, 23);
            label5.TabIndex = 4;
            label5.Text = "GodProizvodnje";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.Location = new Point(3, 192);
            label6.Name = "label6";
            label6.Size = new Size(93, 23);
            label6.TabIndex = 5;
            label6.Text = "Kapacitet";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.Location = new Point(3, 229);
            label7.Name = "label7";
            label7.Size = new Size(93, 23);
            label7.TabIndex = 6;
            label7.Text = "DatIstekaReg";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.Location = new Point(3, 269);
            label9.Name = "label9";
            label9.Size = new Size(93, 23);
            label9.TabIndex = 7;
            label9.Text = "Sertifikati";
            // 
            // txbReg
            // 
            txbReg.Dock = DockStyle.Fill;
            txbReg.Location = new Point(102, 3);
            txbReg.Name = "txbReg";
            txbReg.Size = new Size(176, 23);
            txbReg.TabIndex = 8;
            // 
            // comboTip
            // 
            comboTip.Dock = DockStyle.Fill;
            comboTip.Items.AddRange(new object[] { "Vatrogasno", "Spasilačko", "Tehnička podrška" });
            comboTip.Location = new Point(102, 40);
            comboTip.Name = "comboTip";
            comboTip.Size = new Size(176, 23);
            comboTip.TabIndex = 9;
            comboTip.Text = "Vatrogasno";
            // 
            // comboPodtip
            // 
            comboPodtip.Dock = DockStyle.Fill;
            comboPodtip.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPodtip.Location = new Point(102, 77);
            comboPodtip.Name = "comboPodtip";
            comboPodtip.Size = new Size(176, 23);
            comboPodtip.TabIndex = 10;
            // 
            // txbProiz
            // 
            txbProiz.Dock = DockStyle.Fill;
            txbProiz.Location = new Point(102, 114);
            txbProiz.Name = "txbProiz";
            txbProiz.Size = new Size(176, 23);
            txbProiz.TabIndex = 11;
            // 
            // txbGodProiz
            // 
            txbGodProiz.Dock = DockStyle.Fill;
            txbGodProiz.Location = new Point(102, 151);
            txbGodProiz.Name = "txbGodProiz";
            txbGodProiz.Size = new Size(176, 23);
            txbGodProiz.TabIndex = 12;
            // 
            // txbKapacitet
            // 
            txbKapacitet.Dock = DockStyle.Fill;
            txbKapacitet.Location = new Point(102, 188);
            txbKapacitet.Name = "txbKapacitet";
            txbKapacitet.Size = new Size(176, 23);
            txbKapacitet.TabIndex = 13;
            // 
            // dateTimeIstek
            // 
            dateTimeIstek.Dock = DockStyle.Fill;
            dateTimeIstek.Format = DateTimePickerFormat.Short;
            dateTimeIstek.Location = new Point(102, 225);
            dateTimeIstek.Name = "dateTimeIstek";
            dateTimeIstek.Size = new Size(176, 23);
            dateTimeIstek.TabIndex = 14;
            // 
            // clbSertifikati
            // 
            clbSertifikati.CheckOnClick = true;
            clbSertifikati.Dock = DockStyle.Fill;
            clbSertifikati.IntegralHeight = false;
            clbSertifikati.Location = new Point(102, 262);
            clbSertifikati.Name = "clbSertifikati";
            clbSertifikati.Size = new Size(176, 37);
            clbSertifikati.TabIndex = 15;
            // 
            // VoziloForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(841, 658);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VoziloForm";
            Text = "Vozilo";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1, columnHeader2, columnHeader3, columnHeader4,
                              columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader10;
        private GroupBox groupBox2;
        private Button button1, btnOtkazi, btnIzmeniVozilo, btnObrisiVozilo, btnDodajVozilo;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1, label2, label3, label4, label5, label6, label7, label9;
        private TextBox txbReg, txbProiz, txbGodProiz, txbKapacitet;
        private ComboBox comboTip, comboPodtip;     // ← NOVO POLJE
        private DateTimePicker dateTimeIstek;
        private CheckedListBox clbSertifikati;
    }
}
