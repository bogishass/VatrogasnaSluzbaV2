
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
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            btnServis = new Button();
            button1 = new Button();
            btnOtkazi = new Button();
            btnIzmeniVozilo = new Button();
            btnObrisiVozilo = new Button();
            btnDodajVozilo = new Button();
            groupBox3 = new GroupBox();
            clbSertifikati = new CheckedListBox();
            label9 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txbReg = new TextBox();
            comboTip = new ComboBox();
            comboPodtip = new ComboBox();
            txbProiz = new TextBox();
            txbGodProiz = new TextBox();
            txbKapacitet = new TextBox();
            dateTimeIstek = new DateTimePicker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 284);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Spisak vozila";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(766, 256);
            dataGridView1.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(btnServis);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(btnOtkazi);
            groupBox2.Controls.Add(btnIzmeniVozilo);
            groupBox2.Controls.Add(btnObrisiVozilo);
            groupBox2.Controls.Add(btnDodajVozilo);
            groupBox2.Location = new Point(629, 307);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(163, 248);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Upravljanje vozilima";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnServis
            // 
            btnServis.BackColor = SystemColors.ButtonHighlight;
            btnServis.Location = new Point(8, 145);
            btnServis.Margin = new Padding(3, 2, 3, 2);
            btnServis.Name = "btnServis";
            btnServis.Size = new Size(147, 22);
            btnServis.TabIndex = 0;
            btnServis.Text = "Servis";
            btnServis.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new Point(8, 182);
            button1.Name = "button1";
            button1.Size = new Size(149, 23);
            button1.TabIndex = 4;
            button1.Text = "Sačuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // btnOtkazi
            // 
            btnOtkazi.Location = new Point(8, 211);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(149, 23);
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
            groupBox3.Controls.Add(clbSertifikati);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(tableLayoutPanel1);
            groupBox3.Location = new Point(12, 307);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(603, 248);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Podaci";
            // 
            // clbSertifikati
            // 
            clbSertifikati.CheckOnClick = true;
            clbSertifikati.HorizontalScrollbar = true;
            clbSertifikati.IntegralHeight = false;
            clbSertifikati.Location = new Point(419, 22);
            clbSertifikati.Name = "clbSertifikati";
            clbSertifikati.Size = new Size(176, 218);
            clbSertifikati.TabIndex = 15;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.Location = new Point(344, 26);
            label9.Name = "label9";
            label9.Size = new Size(93, 23);
            label9.TabIndex = 7;
            label9.Text = "Sertifikati";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.26776F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.73224F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(txbReg, 1, 0);
            tableLayoutPanel1.Controls.Add(comboTip, 1, 1);
            tableLayoutPanel1.Controls.Add(comboPodtip, 1, 2);
            tableLayoutPanel1.Controls.Add(txbProiz, 1, 3);
            tableLayoutPanel1.Controls.Add(txbGodProiz, 1, 4);
            tableLayoutPanel1.Controls.Add(txbKapacitet, 1, 5);
            tableLayoutPanel1.Controls.Add(dateTimeIstek, 1, 6);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857132F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857132F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(319, 218);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 0;
            label1.Text = "Registarski broj";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 1;
            label2.Text = "Tip";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.Location = new Point(3, 66);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 2;
            label3.Text = "Podtip";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.Location = new Point(3, 97);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 3;
            label4.Text = "Proizvođač";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 132);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 4;
            label5.Text = "Godina proizvodnje";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.Location = new Point(3, 159);
            label6.Name = "label6";
            label6.Size = new Size(93, 23);
            label6.TabIndex = 5;
            label6.Text = "Kapacitet";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.Location = new Point(3, 190);
            label7.Name = "label7";
            label7.Size = new Size(139, 23);
            label7.TabIndex = 6;
            label7.Text = "Datum isteka registracije";
            // 
            // txbReg
            // 
            txbReg.Dock = DockStyle.Fill;
            txbReg.Location = new Point(153, 3);
            txbReg.Name = "txbReg";
            txbReg.Size = new Size(163, 23);
            txbReg.TabIndex = 8;
            // 
            // comboTip
            // 
            comboTip.Dock = DockStyle.Fill;
            comboTip.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTip.Items.AddRange(new object[] { "Vatrogasno", "Spasilačko", "Tehnička podrška" });
            comboTip.Location = new Point(153, 34);
            comboTip.Name = "comboTip";
            comboTip.Size = new Size(163, 23);
            comboTip.TabIndex = 9;
            // 
            // comboPodtip
            // 
            comboPodtip.Dock = DockStyle.Fill;
            comboPodtip.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPodtip.Location = new Point(153, 65);
            comboPodtip.Name = "comboPodtip";
            comboPodtip.Size = new Size(163, 23);
            comboPodtip.TabIndex = 10;
            // 
            // txbProiz
            // 
            txbProiz.Dock = DockStyle.Fill;
            txbProiz.Location = new Point(153, 96);
            txbProiz.Name = "txbProiz";
            txbProiz.Size = new Size(163, 23);
            txbProiz.TabIndex = 11;
            // 
            // txbGodProiz
            // 
            txbGodProiz.Dock = DockStyle.Fill;
            txbGodProiz.Location = new Point(153, 127);
            txbGodProiz.Name = "txbGodProiz";
            txbGodProiz.Size = new Size(163, 23);
            txbGodProiz.TabIndex = 12;
            // 
            // txbKapacitet
            // 
            txbKapacitet.Dock = DockStyle.Fill;
            txbKapacitet.Location = new Point(153, 158);
            txbKapacitet.Name = "txbKapacitet";
            txbKapacitet.Size = new Size(163, 23);
            txbKapacitet.TabIndex = 13;
            // 
            // dateTimeIstek
            // 
            dateTimeIstek.Dock = DockStyle.Fill;
            dateTimeIstek.Format = DateTimePickerFormat.Short;
            dateTimeIstek.Location = new Point(153, 189);
            dateTimeIstek.Name = "dateTimeIstek";
            dateTimeIstek.Size = new Size(163, 23);
            dateTimeIstek.TabIndex = 14;
            // 
            // VoziloForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(803, 566);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "VoziloForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vatrogasna služba - Vozila";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1, btnOtkazi, btnIzmeniVozilo, btnObrisiVozilo, btnDodajVozilo;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1, label2, label3, label4, label5, label6, label7, label9;
        private TextBox txbReg, txbProiz, txbGodProiz, txbKapacitet;
        private ComboBox comboTip, comboPodtip;     // ← NOVO POLJE
        private DateTimePicker dateTimeIstek;
        private CheckedListBox clbSertifikati;
        private DataGridView dataGridView1;
        private Button btnServis;
    }
}