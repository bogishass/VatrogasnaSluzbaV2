namespace VatrogasnaSluzba.Forms
{
    partial class Oprema
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            INVBroj = new DataGridViewTextBoxColumn();
            Naziv = new DataGridViewTextBoxColumn();
            Tip = new DataGridViewTextBoxColumn();
            PodTip = new DataGridViewTextBoxColumn();
            LokacijaOpreme = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            DatumNabavke = new DataGridViewTextBoxColumn();
            Intervencija = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Oprema";
            label1.Click += this.label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { INVBroj, Naziv, Tip, PodTip, LokacijaOpreme, Status, DatumNabavke, Intervencija });
            dataGridView1.Location = new Point(12, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(662, 392);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += this.dataGridView1_CellContentClick;
            // 
            // INVBroj
            // 
            INVBroj.HeaderText = "Invertarski broj";
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
            // Intervencija
            // 
            Intervencija.HeaderText = "Intervencija";
            Intervencija.Name = "Intervencija";
            // 
            // button1
            // 
            button1.Location = new Point(680, 46);
            button1.Name = "button1";
            button1.Size = new Size(99, 67);
            button1.TabIndex = 2;
            button1.Text = "Dodaj opremu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(680, 134);
            button2.Name = "button2";
            button2.Size = new Size(99, 67);
            button2.TabIndex = 3;
            button2.Text = "Ukloni opremu";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(680, 222);
            button3.Name = "button3";
            button3.Size = new Size(99, 67);
            button3.TabIndex = 4;
            button3.Text = "Edituj opremu";
            button3.UseVisualStyleBackColor = true;
            // 
            // Oprema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Oprema";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn INVBroj;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Tip;
        private DataGridViewTextBoxColumn PodTip;
        private DataGridViewTextBoxColumn LokacijaOpreme;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn DatumNabavke;
        private DataGridViewTextBoxColumn Intervencija;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}