using Nekretnine.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nekretnine.WinUI.Poruke
{
    public partial class frmPoruke : Form
    {
        private readonly APIService _PorukaService = new APIService("Poruka");
        private int _UserID = 0, _PorukaID = 0;

        public frmPoruke(int uid)
        {
            _UserID = uid;
            InitializeComponent();
        }

        private async void frmPoruke_Load(object sender, EventArgs e)
        {
            dgvPrimljenePoruke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPoslanePoruke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            await PretragaPrimljenihPoruka();
            await PretragaPoslanihPoruka();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void dgvPrimljenePoruke_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (dgvPrimljenePoruke.RowCount > 0)
            {
                var val = dgvPrimljenePoruke.SelectedRows[0].Cells[0].Value;
                _PorukaID = int.Parse(val.ToString());
            }
            if (_PorukaID > 0)
            {
                btnOdgovori.Visible = true;
                await UcitajPrimljenuPoruku(_PorukaID);
            }
        }
        //Ucitavanje odabrane primljene poruke
        private async Task UcitajPrimljenuPoruku(int pid)
        {
            var poruka = await _PorukaService.GetById<Model.Models.Poruka>(pid);

            lblDatumIVrijemePrimljene.Text = poruka.DatumVrijeme.ToString();
            lblNaslovPrimljene.Text = poruka.Naslov;
            lblPosiljaoc.Text = poruka.PosiljaocInfo;
            txtSadrzajPrimljene.Text = poruka.Sadrzaj;
        }

        private async void btnOdgovori_Click(object sender, EventArgs e)
        {
            Model.Models.Poruka p = await _PorukaService.GetById<Model.Models.Poruka>(_PorukaID);
            frmNovaPoruka frm = new frmNovaPoruka(p.KlijentId, _UserID);
            _PorukaID = 0;
            btnOdgovori.Visible = false;
            frm.Show();
        }

        private async void dgvPoslanePoruke_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int Id = 0;
            if (dgvPoslanePoruke.RowCount > 0)
            {
                var val = dgvPoslanePoruke.SelectedRows[0].Cells[0].Value;
                Id = int.Parse(val.ToString());
            }
            if (Id > 0)
            {
                await UcitajPoslanuPoruku(Id);
            }
        }
        //Ucitavanje odabrane poslane poruke
        private async Task UcitajPoslanuPoruku(int id)
        {
            var poruka = await _PorukaService.GetById<Model.Models.Poruka>(id);

       
            lblDatumVrijemePoslane.Text = poruka.DatumVrijeme.ToString();
            lblNaslovPoslane.Text = poruka.Naslov;
            lblKlijentPoslane.Text = poruka.PrimaocInfo;
            txtSadrzajPoslane.Text = poruka.Sadrzaj;
        }
        private async Task PretragaPoslanihPoruka()
        {
            var search = new PorukaSearchRequest();


            search.UposlenikId = _UserID;
            search.Posiljaoc = "Uposlenik";

            if (txtImePoslan.Text != "")
            {
                search.PrimaocIme = txtImePoslan.Text.ToLower();
            }
            if (txtPrezimePoslan.Text != "")
            {
                search.PrimaocPrezime = txtPrezimePoslan.Text.ToLower();
            }
            if (txtUserNamePoslan.Text != "")
            {
                search.PrimaocUsername = txtUserNamePoslan.Text.ToLower();
            }



            var result = await _PorukaService.Get<List<Model.Models.Poruka>>(search);
            dgvPoslanePoruke.AutoGenerateColumns = false;
            dgvPoslanePoruke.DataSource = result;
        }

        private async void btnFiltriraj_Click(object sender, EventArgs e)
        {
            await PretragaPrimljenihPoruka();
        }

        private async void btnFiltrirajPrimaoce_Click(object sender, EventArgs e)
        {
            await PretragaPoslanihPoruka();
        }

        private void dgvPrimljenePoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async Task PretragaPrimljenihPoruka()
        {
            var search = new PorukaSearchRequest();


            search.UposlenikId = _UserID;
            search.Posiljaoc = "Klijent";

            if (txtImePosiljaoca.Text != "")
            {
                search.PosiljaocIme = txtImePosiljaoca.Text.ToLower();
            }
            if (txtPrezimePosiljaoca.Text != "")
            {
                search.PosiljaocPrezime = txtPrezimePosiljaoca.Text.ToLower();
            }
            if (txtUserNamePosiljaoca.Text != "")
            {
                search.PosiljaocUsername = txtUserNamePosiljaoca.Text.ToLower();
            }
         


            var result = await _PorukaService.Get<List<Model.Models.Poruka>>(search);
            dgvPrimljenePoruke.AutoGenerateColumns = false;
            dgvPrimljenePoruke.DataSource = result;
        }
    }
}
