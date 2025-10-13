namespace VatrogasnaSluzba.Forms
{
    partial class SmeneForm
    {
        /// <summary>Required designer variable.</summary>
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

        // Levo
        private System.Windows.Forms.GroupBox gbLista;
        private System.Windows.Forms.DataGridView dgvSmene;
        private System.Windows.Forms.FlowLayoutPanel flpListaBtns;
        private System.Windows.Forms.Button btnNova;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;

        /// <summary>Required method for Designer support.</summary>
        private void InitializeComponent()
        {
            panelFilter = new Panel();
            lblStanicaF = new Label();
            cbStanicaFilter = new ComboBox();
            lblOd = new Label();
            dtpOd = new DateTimePicker();
            lblDo = new Label();
            dtpDo = new DateTimePicker();
            btnRefresh = new Button();
            splitMain = new SplitContainer();
            gbLista = new GroupBox();
            dgvSmene = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            flpListaBtns = new FlowLayoutPanel();
            btnNova = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            tabDetails = new TabControl();
            tabDetalji = new TabPage();
            dtpDatum = new DateTimePicker();
            lblDatum = new Label();
            tlpDetalji = new TableLayoutPanel();
            flpDetaljiBtns = new FlowLayoutPanel();
            btnSnimi = new Button();
            btnOtkazi = new Button();
            dtpStart = new DateTimePicker();
            lblStart = new Label();
            cbStanica = new ComboBox();
            lblStanica = new Label();
            dtpEnd = new DateTimePicker();
            lblEnd = new Label();
            tabEkipa = new TabPage();
            gbDispeceri = new GroupBox();
            tlpDisp = new TableLayoutPanel();
            lbDispAvail = new ListBox();
            flpDispArrows = new FlowLayoutPanel();
            btnDispAdd = new Button();
            btnDispRemove = new Button();
            lbDispIn = new ListBox();
            gbVatrogasci = new GroupBox();
            tlpVatrog = new TableLayoutPanel();
            lbVatrogasciAvail = new ListBox();
            flpVtgArrows = new FlowLayoutPanel();
            btnVtgAdd = new Button();
            btnVtgRemove = new Button();
            lbVatrogasciIn = new ListBox();
            tabInterv = new TabPage();
            dgvIntervencije = new DataGridView();
            flpIntervBtns = new FlowLayoutPanel();
            btnIntervAdd = new Button();
            btnIntervRemove = new Button();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            gbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSmene).BeginInit();
            flpListaBtns.SuspendLayout();
            tabDetails.SuspendLayout();
            tabDetalji.SuspendLayout();
            flpDetaljiBtns.SuspendLayout();
            tabEkipa.SuspendLayout();
            gbDispeceri.SuspendLayout();
            tlpDisp.SuspendLayout();
            flpDispArrows.SuspendLayout();
            gbVatrogasci.SuspendLayout();
            tlpVatrog.SuspendLayout();
            flpVtgArrows.SuspendLayout();
            tabInterv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIntervencije).BeginInit();
            flpIntervBtns.SuspendLayout();
            SuspendLayout();
            // 
            // panelFilter
            // 
            panelFilter.Controls.Add(lblStanicaF);
            panelFilter.Controls.Add(cbStanicaFilter);
            panelFilter.Controls.Add(lblOd);
            panelFilter.Controls.Add(dtpOd);
            panelFilter.Controls.Add(lblDo);
            panelFilter.Controls.Add(dtpDo);
            panelFilter.Controls.Add(btnRefresh);
            panelFilter.Dock = DockStyle.Top;
            panelFilter.Location = new Point(0, 0);
            panelFilter.Margin = new Padding(3, 2, 3, 2);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1593, 45);
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
            cbStanicaFilter.Location = new Point(66, 10);
            cbStanicaFilter.Margin = new Padding(3, 2, 3, 2);
            cbStanicaFilter.Name = "cbStanicaFilter";
            cbStanicaFilter.Size = new Size(193, 23);
            cbStanicaFilter.TabIndex = 1;
            // 
            // lblOd
            // 
            lblOd.AutoSize = true;
            lblOd.Location = new Point(267, 14);
            lblOd.Name = "lblOd";
            lblOd.Size = new Size(26, 15);
            lblOd.TabIndex = 2;
            lblOd.Text = "Od:";
            // 
            // dtpOd
            // 
            dtpOd.Format = DateTimePickerFormat.Short;
            dtpOd.Location = new Point(293, 10);
            dtpOd.Margin = new Padding(3, 2, 3, 2);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(113, 23);
            dtpOd.TabIndex = 3;
            // 
            // lblDo
            // 
            lblDo.AutoSize = true;
            lblDo.Location = new Point(411, 14);
            lblDo.Name = "lblDo";
            lblDo.Size = new Size(25, 15);
            lblDo.TabIndex = 4;
            lblDo.Text = "Do:";
            // 
            // dtpDo
            // 
            dtpDo.Format = DateTimePickerFormat.Short;
            dtpDo.Location = new Point(444, 11);
            dtpDo.Margin = new Padding(3, 2, 3, 2);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(140, 23);
            dtpDo.TabIndex = 5;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(636, 5);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 31);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Osveži";
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
            splitMain.Panel2.Controls.Add(tabDetails);
            splitMain.Size = new Size(1593, 678);
            splitMain.SplitterDistance = 1280;
            splitMain.TabIndex = 0;
            // 
            // gbLista
            // 
            gbLista.Controls.Add(dgvSmene);
            gbLista.Controls.Add(flpListaBtns);
            gbLista.Dock = DockStyle.Fill;
            gbLista.Location = new Point(0, 0);
            gbLista.Margin = new Padding(3, 2, 3, 2);
            gbLista.Name = "gbLista";
            gbLista.Padding = new Padding(3, 2, 3, 2);
            gbLista.Size = new Size(1280, 678);
            gbLista.TabIndex = 0;
            gbLista.TabStop = false;
            gbLista.Text = "Lista smena";
            // 
            // dgvSmene
            // 
            dgvSmene.AllowUserToAddRows = false;
            dgvSmene.AllowUserToDeleteRows = false;
            dgvSmene.ColumnHeadersHeight = 29;
            dgvSmene.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dgvSmene.Dock = DockStyle.Fill;
            dgvSmene.Location = new Point(3, 18);
            dgvSmene.Margin = new Padding(3, 2, 3, 2);
            dgvSmene.MultiSelect = false;
            dgvSmene.Name = "dgvSmene";
            dgvSmene.ReadOnly = true;
            dgvSmene.RowHeadersWidth = 51;
            dgvSmene.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSmene.Size = new Size(1274, 624);
            dgvSmene.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // flpListaBtns
            // 
            flpListaBtns.Controls.Add(btnNova);
            flpListaBtns.Controls.Add(btnIzmeni);
            flpListaBtns.Controls.Add(btnObrisi);
            flpListaBtns.Dock = DockStyle.Bottom;
            flpListaBtns.FlowDirection = FlowDirection.RightToLeft;
            flpListaBtns.Location = new Point(3, 642);
            flpListaBtns.Margin = new Padding(3, 2, 3, 2);
            flpListaBtns.Name = "flpListaBtns";
            flpListaBtns.Size = new Size(1274, 34);
            flpListaBtns.TabIndex = 1;
            // 
            // btnNova
            // 
            btnNova.Location = new Point(1173, 6);
            btnNova.Margin = new Padding(5, 6, 5, 6);
            btnNova.Name = "btnNova";
            btnNova.Size = new Size(96, 22);
            btnNova.TabIndex = 0;
            btnNova.Text = "Nova smena";
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(1084, 6);
            btnIzmeni.Margin = new Padding(5, 6, 5, 6);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(79, 22);
            btnIzmeni.TabIndex = 1;
            btnIzmeni.Text = "Izmeni";
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(995, 6);
            btnObrisi.Margin = new Padding(5, 6, 5, 6);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(79, 22);
            btnObrisi.TabIndex = 2;
            btnObrisi.Text = "Obriši";
            // 
            // tabDetails
            // 
            tabDetails.Controls.Add(tabDetalji);
            tabDetails.Controls.Add(tabEkipa);
            tabDetails.Controls.Add(tabInterv);
            tabDetails.Dock = DockStyle.Fill;
            tabDetails.Location = new Point(0, 0);
            tabDetails.Margin = new Padding(3, 2, 3, 2);
            tabDetails.Name = "tabDetails";
            tabDetails.SelectedIndex = 0;
            tabDetails.Size = new Size(309, 678);
            tabDetails.TabIndex = 0;
            // 
            // tabDetalji
            // 
            tabDetalji.Controls.Add(dtpDatum);
            tabDetalji.Controls.Add(lblDatum);
            tabDetalji.Controls.Add(tlpDetalji);
            tabDetalji.Controls.Add(flpDetaljiBtns);
            tabDetalji.Controls.Add(dtpStart);
            tabDetalji.Controls.Add(lblStart);
            tabDetalji.Controls.Add(cbStanica);
            tabDetalji.Controls.Add(lblStanica);
            tabDetalji.Controls.Add(dtpEnd);
            tabDetalji.Controls.Add(lblEnd);
            tabDetalji.Location = new Point(4, 24);
            tabDetalji.Margin = new Padding(3, 2, 3, 2);
            tabDetalji.Name = "tabDetalji";
            tabDetalji.Size = new Size(301, 650);
            tabDetalji.TabIndex = 0;
            tabDetalji.Text = "Detalji";
            // 
            // dtpDatum
            // 
            dtpDatum.Format = DateTimePickerFormat.Short;
            dtpDatum.Location = new Point(97, 17);
            dtpDatum.Margin = new Padding(3, 2, 3, 2);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(103, 23);
            dtpDatum.TabIndex = 1;
            // 
            // lblDatum
            // 
            lblDatum.Location = new Point(3, 17);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(88, 15);
            lblDatum.TabIndex = 0;
            lblDatum.Text = "Datum:";
            // 
            // tlpDetalji
            // 
            tlpDetalji.AutoSize = true;
            tlpDetalji.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpDetalji.ColumnCount = 2;
            tlpDetalji.ColumnStyles.Add(new ColumnStyle());
            tlpDetalji.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDetalji.Dock = DockStyle.Top;
            tlpDetalji.Location = new Point(0, 0);
            tlpDetalji.Margin = new Padding(3, 2, 3, 2);
            tlpDetalji.Name = "tlpDetalji";
            tlpDetalji.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpDetalji.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpDetalji.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpDetalji.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpDetalji.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpDetalji.Size = new Size(301, 0);
            tlpDetalji.TabIndex = 1;
            // 
            // flpDetaljiBtns
            // 
            flpDetaljiBtns.Controls.Add(btnSnimi);
            flpDetaljiBtns.Controls.Add(btnOtkazi);
            flpDetaljiBtns.FlowDirection = FlowDirection.RightToLeft;
            flpDetaljiBtns.Location = new Point(0, 178);
            flpDetaljiBtns.Margin = new Padding(3, 2, 3, 2);
            flpDetaljiBtns.Name = "flpDetaljiBtns";
            flpDetaljiBtns.Size = new Size(301, 102);
            flpDetaljiBtns.TabIndex = 0;
            // 
            // btnSnimi
            // 
            btnSnimi.Location = new Point(5, 6);
            btnSnimi.Margin = new Padding(5, 6, 5, 6);
            btnSnimi.Name = "btnSnimi";
            btnSnimi.Size = new Size(291, 27);
            btnSnimi.TabIndex = 0;
            btnSnimi.Text = "Sačuvaj";
            // 
            // btnOtkazi
            // 
            btnOtkazi.Location = new Point(5, 45);
            btnOtkazi.Margin = new Padding(5, 6, 5, 6);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(291, 25);
            btnOtkazi.TabIndex = 1;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.Click += btnOtkazi_Click_1;
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Time;
            dtpStart.Location = new Point(97, 47);
            dtpStart.Margin = new Padding(3, 2, 3, 2);
            dtpStart.Name = "dtpStart";
            dtpStart.ShowUpDown = true;
            dtpStart.Size = new Size(103, 23);
            dtpStart.TabIndex = 3;
            // 
            // lblStart
            // 
            lblStart.Location = new Point(3, 47);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(88, 15);
            lblStart.TabIndex = 2;
            lblStart.Text = "Početak:";
            // 
            // cbStanica
            // 
            cbStanica.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStanica.Location = new Point(97, 101);
            cbStanica.Margin = new Padding(3, 2, 3, 2);
            cbStanica.Name = "cbStanica";
            cbStanica.Size = new Size(103, 23);
            cbStanica.TabIndex = 7;
            // 
            // lblStanica
            // 
            lblStanica.Location = new Point(3, 109);
            lblStanica.Name = "lblStanica";
            lblStanica.Size = new Size(88, 15);
            lblStanica.TabIndex = 6;
            lblStanica.Text = "Stanica:";
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Time;
            dtpEnd.Location = new Point(97, 74);
            dtpEnd.Margin = new Padding(3, 2, 3, 2);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.ShowUpDown = true;
            dtpEnd.Size = new Size(103, 23);
            dtpEnd.TabIndex = 5;
            dtpEnd.ValueChanged += dtpEnd_ValueChanged;
            // 
            // lblEnd
            // 
            lblEnd.Location = new Point(3, 74);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(88, 15);
            lblEnd.TabIndex = 4;
            lblEnd.Text = "Kraj:";
            // 
            // tabEkipa
            // 
            tabEkipa.AutoScroll = true;
            tabEkipa.Controls.Add(gbDispeceri);
            tabEkipa.Controls.Add(gbVatrogasci);
            tabEkipa.Location = new Point(4, 24);
            tabEkipa.Margin = new Padding(3, 2, 3, 2);
            tabEkipa.Name = "tabEkipa";
            tabEkipa.Padding = new Padding(7, 6, 7, 6);
            tabEkipa.Size = new Size(301, 414);
            tabEkipa.TabIndex = 1;
            tabEkipa.Text = "Ekipa";
            // 
            // gbDispeceri
            // 
            gbDispeceri.Controls.Add(tlpDisp);
            gbDispeceri.Dock = DockStyle.Top;
            gbDispeceri.Location = new Point(7, 171);
            gbDispeceri.Margin = new Padding(3, 2, 3, 2);
            gbDispeceri.Name = "gbDispeceri";
            gbDispeceri.Padding = new Padding(3, 2, 3, 2);
            gbDispeceri.Size = new Size(287, 165);
            gbDispeceri.TabIndex = 0;
            gbDispeceri.TabStop = false;
            gbDispeceri.Text = "Dispečeri";
            // 
            // tlpDisp
            // 
            tlpDisp.ColumnCount = 3;
            tlpDisp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpDisp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tlpDisp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpDisp.Controls.Add(lbDispAvail, 0, 0);
            tlpDisp.Controls.Add(flpDispArrows, 1, 0);
            tlpDisp.Controls.Add(lbDispIn, 2, 0);
            tlpDisp.Dock = DockStyle.Fill;
            tlpDisp.Location = new Point(3, 18);
            tlpDisp.Margin = new Padding(3, 2, 3, 2);
            tlpDisp.Name = "tlpDisp";
            tlpDisp.RowStyles.Add(new RowStyle(SizeType.Absolute, 148F));
            tlpDisp.Size = new Size(281, 145);
            tlpDisp.TabIndex = 0;
            // 
            // lbDispAvail
            // 
            lbDispAvail.Dock = DockStyle.Fill;
            lbDispAvail.ItemHeight = 15;
            lbDispAvail.Location = new Point(3, 2);
            lbDispAvail.Margin = new Padding(3, 2, 3, 2);
            lbDispAvail.Name = "lbDispAvail";
            lbDispAvail.Size = new Size(108, 144);
            lbDispAvail.TabIndex = 0;
            // 
            // flpDispArrows
            // 
            flpDispArrows.Controls.Add(btnDispAdd);
            flpDispArrows.Controls.Add(btnDispRemove);
            flpDispArrows.Dock = DockStyle.Fill;
            flpDispArrows.FlowDirection = FlowDirection.TopDown;
            flpDispArrows.Location = new Point(117, 2);
            flpDispArrows.Margin = new Padding(3, 2, 3, 2);
            flpDispArrows.Name = "flpDispArrows";
            flpDispArrows.Size = new Size(46, 144);
            flpDispArrows.TabIndex = 1;
            // 
            // btnDispAdd
            // 
            btnDispAdd.Location = new Point(9, 30);
            btnDispAdd.Margin = new Padding(9, 30, 9, 4);
            btnDispAdd.Name = "btnDispAdd";
            btnDispAdd.Size = new Size(35, 21);
            btnDispAdd.TabIndex = 0;
            btnDispAdd.Text = "→";
            // 
            // btnDispRemove
            // 
            btnDispRemove.Location = new Point(9, 59);
            btnDispRemove.Margin = new Padding(9, 4, 9, 4);
            btnDispRemove.Name = "btnDispRemove";
            btnDispRemove.Size = new Size(35, 21);
            btnDispRemove.TabIndex = 1;
            btnDispRemove.Text = "←";
            // 
            // lbDispIn
            // 
            lbDispIn.Dock = DockStyle.Fill;
            lbDispIn.ItemHeight = 15;
            lbDispIn.Location = new Point(169, 2);
            lbDispIn.Margin = new Padding(3, 2, 3, 2);
            lbDispIn.Name = "lbDispIn";
            lbDispIn.Size = new Size(109, 144);
            lbDispIn.TabIndex = 2;
            // 
            // gbVatrogasci
            // 
            gbVatrogasci.Controls.Add(tlpVatrog);
            gbVatrogasci.Dock = DockStyle.Top;
            gbVatrogasci.Location = new Point(7, 6);
            gbVatrogasci.Margin = new Padding(3, 2, 3, 2);
            gbVatrogasci.Name = "gbVatrogasci";
            gbVatrogasci.Padding = new Padding(3, 2, 3, 2);
            gbVatrogasci.Size = new Size(287, 165);
            gbVatrogasci.TabIndex = 1;
            gbVatrogasci.TabStop = false;
            gbVatrogasci.Text = "Dežurni vatrogasci";
            // 
            // tlpVatrog
            // 
            tlpVatrog.ColumnCount = 3;
            tlpVatrog.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpVatrog.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tlpVatrog.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpVatrog.Controls.Add(lbVatrogasciAvail, 0, 0);
            tlpVatrog.Controls.Add(flpVtgArrows, 1, 0);
            tlpVatrog.Controls.Add(lbVatrogasciIn, 2, 0);
            tlpVatrog.Dock = DockStyle.Fill;
            tlpVatrog.Location = new Point(3, 18);
            tlpVatrog.Margin = new Padding(3, 2, 3, 2);
            tlpVatrog.Name = "tlpVatrog";
            tlpVatrog.RowStyles.Add(new RowStyle(SizeType.Absolute, 148F));
            tlpVatrog.Size = new Size(281, 145);
            tlpVatrog.TabIndex = 0;
            // 
            // lbVatrogasciAvail
            // 
            lbVatrogasciAvail.Dock = DockStyle.Fill;
            lbVatrogasciAvail.ItemHeight = 15;
            lbVatrogasciAvail.Location = new Point(3, 2);
            lbVatrogasciAvail.Margin = new Padding(3, 2, 3, 2);
            lbVatrogasciAvail.Name = "lbVatrogasciAvail";
            lbVatrogasciAvail.Size = new Size(108, 144);
            lbVatrogasciAvail.TabIndex = 0;
            // 
            // flpVtgArrows
            // 
            flpVtgArrows.Controls.Add(btnVtgAdd);
            flpVtgArrows.Controls.Add(btnVtgRemove);
            flpVtgArrows.Dock = DockStyle.Fill;
            flpVtgArrows.FlowDirection = FlowDirection.TopDown;
            flpVtgArrows.Location = new Point(117, 2);
            flpVtgArrows.Margin = new Padding(3, 2, 3, 2);
            flpVtgArrows.Name = "flpVtgArrows";
            flpVtgArrows.Size = new Size(46, 144);
            flpVtgArrows.TabIndex = 1;
            // 
            // btnVtgAdd
            // 
            btnVtgAdd.Location = new Point(9, 30);
            btnVtgAdd.Margin = new Padding(9, 30, 9, 4);
            btnVtgAdd.Name = "btnVtgAdd";
            btnVtgAdd.Size = new Size(35, 21);
            btnVtgAdd.TabIndex = 0;
            btnVtgAdd.Text = "→";
            // 
            // btnVtgRemove
            // 
            btnVtgRemove.Location = new Point(9, 59);
            btnVtgRemove.Margin = new Padding(9, 4, 9, 4);
            btnVtgRemove.Name = "btnVtgRemove";
            btnVtgRemove.Size = new Size(35, 21);
            btnVtgRemove.TabIndex = 1;
            btnVtgRemove.Text = "←";
            // 
            // lbVatrogasciIn
            // 
            lbVatrogasciIn.Dock = DockStyle.Fill;
            lbVatrogasciIn.ItemHeight = 15;
            lbVatrogasciIn.Location = new Point(169, 2);
            lbVatrogasciIn.Margin = new Padding(3, 2, 3, 2);
            lbVatrogasciIn.Name = "lbVatrogasciIn";
            lbVatrogasciIn.Size = new Size(109, 144);
            lbVatrogasciIn.TabIndex = 2;
            // 
            // tabInterv
            // 
            tabInterv.Controls.Add(dgvIntervencije);
            tabInterv.Controls.Add(flpIntervBtns);
            tabInterv.Location = new Point(4, 24);
            tabInterv.Margin = new Padding(3, 2, 3, 2);
            tabInterv.Name = "tabInterv";
            tabInterv.Size = new Size(301, 414);
            tabInterv.TabIndex = 2;
            tabInterv.Text = "Intervencije";
            // 
            // dgvIntervencije
            // 
            dgvIntervencije.AllowUserToAddRows = false;
            dgvIntervencije.AllowUserToDeleteRows = false;
            dgvIntervencije.ColumnHeadersHeight = 29;
            dgvIntervencije.Dock = DockStyle.Fill;
            dgvIntervencije.Location = new Point(0, 0);
            dgvIntervencije.Margin = new Padding(3, 2, 3, 2);
            dgvIntervencije.MultiSelect = false;
            dgvIntervencije.Name = "dgvIntervencije";
            dgvIntervencije.ReadOnly = true;
            dgvIntervencije.RowHeadersWidth = 51;
            dgvIntervencije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIntervencije.Size = new Size(301, 380);
            dgvIntervencije.TabIndex = 0;
            // 
            // flpIntervBtns
            // 
            flpIntervBtns.Controls.Add(btnIntervAdd);
            flpIntervBtns.Controls.Add(btnIntervRemove);
            flpIntervBtns.Dock = DockStyle.Bottom;
            flpIntervBtns.FlowDirection = FlowDirection.RightToLeft;
            flpIntervBtns.Location = new Point(0, 380);
            flpIntervBtns.Margin = new Padding(3, 2, 3, 2);
            flpIntervBtns.Name = "flpIntervBtns";
            flpIntervBtns.Size = new Size(301, 34);
            flpIntervBtns.TabIndex = 1;
            // 
            // btnIntervAdd
            // 
            btnIntervAdd.Location = new Point(182, 6);
            btnIntervAdd.Margin = new Padding(5, 6, 5, 6);
            btnIntervAdd.Name = "btnIntervAdd";
            btnIntervAdd.Size = new Size(114, 17);
            btnIntervAdd.TabIndex = 0;
            btnIntervAdd.Text = "Dodaj postojeću";
            // 
            // btnIntervRemove
            // 
            btnIntervRemove.Location = new Point(93, 6);
            btnIntervRemove.Margin = new Padding(5, 6, 5, 6);
            btnIntervRemove.Name = "btnIntervRemove";
            btnIntervRemove.Size = new Size(79, 17);
            btnIntervRemove.TabIndex = 1;
            btnIntervRemove.Text = "Ukloni";
            // 
            // SmeneForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1593, 723);
            Controls.Add(splitMain);
            Controls.Add(panelFilter);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SmeneForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Smene ";
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            gbLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSmene).EndInit();
            flpListaBtns.ResumeLayout(false);
            tabDetails.ResumeLayout(false);
            tabDetalji.ResumeLayout(false);
            tabDetalji.PerformLayout();
            flpDetaljiBtns.ResumeLayout(false);
            tabEkipa.ResumeLayout(false);
            gbDispeceri.ResumeLayout(false);
            tlpDisp.ResumeLayout(false);
            flpDispArrows.ResumeLayout(false);
            gbVatrogasci.ResumeLayout(false);
            tlpVatrog.ResumeLayout(false);
            flpVtgArrows.ResumeLayout(false);
            tabInterv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIntervencije).EndInit();
            flpIntervBtns.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private TabControl tabDetails;
        private TabPage tabDetalji;
        private DateTimePicker dtpDatum;
        private Label lblDatum;
        private TableLayoutPanel tlpDetalji;
        private FlowLayoutPanel flpDetaljiBtns;
        private Button btnSnimi;
        private Button btnOtkazi;
        private DateTimePicker dtpStart;
        private Label lblStart;
        private ComboBox cbStanica;
        private Label lblStanica;
        private DateTimePicker dtpEnd;
        private Label lblEnd;
        private TabPage tabEkipa;
        private GroupBox gbDispeceri;
        private TableLayoutPanel tlpDisp;
        private ListBox lbDispAvail;
        private FlowLayoutPanel flpDispArrows;
        private Button btnDispAdd;
        private Button btnDispRemove;
        private ListBox lbDispIn;
        private GroupBox gbVatrogasci;
        private TableLayoutPanel tlpVatrog;
        private ListBox lbVatrogasciAvail;
        private FlowLayoutPanel flpVtgArrows;
        private Button btnVtgAdd;
        private Button btnVtgRemove;
        private ListBox lbVatrogasciIn;
        private TabPage tabInterv;
        private DataGridView dgvIntervencije;
        private FlowLayoutPanel flpIntervBtns;
        private Button btnIntervAdd;
        private Button btnIntervRemove;
    }
}
