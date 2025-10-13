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
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.SplitContainer splitMain;

        // Levo
        private System.Windows.Forms.GroupBox gbLista;
        private System.Windows.Forms.DataGridView dgvSmene;
        private System.Windows.Forms.FlowLayoutPanel flpListaBtns;
        private System.Windows.Forms.Button btnNova;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;

        // Desno
        private System.Windows.Forms.TabControl tabDetails;
        private System.Windows.Forms.TabPage tabDetalji;
        private System.Windows.Forms.TabPage tabEkipa;
        private System.Windows.Forms.TabPage tabInterv;

        // Detalji
        private System.Windows.Forms.TableLayoutPanel tlpDetalji;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblStanica;
        private System.Windows.Forms.ComboBox cbStanica;
        private System.Windows.Forms.FlowLayoutPanel flpDetaljiBtns;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnSnimi;

        // Ekipa
        private System.Windows.Forms.GroupBox gbVatrogasci;
        private System.Windows.Forms.TableLayoutPanel tlpVatrog;
        private System.Windows.Forms.ListBox lbVatrogasciAvail;
        private System.Windows.Forms.FlowLayoutPanel flpVtgArrows;
        private System.Windows.Forms.Button btnVtgAdd;
        private System.Windows.Forms.Button btnVtgRemove;
        private System.Windows.Forms.ListBox lbVatrogasciIn;

        private System.Windows.Forms.GroupBox gbDispeceri;
        private System.Windows.Forms.TableLayoutPanel tlpDisp;
        private System.Windows.Forms.ListBox lbDispAvail;
        private System.Windows.Forms.FlowLayoutPanel flpDispArrows;
        private System.Windows.Forms.Button btnDispAdd;
        private System.Windows.Forms.Button btnDispRemove;
        private System.Windows.Forms.ListBox lbDispIn;

        // Intervencije
        private System.Windows.Forms.DataGridView dgvIntervencije;
        private System.Windows.Forms.FlowLayoutPanel flpIntervBtns;
        private System.Windows.Forms.Button btnIntervAdd;
        private System.Windows.Forms.Button btnIntervRemove;

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
            txtSearch = new TextBox();
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
            flpDetaljiBtns = new FlowLayoutPanel();
            btnSnimi = new Button();
            btnOtkazi = new Button();
            tlpDetalji = new TableLayoutPanel();
            lblDatum = new Label();
            dtpDatum = new DateTimePicker();
            lblStart = new Label();
            dtpStart = new DateTimePicker();
            lblEnd = new Label();
            dtpEnd = new DateTimePicker();
            lblStanica = new Label();
            cbStanica = new ComboBox();
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
            tlpDetalji.SuspendLayout();
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
            panelFilter.Controls.Add(txtSearch);
            panelFilter.Controls.Add(btnRefresh);
            panelFilter.Dock = DockStyle.Top;
            panelFilter.Location = new Point(0, 0);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1257, 60);
            panelFilter.TabIndex = 1;
            // 
            // lblStanicaF
            // 
            lblStanicaF.AutoSize = true;
            lblStanicaF.Location = new Point(12, 18);
            lblStanicaF.Name = "lblStanicaF";
            lblStanicaF.Size = new Size(60, 20);
            lblStanicaF.TabIndex = 0;
            lblStanicaF.Text = "Stanica:";
            // 
            // cbStanicaFilter
            // 
            cbStanicaFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStanicaFilter.Location = new Point(75, 14);
            cbStanicaFilter.Name = "cbStanicaFilter";
            cbStanicaFilter.Size = new Size(220, 28);
            cbStanicaFilter.TabIndex = 1;
            // 
            // lblOd
            // 
            lblOd.AutoSize = true;
            lblOd.Location = new Point(305, 18);
            lblOd.Name = "lblOd";
            lblOd.Size = new Size(32, 20);
            lblOd.TabIndex = 2;
            lblOd.Text = "Od:";
            // 
            // dtpOd
            // 
            dtpOd.Format = DateTimePickerFormat.Short;
            dtpOd.Location = new Point(335, 14);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(129, 27);
            dtpOd.TabIndex = 3;
            // 
            // lblDo
            // 
            lblDo.AutoSize = true;
            lblDo.Location = new Point(470, 18);
            lblDo.Name = "lblDo";
            lblDo.Size = new Size(32, 20);
            lblDo.TabIndex = 4;
            lblDo.Text = "Do:";
            // 
            // dtpDo
            // 
            dtpDo.Format = DateTimePickerFormat.Short;
            dtpDo.Location = new Point(508, 15);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(159, 27);
            dtpDo.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(702, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(129, 27);
            txtSearch.TabIndex = 6;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(859, 15);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(80, 26);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Osveži";
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 60);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(gbLista);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(tabDetails);
            splitMain.Size = new Size(1257, 517);
            splitMain.SplitterDistance = 1012;
            splitMain.TabIndex = 0;
            // 
            // gbLista
            // 
            gbLista.Controls.Add(dgvSmene);
            gbLista.Controls.Add(flpListaBtns);
            gbLista.Dock = DockStyle.Fill;
            gbLista.Location = new Point(0, 0);
            gbLista.Name = "gbLista";
            gbLista.Size = new Size(1012, 517);
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
            dgvSmene.Location = new Point(3, 23);
            dgvSmene.MultiSelect = false;
            dgvSmene.Name = "dgvSmene";
            dgvSmene.ReadOnly = true;
            dgvSmene.RowHeadersWidth = 51;
            dgvSmene.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSmene.Size = new Size(1006, 446);
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
            flpListaBtns.Location = new Point(3, 469);
            flpListaBtns.Name = "flpListaBtns";
            flpListaBtns.Size = new Size(1006, 45);
            flpListaBtns.TabIndex = 1;
            // 
            // btnNova
            // 
            btnNova.Location = new Point(890, 8);
            btnNova.Margin = new Padding(6, 8, 6, 8);
            btnNova.Name = "btnNova";
            btnNova.Size = new Size(110, 29);
            btnNova.TabIndex = 0;
            btnNova.Text = "Nova smena";
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(788, 8);
            btnIzmeni.Margin = new Padding(6, 8, 6, 8);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(90, 29);
            btnIzmeni.TabIndex = 1;
            btnIzmeni.Text = "Izmeni";
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(686, 8);
            btnObrisi.Margin = new Padding(6, 8, 6, 8);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(90, 29);
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
            tabDetails.Name = "tabDetails";
            tabDetails.SelectedIndex = 0;
            tabDetails.Size = new Size(241, 517);
            tabDetails.TabIndex = 0;
            // 
            // tabDetalji
            // 
            tabDetalji.Controls.Add(flpDetaljiBtns);
            tabDetalji.Controls.Add(tlpDetalji);
            tabDetalji.Location = new Point(4, 29);
            tabDetalji.Name = "tabDetalji";
            tabDetalji.Size = new Size(233, 484);
            tabDetalji.TabIndex = 0;
            tabDetalji.Text = "Detalji";
            // 
            // flpDetaljiBtns
            // 
            flpDetaljiBtns.Controls.Add(btnSnimi);
            flpDetaljiBtns.Controls.Add(btnOtkazi);
            flpDetaljiBtns.Dock = DockStyle.Top;
            flpDetaljiBtns.FlowDirection = FlowDirection.RightToLeft;
            flpDetaljiBtns.Location = new Point(0, 80);
            flpDetaljiBtns.Name = "flpDetaljiBtns";
            flpDetaljiBtns.Size = new Size(233, 192);
            flpDetaljiBtns.TabIndex = 0;
            // 
            // btnSnimi
            // 
            btnSnimi.Location = new Point(137, 8);
            btnSnimi.Margin = new Padding(6, 8, 6, 8);
            btnSnimi.Name = "btnSnimi";
            btnSnimi.Size = new Size(90, 36);
            btnSnimi.TabIndex = 0;
            btnSnimi.Text = "Sačuvaj";
            // 
            // btnOtkazi
            // 
            btnOtkazi.Location = new Point(35, 8);
            btnOtkazi.Margin = new Padding(6, 8, 6, 8);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(90, 33);
            btnOtkazi.TabIndex = 1;
            btnOtkazi.Text = "Otkaži";
            // 
            // tlpDetalji
            // 
            tlpDetalji.AutoSize = true;
            tlpDetalji.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpDetalji.ColumnCount = 2;
            tlpDetalji.ColumnStyles.Add(new ColumnStyle());
            tlpDetalji.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDetalji.Controls.Add(lblDatum, 0, 0);
            tlpDetalji.Controls.Add(dtpDatum, 1, 0);
            tlpDetalji.Controls.Add(lblStart, 0, 1);
            tlpDetalji.Controls.Add(dtpStart, 1, 1);
            tlpDetalji.Controls.Add(lblEnd, 0, 2);
            tlpDetalji.Controls.Add(dtpEnd, 1, 2);
            tlpDetalji.Controls.Add(lblStanica, 0, 3);
            tlpDetalji.Controls.Add(cbStanica, 1, 3);
            tlpDetalji.Dock = DockStyle.Top;
            tlpDetalji.Location = new Point(0, 0);
            tlpDetalji.Name = "tlpDetalji";
            tlpDetalji.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDetalji.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDetalji.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDetalji.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDetalji.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDetalji.Size = new Size(233, 80);
            tlpDetalji.TabIndex = 1;
            // 
            // lblDatum
            // 
            lblDatum.Location = new Point(3, 0);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(100, 20);
            lblDatum.TabIndex = 0;
            lblDatum.Text = "Datum:";
            // 
            // dtpDatum
            // 
            dtpDatum.Format = DateTimePickerFormat.Short;
            dtpDatum.Location = new Point(109, 3);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(120, 27);
            dtpDatum.TabIndex = 1;
            // 
            // lblStart
            // 
            lblStart.Location = new Point(3, 20);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(100, 20);
            lblStart.TabIndex = 2;
            lblStart.Text = "Početak:";
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Time;
            dtpStart.Location = new Point(109, 23);
            dtpStart.Name = "dtpStart";
            dtpStart.ShowUpDown = true;
            dtpStart.Size = new Size(120, 27);
            dtpStart.TabIndex = 3;
            // 
            // lblEnd
            // 
            lblEnd.Location = new Point(3, 40);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(100, 20);
            lblEnd.TabIndex = 4;
            lblEnd.Text = "Kraj:";
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Time;
            dtpEnd.Location = new Point(109, 43);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.ShowUpDown = true;
            dtpEnd.Size = new Size(120, 27);
            dtpEnd.TabIndex = 5;
            // 
            // lblStanica
            // 
            lblStanica.Location = new Point(3, 60);
            lblStanica.Name = "lblStanica";
            lblStanica.Size = new Size(100, 20);
            lblStanica.TabIndex = 6;
            lblStanica.Text = "Stanica:";
            // 
            // cbStanica
            // 
            cbStanica.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStanica.Location = new Point(109, 63);
            cbStanica.Name = "cbStanica";
            cbStanica.Size = new Size(120, 28);
            cbStanica.TabIndex = 7;
            // 
            // tabEkipa
            // 
            tabEkipa.AutoScroll = true;
            tabEkipa.Controls.Add(gbDispeceri);
            tabEkipa.Controls.Add(gbVatrogasci);
            tabEkipa.Location = new Point(4, 29);
            tabEkipa.Name = "tabEkipa";
            tabEkipa.Padding = new Padding(8);
            tabEkipa.Size = new Size(233, 484);
            tabEkipa.TabIndex = 1;
            tabEkipa.Text = "Ekipa";
            // 
            // gbDispeceri
            // 
            gbDispeceri.Controls.Add(tlpDisp);
            gbDispeceri.Dock = DockStyle.Top;
            gbDispeceri.Location = new Point(8, 228);
            gbDispeceri.Name = "gbDispeceri";
            gbDispeceri.Size = new Size(217, 220);
            gbDispeceri.TabIndex = 0;
            gbDispeceri.TabStop = false;
            gbDispeceri.Text = "Dispečeri";
            // 
            // tlpDisp
            // 
            tlpDisp.ColumnCount = 3;
            tlpDisp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpDisp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tlpDisp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpDisp.Controls.Add(lbDispAvail, 0, 0);
            tlpDisp.Controls.Add(flpDispArrows, 1, 0);
            tlpDisp.Controls.Add(lbDispIn, 2, 0);
            tlpDisp.Dock = DockStyle.Fill;
            tlpDisp.Location = new Point(3, 23);
            tlpDisp.Name = "tlpDisp";
            tlpDisp.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDisp.Size = new Size(211, 194);
            tlpDisp.TabIndex = 0;
            // 
            // lbDispAvail
            // 
            lbDispAvail.Dock = DockStyle.Fill;
            lbDispAvail.Location = new Point(3, 3);
            lbDispAvail.Name = "lbDispAvail";
            lbDispAvail.Size = new Size(69, 188);
            lbDispAvail.TabIndex = 0;
            // 
            // flpDispArrows
            // 
            flpDispArrows.Controls.Add(btnDispAdd);
            flpDispArrows.Controls.Add(btnDispRemove);
            flpDispArrows.Dock = DockStyle.Fill;
            flpDispArrows.FlowDirection = FlowDirection.TopDown;
            flpDispArrows.Location = new Point(78, 3);
            flpDispArrows.Name = "flpDispArrows";
            flpDispArrows.Size = new Size(54, 188);
            flpDispArrows.TabIndex = 1;
            // 
            // btnDispAdd
            // 
            btnDispAdd.Location = new Point(10, 40);
            btnDispAdd.Margin = new Padding(10, 40, 10, 6);
            btnDispAdd.Name = "btnDispAdd";
            btnDispAdd.Size = new Size(40, 28);
            btnDispAdd.TabIndex = 0;
            btnDispAdd.Text = "→";
            // 
            // btnDispRemove
            // 
            btnDispRemove.Location = new Point(10, 80);
            btnDispRemove.Margin = new Padding(10, 6, 10, 6);
            btnDispRemove.Name = "btnDispRemove";
            btnDispRemove.Size = new Size(40, 28);
            btnDispRemove.TabIndex = 1;
            btnDispRemove.Text = "←";
            // 
            // lbDispIn
            // 
            lbDispIn.Dock = DockStyle.Fill;
            lbDispIn.Location = new Point(138, 3);
            lbDispIn.Name = "lbDispIn";
            lbDispIn.Size = new Size(70, 188);
            lbDispIn.TabIndex = 2;
            // 
            // gbVatrogasci
            // 
            gbVatrogasci.Controls.Add(tlpVatrog);
            gbVatrogasci.Dock = DockStyle.Top;
            gbVatrogasci.Location = new Point(8, 8);
            gbVatrogasci.Name = "gbVatrogasci";
            gbVatrogasci.Size = new Size(217, 220);
            gbVatrogasci.TabIndex = 1;
            gbVatrogasci.TabStop = false;
            gbVatrogasci.Text = "Dežurni vatrogasci";
            // 
            // tlpVatrog
            // 
            tlpVatrog.ColumnCount = 3;
            tlpVatrog.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpVatrog.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tlpVatrog.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpVatrog.Controls.Add(lbVatrogasciAvail, 0, 0);
            tlpVatrog.Controls.Add(flpVtgArrows, 1, 0);
            tlpVatrog.Controls.Add(lbVatrogasciIn, 2, 0);
            tlpVatrog.Dock = DockStyle.Fill;
            tlpVatrog.Location = new Point(3, 23);
            tlpVatrog.Name = "tlpVatrog";
            tlpVatrog.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpVatrog.Size = new Size(211, 194);
            tlpVatrog.TabIndex = 0;
            // 
            // lbVatrogasciAvail
            // 
            lbVatrogasciAvail.Dock = DockStyle.Fill;
            lbVatrogasciAvail.Location = new Point(3, 3);
            lbVatrogasciAvail.Name = "lbVatrogasciAvail";
            lbVatrogasciAvail.Size = new Size(69, 188);
            lbVatrogasciAvail.TabIndex = 0;
            // 
            // flpVtgArrows
            // 
            flpVtgArrows.Controls.Add(btnVtgAdd);
            flpVtgArrows.Controls.Add(btnVtgRemove);
            flpVtgArrows.Dock = DockStyle.Fill;
            flpVtgArrows.FlowDirection = FlowDirection.TopDown;
            flpVtgArrows.Location = new Point(78, 3);
            flpVtgArrows.Name = "flpVtgArrows";
            flpVtgArrows.Size = new Size(54, 188);
            flpVtgArrows.TabIndex = 1;
            // 
            // btnVtgAdd
            // 
            btnVtgAdd.Location = new Point(10, 40);
            btnVtgAdd.Margin = new Padding(10, 40, 10, 6);
            btnVtgAdd.Name = "btnVtgAdd";
            btnVtgAdd.Size = new Size(40, 28);
            btnVtgAdd.TabIndex = 0;
            btnVtgAdd.Text = "→";
            // 
            // btnVtgRemove
            // 
            btnVtgRemove.Location = new Point(10, 80);
            btnVtgRemove.Margin = new Padding(10, 6, 10, 6);
            btnVtgRemove.Name = "btnVtgRemove";
            btnVtgRemove.Size = new Size(40, 28);
            btnVtgRemove.TabIndex = 1;
            btnVtgRemove.Text = "←";
            // 
            // lbVatrogasciIn
            // 
            lbVatrogasciIn.Dock = DockStyle.Fill;
            lbVatrogasciIn.Location = new Point(138, 3);
            lbVatrogasciIn.Name = "lbVatrogasciIn";
            lbVatrogasciIn.Size = new Size(70, 188);
            lbVatrogasciIn.TabIndex = 2;
            // 
            // tabInterv
            // 
            tabInterv.Controls.Add(dgvIntervencije);
            tabInterv.Controls.Add(flpIntervBtns);
            tabInterv.Location = new Point(4, 29);
            tabInterv.Name = "tabInterv";
            tabInterv.Size = new Size(233, 484);
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
            dgvIntervencije.MultiSelect = false;
            dgvIntervencije.Name = "dgvIntervencije";
            dgvIntervencije.ReadOnly = true;
            dgvIntervencije.RowHeadersWidth = 51;
            dgvIntervencije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIntervencije.Size = new Size(233, 439);
            dgvIntervencije.TabIndex = 0;
            // 
            // flpIntervBtns
            // 
            flpIntervBtns.Controls.Add(btnIntervAdd);
            flpIntervBtns.Controls.Add(btnIntervRemove);
            flpIntervBtns.Dock = DockStyle.Bottom;
            flpIntervBtns.FlowDirection = FlowDirection.RightToLeft;
            flpIntervBtns.Location = new Point(0, 439);
            flpIntervBtns.Name = "flpIntervBtns";
            flpIntervBtns.Size = new Size(233, 45);
            flpIntervBtns.TabIndex = 1;
            // 
            // btnIntervAdd
            // 
            btnIntervAdd.Location = new Point(97, 8);
            btnIntervAdd.Margin = new Padding(6, 8, 6, 8);
            btnIntervAdd.Name = "btnIntervAdd";
            btnIntervAdd.Size = new Size(130, 23);
            btnIntervAdd.TabIndex = 0;
            btnIntervAdd.Text = "Dodaj postojeću";
            // 
            // btnIntervRemove
            // 
            btnIntervRemove.Location = new Point(137, 47);
            btnIntervRemove.Margin = new Padding(6, 8, 6, 8);
            btnIntervRemove.Name = "btnIntervRemove";
            btnIntervRemove.Size = new Size(90, 23);
            btnIntervRemove.TabIndex = 1;
            btnIntervRemove.Text = "Ukloni";
            // 
            // SmeneForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 577);
            Controls.Add(splitMain);
            Controls.Add(panelFilter);
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
            tlpDetalji.ResumeLayout(false);
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
    }
}
