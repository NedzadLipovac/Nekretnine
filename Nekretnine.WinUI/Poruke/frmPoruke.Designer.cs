namespace Nekretnine.WinUI.Poruke
{
    partial class frmPoruke
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtImePosiljaoca = new System.Windows.Forms.TextBox();
            this.txtPrezimePosiljaoca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserNamePosiljaoca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNaslovPrimljene = new System.Windows.Forms.Label();
            this.lblPosiljaoc = new System.Windows.Forms.Label();
            this.lblDatumIVrijemePrimljene = new System.Windows.Forms.Label();
            this.btnOdgovori = new System.Windows.Forms.Button();
            this.txtSadrzajPrimljene = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPrimljenePoruke = new System.Windows.Forms.DataGridView();
            this.PorukaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posiljaoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblNaslovPoslane = new System.Windows.Forms.Label();
            this.lblKlijentPoslane = new System.Windows.Forms.Label();
            this.lblDatumVrijemePoslane = new System.Windows.Forms.Label();
            this.txtSadrzajPoslane = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPoslanePoruke = new System.Windows.Forms.DataGridView();
            this.PorukaId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Primaoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFiltrirajPrimaoce = new System.Windows.Forms.Button();
            this.txtPrezimePoslan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUserNamePoslan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtImePoslan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNovaPorukaNoviKlijent = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimljenePoruke)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslanePoruke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime pošiljaoca";
            // 
            // txtImePosiljaoca
            // 
            this.txtImePosiljaoca.Location = new System.Drawing.Point(25, 47);
            this.txtImePosiljaoca.Name = "txtImePosiljaoca";
            this.txtImePosiljaoca.Size = new System.Drawing.Size(280, 22);
            this.txtImePosiljaoca.TabIndex = 1;
            // 
            // txtPrezimePosiljaoca
            // 
            this.txtPrezimePosiljaoca.Location = new System.Drawing.Point(401, 47);
            this.txtPrezimePosiljaoca.Name = "txtPrezimePosiljaoca";
            this.txtPrezimePosiljaoca.Size = new System.Drawing.Size(272, 22);
            this.txtPrezimePosiljaoca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime pošiljaoca";
            // 
            // txtUserNamePosiljaoca
            // 
            this.txtUserNamePosiljaoca.Location = new System.Drawing.Point(25, 118);
            this.txtUserNamePosiljaoca.Name = "txtUserNamePosiljaoca";
            this.txtUserNamePosiljaoca.Size = new System.Drawing.Size(280, 22);
            this.txtUserNamePosiljaoca.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username pošiljaoca";
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltriraj.Location = new System.Drawing.Point(546, 111);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(127, 29);
            this.btnFiltriraj.TabIndex = 6;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 611);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnFiltriraj);
            this.tabPage1.Controls.Add(this.txtImePosiljaoca);
            this.tabPage1.Controls.Add(this.txtUserNamePosiljaoca);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtPrezimePosiljaoca);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(924, 582);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Primljene Poruke";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.lblNaslovPrimljene);
            this.groupBox2.Controls.Add(this.lblPosiljaoc);
            this.groupBox2.Controls.Add(this.lblDatumIVrijemePrimljene);
            this.groupBox2.Controls.Add(this.btnOdgovori);
            this.groupBox2.Controls.Add(this.txtSadrzajPrimljene);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(467, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 350);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // lblNaslovPrimljene
            // 
            this.lblNaslovPrimljene.AutoSize = true;
            this.lblNaslovPrimljene.Location = new System.Drawing.Point(213, 111);
            this.lblNaslovPrimljene.Name = "lblNaslovPrimljene";
            this.lblNaslovPrimljene.Size = new System.Drawing.Size(51, 17);
            this.lblNaslovPrimljene.TabIndex = 17;
            this.lblNaslovPrimljene.Text = "Naslov";
            // 
            // lblPosiljaoc
            // 
            this.lblPosiljaoc.AutoSize = true;
            this.lblPosiljaoc.Location = new System.Drawing.Point(213, 73);
            this.lblPosiljaoc.Name = "lblPosiljaoc";
            this.lblPosiljaoc.Size = new System.Drawing.Size(46, 17);
            this.lblPosiljaoc.TabIndex = 16;
            this.lblPosiljaoc.Text = "Klijent";
            // 
            // lblDatumIVrijemePrimljene
            // 
            this.lblDatumIVrijemePrimljene.AutoSize = true;
            this.lblDatumIVrijemePrimljene.Location = new System.Drawing.Point(213, 35);
            this.lblDatumIVrijemePrimljene.Name = "lblDatumIVrijemePrimljene";
            this.lblDatumIVrijemePrimljene.Size = new System.Drawing.Size(105, 17);
            this.lblDatumIVrijemePrimljene.TabIndex = 15;
            this.lblDatumIVrijemePrimljene.Text = "Datum i vrijeme";
            // 
            // btnOdgovori
            // 
            this.btnOdgovori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdgovori.Location = new System.Drawing.Point(343, 321);
            this.btnOdgovori.Name = "btnOdgovori";
            this.btnOdgovori.Size = new System.Drawing.Size(104, 26);
            this.btnOdgovori.TabIndex = 14;
            this.btnOdgovori.Text = "Odgovori";
            this.btnOdgovori.UseVisualStyleBackColor = true;
            this.btnOdgovori.Click += new System.EventHandler(this.btnOdgovori_Click);
            // 
            // txtSadrzajPrimljene
            // 
            this.txtSadrzajPrimljene.Location = new System.Drawing.Point(20, 166);
            this.txtSadrzajPrimljene.Multiline = true;
            this.txtSadrzajPrimljene.Name = "txtSadrzajPrimljene";
            this.txtSadrzajPrimljene.ReadOnly = true;
            this.txtSadrzajPrimljene.Size = new System.Drawing.Size(427, 145);
            this.txtSadrzajPrimljene.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sadržaj poruke : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Naslov : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(113, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pošiljaoc : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Datum i vrijeme slanja : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.dgvPrimljenePoruke);
            this.groupBox1.Location = new System.Drawing.Point(9, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 350);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Poruke";
            // 
            // dgvPrimljenePoruke
            // 
            this.dgvPrimljenePoruke.AllowUserToAddRows = false;
            this.dgvPrimljenePoruke.AllowUserToDeleteRows = false;
            this.dgvPrimljenePoruke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimljenePoruke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PorukaId,
            this.Posiljaoc,
            this.Naslov});
            this.dgvPrimljenePoruke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrimljenePoruke.Location = new System.Drawing.Point(3, 18);
            this.dgvPrimljenePoruke.Name = "dgvPrimljenePoruke";
            this.dgvPrimljenePoruke.ReadOnly = true;
            this.dgvPrimljenePoruke.RowTemplate.Height = 24;
            this.dgvPrimljenePoruke.Size = new System.Drawing.Size(447, 329);
            this.dgvPrimljenePoruke.TabIndex = 0;
            this.dgvPrimljenePoruke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrimljenePoruke_CellContentClick);
            this.dgvPrimljenePoruke.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPrimljenePoruke_MouseDoubleClick);
            // 
            // PorukaId
            // 
            this.PorukaId.DataPropertyName = "PorukaId";
            this.PorukaId.HeaderText = "PorukaId";
            this.PorukaId.Name = "PorukaId";
            this.PorukaId.ReadOnly = true;
            this.PorukaId.Visible = false;
            // 
            // Posiljaoc
            // 
            this.Posiljaoc.DataPropertyName = "PosiljaocInfo";
            this.Posiljaoc.HeaderText = "Posiljaoc";
            this.Posiljaoc.Name = "Posiljaoc";
            this.Posiljaoc.ReadOnly = true;
            this.Posiljaoc.Width = 140;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            this.Naslov.Width = 200;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.btnFiltrirajPrimaoce);
            this.tabPage2.Controls.Add(this.txtPrezimePoslan);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtUserNamePoslan);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtImePoslan);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(924, 582);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Poslane Poruke";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.lblNaslovPoslane);
            this.groupBox4.Controls.Add(this.lblKlijentPoslane);
            this.groupBox4.Controls.Add(this.lblDatumVrijemePoslane);
            this.groupBox4.Controls.Add(this.txtSadrzajPoslane);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(465, 210);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(453, 350);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // lblNaslovPoslane
            // 
            this.lblNaslovPoslane.AutoSize = true;
            this.lblNaslovPoslane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslovPoslane.Location = new System.Drawing.Point(224, 104);
            this.lblNaslovPoslane.Name = "lblNaslovPoslane";
            this.lblNaslovPoslane.Size = new System.Drawing.Size(54, 18);
            this.lblNaslovPoslane.TabIndex = 8;
            this.lblNaslovPoslane.Text = "Naslov";
            // 
            // lblKlijentPoslane
            // 
            this.lblKlijentPoslane.AutoSize = true;
            this.lblKlijentPoslane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlijentPoslane.Location = new System.Drawing.Point(224, 73);
            this.lblKlijentPoslane.Name = "lblKlijentPoslane";
            this.lblKlijentPoslane.Size = new System.Drawing.Size(47, 18);
            this.lblKlijentPoslane.TabIndex = 7;
            this.lblKlijentPoslane.Text = "Klijent";
            // 
            // lblDatumVrijemePoslane
            // 
            this.lblDatumVrijemePoslane.AutoSize = true;
            this.lblDatumVrijemePoslane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumVrijemePoslane.Location = new System.Drawing.Point(224, 38);
            this.lblDatumVrijemePoslane.Name = "lblDatumVrijemePoslane";
            this.lblDatumVrijemePoslane.Size = new System.Drawing.Size(110, 18);
            this.lblDatumVrijemePoslane.TabIndex = 6;
            this.lblDatumVrijemePoslane.Text = "Datum i vrijeme";
            // 
            // txtSadrzajPoslane
            // 
            this.txtSadrzajPoslane.Enabled = false;
            this.txtSadrzajPoslane.Location = new System.Drawing.Point(20, 178);
            this.txtSadrzajPoslane.Multiline = true;
            this.txtSadrzajPoslane.Name = "txtSadrzajPoslane";
            this.txtSadrzajPoslane.ReadOnly = true;
            this.txtSadrzajPoslane.Size = new System.Drawing.Size(427, 145);
            this.txtSadrzajPoslane.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(29, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 18);
            this.label14.TabIndex = 4;
            this.label14.Text = "Sadržaj poruke : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(143, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 18);
            this.label13.TabIndex = 3;
            this.label13.Text = "Naslov : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(132, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "Primaoc : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Datum i vrijeme slanja : ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.dgvPoslanePoruke);
            this.groupBox3.Location = new System.Drawing.Point(9, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 350);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Poruke";
            // 
            // dgvPoslanePoruke
            // 
            this.dgvPoslanePoruke.AllowUserToAddRows = false;
            this.dgvPoslanePoruke.AllowUserToDeleteRows = false;
            this.dgvPoslanePoruke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoslanePoruke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PorukaId1,
            this.Primaoc,
            this.Naslov1});
            this.dgvPoslanePoruke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPoslanePoruke.Location = new System.Drawing.Point(3, 18);
            this.dgvPoslanePoruke.Name = "dgvPoslanePoruke";
            this.dgvPoslanePoruke.ReadOnly = true;
            this.dgvPoslanePoruke.RowTemplate.Height = 24;
            this.dgvPoslanePoruke.Size = new System.Drawing.Size(447, 329);
            this.dgvPoslanePoruke.TabIndex = 0;
            this.dgvPoslanePoruke.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPoslanePoruke_MouseDoubleClick);
            // 
            // PorukaId1
            // 
            this.PorukaId1.DataPropertyName = "PorukaId";
            this.PorukaId1.HeaderText = "PorukaId1";
            this.PorukaId1.Name = "PorukaId1";
            this.PorukaId1.ReadOnly = true;
            this.PorukaId1.Visible = false;
            // 
            // Primaoc
            // 
            this.Primaoc.DataPropertyName = "PrimaocInfo";
            this.Primaoc.HeaderText = "Primaoc";
            this.Primaoc.Name = "Primaoc";
            this.Primaoc.ReadOnly = true;
            this.Primaoc.Width = 140;
            // 
            // Naslov1
            // 
            this.Naslov1.DataPropertyName = "Naslov";
            this.Naslov1.HeaderText = "Naslov";
            this.Naslov1.Name = "Naslov1";
            this.Naslov1.ReadOnly = true;
            this.Naslov1.Width = 180;
            // 
            // btnFiltrirajPrimaoce
            // 
            this.btnFiltrirajPrimaoce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrirajPrimaoce.Location = new System.Drawing.Point(681, 114);
            this.btnFiltrirajPrimaoce.Name = "btnFiltrirajPrimaoce";
            this.btnFiltrirajPrimaoce.Size = new System.Drawing.Size(121, 27);
            this.btnFiltrirajPrimaoce.TabIndex = 6;
            this.btnFiltrirajPrimaoce.Text = "Filtriraj";
            this.btnFiltrirajPrimaoce.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFiltrirajPrimaoce.UseVisualStyleBackColor = true;
            this.btnFiltrirajPrimaoce.Click += new System.EventHandler(this.btnFiltrirajPrimaoce_Click);
            // 
            // txtPrezimePoslan
            // 
            this.txtPrezimePoslan.Location = new System.Drawing.Point(472, 53);
            this.txtPrezimePoslan.Name = "txtPrezimePoslan";
            this.txtPrezimePoslan.Size = new System.Drawing.Size(330, 22);
            this.txtPrezimePoslan.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(469, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Prezime Primaoca";
            // 
            // txtUserNamePoslan
            // 
            this.txtUserNamePoslan.Location = new System.Drawing.Point(49, 119);
            this.txtUserNamePoslan.Name = "txtUserNamePoslan";
            this.txtUserNamePoslan.Size = new System.Drawing.Size(330, 22);
            this.txtUserNamePoslan.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Username Priaoca";
            // 
            // txtImePoslan
            // 
            this.txtImePoslan.Location = new System.Drawing.Point(49, 53);
            this.txtImePoslan.Name = "txtImePoslan";
            this.txtImePoslan.Size = new System.Drawing.Size(330, 22);
            this.txtImePoslan.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ime Primaoca";
            // 
            // btnNovaPorukaNoviKlijent
            // 
            this.btnNovaPorukaNoviKlijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaPorukaNoviKlijent.Location = new System.Drawing.Point(735, 625);
            this.btnNovaPorukaNoviKlijent.Name = "btnNovaPorukaNoviKlijent";
            this.btnNovaPorukaNoviKlijent.Size = new System.Drawing.Size(174, 34);
            this.btnNovaPorukaNoviKlijent.TabIndex = 8;
            this.btnNovaPorukaNoviKlijent.Text = "NOVA PORUKA";
            this.btnNovaPorukaNoviKlijent.UseVisualStyleBackColor = true;
            this.btnNovaPorukaNoviKlijent.Click += new System.EventHandler(this.btnNovaPorukaNoviKlijent_Click);
            // 
            // frmPoruke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 671);
            this.Controls.Add(this.btnNovaPorukaNoviKlijent);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPoruke";
            this.Text = "frmPoruke";
            this.Load += new System.EventHandler(this.frmPoruke_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimljenePoruke)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslanePoruke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImePosiljaoca;
        private System.Windows.Forms.TextBox txtPrezimePosiljaoca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserNamePosiljaoca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPrimljenePoruke;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSadrzajPrimljene;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOdgovori;
        private System.Windows.Forms.Label lblNaslovPrimljene;
        private System.Windows.Forms.Label lblPosiljaoc;
        private System.Windows.Forms.Label lblDatumIVrijemePrimljene;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSadrzajPoslane;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPoslanePoruke;
        private System.Windows.Forms.Button btnFiltrirajPrimaoce;
        private System.Windows.Forms.TextBox txtPrezimePoslan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUserNamePoslan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtImePoslan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNaslovPoslane;
        private System.Windows.Forms.Label lblKlijentPoslane;
        private System.Windows.Forms.Label lblDatumVrijemePoslane;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorukaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posiljaoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorukaId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Primaoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov1;
        private System.Windows.Forms.Button btnNovaPorukaNoviKlijent;
    }
}