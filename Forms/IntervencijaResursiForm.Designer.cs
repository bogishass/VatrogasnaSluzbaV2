namespace VatrogasnaSluzba.Forms
{
    partial class IntervencijaResursiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntervencijaResursiForm));
            tabControlResursi = new TabControl();
            tabVatrogasci = new TabPage();
            dgvVatrogasci = new DataGridView();
            tabDispeceri = new TabPage();
            dgvDispeceri = new DataGridView();
            tabTehnicari = new TabPage();
            dgvTehnicari = new DataGridView();
            tabVolonteri = new TabPage();
            dgvVolonteri = new DataGridView();
            tabVozila = new TabPage();
            dgvVozila = new DataGridView();
            tabVozilaVolontera = new TabPage();
            dgvVozilaVolontera = new DataGridView();
            tabOprema = new TabPage();
            dgvOprema = new DataGridView();
            btnIzmeni = new Button();
            btnOdbaci = new Button();
            btnOK = new Button();
            btnOtkazi = new Button();
            tabControlResursi.SuspendLayout();
            tabVatrogasci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVatrogasci).BeginInit();
            tabDispeceri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDispeceri).BeginInit();
            tabTehnicari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTehnicari).BeginInit();
            tabVolonteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVolonteri).BeginInit();
            tabVozila.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVozila).BeginInit();
            tabVozilaVolontera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVozilaVolontera).BeginInit();
            tabOprema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOprema).BeginInit();
            SuspendLayout();
            // 
            // tabControlResursi
            // 
            tabControlResursi.Controls.Add(tabVatrogasci);
            tabControlResursi.Controls.Add(tabDispeceri);
            tabControlResursi.Controls.Add(tabTehnicari);
            tabControlResursi.Controls.Add(tabVolonteri);
            tabControlResursi.Controls.Add(tabVozila);
            tabControlResursi.Controls.Add(tabVozilaVolontera);
            tabControlResursi.Controls.Add(tabOprema);
            tabControlResursi.Location = new Point(10, 9);
            tabControlResursi.Margin = new Padding(3, 2, 3, 2);
            tabControlResursi.Name = "tabControlResursi";
            tabControlResursi.SelectedIndex = 0;
            tabControlResursi.Size = new Size(559, 262);
            tabControlResursi.TabIndex = 4;
            // 
            // tabVatrogasci
            // 
            tabVatrogasci.Controls.Add(dgvVatrogasci);
            tabVatrogasci.Location = new Point(4, 24);
            tabVatrogasci.Margin = new Padding(3, 2, 3, 2);
            tabVatrogasci.Name = "tabVatrogasci";
            tabVatrogasci.Padding = new Padding(3, 2, 3, 2);
            tabVatrogasci.Size = new Size(551, 234);
            tabVatrogasci.TabIndex = 0;
            tabVatrogasci.Text = "Vatrogasci";
            tabVatrogasci.UseVisualStyleBackColor = true;
            // 
            // dgvVatrogasci
            // 
            dgvVatrogasci.AllowUserToAddRows = false;
            dgvVatrogasci.AllowUserToDeleteRows = false;
            dgvVatrogasci.AllowUserToOrderColumns = true;
            dgvVatrogasci.AllowUserToResizeRows = false;
            dgvVatrogasci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvVatrogasci.BackgroundColor = SystemColors.Window;
            dgvVatrogasci.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvVatrogasci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVatrogasci.Dock = DockStyle.Fill;
            dgvVatrogasci.Location = new Point(3, 2);
            dgvVatrogasci.MultiSelect = false;
            dgvVatrogasci.Name = "dgvVatrogasci";
            dgvVatrogasci.ReadOnly = true;
            dgvVatrogasci.RowHeadersVisible = false;
            dgvVatrogasci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVatrogasci.Size = new Size(545, 230);
            dgvVatrogasci.TabIndex = 0;
            // 
            // tabDispeceri
            // 
            tabDispeceri.Controls.Add(dgvDispeceri);
            tabDispeceri.Location = new Point(4, 24);
            tabDispeceri.Margin = new Padding(3, 2, 3, 2);
            tabDispeceri.Name = "tabDispeceri";
            tabDispeceri.Padding = new Padding(3, 2, 3, 2);
            tabDispeceri.Size = new Size(551, 234);
            tabDispeceri.TabIndex = 1;
            tabDispeceri.Text = "Dispečeri";
            tabDispeceri.UseVisualStyleBackColor = true;
            // 
            // dgvDispeceri
            // 
            dgvDispeceri.AllowUserToAddRows = false;
            dgvDispeceri.AllowUserToDeleteRows = false;
            dgvDispeceri.AllowUserToOrderColumns = true;
            dgvDispeceri.AllowUserToResizeRows = false;
            dgvDispeceri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvDispeceri.BackgroundColor = SystemColors.Window;
            dgvDispeceri.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvDispeceri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDispeceri.Dock = DockStyle.Fill;
            dgvDispeceri.Location = new Point(3, 2);
            dgvDispeceri.MultiSelect = false;
            dgvDispeceri.Name = "dgvDispeceri";
            dgvDispeceri.ReadOnly = true;
            dgvDispeceri.RowHeadersVisible = false;
            dgvDispeceri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDispeceri.Size = new Size(545, 230);
            dgvDispeceri.TabIndex = 1;
            // 
            // tabTehnicari
            // 
            tabTehnicari.Controls.Add(dgvTehnicari);
            tabTehnicari.Location = new Point(4, 24);
            tabTehnicari.Margin = new Padding(3, 2, 3, 2);
            tabTehnicari.Name = "tabTehnicari";
            tabTehnicari.Padding = new Padding(3, 2, 3, 2);
            tabTehnicari.Size = new Size(551, 234);
            tabTehnicari.TabIndex = 2;
            tabTehnicari.Text = "Tehničari";
            tabTehnicari.UseVisualStyleBackColor = true;
            // 
            // dgvTehnicari
            // 
            dgvTehnicari.AllowUserToAddRows = false;
            dgvTehnicari.AllowUserToDeleteRows = false;
            dgvTehnicari.AllowUserToOrderColumns = true;
            dgvTehnicari.AllowUserToResizeRows = false;
            dgvTehnicari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvTehnicari.BackgroundColor = SystemColors.Window;
            dgvTehnicari.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTehnicari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTehnicari.Dock = DockStyle.Fill;
            dgvTehnicari.Location = new Point(3, 2);
            dgvTehnicari.MultiSelect = false;
            dgvTehnicari.Name = "dgvTehnicari";
            dgvTehnicari.ReadOnly = true;
            dgvTehnicari.RowHeadersVisible = false;
            dgvTehnicari.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTehnicari.Size = new Size(545, 230);
            dgvTehnicari.TabIndex = 1;
            // 
            // tabVolonteri
            // 
            tabVolonteri.Controls.Add(dgvVolonteri);
            tabVolonteri.Location = new Point(4, 24);
            tabVolonteri.Margin = new Padding(3, 2, 3, 2);
            tabVolonteri.Name = "tabVolonteri";
            tabVolonteri.Padding = new Padding(3, 2, 3, 2);
            tabVolonteri.Size = new Size(551, 234);
            tabVolonteri.TabIndex = 3;
            tabVolonteri.Text = "Volonteri";
            tabVolonteri.UseVisualStyleBackColor = true;
            // 
            // dgvVolonteri
            // 
            dgvVolonteri.AllowUserToAddRows = false;
            dgvVolonteri.AllowUserToDeleteRows = false;
            dgvVolonteri.AllowUserToOrderColumns = true;
            dgvVolonteri.AllowUserToResizeRows = false;
            dgvVolonteri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvVolonteri.BackgroundColor = SystemColors.Window;
            dgvVolonteri.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvVolonteri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVolonteri.Dock = DockStyle.Fill;
            dgvVolonteri.Location = new Point(3, 2);
            dgvVolonteri.MultiSelect = false;
            dgvVolonteri.Name = "dgvVolonteri";
            dgvVolonteri.ReadOnly = true;
            dgvVolonteri.RowHeadersVisible = false;
            dgvVolonteri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVolonteri.Size = new Size(545, 230);
            dgvVolonteri.TabIndex = 1;
            // 
            // tabVozila
            // 
            tabVozila.Controls.Add(dgvVozila);
            tabVozila.Location = new Point(4, 24);
            tabVozila.Margin = new Padding(3, 2, 3, 2);
            tabVozila.Name = "tabVozila";
            tabVozila.Padding = new Padding(3, 2, 3, 2);
            tabVozila.Size = new Size(551, 234);
            tabVozila.TabIndex = 4;
            tabVozila.Text = "Vozila";
            tabVozila.UseVisualStyleBackColor = true;
            // 
            // dgvVozila
            // 
            dgvVozila.AllowUserToAddRows = false;
            dgvVozila.AllowUserToDeleteRows = false;
            dgvVozila.AllowUserToOrderColumns = true;
            dgvVozila.AllowUserToResizeRows = false;
            dgvVozila.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvVozila.BackgroundColor = SystemColors.Window;
            dgvVozila.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvVozila.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVozila.Dock = DockStyle.Fill;
            dgvVozila.Location = new Point(3, 2);
            dgvVozila.MultiSelect = false;
            dgvVozila.Name = "dgvVozila";
            dgvVozila.ReadOnly = true;
            dgvVozila.RowHeadersVisible = false;
            dgvVozila.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVozila.Size = new Size(545, 230);
            dgvVozila.TabIndex = 1;
            // 
            // tabVozilaVolontera
            // 
            tabVozilaVolontera.Controls.Add(dgvVozilaVolontera);
            tabVozilaVolontera.Location = new Point(4, 24);
            tabVozilaVolontera.Margin = new Padding(3, 2, 3, 2);
            tabVozilaVolontera.Name = "tabVozilaVolontera";
            tabVozilaVolontera.Padding = new Padding(3, 2, 3, 2);
            tabVozilaVolontera.Size = new Size(551, 234);
            tabVozilaVolontera.TabIndex = 5;
            tabVozilaVolontera.Text = "Vozila volontera";
            tabVozilaVolontera.UseVisualStyleBackColor = true;
            // 
            // dgvVozilaVolontera
            // 
            dgvVozilaVolontera.AllowUserToAddRows = false;
            dgvVozilaVolontera.AllowUserToDeleteRows = false;
            dgvVozilaVolontera.AllowUserToOrderColumns = true;
            dgvVozilaVolontera.AllowUserToResizeRows = false;
            dgvVozilaVolontera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvVozilaVolontera.BackgroundColor = SystemColors.Window;
            dgvVozilaVolontera.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvVozilaVolontera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVozilaVolontera.Dock = DockStyle.Fill;
            dgvVozilaVolontera.Location = new Point(3, 2);
            dgvVozilaVolontera.MultiSelect = false;
            dgvVozilaVolontera.Name = "dgvVozilaVolontera";
            dgvVozilaVolontera.ReadOnly = true;
            dgvVozilaVolontera.RowHeadersVisible = false;
            dgvVozilaVolontera.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVozilaVolontera.Size = new Size(545, 230);
            dgvVozilaVolontera.TabIndex = 2;
            // 
            // tabOprema
            // 
            tabOprema.Controls.Add(dgvOprema);
            tabOprema.Location = new Point(4, 24);
            tabOprema.Name = "tabOprema";
            tabOprema.Padding = new Padding(3);
            tabOprema.Size = new Size(551, 234);
            tabOprema.TabIndex = 6;
            tabOprema.Text = "Oprema";
            tabOprema.UseVisualStyleBackColor = true;
            // 
            // dgvOprema
            // 
            dgvOprema.AllowUserToAddRows = false;
            dgvOprema.AllowUserToDeleteRows = false;
            dgvOprema.AllowUserToOrderColumns = true;
            dgvOprema.AllowUserToResizeRows = false;
            dgvOprema.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvOprema.BackgroundColor = SystemColors.Window;
            dgvOprema.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvOprema.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOprema.Dock = DockStyle.Fill;
            dgvOprema.Location = new Point(3, 3);
            dgvOprema.MultiSelect = false;
            dgvOprema.Name = "dgvOprema";
            dgvOprema.ReadOnly = true;
            dgvOprema.RowHeadersVisible = false;
            dgvOprema.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOprema.Size = new Size(545, 228);
            dgvOprema.TabIndex = 2;
            // 
            // btnIzmeni
            // 
            btnIzmeni.BackColor = SystemColors.Control;
            btnIzmeni.Location = new Point(379, 275);
            btnIzmeni.Margin = new Padding(3, 2, 3, 2);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(92, 25);
            btnIzmeni.TabIndex = 0;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = false;
            // 
            // btnOdbaci
            // 
            btnOdbaci.BackColor = SystemColors.Control;
            btnOdbaci.Location = new Point(477, 275);
            btnOdbaci.Margin = new Padding(3, 2, 3, 2);
            btnOdbaci.Name = "btnOdbaci";
            btnOdbaci.Size = new Size(92, 25);
            btnOdbaci.TabIndex = 1;
            btnOdbaci.Text = "Odbaci";
            btnOdbaci.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.DarkSeaGreen;
            btnOK.Location = new Point(335, 325);
            btnOK.Margin = new Padding(3, 2, 3, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(114, 30);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            // 
            // btnOtkazi
            // 
            btnOtkazi.BackColor = Color.LightCoral;
            btnOtkazi.Location = new Point(455, 325);
            btnOtkazi.Margin = new Padding(3, 2, 3, 2);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(114, 30);
            btnOtkazi.TabIndex = 3;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = false;
            // 
            // IntervencijaResursiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(576, 366);
            Controls.Add(btnIzmeni);
            Controls.Add(btnOdbaci);
            Controls.Add(btnOK);
            Controls.Add(btnOtkazi);
            Controls.Add(tabControlResursi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "IntervencijaResursiForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Upravljanje resursima";
            tabControlResursi.ResumeLayout(false);
            tabVatrogasci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVatrogasci).EndInit();
            tabDispeceri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDispeceri).EndInit();
            tabTehnicari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTehnicari).EndInit();
            tabVolonteri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVolonteri).EndInit();
            tabVozila.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVozila).EndInit();
            tabVozilaVolontera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVozilaVolontera).EndInit();
            tabOprema.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOprema).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.TabControl tabControlResursi;
        private System.Windows.Forms.TabPage tabVatrogasci;
        private System.Windows.Forms.TabPage tabDispeceri;
        private System.Windows.Forms.TabPage tabTehnicari;
        private System.Windows.Forms.TabPage tabVolonteri;
        private System.Windows.Forms.TabPage tabVozila;
        private System.Windows.Forms.TabPage tabVozilaVolontera;
        private System.Windows.Forms.DataGridView dgvVatrogasci;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnOdbaci;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnOtkazi;
        private DataGridView dgvDispeceri;
        private DataGridView dgvTehnicari;
        private DataGridView dgvVolonteri;
        private DataGridView dgvVozila;
        private TabPage tabOprema;
        private DataGridView dgvVozilaVolontera;
        private DataGridView dgvOprema;
    }
}