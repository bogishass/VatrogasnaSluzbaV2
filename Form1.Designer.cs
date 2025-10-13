namespace VatrogasnaSluzba.Forms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnZaposleni = new Button();
            btnVozila = new Button();
            btnOprema = new Button();
            btnStanice = new Button();
            btnIntervencije = new Button();
            pictureBox1 = new PictureBox();
            btnSmene = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnZaposleni
            // 
            btnZaposleni.BackColor = Color.MidnightBlue;
            btnZaposleni.FlatStyle = FlatStyle.Flat;
            btnZaposleni.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnZaposleni.ForeColor = Color.White;
            btnZaposleni.Location = new Point(11, 26);
            btnZaposleni.Name = "btnZaposleni";
            btnZaposleni.Size = new Size(146, 38);
            btnZaposleni.TabIndex = 0;
            btnZaposleni.Text = "Zaposleni";
            btnZaposleni.UseVisualStyleBackColor = false;
            btnZaposleni.Click += btnZaposleni_Click;
            // 
            // btnVozila
            // 
            btnVozila.BackColor = Color.MidnightBlue;
            btnVozila.FlatStyle = FlatStyle.Flat;
            btnVozila.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnVozila.ForeColor = Color.White;
            btnVozila.Location = new Point(11, 158);
            btnVozila.Name = "btnVozila";
            btnVozila.Size = new Size(145, 38);
            btnVozila.TabIndex = 2;
            btnVozila.Text = "Vozila";
            btnVozila.UseVisualStyleBackColor = false;
            btnVozila.Click += btnVozila_Click;
            // 
            // btnOprema
            // 
            btnOprema.BackColor = Color.MidnightBlue;
            btnOprema.FlatStyle = FlatStyle.Flat;
            btnOprema.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnOprema.ForeColor = Color.White;
            btnOprema.Location = new Point(12, 202);
            btnOprema.Name = "btnOprema";
            btnOprema.Size = new Size(145, 38);
            btnOprema.TabIndex = 4;
            btnOprema.Text = "Oprema";
            btnOprema.UseVisualStyleBackColor = false;
            btnOprema.Click += btnOprema_Click;
            // 
            // btnStanice
            // 
            btnStanice.BackColor = Color.MidnightBlue;
            btnStanice.FlatStyle = FlatStyle.Flat;
            btnStanice.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnStanice.ForeColor = Color.White;
            btnStanice.Location = new Point(11, 70);
            btnStanice.Name = "btnStanice";
            btnStanice.Size = new Size(145, 38);
            btnStanice.TabIndex = 5;
            btnStanice.Text = "Stanice";
            btnStanice.UseVisualStyleBackColor = false;
            btnStanice.Click += btnStanice_Click;
            // 
            // btnIntervencije
            // 
            btnIntervencije.BackColor = Color.MidnightBlue;
            btnIntervencije.FlatStyle = FlatStyle.Flat;
            btnIntervencije.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnIntervencije.ForeColor = Color.White;
            btnIntervencije.Location = new Point(12, 114);
            btnIntervencije.Name = "btnIntervencije";
            btnIntervencije.Size = new Size(145, 38);
            btnIntervencije.TabIndex = 7;
            btnIntervencije.Text = "Intervencije";
            btnIntervencije.UseVisualStyleBackColor = false;
            btnIntervencije.Click += btnIntervencije_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(264, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnSmene
            // 
            btnSmene.BackColor = Color.IndianRed;
            btnSmene.FlatStyle = FlatStyle.Flat;
            btnSmene.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnSmene.ForeColor = Color.White;
            btnSmene.Location = new Point(163, 202);
            btnSmene.Name = "btnSmene";
            btnSmene.Size = new Size(145, 38);
            btnSmene.TabIndex = 9;
            btnSmene.Text = "Smene direkt";
            btnSmene.UseVisualStyleBackColor = false;
            btnSmene.Click += btnSmene_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(561, 264);
            Controls.Add(btnSmene);
            Controls.Add(btnIntervencije);
            Controls.Add(btnStanice);
            Controls.Add(btnOprema);
            Controls.Add(btnVozila);
            Controls.Add(btnZaposleni);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vatrogasna služba";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnZaposleni;
        private Button btnVozila;
        private Button btnOprema;
        private Button btnStanice;
        private Button btnIntervencije;
        private PictureBox pictureBox1;
        private Button btnSmene;
    }
}