namespace Nekretnine.WinUI.Klijenti
{
    partial class frmKlijenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKlijenti));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            this.KlijentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGrad = new System.Windows.Forms.ComboBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DetaljiKlijentaa = new System.Windows.Forms.TabPage();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.chbAktivan = new System.Windows.Forms.CheckBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.txtTelefon1 = new System.Windows.Forms.TextBox();
            this.txtAdresa1 = new System.Windows.Forms.TextBox();
            this.txtPrezime1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIme1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NoviKlijent = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbGradNovi = new System.Windows.Forms.ComboBox();
            this.txtPotvrdaPaassworda = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.btnDodajSlikuNovi = new System.Windows.Forms.Button();
            this.chbAktivanNovi = new System.Windows.Forms.CheckBox();
            this.btnSpremiNovi = new System.Windows.Forms.Button();
            this.txtEmailNovi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAdresaNovi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpDatumRodjenjaNovi = new System.Windows.Forms.DateTimePicker();
            this.txtTelefonNovi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrezimeNovi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtImeNovi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtUsernameNovi = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            this.DetaljiKlijentaa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.NoviKlijent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.DetaljiKlijentaa);
            this.tabControl1.Controls.Add(this.NoviKlijent);
            this.tabControl1.Location = new System.Drawing.Point(11, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 596);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnPrikazi);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbGrad);
            this.tabPage1.Controls.Add(this.txtPrezime);
            this.tabPage1.Controls.Add(this.txtIme);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista Klijenata";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKlijenti);
            this.groupBox1.Location = new System.Drawing.Point(21, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 285);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klijenti";
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.AllowUserToAddRows = false;
            this.dgvKlijenti.AllowUserToDeleteRows = false;
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KlijentId,
            this.Ime,
            this.Prezime,
            this.Email,
            this.Telefon,
            this.DatumRodjenja});
            this.dgvKlijenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKlijenti.Location = new System.Drawing.Point(3, 18);
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.ReadOnly = true;
            this.dgvKlijenti.RowTemplate.Height = 24;
            this.dgvKlijenti.Size = new System.Drawing.Size(871, 264);
            this.dgvKlijenti.TabIndex = 0;
            this.dgvKlijenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKlijenti_CellContentClick);
            this.dgvKlijenti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKlijenti_MouseDoubleClick);
            // 
            // KlijentId
            // 
            this.KlijentId.DataPropertyName = "KlijentId";
            this.KlijentId.HeaderText = "KlijentId";
            this.KlijentId.Name = "KlijentId";
            this.KlijentId.ReadOnly = true;
            this.KlijentId.Visible = false;
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
            this.Email.Width = 150;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            this.Telefon.Width = 109;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "DatumRodjenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            this.DatumRodjenja.Width = 150;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(685, 139);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(129, 42);
            this.btnPrikazi.TabIndex = 9;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(389, 71);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // cmbGrad
            // 
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Location = new System.Drawing.Point(389, 149);
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(214, 24);
            this.cmbGrad.TabIndex = 6;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(46, 149);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(214, 22);
            this.txtPrezime.TabIndex = 5;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(46, 71);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(214, 22);
            this.txtIme.TabIndex = 4;
            this.txtIme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DetaljiKlijentaa
            // 
            this.DetaljiKlijentaa.Controls.Add(this.dtpDatumRodjenja);
            this.DetaljiKlijentaa.Controls.Add(this.btnSacuvaj);
            this.DetaljiKlijentaa.Controls.Add(this.chbAktivan);
            this.DetaljiKlijentaa.Controls.Add(this.btnDodajSliku);
            this.DetaljiKlijentaa.Controls.Add(this.label10);
            this.DetaljiKlijentaa.Controls.Add(this.label9);
            this.DetaljiKlijentaa.Controls.Add(this.label8);
            this.DetaljiKlijentaa.Controls.Add(this.label7);
            this.DetaljiKlijentaa.Controls.Add(this.txtEmail1);
            this.DetaljiKlijentaa.Controls.Add(this.txtTelefon1);
            this.DetaljiKlijentaa.Controls.Add(this.txtAdresa1);
            this.DetaljiKlijentaa.Controls.Add(this.txtPrezime1);
            this.DetaljiKlijentaa.Controls.Add(this.label6);
            this.DetaljiKlijentaa.Controls.Add(this.txtIme1);
            this.DetaljiKlijentaa.Controls.Add(this.label5);
            this.DetaljiKlijentaa.Controls.Add(this.pictureBox1);
            this.DetaljiKlijentaa.Location = new System.Drawing.Point(4, 25);
            this.DetaljiKlijentaa.Name = "DetaljiKlijentaa";
            this.DetaljiKlijentaa.Padding = new System.Windows.Forms.Padding(3);
            this.DetaljiKlijentaa.Size = new System.Drawing.Size(904, 567);
            this.DetaljiKlijentaa.TabIndex = 1;
            this.DetaljiKlijentaa.Text = "Detalji Klijenta";
            this.DetaljiKlijentaa.UseVisualStyleBackColor = true;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(463, 376);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(234, 22);
            this.dtpDatumRodjenja.TabIndex = 17;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(608, 422);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(89, 25);
            this.btnSacuvaj.TabIndex = 16;
            this.btnSacuvaj.Text = "Spremi";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // chbAktivan
            // 
            this.chbAktivan.AutoSize = true;
            this.chbAktivan.Location = new System.Drawing.Point(463, 422);
            this.chbAktivan.Name = "chbAktivan";
            this.chbAktivan.Size = new System.Drawing.Size(76, 21);
            this.chbAktivan.TabIndex = 15;
            this.chbAktivan.Text = "Aktivan";
            this.chbAktivan.UseVisualStyleBackColor = true;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(147, 422);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(101, 26);
            this.btnDodajSliku.TabIndex = 14;
            this.btnDodajSliku.Text = "Dodaj Sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(460, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Datum rođenja";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Telefon";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Adresa";
            // 
            // txtEmail1
            // 
            this.txtEmail1.Location = new System.Drawing.Point(463, 312);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(234, 22);
            this.txtEmail1.TabIndex = 8;
            this.txtEmail1.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail1_Validating);
            // 
            // txtTelefon1
            // 
            this.txtTelefon1.Location = new System.Drawing.Point(463, 254);
            this.txtTelefon1.Name = "txtTelefon1";
            this.txtTelefon1.Size = new System.Drawing.Size(234, 22);
            this.txtTelefon1.TabIndex = 7;
            this.txtTelefon1.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefon1_Validating);
            // 
            // txtAdresa1
            // 
            this.txtAdresa1.Location = new System.Drawing.Point(463, 185);
            this.txtAdresa1.Name = "txtAdresa1";
            this.txtAdresa1.Size = new System.Drawing.Size(234, 22);
            this.txtAdresa1.TabIndex = 6;
            this.txtAdresa1.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresa1_Validating);
            // 
            // txtPrezime1
            // 
            this.txtPrezime1.Location = new System.Drawing.Point(463, 119);
            this.txtPrezime1.Name = "txtPrezime1";
            this.txtPrezime1.Size = new System.Drawing.Size(234, 22);
            this.txtPrezime1.TabIndex = 5;
            this.txtPrezime1.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime1_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Prezime";
            // 
            // txtIme1
            // 
            this.txtIme1.Location = new System.Drawing.Point(463, 61);
            this.txtIme1.Name = "txtIme1";
            this.txtIme1.Size = new System.Drawing.Size(234, 22);
            this.txtIme1.TabIndex = 3;
            this.txtIme1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.txtIme1.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme1_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ime";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nekretnine.WinUI.Properties.Resources.no_Image;
            this.pictureBox1.Location = new System.Drawing.Point(35, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // NoviKlijent
            // 
            this.NoviKlijent.Controls.Add(this.txtUsernameNovi);
            this.NoviKlijent.Controls.Add(this.label19);
            this.NoviKlijent.Controls.Add(this.label18);
            this.NoviKlijent.Controls.Add(this.cmbGradNovi);
            this.NoviKlijent.Controls.Add(this.txtPotvrdaPaassworda);
            this.NoviKlijent.Controls.Add(this.label17);
            this.NoviKlijent.Controls.Add(this.txtPassword);
            this.NoviKlijent.Controls.Add(this.Password);
            this.NoviKlijent.Controls.Add(this.btnDodajSlikuNovi);
            this.NoviKlijent.Controls.Add(this.chbAktivanNovi);
            this.NoviKlijent.Controls.Add(this.btnSpremiNovi);
            this.NoviKlijent.Controls.Add(this.txtEmailNovi);
            this.NoviKlijent.Controls.Add(this.label16);
            this.NoviKlijent.Controls.Add(this.txtAdresaNovi);
            this.NoviKlijent.Controls.Add(this.label15);
            this.NoviKlijent.Controls.Add(this.label14);
            this.NoviKlijent.Controls.Add(this.dtpDatumRodjenjaNovi);
            this.NoviKlijent.Controls.Add(this.txtTelefonNovi);
            this.NoviKlijent.Controls.Add(this.label13);
            this.NoviKlijent.Controls.Add(this.txtPrezimeNovi);
            this.NoviKlijent.Controls.Add(this.label12);
            this.NoviKlijent.Controls.Add(this.txtImeNovi);
            this.NoviKlijent.Controls.Add(this.label11);
            this.NoviKlijent.Controls.Add(this.pictureBox2);
            this.NoviKlijent.Location = new System.Drawing.Point(4, 25);
            this.NoviKlijent.Name = "NoviKlijent";
            this.NoviKlijent.Padding = new System.Windows.Forms.Padding(3);
            this.NoviKlijent.Size = new System.Drawing.Size(904, 567);
            this.NoviKlijent.TabIndex = 2;
            this.NoviKlijent.Text = "Novi Klijent";
            this.NoviKlijent.UseVisualStyleBackColor = true;
            this.NoviKlijent.Click += new System.EventHandler(this.NoviKlijent_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(646, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 17);
            this.label18.TabIndex = 21;
            this.label18.Text = "Grad";
            // 
            // cmbGradNovi
            // 
            this.cmbGradNovi.FormattingEnabled = true;
            this.cmbGradNovi.Location = new System.Drawing.Point(649, 59);
            this.cmbGradNovi.Name = "cmbGradNovi";
            this.cmbGradNovi.Size = new System.Drawing.Size(231, 24);
            this.cmbGradNovi.TabIndex = 20;
            this.cmbGradNovi.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGradNovi_Validating);
            // 
            // txtPotvrdaPaassworda
            // 
            this.txtPotvrdaPaassworda.Location = new System.Drawing.Point(649, 239);
            this.txtPotvrdaPaassworda.Name = "txtPotvrdaPaassworda";
            this.txtPotvrdaPaassworda.Size = new System.Drawing.Size(231, 22);
            this.txtPotvrdaPaassworda.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(646, 219);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 17);
            this.label17.TabIndex = 18;
            this.label17.Text = "Potvrda Passworda";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(649, 178);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(231, 22);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(646, 159);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(69, 17);
            this.Password.TabIndex = 16;
            this.Password.Text = "Password";
            // 
            // btnDodajSlikuNovi
            // 
            this.btnDodajSlikuNovi.Location = new System.Drawing.Point(137, 418);
            this.btnDodajSlikuNovi.Name = "btnDodajSlikuNovi";
            this.btnDodajSlikuNovi.Size = new System.Drawing.Size(126, 33);
            this.btnDodajSlikuNovi.TabIndex = 15;
            this.btnDodajSlikuNovi.Text = "Dodaj Sliku";
            this.btnDodajSlikuNovi.UseVisualStyleBackColor = true;
            this.btnDodajSlikuNovi.Click += new System.EventHandler(this.btnDodajSlikuNovi_Click);
            // 
            // chbAktivanNovi
            // 
            this.chbAktivanNovi.AutoSize = true;
            this.chbAktivanNovi.Location = new System.Drawing.Point(804, 296);
            this.chbAktivanNovi.Name = "chbAktivanNovi";
            this.chbAktivanNovi.Size = new System.Drawing.Size(76, 21);
            this.chbAktivanNovi.TabIndex = 14;
            this.chbAktivanNovi.Text = "Aktivan";
            this.chbAktivanNovi.UseVisualStyleBackColor = true;
            // 
            // btnSpremiNovi
            // 
            this.btnSpremiNovi.Location = new System.Drawing.Point(746, 347);
            this.btnSpremiNovi.Name = "btnSpremiNovi";
            this.btnSpremiNovi.Size = new System.Drawing.Size(146, 43);
            this.btnSpremiNovi.TabIndex = 13;
            this.btnSpremiNovi.Text = "Spremi";
            this.btnSpremiNovi.UseVisualStyleBackColor = true;
            this.btnSpremiNovi.Click += new System.EventHandler(this.btnSpremiNovi_Click);
            // 
            // txtEmailNovi
            // 
            this.txtEmailNovi.Location = new System.Drawing.Point(383, 357);
            this.txtEmailNovi.Name = "txtEmailNovi";
            this.txtEmailNovi.Size = new System.Drawing.Size(231, 22);
            this.txtEmailNovi.TabIndex = 12;
            this.txtEmailNovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmailNovi_Validating);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(380, 337);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 17);
            this.label16.TabIndex = 11;
            this.label16.Text = "Email";
            // 
            // txtAdresaNovi
            // 
            this.txtAdresaNovi.Location = new System.Drawing.Point(383, 294);
            this.txtAdresaNovi.Name = "txtAdresaNovi";
            this.txtAdresaNovi.Size = new System.Drawing.Size(231, 22);
            this.txtAdresaNovi.TabIndex = 10;
            this.txtAdresaNovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresaNovi_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(380, 274);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 17);
            this.label15.TabIndex = 9;
            this.label15.Text = "Adresa";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(380, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Datum Rođenja";
            // 
            // dtpDatumRodjenjaNovi
            // 
            this.dtpDatumRodjenjaNovi.Location = new System.Drawing.Point(383, 177);
            this.dtpDatumRodjenjaNovi.Name = "dtpDatumRodjenjaNovi";
            this.dtpDatumRodjenjaNovi.Size = new System.Drawing.Size(231, 22);
            this.dtpDatumRodjenjaNovi.TabIndex = 7;
            // 
            // txtTelefonNovi
            // 
            this.txtTelefonNovi.Location = new System.Drawing.Point(383, 235);
            this.txtTelefonNovi.Name = "txtTelefonNovi";
            this.txtTelefonNovi.Size = new System.Drawing.Size(231, 22);
            this.txtTelefonNovi.TabIndex = 6;
            this.txtTelefonNovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefonNovi_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(380, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "Telefon";
            // 
            // txtPrezimeNovi
            // 
            this.txtPrezimeNovi.Location = new System.Drawing.Point(383, 119);
            this.txtPrezimeNovi.Name = "txtPrezimeNovi";
            this.txtPrezimeNovi.Size = new System.Drawing.Size(231, 22);
            this.txtPrezimeNovi.TabIndex = 4;
            this.txtPrezimeNovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezimeNovi_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(380, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Prezime";
            // 
            // txtImeNovi
            // 
            this.txtImeNovi.Location = new System.Drawing.Point(383, 59);
            this.txtImeNovi.Name = "txtImeNovi";
            this.txtImeNovi.Size = new System.Drawing.Size(231, 22);
            this.txtImeNovi.TabIndex = 2;
            this.txtImeNovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtImeNovi_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(380, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Ime";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = global::Nekretnine.WinUI.Properties.Resources.no_Image;
            this.pictureBox2.Location = new System.Drawing.Point(25, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(321, 361);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtUsernameNovi
            // 
            this.txtUsernameNovi.Location = new System.Drawing.Point(649, 129);
            this.txtUsernameNovi.Name = "txtUsernameNovi";
            this.txtUsernameNovi.Size = new System.Drawing.Size(231, 22);
            this.txtUsernameNovi.TabIndex = 23;
            this.txtUsernameNovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsernameNovi_Validating);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(646, 110);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 17);
            this.label19.TabIndex = 22;
            this.label19.Text = "Korisnicko Ime";
            // 
            // frmKlijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 608);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKlijenti";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmKlijenti_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            this.DetaljiKlijentaa.ResumeLayout(false);
            this.DetaljiKlijentaa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.NoviKlijent.ResumeLayout(false);
            this.NoviKlijent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage DetaljiKlijentaa;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrad;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIme1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.TextBox txtTelefon1;
        private System.Windows.Forms.TextBox txtAdresa1;
        private System.Windows.Forms.TextBox txtPrezime1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chbAktivan;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TabPage NoviKlijent;
        private System.Windows.Forms.Button btnDodajSlikuNovi;
        private System.Windows.Forms.CheckBox chbAktivanNovi;
        private System.Windows.Forms.Button btnSpremiNovi;
        private System.Windows.Forms.TextBox txtEmailNovi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAdresaNovi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenjaNovi;
        private System.Windows.Forms.TextBox txtTelefonNovi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPrezimeNovi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtImeNovi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPotvrdaPaassworda;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbGradNovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.TextBox txtUsernameNovi;
        private System.Windows.Forms.Label label19;
    }
}