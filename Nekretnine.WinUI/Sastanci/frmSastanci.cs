using Nekretnine.Model.Requests;
using Nekretnine.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nekretnine.WinUI.Sastanci
{
    public partial class frmSastanci : Form
    {
        private readonly APIService _service = new APIService("Sastanak");
        private readonly APIService _klijentiService = new APIService("Klijent");
        public int _SastanakId { get; set; }
        private readonly SastanakUpsertRequest sastanakDodajRequest = new SastanakUpsertRequest();
        private readonly SastanakUpsertRequest sastanakUrediRequest = new SastanakUpsertRequest();
        public frmSastanci()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void frmSastanci_Load(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.Remove(DetaljiSastanka);
            await LoadKlijenti(cmbKlijent);
            this.dgvSastanci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private async void btnPrikaziSastanke_Click(object sender, EventArgs e)
        {
            var search = new SastanakSearchRequest();

            if(txtMjesto.Text!="")
            {
                search.Mjesto = txtMjesto.Text;
            }
            else
            {
                search = null;
            }

            var result = await _service.Get<List<Model.Models.Sastanak>>(search);
            dgvSastanci.AutoGenerateColumns = false;
            dgvSastanci.DataSource = result;
        }
        private async Task LoadKlijenti (ComboBox cmb)
        {
            KlijentSearchRequest searchRequest = new KlijentSearchRequest()
            {
                Status = true
            };
            var result = await _klijentiService.Get<List<Model.Models.Klijent>>(searchRequest);
            result.Insert(0, new Model.Models.Klijent());

            ComboBoxLoad<Model.Models.Klijent> cmbLoad = new ComboBoxLoad<Model.Models.Klijent>();
            cmbLoad.Load(cmb, result, "Ime", "KlijentId");
        }
        private void NoviSastanak_Click(object sender, EventArgs e)
        {

        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                var klijentIdObj = cmbKlijent.SelectedValue;
                if (int.TryParse(klijentIdObj.ToString(), out int kId))
                {
                    sastanakDodajRequest.KlijentId = kId;
                }

                sastanakDodajRequest.Mjesto = txtMjestoSastanka.Text;
                sastanakDodajRequest.Opis = txtOpisSastanka.Text;
                sastanakDodajRequest.DatumVrijeme = dtpDatumSastanka.Value;

                var entity = await _service.Insert<Model.Models.Sastanak>(sastanakDodajRequest);

                if (entity != null)
                {
                    MessageBox.Show("Sastanak uspješno dodan");

                    txtOpisSastanka.Clear();
                    txtMjestoSastanka.Clear();
                    dtpDatumSastanka.Value = DateTime.Now;
                    cmbKlijent.SelectedIndex = -1;

                    tabControl1.SelectTab(sastanciLista);
                }

            }
        }

        private async Task UcitajEditSastanka()
        {
            var sastanak =await _service.GetById<Model.Models.Sastanak>(_SastanakId);
            var klijent = await _klijentiService.GetById<Model.Models.Klijent>(sastanak.KlijentId);
            sastanakUrediRequest.KlijentId = sastanak.KlijentId;
            sastanakUrediRequest.Mjesto = sastanak.Mjesto;
            sastanakUrediRequest.Opis = sastanak.Opis;
            sastanakUrediRequest.DatumVrijeme = sastanak.DatumVrijeme;

            txtMjestoSastankaUredi.Text = sastanakUrediRequest.Mjesto;
            txtOpisSastanakUredi.Text= sastanakUrediRequest.Opis;
            dtpDatumSastnakaUredi.Value = sastanakUrediRequest.DatumVrijeme.Date;
            txtKlijentSastankaUredi.Text = sastanak.Klijent;

        }
        private async void dgvSastanci_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.tabControl1.TabPages.Remove(DetaljiSastanka);
         
            int id = 0;
            var val = dgvSastanci.SelectedRows[0].Cells[0].Value;
            if(dgvSastanci.RowCount>0)
            {
                id = int.Parse(val.ToString());
                _SastanakId = id;
                await UcitajEditSastanka();
                this.tabControl1.TabPages.Add(DetaljiSastanka);
                this.tabControl1.SelectTab(DetaljiSastanka);
            }
        }

        private async void btnUrediSastanakSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                sastanakUrediRequest.DatumVrijeme = dtpDatumSastnakaUredi.Value;
                sastanakUrediRequest.Mjesto = txtMjestoSastankaUredi.Text;
                sastanakUrediRequest.Opis = txtOpisSastanakUredi.Text;
                sastanakUrediRequest.SastanakId = _SastanakId;
                var entity = await _service.Update<Model.Models.Sastanak>(_SastanakId, sastanakUrediRequest);

                if (entity != null)
                {
                    MessageBox.Show("Podaci o sastanku uspješno izmejnjeni");
                    this.tabControl1.TabPages.Remove(DetaljiSastanka);
                    tabControl1.SelectTab(sastanciLista);
                }

            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            txtOpisSastanka.Clear();
            txtMjestoSastanka.Clear();
            dtpDatumSastanka.Value = DateTime.Now;
            cmbKlijent.SelectedIndex = -1;

            tabControl1.SelectTab(sastanciLista);
        }

        private void btnOdustaniDetalji_Click(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.Remove(DetaljiSastanka);
            tabControl1.SelectTab(sastanciLista);
        }
        #region Validation
        private void cmbKlijent_Validating(object sender, CancelEventArgs e)
        {
            var GradObj = cmbKlijent.SelectedValue;

            if (GradObj.ToString() == "0")
            {
                errorProvider1.SetError(cmbKlijent, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cmbKlijent, null);
            }
        }

        private void txtMjestoSastanka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMjestoSastanka.Text))
            {
                errorProvider1.SetError(txtMjestoSastanka, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtMjestoSastanka, null);
            }
        }
        private void txtMjestoSastankaUredi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMjestoSastankaUredi.Text))
            {
                errorProvider1.SetError(txtMjestoSastankaUredi, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtMjestoSastankaUredi, null);
            }
        }
        #endregion


    }
}
