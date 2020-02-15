using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nekretnine.WinUI.UpitiZaSastanke
{
    public partial class frmUpiti : Form
    {
        private readonly APIService _service = new APIService("UpitZaSastanak");

        public frmUpiti()
        {
            InitializeComponent();
            dgvUpiti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUpiti.DisplayedRowCount(true);
        }

        private async void frmUpiti_Load(object sender, EventArgs e)
        {
            var result = await _service.Get<List<Model.Models.UpitZaSastanak>>(null);

            dgvUpiti.AutoGenerateColumns = false;
            dgvUpiti.DataSource = result;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
