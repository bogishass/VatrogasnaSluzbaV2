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
            btnZaposleni = new Button();
            btnVolonteri = new Button();
            btnVozila = new Button();
            btnVozilaVol = new Button();
            btnOprema = new Button();
            btnStanice = new Button();
            btnSmene = new Button();
            SuspendLayout();
            // 
            // btnZaposleni
            // 
            btnZaposleni.Location = new Point(36, 37);
            btnZaposleni.Name = "btnZaposleni";
            btnZaposleni.Size = new Size(99, 52);
            btnZaposleni.TabIndex = 0;
            btnZaposleni.Text = "Zaposleni";
            btnZaposleni.UseVisualStyleBackColor = true;
            btnZaposleni.Click += btnZaposleni_Click;
            // 
            // btnVolonteri
            // 
            btnVolonteri.Location = new Point(36, 120);
            btnVolonteri.Name = "btnVolonteri";
            btnVolonteri.Size = new Size(99, 52);
            btnVolonteri.TabIndex = 1;
            btnVolonteri.Text = "Volonteri";
            btnVolonteri.UseVisualStyleBackColor = true;
            btnVolonteri.Click += btnVolonteri_Click;
            // 
            // btnVozila
            // 
            btnVozila.Location = new Point(36, 199);
            btnVozila.Name = "btnVozila";
            btnVozila.Size = new Size(99, 52);
            btnVozila.TabIndex = 2;
            btnVozila.Text = "Vozila";
            btnVozila.UseVisualStyleBackColor = true;
            // 
            // btnVozilaVol
            // 
            btnVozilaVol.Location = new Point(36, 283);
            btnVozilaVol.Name = "btnVozilaVol";
            btnVozilaVol.Size = new Size(99, 52);
            btnVozilaVol.TabIndex = 3;
            btnVozilaVol.Text = "Vozila volontera";
            btnVozilaVol.UseVisualStyleBackColor = true;
            // 
            // btnOprema
            // 
            btnOprema.Location = new Point(185, 37);
            btnOprema.Name = "btnOprema";
            btnOprema.Size = new Size(99, 52);
            btnOprema.TabIndex = 4;
            btnOprema.Text = "Oprema";
            btnOprema.UseVisualStyleBackColor = true;
            // 
            // btnStanice
            // 
            btnStanice.Location = new Point(185, 120);
            btnStanice.Name = "btnStanice";
            btnStanice.Size = new Size(99, 52);
            btnStanice.TabIndex = 5;
            btnStanice.Text = "Stanice";
            btnStanice.UseVisualStyleBackColor = true;
            // 
            // btnSmene
            // 
            btnSmene.Location = new Point(185, 199);
            btnSmene.Name = "btnSmene";
            btnSmene.Size = new Size(99, 52);
            btnSmene.TabIndex = 6;
            btnSmene.Text = "Smene";
            btnSmene.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 366);
            Controls.Add(btnSmene);
            Controls.Add(btnStanice);
            Controls.Add(btnOprema);
            Controls.Add(btnVozilaVol);
            Controls.Add(btnVozila);
            Controls.Add(btnVolonteri);
            Controls.Add(btnZaposleni);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Pocetna stranica";
            ResumeLayout(false);
        }

        #endregion

        private Button btnZaposleni;
        private Button btnVolonteri;
        private Button btnVozila;
        private Button btnVozilaVol;
        private Button btnOprema;
        private Button btnStanice;
        private Button btnSmene;
    }
}