namespace VatrogasnaSluzba.Forms
{
    partial class ZaposleniForm
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            groupBox2 = new GroupBox();
            btnIzmeni = new Button();
            btnDodaj = new Button();
            btnObrisi = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(643, 428);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista zaposlenih";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            listView1.Location = new Point(6, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(631, 400);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "JMBG";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ime";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Prezime";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Pol";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Datum rodjenja";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Adresa";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Email";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Telefoni";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Pozicija";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Pocetak angazovanja";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnIzmeni);
            groupBox2.Controls.Add(btnDodaj);
            groupBox2.Controls.Add(btnObrisi);
            groupBox2.Location = new Point(672, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(161, 156);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Upravljanje zaposlenima";
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(6, 104);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(149, 35);
            btnIzmeni.TabIndex = 2;
            btnIzmeni.Text = "Izmeni zaposlenog";
            btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(6, 22);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(149, 35);
            btnDodaj.TabIndex = 0;
            btnDodaj.Text = "Dodaj zaposlenog";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(6, 63);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(149, 35);
            btnObrisi.TabIndex = 1;
            btnObrisi.Text = "Obrisi zaposlenog";
            btnObrisi.UseVisualStyleBackColor = true;
            // 
            // ZaposleniForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 458);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ZaposleniForm";
            Text = "Zaposleni";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private GroupBox groupBox2;
        private Button btnIzmeni;
        private Button btnDodaj;
        private Button btnObrisi;
    }
}