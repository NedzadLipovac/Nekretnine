namespace Nekretnine.WinUI
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpiti = new System.Windows.Forms.Button();
            this.lblKorisnikId = new System.Windows.Forms.Label();
            this.btnOdjaviSe = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.lblUloga = new System.Windows.Forms.Label();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNekretine = new System.Windows.Forms.Button();
            this.btnKlijenti = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.btnPoruke = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlMjesto = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.btnUpiti);
            this.panel1.Controls.Add(this.lblKorisnikId);
            this.panel1.Controls.Add(this.btnOdjaviSe);
            this.panel1.Controls.Add(this.btnProfil);
            this.panel1.Controls.Add(this.btnRezervacije);
            this.panel1.Controls.Add(this.lblUloga);
            this.panel1.Controls.Add(this.lblKorisnik);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnNekretine);
            this.panel1.Controls.Add(this.btnKlijenti);
            this.panel1.Controls.Add(this.btnKorisnici);
            this.panel1.Controls.Add(this.btnPoruke);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 696);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnUpiti
            // 
            this.btnUpiti.FlatAppearance.BorderSize = 0;
            this.btnUpiti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpiti.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpiti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpiti.Image = ((System.Drawing.Image)(resources.GetObject("btnUpiti.Image")));
            this.btnUpiti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpiti.Location = new System.Drawing.Point(7, 518);
            this.btnUpiti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpiti.Name = "btnUpiti";
            this.btnUpiti.Size = new System.Drawing.Size(206, 46);
            this.btnUpiti.TabIndex = 17;
            this.btnUpiti.Text = "    Upiti za Sastanke";
            this.btnUpiti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpiti.UseVisualStyleBackColor = true;
            this.btnUpiti.Click += new System.EventHandler(this.btnUpiti_Click);
            // 
            // lblKorisnikId
            // 
            this.lblKorisnikId.AutoSize = true;
            this.lblKorisnikId.Enabled = false;
            this.lblKorisnikId.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblKorisnikId.Location = new System.Drawing.Point(64, 9);
            this.lblKorisnikId.Name = "lblKorisnikId";
            this.lblKorisnikId.Size = new System.Drawing.Size(0, 17);
            this.lblKorisnikId.TabIndex = 16;
            this.lblKorisnikId.Visible = false;
            // 
            // btnOdjaviSe
            // 
            this.btnOdjaviSe.FlatAppearance.BorderSize = 0;
            this.btnOdjaviSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjaviSe.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjaviSe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdjaviSe.Image = global::Nekretnine.WinUI.Properties.Resources.powerbutton;
            this.btnOdjaviSe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdjaviSe.Location = new System.Drawing.Point(9, 574);
            this.btnOdjaviSe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdjaviSe.Name = "btnOdjaviSe";
            this.btnOdjaviSe.Size = new System.Drawing.Size(206, 46);
            this.btnOdjaviSe.TabIndex = 15;
            this.btnOdjaviSe.Text = "    Odjavi se";
            this.btnOdjaviSe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOdjaviSe.UseVisualStyleBackColor = true;
            this.btnOdjaviSe.Click += new System.EventHandler(this.btnOdjaviSe_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.FlatAppearance.BorderSize = 0;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProfil.Image = global::Nekretnine.WinUI.Properties.Resources.iconsgears;
            this.btnProfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfil.Location = new System.Drawing.Point(17, 148);
            this.btnProfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(188, 46);
            this.btnProfil.TabIndex = 14;
            this.btnProfil.Text = "  Izmjena profila";
            this.btnProfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfil.UseVisualStyleBackColor = true;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.FlatAppearance.BorderSize = 0;
            this.btnRezervacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervacije.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervacije.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRezervacije.Image = ((System.Drawing.Image)(resources.GetObject("btnRezervacije.Image")));
            this.btnRezervacije.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRezervacije.Location = new System.Drawing.Point(9, 468);
            this.btnRezervacije.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(206, 46);
            this.btnRezervacije.TabIndex = 10;
            this.btnRezervacije.Text = "    Rezervacije";
            this.btnRezervacije.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRezervacije.UseVisualStyleBackColor = true;
            this.btnRezervacije.Click += new System.EventHandler(this.btnRezervacije_Click);
            // 
            // lblUloga
            // 
            this.lblUloga.AutoSize = true;
            this.lblUloga.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUloga.Location = new System.Drawing.Point(64, 110);
            this.lblUloga.Name = "lblUloga";
            this.lblUloga.Size = new System.Drawing.Size(0, 17);
            this.lblUloga.TabIndex = 9;
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKorisnik.Location = new System.Drawing.Point(50, 126);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(0, 18);
            this.lblKorisnik.TabIndex = 6;
            this.lblKorisnik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nekretnine.WinUI.Properties.Resources.ja;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(44, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnNekretine
            // 
            this.btnNekretine.FlatAppearance.BorderSize = 0;
            this.btnNekretine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNekretine.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNekretine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNekretine.Image = global::Nekretnine.WinUI.Properties.Resources.architecture_and_city1;
            this.btnNekretine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNekretine.Location = new System.Drawing.Point(9, 414);
            this.btnNekretine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNekretine.Name = "btnNekretine";
            this.btnNekretine.Size = new System.Drawing.Size(206, 46);
            this.btnNekretine.TabIndex = 4;
            this.btnNekretine.Text = "    Nekretnine";
            this.btnNekretine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNekretine.UseVisualStyleBackColor = true;
            this.btnNekretine.Click += new System.EventHandler(this.btnNekretnine_Click);
            // 
            // btnKlijenti
            // 
            this.btnKlijenti.FlatAppearance.BorderSize = 0;
            this.btnKlijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKlijenti.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKlijenti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKlijenti.Image = ((System.Drawing.Image)(resources.GetObject("btnKlijenti.Image")));
            this.btnKlijenti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKlijenti.Location = new System.Drawing.Point(9, 363);
            this.btnKlijenti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKlijenti.Name = "btnKlijenti";
            this.btnKlijenti.Size = new System.Drawing.Size(206, 46);
            this.btnKlijenti.TabIndex = 3;
            this.btnKlijenti.Text = "    Klijenti";
            this.btnKlijenti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKlijenti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKlijenti.UseVisualStyleBackColor = true;
            this.btnKlijenti.Click += new System.EventHandler(this.btnKlijenti_Click);
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.FlatAppearance.BorderSize = 0;
            this.btnKorisnici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKorisnici.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKorisnici.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKorisnici.Image = global::Nekretnine.WinUI.Properties.Resources.usergroupsfilled;
            this.btnKorisnici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKorisnici.Location = new System.Drawing.Point(9, 311);
            this.btnKorisnici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(206, 46);
            this.btnKorisnici.TabIndex = 2;
            this.btnKorisnici.Text = "    Korisnici";
            this.btnKorisnici.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKorisnici.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKorisnici.UseVisualStyleBackColor = true;
            this.btnKorisnici.Click += new System.EventHandler(this.btnKorisnici_Click);
            // 
            // btnPoruke
            // 
            this.btnPoruke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.btnPoruke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPoruke.FlatAppearance.BorderSize = 0;
            this.btnPoruke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoruke.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoruke.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPoruke.Image = global::Nekretnine.WinUI.Properties.Resources.newpost;
            this.btnPoruke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPoruke.Location = new System.Drawing.Point(9, 260);
            this.btnPoruke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPoruke.Name = "btnPoruke";
            this.btnPoruke.Size = new System.Drawing.Size(206, 46);
            this.btnPoruke.TabIndex = 1;
            this.btnPoruke.Text = "    Poruke";
            this.btnPoruke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPoruke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPoruke.UseVisualStyleBackColor = false;
            this.btnPoruke.Click += new System.EventHandler(this.btnPoruke_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Image = global::Nekretnine.WinUI.Properties.Resources.desktop;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(9, 204);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(205, 46);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "         Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlMjesto
            // 
            this.pnlMjesto.Location = new System.Drawing.Point(219, 0);
            this.pnlMjesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMjesto.Name = "pnlMjesto";
            this.pnlMjesto.Size = new System.Drawing.Size(938, 718);
            this.pnlMjesto.TabIndex = 2;
            this.pnlMjesto.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMjesto_Paint);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 696);
            this.Controls.Add(this.pnlMjesto);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashboardForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNekretine;
        private System.Windows.Forms.Button btnKlijenti;
        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.Button btnRezervacije;
        private System.Windows.Forms.Label lblUloga;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlMjesto;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnOdjaviSe;
        private System.Windows.Forms.Button btnPoruke;
        private System.Windows.Forms.Label lblKorisnikId;
        private System.Windows.Forms.Button btnUpiti;
    }
}