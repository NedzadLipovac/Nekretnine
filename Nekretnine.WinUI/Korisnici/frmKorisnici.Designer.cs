namespace Nekretnine.WinUI.Korisnici
{
    partial class frmKorisnici
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.listaKorisnika = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.chbAktivanLista = new System.Windows.Forms.CheckBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.cmbGradLista = new System.Windows.Forms.ComboBox();
            this.txtEmailLista = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrezimelista = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Korisnici = new System.Windows.Forms.GroupBox();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtImeLista = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.NoviKorisnik = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDatumRodjenjaNovi = new System.Windows.Forms.DateTimePicker();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.btnSnimiNovi = new System.Windows.Forms.Button();
            this.chbStatusNovi = new System.Windows.Forms.CheckBox();
            this.txtPasswordPotvrdaNovi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPasswordNovi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGradNovi = new System.Windows.Forms.ComboBox();
            this.txtUsernameNovi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdresaNovi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefonNovi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailNovi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrezimeNovi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImeNovi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.DetaljiKorisnika = new System.Windows.Forms.TabPage();
            this.btnDodajSlikuDetalji = new System.Windows.Forms.Button();
            this.txtEmailDetalji = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnSpremiDetalji = new System.Windows.Forms.Button();
            this.chbStatusDetalji = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dtpDatumRodjenjaDetalji = new System.Windows.Forms.DateTimePicker();
            this.txtTelefonDetalji = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAdresaDetalji = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPrezimeDetalji = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtImeDetalji = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.listaKorisnika.SuspendLayout();
            this.Korisnici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.NoviKorisnik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.DetaljiKorisnika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.listaKorisnika);
            this.tabControl1.Controls.Add(this.NoviKorisnik);
            this.tabControl1.Controls.Add(this.DetaljiKorisnika);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 551);
            this.tabControl1.TabIndex = 0;
            // 
            // listaKorisnika
            // 
            this.listaKorisnika.Controls.Add(this.label14);
            this.listaKorisnika.Controls.Add(this.chbAktivanLista);
            this.listaKorisnika.Controls.Add(this.btnPrikazi);
            this.listaKorisnika.Controls.Add(this.cmbGradLista);
            this.listaKorisnika.Controls.Add(this.txtEmailLista);
            this.listaKorisnika.Controls.Add(this.label13);
            this.listaKorisnika.Controls.Add(this.txtPrezimelista);
            this.listaKorisnika.Controls.Add(this.label12);
            this.listaKorisnika.Controls.Add(this.Korisnici);
            this.listaKorisnika.Controls.Add(this.txtImeLista);
            this.listaKorisnika.Controls.Add(this.label11);
            this.listaKorisnika.Location = new System.Drawing.Point(4, 25);
            this.listaKorisnika.Name = "listaKorisnika";
            this.listaKorisnika.Padding = new System.Windows.Forms.Padding(3);
            this.listaKorisnika.Size = new System.Drawing.Size(906, 522);
            this.listaKorisnika.TabIndex = 0;
            this.listaKorisnika.Text = "Lista Korisnika ";
            this.listaKorisnika.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(390, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "Grad";
            // 
            // chbAktivanLista
            // 
            this.chbAktivanLista.AutoSize = true;
            this.chbAktivanLista.Checked = true;
            this.chbAktivanLista.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAktivanLista.Location = new System.Drawing.Point(685, 99);
            this.chbAktivanLista.Name = "chbAktivanLista";
            this.chbAktivanLista.Size = new System.Drawing.Size(76, 21);
            this.chbAktivanLista.TabIndex = 9;
            this.chbAktivanLista.Text = "Aktivan";
            this.chbAktivanLista.UseVisualStyleBackColor = true;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(782, 90);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(96, 30);
            this.btnPrikazi.TabIndex = 8;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // cmbGradLista
            // 
            this.cmbGradLista.FormattingEnabled = true;
            this.cmbGradLista.Location = new System.Drawing.Point(393, 97);
            this.cmbGradLista.Name = "cmbGradLista";
            this.cmbGradLista.Size = new System.Drawing.Size(267, 24);
            this.cmbGradLista.TabIndex = 7;
            // 
            // txtEmailLista
            // 
            this.txtEmailLista.Location = new System.Drawing.Point(393, 36);
            this.txtEmailLista.Name = "txtEmailLista";
            this.txtEmailLista.Size = new System.Drawing.Size(267, 22);
            this.txtEmailLista.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(390, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "Email";
            // 
            // txtPrezimelista
            // 
            this.txtPrezimelista.Location = new System.Drawing.Point(50, 96);
            this.txtPrezimelista.Name = "txtPrezimelista";
            this.txtPrezimelista.Size = new System.Drawing.Size(267, 22);
            this.txtPrezimelista.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Prezime";
            // 
            // Korisnici
            // 
            this.Korisnici.Controls.Add(this.dgvKorisnici);
            this.Korisnici.Location = new System.Drawing.Point(3, 149);
            this.Korisnici.Name = "Korisnici";
            this.Korisnici.Size = new System.Drawing.Size(900, 370);
            this.Korisnici.TabIndex = 2;
            this.Korisnici.TabStop = false;
            this.Korisnici.Text = "Korisnici";
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KorisnikId,
            this.Ime,
            this.Prezime,
            this.Email,
            this.Telefon,
            this.DatumRodjenja,
            this.Adresa});
            this.dgvKorisnici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKorisnici.Location = new System.Drawing.Point(3, 18);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.RowTemplate.Height = 24;
            this.dgvKorisnici.Size = new System.Drawing.Size(894, 349);
            this.dgvKorisnici.TabIndex = 0;
            this.dgvKorisnici.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKorisnici_MouseDoubleClick);
            // 
            // KorisnikId
            // 
            this.KorisnikId.DataPropertyName = "KorisnikId";
            this.KorisnikId.HeaderText = "KorisnikId";
            this.KorisnikId.Name = "KorisnikId";
            this.KorisnikId.ReadOnly = true;
            this.KorisnikId.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "Datum Rodjenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            this.DatumRodjenja.Width = 130;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // txtImeLista
            // 
            this.txtImeLista.Location = new System.Drawing.Point(50, 36);
            this.txtImeLista.Name = "txtImeLista";
            this.txtImeLista.Size = new System.Drawing.Size(267, 22);
            this.txtImeLista.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ime";
            // 
            // NoviKorisnik
            // 
            this.NoviKorisnik.Controls.Add(this.label10);
            this.NoviKorisnik.Controls.Add(this.dtpDatumRodjenjaNovi);
            this.NoviKorisnik.Controls.Add(this.btnDodajSliku);
            this.NoviKorisnik.Controls.Add(this.btnSnimiNovi);
            this.NoviKorisnik.Controls.Add(this.chbStatusNovi);
            this.NoviKorisnik.Controls.Add(this.txtPasswordPotvrdaNovi);
            this.NoviKorisnik.Controls.Add(this.label9);
            this.NoviKorisnik.Controls.Add(this.txtPasswordNovi);
            this.NoviKorisnik.Controls.Add(this.label8);
            this.NoviKorisnik.Controls.Add(this.label7);
            this.NoviKorisnik.Controls.Add(this.cmbGradNovi);
            this.NoviKorisnik.Controls.Add(this.txtUsernameNovi);
            this.NoviKorisnik.Controls.Add(this.label5);
            this.NoviKorisnik.Controls.Add(this.txtAdresaNovi);
            this.NoviKorisnik.Controls.Add(this.label6);
            this.NoviKorisnik.Controls.Add(this.txtTelefonNovi);
            this.NoviKorisnik.Controls.Add(this.label3);
            this.NoviKorisnik.Controls.Add(this.txtEmailNovi);
            this.NoviKorisnik.Controls.Add(this.label4);
            this.NoviKorisnik.Controls.Add(this.txtPrezimeNovi);
            this.NoviKorisnik.Controls.Add(this.label2);
            this.NoviKorisnik.Controls.Add(this.txtImeNovi);
            this.NoviKorisnik.Controls.Add(this.label1);
            this.NoviKorisnik.Controls.Add(this.pictureBox3);
            this.NoviKorisnik.Location = new System.Drawing.Point(4, 25);
            this.NoviKorisnik.Name = "NoviKorisnik";
            this.NoviKorisnik.Padding = new System.Windows.Forms.Padding(3);
            this.NoviKorisnik.Size = new System.Drawing.Size(906, 522);
            this.NoviKorisnik.TabIndex = 1;
            this.NoviKorisnik.Text = "Novi Korisnik";
            this.NoviKorisnik.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Datum Rođenja";
            // 
            // dtpDatumRodjenjaNovi
            // 
            this.dtpDatumRodjenjaNovi.Location = new System.Drawing.Point(367, 363);
            this.dtpDatumRodjenjaNovi.Name = "dtpDatumRodjenjaNovi";
            this.dtpDatumRodjenjaNovi.Size = new System.Drawing.Size(248, 22);
            this.dtpDatumRodjenjaNovi.TabIndex = 26;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(112, 429);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(117, 33);
            this.btnDodajSliku.TabIndex = 25;
            this.btnDodajSliku.Text = "Dodaj Sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // btnSnimiNovi
            // 
            this.btnSnimiNovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimiNovi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSnimiNovi.Location = new System.Drawing.Point(740, 336);
            this.btnSnimiNovi.Name = "btnSnimiNovi";
            this.btnSnimiNovi.Size = new System.Drawing.Size(145, 49);
            this.btnSnimiNovi.TabIndex = 24;
            this.btnSnimiNovi.Text = "Snimi";
            this.btnSnimiNovi.UseVisualStyleBackColor = true;
            this.btnSnimiNovi.Click += new System.EventHandler(this.btnSnimiNovi_Click);
            // 
            // chbStatusNovi
            // 
            this.chbStatusNovi.AutoSize = true;
            this.chbStatusNovi.Checked = true;
            this.chbStatusNovi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbStatusNovi.Location = new System.Drawing.Point(809, 300);
            this.chbStatusNovi.Name = "chbStatusNovi";
            this.chbStatusNovi.Size = new System.Drawing.Size(76, 21);
            this.chbStatusNovi.TabIndex = 21;
            this.chbStatusNovi.Text = "Aktivan";
            this.chbStatusNovi.UseVisualStyleBackColor = true;
            // 
            // txtPasswordPotvrdaNovi
            // 
            this.txtPasswordPotvrdaNovi.Location = new System.Drawing.Point(637, 236);
            this.txtPasswordPotvrdaNovi.Name = "txtPasswordPotvrdaNovi";
            this.txtPasswordPotvrdaNovi.Size = new System.Drawing.Size(248, 22);
            this.txtPasswordPotvrdaNovi.TabIndex = 20;
            this.txtPasswordPotvrdaNovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtPasswordPotvrdaNovi_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(634, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Potvrada Passworda";
            // 
            // txtPasswordNovi
            // 
            this.txtPasswordNovi.Location = new System.Drawing.Point(637, 175);
            this.txtPasswordNovi.Name = "txtPasswordNovi";
            this.txtPasswordNovi.Size = new System.Drawing.Size(248, 22);
            this.txtPasswordNovi.TabIndex = 18;
            this.txtPasswordNovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtPasswordNovi_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(634, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(634, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Grad";
            // 
            // cmbGradNovi
            // 
            this.cmbGradNovi.FormattingEnabled = true;
            this.cmbGradNovi.Location = new System.Drawing.Point(637, 48);
            this.cmbGradNovi.Name = "cmbGradNovi";
            this.cmbGradNovi.Size = new System.Drawing.Size(251, 24);
            this.cmbGradNovi.TabIndex = 15;
            this.cmbGradNovi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbGradNovi.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGradNovi_Validating);
            // 
            // txtUsernameNovi
            // 
            this.txtUsernameNovi.Location = new System.Drawing.Point(637, 114);
            this.txtUsernameNovi.Name = "txtUsernameNovi";
            this.txtUsernameNovi.Size = new System.Drawing.Size(248, 22);
            this.txtUsernameNovi.TabIndex = 14;
            this.txtUsernameNovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsernameNovi_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Korisnicko Ime";
            // 
            // txtAdresaNovi
            // 
            this.txtAdresaNovi.Location = new System.Drawing.Point(367, 300);
            this.txtAdresaNovi.Name = "txtAdresaNovi";
            this.txtAdresaNovi.Size = new System.Drawing.Size(248, 22);
            this.txtAdresaNovi.TabIndex = 12;
            this.txtAdresaNovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresaNovi_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adresa";
            // 
            // txtTelefonNovi
            // 
            this.txtTelefonNovi.Location = new System.Drawing.Point(367, 234);
            this.txtTelefonNovi.Name = "txtTelefonNovi";
            this.txtTelefonNovi.Size = new System.Drawing.Size(248, 22);
            this.txtTelefonNovi.TabIndex = 10;
            this.txtTelefonNovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefonNovi_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefon";
            // 
            // txtEmailNovi
            // 
            this.txtEmailNovi.Location = new System.Drawing.Point(367, 175);
            this.txtEmailNovi.Name = "txtEmailNovi";
            this.txtEmailNovi.Size = new System.Drawing.Size(248, 22);
            this.txtEmailNovi.TabIndex = 8;
            this.txtEmailNovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmailNovi_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // txtPrezimeNovi
            // 
            this.txtPrezimeNovi.Location = new System.Drawing.Point(367, 114);
            this.txtPrezimeNovi.Name = "txtPrezimeNovi";
            this.txtPrezimeNovi.Size = new System.Drawing.Size(248, 22);
            this.txtPrezimeNovi.TabIndex = 6;
            this.txtPrezimeNovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezimeNovi_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime";
            // 
            // txtImeNovi
            // 
            this.txtImeNovi.Location = new System.Drawing.Point(367, 50);
            this.txtImeNovi.Name = "txtImeNovi";
            this.txtImeNovi.Size = new System.Drawing.Size(248, 22);
            this.txtImeNovi.TabIndex = 4;
            this.txtImeNovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtImeNovi_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Nekretnine.WinUI.Properties.Resources.no_Image;
            this.pictureBox3.InitialImage = global::Nekretnine.WinUI.Properties.Resources.no_Image;
            this.pictureBox3.Location = new System.Drawing.Point(19, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(321, 361);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // DetaljiKorisnika
            // 
            this.DetaljiKorisnika.Controls.Add(this.btnDodajSlikuDetalji);
            this.DetaljiKorisnika.Controls.Add(this.txtEmailDetalji);
            this.DetaljiKorisnika.Controls.Add(this.label20);
            this.DetaljiKorisnika.Controls.Add(this.btnSpremiDetalji);
            this.DetaljiKorisnika.Controls.Add(this.chbStatusDetalji);
            this.DetaljiKorisnika.Controls.Add(this.label19);
            this.DetaljiKorisnika.Controls.Add(this.dtpDatumRodjenjaDetalji);
            this.DetaljiKorisnika.Controls.Add(this.txtTelefonDetalji);
            this.DetaljiKorisnika.Controls.Add(this.label17);
            this.DetaljiKorisnika.Controls.Add(this.txtAdresaDetalji);
            this.DetaljiKorisnika.Controls.Add(this.label18);
            this.DetaljiKorisnika.Controls.Add(this.txtPrezimeDetalji);
            this.DetaljiKorisnika.Controls.Add(this.label16);
            this.DetaljiKorisnika.Controls.Add(this.txtImeDetalji);
            this.DetaljiKorisnika.Controls.Add(this.label15);
            this.DetaljiKorisnika.Controls.Add(this.pictureBox1);
            this.DetaljiKorisnika.Location = new System.Drawing.Point(4, 25);
            this.DetaljiKorisnika.Name = "DetaljiKorisnika";
            this.DetaljiKorisnika.Padding = new System.Windows.Forms.Padding(3);
            this.DetaljiKorisnika.Size = new System.Drawing.Size(906, 522);
            this.DetaljiKorisnika.TabIndex = 2;
            this.DetaljiKorisnika.Text = "Detalji Korisnika";
            this.DetaljiKorisnika.UseVisualStyleBackColor = true;
            this.DetaljiKorisnika.Click += new System.EventHandler(this.DetaljiKorisnika_Click);
            // 
            // btnDodajSlikuDetalji
            // 
            this.btnDodajSlikuDetalji.Location = new System.Drawing.Point(135, 418);
            this.btnDodajSlikuDetalji.Name = "btnDodajSlikuDetalji";
            this.btnDodajSlikuDetalji.Size = new System.Drawing.Size(126, 28);
            this.btnDodajSlikuDetalji.TabIndex = 15;
            this.btnDodajSlikuDetalji.Text = "Dodaj Sliku";
            this.btnDodajSlikuDetalji.UseVisualStyleBackColor = true;
            this.btnDodajSlikuDetalji.Click += new System.EventHandler(this.btnDodajSlikuDetalji_Click);
            // 
            // txtEmailDetalji
            // 
            this.txtEmailDetalji.Location = new System.Drawing.Point(450, 312);
            this.txtEmailDetalji.Name = "txtEmailDetalji";
            this.txtEmailDetalji.Size = new System.Drawing.Size(271, 22);
            this.txtEmailDetalji.TabIndex = 14;
            this.txtEmailDetalji.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmailDetalji_Validating);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(447, 292);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 17);
            this.label20.TabIndex = 13;
            this.label20.Text = "Email";
            // 
            // btnSpremiDetalji
            // 
            this.btnSpremiDetalji.Location = new System.Drawing.Point(612, 410);
            this.btnSpremiDetalji.Name = "btnSpremiDetalji";
            this.btnSpremiDetalji.Size = new System.Drawing.Size(108, 33);
            this.btnSpremiDetalji.TabIndex = 12;
            this.btnSpremiDetalji.Text = "Spremi";
            this.btnSpremiDetalji.UseVisualStyleBackColor = true;
            this.btnSpremiDetalji.Click += new System.EventHandler(this.btnSpremiDetalji_Click);
            // 
            // chbStatusDetalji
            // 
            this.chbStatusDetalji.AutoSize = true;
            this.chbStatusDetalji.Checked = true;
            this.chbStatusDetalji.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbStatusDetalji.Location = new System.Drawing.Point(450, 420);
            this.chbStatusDetalji.Name = "chbStatusDetalji";
            this.chbStatusDetalji.Size = new System.Drawing.Size(76, 21);
            this.chbStatusDetalji.TabIndex = 11;
            this.chbStatusDetalji.Text = "Aktivan";
            this.chbStatusDetalji.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(447, 350);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 17);
            this.label19.TabIndex = 10;
            this.label19.Text = "Datum Rodjenja";
            // 
            // dtpDatumRodjenjaDetalji
            // 
            this.dtpDatumRodjenjaDetalji.Location = new System.Drawing.Point(450, 370);
            this.dtpDatumRodjenjaDetalji.Name = "dtpDatumRodjenjaDetalji";
            this.dtpDatumRodjenjaDetalji.Size = new System.Drawing.Size(271, 22);
            this.dtpDatumRodjenjaDetalji.TabIndex = 9;
            // 
            // txtTelefonDetalji
            // 
            this.txtTelefonDetalji.Location = new System.Drawing.Point(450, 252);
            this.txtTelefonDetalji.Name = "txtTelefonDetalji";
            this.txtTelefonDetalji.Size = new System.Drawing.Size(271, 22);
            this.txtTelefonDetalji.TabIndex = 8;
            this.txtTelefonDetalji.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefonDetalji_Validating);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(447, 232);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 17);
            this.label17.TabIndex = 7;
            this.label17.Text = "Telefon";
            // 
            // txtAdresaDetalji
            // 
            this.txtAdresaDetalji.Location = new System.Drawing.Point(450, 191);
            this.txtAdresaDetalji.Name = "txtAdresaDetalji";
            this.txtAdresaDetalji.Size = new System.Drawing.Size(271, 22);
            this.txtAdresaDetalji.TabIndex = 6;
            this.txtAdresaDetalji.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresaDetalji_Validating);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(447, 171);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 17);
            this.label18.TabIndex = 5;
            this.label18.Text = "Adresa";
            // 
            // txtPrezimeDetalji
            // 
            this.txtPrezimeDetalji.Location = new System.Drawing.Point(450, 128);
            this.txtPrezimeDetalji.Name = "txtPrezimeDetalji";
            this.txtPrezimeDetalji.Size = new System.Drawing.Size(271, 22);
            this.txtPrezimeDetalji.TabIndex = 4;
            this.txtPrezimeDetalji.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezimeDetalji_Validating);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(447, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 17);
            this.label16.TabIndex = 3;
            this.label16.Text = "Prezime";
            // 
            // txtImeDetalji
            // 
            this.txtImeDetalji.Location = new System.Drawing.Point(450, 63);
            this.txtImeDetalji.Name = "txtImeDetalji";
            this.txtImeDetalji.Size = new System.Drawing.Size(271, 22);
            this.txtImeDetalji.TabIndex = 2;
            this.txtImeDetalji.Validating += new System.ComponentModel.CancelEventHandler(this.txtImeDetalji_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(447, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Ime";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nekretnine.WinUI.Properties.Resources.no_Image;
            this.pictureBox1.Location = new System.Drawing.Point(40, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 586);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKorisnici";
            this.Text = "frmKorisnici";
            this.Load += new System.EventHandler(this.frmKorisnici_Load);
            this.tabControl1.ResumeLayout(false);
            this.listaKorisnika.ResumeLayout(false);
            this.listaKorisnika.PerformLayout();
            this.Korisnici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.NoviKorisnik.ResumeLayout(false);
            this.NoviKorisnik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.DetaljiKorisnika.ResumeLayout(false);
            this.DetaljiKorisnika.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage listaKorisnika;
        private System.Windows.Forms.TabPage NoviKorisnik;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtImeNovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrezimeNovi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsernameNovi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdresaNovi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefonNovi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailNovi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGradNovi;
        private System.Windows.Forms.TextBox txtPasswordNovi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chbStatusNovi;
        private System.Windows.Forms.TextBox txtPasswordPotvrdaNovi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Button btnSnimiNovi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenjaNovi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox Korisnici;
        private System.Windows.Forms.TextBox txtImeLista;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chbAktivanLista;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.ComboBox cmbGradLista;
        private System.Windows.Forms.TextBox txtEmailLista;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPrezimelista;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.TabPage DetaljiKorisnika;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSpremiDetalji;
        private System.Windows.Forms.CheckBox chbStatusDetalji;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenjaDetalji;
        private System.Windows.Forms.TextBox txtTelefonDetalji;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAdresaDetalji;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPrezimeDetalji;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtImeDetalji;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmailDetalji;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnDodajSlikuDetalji;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}