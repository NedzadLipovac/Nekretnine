namespace Nekretnine.WinUI.Nekretnine
{
    partial class frmNekretnine
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
            this.listaNekretnina = new System.Windows.Forms.TabPage();
            this.cmbGrad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKvadrataOd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikaziNekretnine = new System.Windows.Forms.Button();
            this.Nekretnine = new System.Windows.Forms.GroupBox();
            this.dgvNekretnine = new System.Windows.Forms.DataGridView();
            this.NekretninaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vlasnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaIzgradnje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kvadratura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prodaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSpasiNovi = new System.Windows.Forms.Button();
            this.chbProdajaNovi = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGradNovi = new System.Windows.Forms.ComboBox();
            this.txtGodinaIzgradnjeNovi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKvadraturaNovi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVlasnikNovi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdresaNovi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNazivNovi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DetaljiNekretnine = new System.Windows.Forms.TabPage();
            this.btnSpremiDetalji = new System.Windows.Forms.Button();
            this.chbProdajaDetalji = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbGradDetalji = new System.Windows.Forms.ComboBox();
            this.txtGodinaIzgradnjeDetalji = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVlasnikDetalji = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKvadraturaDetalji = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAdresaDetalji = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNazivDetalji = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SlikeNekretnine = new System.Windows.Forms.TabPage();
            this.btnSpremiSliku = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.selectedImage = new System.Windows.Forms.PictureBox();
            this.imageList = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.listaNekretnina.SuspendLayout();
            this.Nekretnine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNekretnine)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.DetaljiNekretnine.SuspendLayout();
            this.SlikeNekretnine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.listaNekretnina);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.DetaljiNekretnine);
            this.tabControl1.Controls.Add(this.SlikeNekretnine);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(905, 593);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Validating += new System.ComponentModel.CancelEventHandler(this.tabControl1_Validating);
            // 
            // listaNekretnina
            // 
            this.listaNekretnina.Controls.Add(this.cmbGrad);
            this.listaNekretnina.Controls.Add(this.label2);
            this.listaNekretnina.Controls.Add(this.txtKvadrataOd);
            this.listaNekretnina.Controls.Add(this.label1);
            this.listaNekretnina.Controls.Add(this.btnPrikaziNekretnine);
            this.listaNekretnina.Controls.Add(this.Nekretnine);
            this.listaNekretnina.Location = new System.Drawing.Point(4, 25);
            this.listaNekretnina.Name = "listaNekretnina";
            this.listaNekretnina.Padding = new System.Windows.Forms.Padding(3);
            this.listaNekretnina.Size = new System.Drawing.Size(897, 564);
            this.listaNekretnina.TabIndex = 0;
            this.listaNekretnina.Text = "Lista Nekretnina";
            this.listaNekretnina.UseVisualStyleBackColor = true;
            // 
            // cmbGrad
            // 
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Location = new System.Drawing.Point(159, 88);
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(235, 24);
            this.cmbGrad.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grad";
            // 
            // txtKvadrataOd
            // 
            this.txtKvadrataOd.Location = new System.Drawing.Point(159, 46);
            this.txtKvadrataOd.Name = "txtKvadrataOd";
            this.txtKvadrataOd.Size = new System.Drawing.Size(235, 22);
            this.txtKvadrataOd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kvadrata od:";
            // 
            // btnPrikaziNekretnine
            // 
            this.btnPrikaziNekretnine.Location = new System.Drawing.Point(719, 88);
            this.btnPrikaziNekretnine.Name = "btnPrikaziNekretnine";
            this.btnPrikaziNekretnine.Size = new System.Drawing.Size(91, 29);
            this.btnPrikaziNekretnine.TabIndex = 1;
            this.btnPrikaziNekretnine.Text = "Prikazi";
            this.btnPrikaziNekretnine.UseVisualStyleBackColor = true;
            this.btnPrikaziNekretnine.Click += new System.EventHandler(this.btnPrikaziNekretnine_Click);
            // 
            // Nekretnine
            // 
            this.Nekretnine.Controls.Add(this.dgvNekretnine);
            this.Nekretnine.Location = new System.Drawing.Point(3, 158);
            this.Nekretnine.Name = "Nekretnine";
            this.Nekretnine.Size = new System.Drawing.Size(894, 358);
            this.Nekretnine.TabIndex = 0;
            this.Nekretnine.TabStop = false;
            this.Nekretnine.Text = "Nekretnine";
            // 
            // dgvNekretnine
            // 
            this.dgvNekretnine.AllowUserToAddRows = false;
            this.dgvNekretnine.AllowUserToDeleteRows = false;
            this.dgvNekretnine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNekretnine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NekretninaId,
            this.Adresa,
            this.Naziv,
            this.Grad,
            this.Vlasnik,
            this.GodinaIzgradnje,
            this.Kvadratura,
            this.Prodaja});
            this.dgvNekretnine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNekretnine.Location = new System.Drawing.Point(3, 18);
            this.dgvNekretnine.Name = "dgvNekretnine";
            this.dgvNekretnine.ReadOnly = true;
            this.dgvNekretnine.RowTemplate.Height = 24;
            this.dgvNekretnine.Size = new System.Drawing.Size(888, 337);
            this.dgvNekretnine.TabIndex = 0;
            this.dgvNekretnine.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvNekretnine_MouseDoubleClick);
            // 
            // NekretninaId
            // 
            this.NekretninaId.DataPropertyName = "NekretninaId";
            this.NekretninaId.HeaderText = "NekretninaId";
            this.NekretninaId.Name = "NekretninaId";
            this.NekretninaId.ReadOnly = true;
            this.NekretninaId.Visible = false;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Grad
            // 
            this.Grad.DataPropertyName = "Grad";
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            // 
            // Vlasnik
            // 
            this.Vlasnik.DataPropertyName = "Vlasnik";
            this.Vlasnik.HeaderText = "Vlasnik";
            this.Vlasnik.Name = "Vlasnik";
            this.Vlasnik.ReadOnly = true;
            // 
            // GodinaIzgradnje
            // 
            this.GodinaIzgradnje.DataPropertyName = "GodinaIzgradnje";
            this.GodinaIzgradnje.HeaderText = "GodinaIzgradnje";
            this.GodinaIzgradnje.Name = "GodinaIzgradnje";
            this.GodinaIzgradnje.ReadOnly = true;
            // 
            // Kvadratura
            // 
            this.Kvadratura.DataPropertyName = "Kvadratura";
            this.Kvadratura.HeaderText = "Kvadratura";
            this.Kvadratura.Name = "Kvadratura";
            this.Kvadratura.ReadOnly = true;
            // 
            // Prodaja
            // 
            this.Prodaja.DataPropertyName = "Prodaja";
            this.Prodaja.HeaderText = "Prodaja";
            this.Prodaja.Name = "Prodaja";
            this.Prodaja.ReadOnly = true;
            this.Prodaja.Width = 70;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSpasiNovi);
            this.tabPage2.Controls.Add(this.chbProdajaNovi);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.cmbGradNovi);
            this.tabPage2.Controls.Add(this.txtGodinaIzgradnjeNovi);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtKvadraturaNovi);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtVlasnikNovi);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtAdresaNovi);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtNazivNovi);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(897, 564);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nova Nekretnina";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSpasiNovi
            // 
            this.btnSpasiNovi.Location = new System.Drawing.Point(753, 109);
            this.btnSpasiNovi.Name = "btnSpasiNovi";
            this.btnSpasiNovi.Size = new System.Drawing.Size(94, 31);
            this.btnSpasiNovi.TabIndex = 13;
            this.btnSpasiNovi.Text = "Spremi";
            this.btnSpasiNovi.UseVisualStyleBackColor = true;
            this.btnSpasiNovi.Click += new System.EventHandler(this.btnSpasiNovi_Click);
            // 
            // chbProdajaNovi
            // 
            this.chbProdajaNovi.AutoSize = true;
            this.chbProdajaNovi.Location = new System.Drawing.Point(587, 119);
            this.chbProdajaNovi.Name = "chbProdajaNovi";
            this.chbProdajaNovi.Size = new System.Drawing.Size(79, 21);
            this.chbProdajaNovi.TabIndex = 12;
            this.chbProdajaNovi.Text = "Prodaja";
            this.chbProdajaNovi.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(584, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Grad";
            // 
            // cmbGradNovi
            // 
            this.cmbGradNovi.FormattingEnabled = true;
            this.cmbGradNovi.Location = new System.Drawing.Point(587, 61);
            this.cmbGradNovi.Name = "cmbGradNovi";
            this.cmbGradNovi.Size = new System.Drawing.Size(261, 24);
            this.cmbGradNovi.TabIndex = 10;
            this.cmbGradNovi.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGradNovi_Validating);
            // 
            // txtGodinaIzgradnjeNovi
            // 
            this.txtGodinaIzgradnjeNovi.Location = new System.Drawing.Point(151, 301);
            this.txtGodinaIzgradnjeNovi.Name = "txtGodinaIzgradnjeNovi";
            this.txtGodinaIzgradnjeNovi.Size = new System.Drawing.Size(254, 22);
            this.txtGodinaIzgradnjeNovi.TabIndex = 9;
            this.txtGodinaIzgradnjeNovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtGodinaIzgradnjeNovi_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "GodinaIzgradnje";
            // 
            // txtKvadraturaNovi
            // 
            this.txtKvadraturaNovi.Location = new System.Drawing.Point(151, 238);
            this.txtKvadraturaNovi.Name = "txtKvadraturaNovi";
            this.txtKvadraturaNovi.Size = new System.Drawing.Size(254, 22);
            this.txtKvadraturaNovi.TabIndex = 7;
            this.txtKvadraturaNovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtKvadraturaNovi_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kvadratura";
            // 
            // txtVlasnikNovi
            // 
            this.txtVlasnikNovi.Location = new System.Drawing.Point(151, 176);
            this.txtVlasnikNovi.Name = "txtVlasnikNovi";
            this.txtVlasnikNovi.Size = new System.Drawing.Size(254, 22);
            this.txtVlasnikNovi.TabIndex = 5;
            this.txtVlasnikNovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtVlasnikNovi_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vlasnik";
            // 
            // txtAdresaNovi
            // 
            this.txtAdresaNovi.Location = new System.Drawing.Point(151, 119);
            this.txtAdresaNovi.Name = "txtAdresaNovi";
            this.txtAdresaNovi.Size = new System.Drawing.Size(254, 22);
            this.txtAdresaNovi.TabIndex = 3;
            this.txtAdresaNovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresaNovi_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adresa";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNazivNovi
            // 
            this.txtNazivNovi.Location = new System.Drawing.Point(151, 61);
            this.txtNazivNovi.Name = "txtNazivNovi";
            this.txtNazivNovi.Size = new System.Drawing.Size(254, 22);
            this.txtNazivNovi.TabIndex = 1;
            this.txtNazivNovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtNazivNovi_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Naziv";
            // 
            // DetaljiNekretnine
            // 
            this.DetaljiNekretnine.Controls.Add(this.btnSpremiDetalji);
            this.DetaljiNekretnine.Controls.Add(this.chbProdajaDetalji);
            this.DetaljiNekretnine.Controls.Add(this.label14);
            this.DetaljiNekretnine.Controls.Add(this.cmbGradDetalji);
            this.DetaljiNekretnine.Controls.Add(this.txtGodinaIzgradnjeDetalji);
            this.DetaljiNekretnine.Controls.Add(this.label13);
            this.DetaljiNekretnine.Controls.Add(this.txtVlasnikDetalji);
            this.DetaljiNekretnine.Controls.Add(this.label12);
            this.DetaljiNekretnine.Controls.Add(this.txtKvadraturaDetalji);
            this.DetaljiNekretnine.Controls.Add(this.label11);
            this.DetaljiNekretnine.Controls.Add(this.txtAdresaDetalji);
            this.DetaljiNekretnine.Controls.Add(this.label10);
            this.DetaljiNekretnine.Controls.Add(this.txtNazivDetalji);
            this.DetaljiNekretnine.Controls.Add(this.label9);
            this.DetaljiNekretnine.Location = new System.Drawing.Point(4, 25);
            this.DetaljiNekretnine.Name = "DetaljiNekretnine";
            this.DetaljiNekretnine.Padding = new System.Windows.Forms.Padding(3);
            this.DetaljiNekretnine.Size = new System.Drawing.Size(897, 564);
            this.DetaljiNekretnine.TabIndex = 2;
            this.DetaljiNekretnine.Text = "DetaljiNekretnine";
            this.DetaljiNekretnine.UseVisualStyleBackColor = true;
            // 
            // btnSpremiDetalji
            // 
            this.btnSpremiDetalji.Location = new System.Drawing.Point(656, 129);
            this.btnSpremiDetalji.Name = "btnSpremiDetalji";
            this.btnSpremiDetalji.Size = new System.Drawing.Size(113, 28);
            this.btnSpremiDetalji.TabIndex = 13;
            this.btnSpremiDetalji.Text = "Spremi";
            this.btnSpremiDetalji.UseVisualStyleBackColor = true;
            this.btnSpremiDetalji.Click += new System.EventHandler(this.btnSpremiDetalji_Click);
            // 
            // chbProdajaDetalji
            // 
            this.chbProdajaDetalji.AutoSize = true;
            this.chbProdajaDetalji.Location = new System.Drawing.Point(511, 129);
            this.chbProdajaDetalji.Name = "chbProdajaDetalji";
            this.chbProdajaDetalji.Size = new System.Drawing.Size(79, 21);
            this.chbProdajaDetalji.TabIndex = 12;
            this.chbProdajaDetalji.Text = "Prodaja";
            this.chbProdajaDetalji.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(508, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 17);
            this.label14.TabIndex = 11;
            this.label14.Text = "Grad";
            // 
            // cmbGradDetalji
            // 
            this.cmbGradDetalji.FormattingEnabled = true;
            this.cmbGradDetalji.Location = new System.Drawing.Point(508, 64);
            this.cmbGradDetalji.Name = "cmbGradDetalji";
            this.cmbGradDetalji.Size = new System.Drawing.Size(261, 24);
            this.cmbGradDetalji.TabIndex = 10;
            this.cmbGradDetalji.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGradDetalji_Validating);
            // 
            // txtGodinaIzgradnjeDetalji
            // 
            this.txtGodinaIzgradnjeDetalji.Location = new System.Drawing.Point(153, 312);
            this.txtGodinaIzgradnjeDetalji.Name = "txtGodinaIzgradnjeDetalji";
            this.txtGodinaIzgradnjeDetalji.Size = new System.Drawing.Size(272, 22);
            this.txtGodinaIzgradnjeDetalji.TabIndex = 9;
            this.txtGodinaIzgradnjeDetalji.Validating += new System.ComponentModel.CancelEventHandler(this.txtGodinaIzgradnjeDetalji_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(150, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "GodinaIzgradnje";
            // 
            // txtVlasnikDetalji
            // 
            this.txtVlasnikDetalji.Location = new System.Drawing.Point(153, 247);
            this.txtVlasnikDetalji.Name = "txtVlasnikDetalji";
            this.txtVlasnikDetalji.Size = new System.Drawing.Size(272, 22);
            this.txtVlasnikDetalji.TabIndex = 7;
            this.txtVlasnikDetalji.Validating += new System.ComponentModel.CancelEventHandler(this.txtVlasnikDetalji_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Vlasnik";
            // 
            // txtKvadraturaDetalji
            // 
            this.txtKvadraturaDetalji.Location = new System.Drawing.Point(153, 190);
            this.txtKvadraturaDetalji.Name = "txtKvadraturaDetalji";
            this.txtKvadraturaDetalji.Size = new System.Drawing.Size(272, 22);
            this.txtKvadraturaDetalji.TabIndex = 5;
            this.txtKvadraturaDetalji.Validating += new System.ComponentModel.CancelEventHandler(this.txtKvadraturaDetalji_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Kvadratura";
            // 
            // txtAdresaDetalji
            // 
            this.txtAdresaDetalji.Location = new System.Drawing.Point(153, 128);
            this.txtAdresaDetalji.Name = "txtAdresaDetalji";
            this.txtAdresaDetalji.Size = new System.Drawing.Size(272, 22);
            this.txtAdresaDetalji.TabIndex = 3;
            this.txtAdresaDetalji.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresaDetalji_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Adresa";
            // 
            // txtNazivDetalji
            // 
            this.txtNazivDetalji.Location = new System.Drawing.Point(153, 64);
            this.txtNazivDetalji.Name = "txtNazivDetalji";
            this.txtNazivDetalji.Size = new System.Drawing.Size(272, 22);
            this.txtNazivDetalji.TabIndex = 1;
            this.txtNazivDetalji.Validating += new System.ComponentModel.CancelEventHandler(this.txtNazivDetalji_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Naziv";
            // 
            // SlikeNekretnine
            // 
            this.SlikeNekretnine.Controls.Add(this.btnSpremiSliku);
            this.SlikeNekretnine.Controls.Add(this.label15);
            this.SlikeNekretnine.Controls.Add(this.btnDodajSliku);
            this.SlikeNekretnine.Controls.Add(this.txtSlikaInput);
            this.SlikeNekretnine.Controls.Add(this.selectedImage);
            this.SlikeNekretnine.Controls.Add(this.imageList);
            this.SlikeNekretnine.Location = new System.Drawing.Point(4, 25);
            this.SlikeNekretnine.Name = "SlikeNekretnine";
            this.SlikeNekretnine.Padding = new System.Windows.Forms.Padding(3);
            this.SlikeNekretnine.Size = new System.Drawing.Size(897, 564);
            this.SlikeNekretnine.TabIndex = 3;
            this.SlikeNekretnine.Text = "Slike";
            this.SlikeNekretnine.UseVisualStyleBackColor = true;
            // 
            // btnSpremiSliku
            // 
            this.btnSpremiSliku.Location = new System.Drawing.Point(668, 6);
            this.btnSpremiSliku.Name = "btnSpremiSliku";
            this.btnSpremiSliku.Size = new System.Drawing.Size(127, 30);
            this.btnSpremiSliku.TabIndex = 6;
            this.btnSpremiSliku.Text = "Spremi Sliku";
            this.btnSpremiSliku.UseVisualStyleBackColor = true;
            this.btnSpremiSliku.Click += new System.EventHandler(this.btnSpremiSliku_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "Slika";
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(490, 6);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(140, 30);
            this.btnDodajSliku.TabIndex = 4;
            this.btnDodajSliku.Text = "Dodaj Sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(62, 10);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(391, 22);
            this.txtSlikaInput.TabIndex = 3;
            // 
            // selectedImage
            // 
            this.selectedImage.Location = new System.Drawing.Point(246, 48);
            this.selectedImage.Name = "selectedImage";
            this.selectedImage.Size = new System.Drawing.Size(641, 456);
            this.selectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.selectedImage.TabIndex = 2;
            this.selectedImage.TabStop = false;
            // 
            // imageList
            // 
            this.imageList.Location = new System.Drawing.Point(3, 48);
            this.imageList.Name = "imageList";
            this.imageList.Size = new System.Drawing.Size(237, 456);
            this.imageList.TabIndex = 1;
            this.imageList.UseCompatibleStateImageBehavior = false;
            this.imageList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.imageList_ItemSelectionChanged);
            this.imageList.SelectedIndexChanged += new System.EventHandler(this.imageList_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmNekretnine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 566);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNekretnine";
            this.Text = "frmNekretnine";
            this.Load += new System.EventHandler(this.frmNekretnine_Load);
            this.tabControl1.ResumeLayout(false);
            this.listaNekretnina.ResumeLayout(false);
            this.listaNekretnina.PerformLayout();
            this.Nekretnine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNekretnine)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.DetaljiNekretnine.ResumeLayout(false);
            this.DetaljiNekretnine.PerformLayout();
            this.SlikeNekretnine.ResumeLayout(false);
            this.SlikeNekretnine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage listaNekretnina;
        private System.Windows.Forms.GroupBox Nekretnine;
        private System.Windows.Forms.DataGridView dgvNekretnine;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbGrad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKvadrataOd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikaziNekretnine;
        private System.Windows.Forms.DataGridViewTextBoxColumn NekretninaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vlasnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaIzgradnje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kvadratura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prodaja;
        private System.Windows.Forms.TextBox txtNazivNovi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdresaNovi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSpasiNovi;
        private System.Windows.Forms.CheckBox chbProdajaNovi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGradNovi;
        private System.Windows.Forms.TextBox txtGodinaIzgradnjeNovi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKvadraturaNovi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVlasnikNovi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage DetaljiNekretnine;
        private System.Windows.Forms.TextBox txtGodinaIzgradnjeDetalji;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtVlasnikDetalji;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtKvadraturaDetalji;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAdresaDetalji;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNazivDetalji;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSpremiDetalji;
        private System.Windows.Forms.CheckBox chbProdajaDetalji;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbGradDetalji;
        private System.Windows.Forms.TabPage SlikeNekretnine;
        private System.Windows.Forms.PictureBox selectedImage;
        private System.Windows.Forms.ListView imageList;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.TextBox txtSlikaInput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSpremiSliku;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}