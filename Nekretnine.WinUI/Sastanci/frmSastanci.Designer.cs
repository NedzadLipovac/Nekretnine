namespace Nekretnine.WinUI.Sastanci
{
    partial class frmSastanci
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
            this.sastanciLista = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSastanci = new System.Windows.Forms.DataGridView();
            this.btnPrikaziSastanke = new System.Windows.Forms.Button();
            this.txtMjesto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NoviSastanak = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMjestoSastanka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatumSastanka = new System.Windows.Forms.DateTimePicker();
            this.cmbKlijent = new System.Windows.Forms.ComboBox();
            this.txtOpisSastanka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DetaljiSastanka = new System.Windows.Forms.TabPage();
            this.btnOdustaniDetalji = new System.Windows.Forms.Button();
            this.btnUrediSastanakSacuvaj = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOpisSastanakUredi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDatumSastnakaUredi = new System.Windows.Forms.DateTimePicker();
            this.txtMjestoSastankaUredi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKlijentSastankaUredi = new System.Windows.Forms.TextBox();
            this.txtKlijentUredi = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SastanakId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mjesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.sastanciLista.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastanci)).BeginInit();
            this.NoviSastanak.SuspendLayout();
            this.DetaljiSastanka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.sastanciLista);
            this.tabControl1.Controls.Add(this.NoviSastanak);
            this.tabControl1.Controls.Add(this.DetaljiSastanka);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(921, 584);
            this.tabControl1.TabIndex = 0;
            // 
            // sastanciLista
            // 
            this.sastanciLista.Controls.Add(this.groupBox1);
            this.sastanciLista.Controls.Add(this.btnPrikaziSastanke);
            this.sastanciLista.Controls.Add(this.txtMjesto);
            this.sastanciLista.Controls.Add(this.label1);
            this.sastanciLista.Location = new System.Drawing.Point(4, 25);
            this.sastanciLista.Name = "sastanciLista";
            this.sastanciLista.Padding = new System.Windows.Forms.Padding(3);
            this.sastanciLista.Size = new System.Drawing.Size(913, 555);
            this.sastanciLista.TabIndex = 0;
            this.sastanciLista.Text = "Sastanci";
            this.sastanciLista.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSastanci);
            this.groupBox1.Location = new System.Drawing.Point(60, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 425);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sastanci";
            // 
            // dgvSastanci
            // 
            this.dgvSastanci.AllowUserToAddRows = false;
            this.dgvSastanci.AllowUserToDeleteRows = false;
            this.dgvSastanci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSastanci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SastanakId,
            this.Klijent,
            this.Mjesto,
            this.Datum,
            this.Opis});
            this.dgvSastanci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSastanci.Location = new System.Drawing.Point(3, 18);
            this.dgvSastanci.Name = "dgvSastanci";
            this.dgvSastanci.ReadOnly = true;
            this.dgvSastanci.RowTemplate.Height = 24;
            this.dgvSastanci.Size = new System.Drawing.Size(703, 404);
            this.dgvSastanci.TabIndex = 0;
            this.dgvSastanci.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSastanci_MouseDoubleClick);
            // 
            // btnPrikaziSastanke
            // 
            this.btnPrikaziSastanke.Location = new System.Drawing.Point(662, 55);
            this.btnPrikaziSastanke.Name = "btnPrikaziSastanke";
            this.btnPrikaziSastanke.Size = new System.Drawing.Size(91, 29);
            this.btnPrikaziSastanke.TabIndex = 2;
            this.btnPrikaziSastanke.Text = "Prikazi";
            this.btnPrikaziSastanke.UseVisualStyleBackColor = true;
            this.btnPrikaziSastanke.Click += new System.EventHandler(this.btnPrikaziSastanke_Click);
            // 
            // txtMjesto
            // 
            this.txtMjesto.Location = new System.Drawing.Point(158, 55);
            this.txtMjesto.Name = "txtMjesto";
            this.txtMjesto.Size = new System.Drawing.Size(328, 22);
            this.txtMjesto.TabIndex = 1;
            this.txtMjesto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mjesto :";
            // 
            // NoviSastanak
            // 
            this.NoviSastanak.Controls.Add(this.label5);
            this.NoviSastanak.Controls.Add(this.btnOdustani);
            this.NoviSastanak.Controls.Add(this.btnSacuvaj);
            this.NoviSastanak.Controls.Add(this.label4);
            this.NoviSastanak.Controls.Add(this.txtMjestoSastanka);
            this.NoviSastanak.Controls.Add(this.label3);
            this.NoviSastanak.Controls.Add(this.dtpDatumSastanka);
            this.NoviSastanak.Controls.Add(this.cmbKlijent);
            this.NoviSastanak.Controls.Add(this.txtOpisSastanka);
            this.NoviSastanak.Controls.Add(this.label2);
            this.NoviSastanak.Location = new System.Drawing.Point(4, 25);
            this.NoviSastanak.Name = "NoviSastanak";
            this.NoviSastanak.Padding = new System.Windows.Forms.Padding(3);
            this.NoviSastanak.Size = new System.Drawing.Size(913, 555);
            this.NoviSastanak.TabIndex = 1;
            this.NoviSastanak.Text = "Novi Sastanak";
            this.NoviSastanak.UseVisualStyleBackColor = true;
            this.NoviSastanak.Click += new System.EventHandler(this.NoviSastanak_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Opis sastanka ";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(685, 354);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(101, 32);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(489, 354);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(109, 32);
            this.btnSacuvaj.TabIndex = 7;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mjesto";
            // 
            // txtMjestoSastanka
            // 
            this.txtMjestoSastanka.Location = new System.Drawing.Point(115, 230);
            this.txtMjestoSastanka.Name = "txtMjestoSastanka";
            this.txtMjestoSastanka.Size = new System.Drawing.Size(238, 22);
            this.txtMjestoSastanka.TabIndex = 5;
            this.txtMjestoSastanka.Validating += new System.ComponentModel.CancelEventHandler(this.txtMjestoSastanka_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum";
            // 
            // dtpDatumSastanka
            // 
            this.dtpDatumSastanka.Location = new System.Drawing.Point(115, 173);
            this.dtpDatumSastanka.Name = "dtpDatumSastanka";
            this.dtpDatumSastanka.Size = new System.Drawing.Size(238, 22);
            this.dtpDatumSastanka.TabIndex = 3;
            // 
            // cmbKlijent
            // 
            this.cmbKlijent.FormattingEnabled = true;
            this.cmbKlijent.Location = new System.Drawing.Point(115, 116);
            this.cmbKlijent.Name = "cmbKlijent";
            this.cmbKlijent.Size = new System.Drawing.Size(238, 24);
            this.cmbKlijent.TabIndex = 2;
            this.cmbKlijent.Validating += new System.ComponentModel.CancelEventHandler(this.cmbKlijent_Validating);
            // 
            // txtOpisSastanka
            // 
            this.txtOpisSastanka.Location = new System.Drawing.Point(449, 82);
            this.txtOpisSastanka.Multiline = true;
            this.txtOpisSastanka.Name = "txtOpisSastanka";
            this.txtOpisSastanka.Size = new System.Drawing.Size(420, 231);
            this.txtOpisSastanka.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Klijent";
            // 
            // DetaljiSastanka
            // 
            this.DetaljiSastanka.Controls.Add(this.btnOdustaniDetalji);
            this.DetaljiSastanka.Controls.Add(this.btnUrediSastanakSacuvaj);
            this.DetaljiSastanka.Controls.Add(this.label8);
            this.DetaljiSastanka.Controls.Add(this.txtOpisSastanakUredi);
            this.DetaljiSastanka.Controls.Add(this.label7);
            this.DetaljiSastanka.Controls.Add(this.dtpDatumSastnakaUredi);
            this.DetaljiSastanka.Controls.Add(this.txtMjestoSastankaUredi);
            this.DetaljiSastanka.Controls.Add(this.label6);
            this.DetaljiSastanka.Controls.Add(this.txtKlijentSastankaUredi);
            this.DetaljiSastanka.Controls.Add(this.txtKlijentUredi);
            this.DetaljiSastanka.Location = new System.Drawing.Point(4, 25);
            this.DetaljiSastanka.Name = "DetaljiSastanka";
            this.DetaljiSastanka.Padding = new System.Windows.Forms.Padding(3);
            this.DetaljiSastanka.Size = new System.Drawing.Size(913, 555);
            this.DetaljiSastanka.TabIndex = 2;
            this.DetaljiSastanka.Text = "Detalji Sastanka";
            this.DetaljiSastanka.UseVisualStyleBackColor = true;
            // 
            // btnOdustaniDetalji
            // 
            this.btnOdustaniDetalji.Location = new System.Drawing.Point(714, 314);
            this.btnOdustaniDetalji.Name = "btnOdustaniDetalji";
            this.btnOdustaniDetalji.Size = new System.Drawing.Size(92, 31);
            this.btnOdustaniDetalji.TabIndex = 9;
            this.btnOdustaniDetalji.Text = "Odustani";
            this.btnOdustaniDetalji.UseVisualStyleBackColor = true;
            this.btnOdustaniDetalji.Click += new System.EventHandler(this.btnOdustaniDetalji_Click);
            // 
            // btnUrediSastanakSacuvaj
            // 
            this.btnUrediSastanakSacuvaj.Location = new System.Drawing.Point(511, 314);
            this.btnUrediSastanakSacuvaj.Name = "btnUrediSastanakSacuvaj";
            this.btnUrediSastanakSacuvaj.Size = new System.Drawing.Size(93, 31);
            this.btnUrediSastanakSacuvaj.TabIndex = 8;
            this.btnUrediSastanakSacuvaj.Text = "Sacuvaj";
            this.btnUrediSastanakSacuvaj.UseVisualStyleBackColor = true;
            this.btnUrediSastanakSacuvaj.Click += new System.EventHandler(this.btnUrediSastanakSacuvaj_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(492, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Opis Sastanka";
            // 
            // txtOpisSastanakUredi
            // 
            this.txtOpisSastanakUredi.Location = new System.Drawing.Point(495, 111);
            this.txtOpisSastanakUredi.Multiline = true;
            this.txtOpisSastanakUredi.Name = "txtOpisSastanakUredi";
            this.txtOpisSastanakUredi.Size = new System.Drawing.Size(355, 177);
            this.txtOpisSastanakUredi.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Datum";
            // 
            // dtpDatumSastnakaUredi
            // 
            this.dtpDatumSastnakaUredi.Location = new System.Drawing.Point(141, 176);
            this.dtpDatumSastnakaUredi.Name = "dtpDatumSastnakaUredi";
            this.dtpDatumSastnakaUredi.Size = new System.Drawing.Size(226, 22);
            this.dtpDatumSastnakaUredi.TabIndex = 4;
            // 
            // txtMjestoSastankaUredi
            // 
            this.txtMjestoSastankaUredi.Location = new System.Drawing.Point(141, 230);
            this.txtMjestoSastankaUredi.Name = "txtMjestoSastankaUredi";
            this.txtMjestoSastankaUredi.Size = new System.Drawing.Size(226, 22);
            this.txtMjestoSastankaUredi.TabIndex = 3;
            this.txtMjestoSastankaUredi.Validating += new System.ComponentModel.CancelEventHandler(this.txtMjestoSastankaUredi_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mjesto ";
            // 
            // txtKlijentSastankaUredi
            // 
            this.txtKlijentSastankaUredi.Location = new System.Drawing.Point(141, 123);
            this.txtKlijentSastankaUredi.Name = "txtKlijentSastankaUredi";
            this.txtKlijentSastankaUredi.ReadOnly = true;
            this.txtKlijentSastankaUredi.Size = new System.Drawing.Size(226, 22);
            this.txtKlijentSastankaUredi.TabIndex = 1;
            // 
            // txtKlijentUredi
            // 
            this.txtKlijentUredi.AutoSize = true;
            this.txtKlijentUredi.Location = new System.Drawing.Point(89, 126);
            this.txtKlijentUredi.Name = "txtKlijentUredi";
            this.txtKlijentUredi.Size = new System.Drawing.Size(46, 17);
            this.txtKlijentUredi.TabIndex = 0;
            this.txtKlijentUredi.Text = "Klijent";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SastanakId
            // 
            this.SastanakId.DataPropertyName = "SastanakId";
            this.SastanakId.HeaderText = "SastanakId";
            this.SastanakId.Name = "SastanakId";
            this.SastanakId.ReadOnly = true;
            this.SastanakId.Visible = false;
            // 
            // Klijent
            // 
            this.Klijent.DataPropertyName = "Klijent";
            this.Klijent.HeaderText = "Klijent";
            this.Klijent.Name = "Klijent";
            this.Klijent.ReadOnly = true;
            this.Klijent.Width = 120;
            // 
            // Mjesto
            // 
            this.Mjesto.DataPropertyName = "Mjesto";
            this.Mjesto.HeaderText = "Mjesto";
            this.Mjesto.Name = "Mjesto";
            this.Mjesto.ReadOnly = true;
            this.Mjesto.Width = 120;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "DatumVrijeme";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 110;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 150;
            // 
            // frmSastanci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 608);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSastanci";
            this.Text = "frmSastanci";
            this.Load += new System.EventHandler(this.frmSastanci_Load);
            this.tabControl1.ResumeLayout(false);
            this.sastanciLista.ResumeLayout(false);
            this.sastanciLista.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastanci)).EndInit();
            this.NoviSastanak.ResumeLayout(false);
            this.NoviSastanak.PerformLayout();
            this.DetaljiSastanka.ResumeLayout(false);
            this.DetaljiSastanka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sastanciLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSastanci;
        private System.Windows.Forms.Button btnPrikaziSastanke;
        private System.Windows.Forms.TextBox txtMjesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage NoviSastanak;
        private System.Windows.Forms.TextBox txtOpisSastanka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMjestoSastanka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatumSastanka;
        private System.Windows.Forms.ComboBox cmbKlijent;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage DetaljiSastanka;
        private System.Windows.Forms.TextBox txtMjestoSastankaUredi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKlijentSastankaUredi;
        private System.Windows.Forms.Label txtKlijentUredi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOpisSastanakUredi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDatumSastnakaUredi;
        private System.Windows.Forms.Button btnOdustaniDetalji;
        private System.Windows.Forms.Button btnUrediSastanakSacuvaj;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SastanakId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mjesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
    }
}