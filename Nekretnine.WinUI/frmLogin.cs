using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nekretnine.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("Grad");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnPrijava_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtUserName.Text;
                APIService.Password = txtPassword.Text;

                await _service.Get<dynamic>(null);

                DashboardForm frm = new DashboardForm(APIService.Username);
                frm.Show();

                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Authentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
