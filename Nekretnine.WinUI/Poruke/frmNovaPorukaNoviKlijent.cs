using Microsoft.AspNetCore.SignalR.Client;
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

namespace Nekretnine.WinUI.Poruke
{
    public partial class frmNovaPorukaNoviKlijent : Form
    {
        private readonly APIService _porukaService = new APIService("Poruka");
        private readonly APIService _klijentService = new APIService("Klijent");
        private HubConnection connection;

        private int _KlijentID, _UposlenikID = 0;
        public frmNovaPorukaNoviKlijent(int UID)
        {
            _UposlenikID = UID;
  
            InitializeComponent();
        }
        private async Task LoadKlijenti(ComboBox cmb)
        {
            KlijentSearchRequest searchRequest = new KlijentSearchRequest()
            {
                Status = true
            };
            var result = await _klijentService.Get<List<Model.Models.Klijent>>(searchRequest);
            result.Insert(0, new Model.Models.Klijent());

            ComboBoxLoad<Model.Models.Klijent> cmbLoad = new ComboBoxLoad<Model.Models.Klijent>();
            cmbLoad.Load(cmb, result, "Ime", "KlijentId");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void frmNovaPorukaNoviKlijent_Load(object sender, EventArgs e)
        {
            await LoadKlijenti(cmbPrimaoc);
        }

        private async void btnPosalji_Click(object sender, EventArgs e)
        {
            PorukaUpsertRequest porukaUpsert = new PorukaUpsertRequest();
            var KlijentObj = cmbPrimaoc.SelectedValue;
            if (KlijentObj == null)
                KlijentObj = 0;
            if (int.TryParse(KlijentObj.ToString(), out int KlijentId))
            {
                porukaUpsert.KlijentId = KlijentId;
            }
            porukaUpsert.DatumVrijeme = DateTime.Now;
            porukaUpsert.UposlenikId = _UposlenikID;
            porukaUpsert.Procitano = false;
            porukaUpsert.Sadrzaj = txtSadrzaj.Text;
            porukaUpsert.Naslov = txtNaslov.Text;
            porukaUpsert.Posiljaoc = "Uposlenik";
            var entity = await _porukaService.Insert<Model.Models.Poruka>(porukaUpsert);
            if (entity != null)
            {
                MessageBox.Show("Poruka je uspješno poslana");
                this.Close();
            }

            //try
            //{
            //    await connection.InvokeAsync("SendMessage",
            //        "Uposlenik",txtNaslov.Text, txtSadrzaj.Text);
            //}
            //catch (Exception ex)
            //{
            //    //messagesList.Items.Add(ex.Message);
            //    throw;
            //}
        }
    }
}
