namespace Nekretnine.WinUI.UpitiZaSastanke
{
    partial class frmUpiti
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Upiti = new System.Windows.Forms.GroupBox();
            this.dgvUpiti = new System.Windows.Forms.DataGridView();
            this.UpitZaSastanakId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivSastanka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PredlozeniDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Upiti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpiti)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(925, 584);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Upiti);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(917, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista upita";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Upiti
            // 
            this.Upiti.Controls.Add(this.dgvUpiti);
            this.Upiti.Location = new System.Drawing.Point(88, 61);
            this.Upiti.Name = "Upiti";
            this.Upiti.Size = new System.Drawing.Size(705, 468);
            this.Upiti.TabIndex = 0;
            this.Upiti.TabStop = false;
            this.Upiti.Text = "Upiti";
            // 
            // dgvUpiti
            // 
            this.dgvUpiti.AllowUserToAddRows = false;
            this.dgvUpiti.AllowUserToDeleteRows = false;
            this.dgvUpiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpiti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UpitZaSastanakId,
            this.NazivSastanka,
            this.PredlozeniDatum,
            this.Klijent});
            this.dgvUpiti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUpiti.Location = new System.Drawing.Point(3, 18);
            this.dgvUpiti.Name = "dgvUpiti";
            this.dgvUpiti.ReadOnly = true;
            this.dgvUpiti.RowTemplate.Height = 24;
            this.dgvUpiti.Size = new System.Drawing.Size(699, 447);
            this.dgvUpiti.TabIndex = 0;
            // 
            // UpitZaSastanakId
            // 
            this.UpitZaSastanakId.DataPropertyName = "UpitZaSastanakId";
            this.UpitZaSastanakId.HeaderText = "UpitZaSastanakId";
            this.UpitZaSastanakId.Name = "UpitZaSastanakId";
            this.UpitZaSastanakId.ReadOnly = true;
            this.UpitZaSastanakId.Visible = false;
            this.UpitZaSastanakId.Width = 130;
            // 
            // NazivSastanka
            // 
            this.NazivSastanka.DataPropertyName = "NazivSastanka";
            this.NazivSastanka.HeaderText = "NazivSastanka";
            this.NazivSastanka.Name = "NazivSastanka";
            this.NazivSastanka.ReadOnly = true;
            this.NazivSastanka.Width = 160;
            // 
            // PredlozeniDatum
            // 
            this.PredlozeniDatum.DataPropertyName = "PredlozeniDatum";
            this.PredlozeniDatum.HeaderText = "PredlozeniDatum";
            this.PredlozeniDatum.Name = "PredlozeniDatum";
            this.PredlozeniDatum.ReadOnly = true;
            this.PredlozeniDatum.Width = 150;
            // 
            // Klijent
            // 
            this.Klijent.DataPropertyName = "Klijent";
            this.Klijent.HeaderText = "Klijent";
            this.Klijent.Name = "Klijent";
            this.Klijent.ReadOnly = true;
            this.Klijent.Width = 170;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTA ZATRAZENIH SASTANAKA OD STRANE KLIJENATA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmUpiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 608);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpiti";
            this.Text = "frmUpiti";
            this.Load += new System.EventHandler(this.frmUpiti_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Upiti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpiti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox Upiti;
        private System.Windows.Forms.DataGridView dgvUpiti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpitZaSastanakId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivSastanka;
        private System.Windows.Forms.DataGridViewTextBoxColumn PredlozeniDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijent;
    }
}