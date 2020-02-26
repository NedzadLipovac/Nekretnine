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
    public partial class frmNovaPoruka : Form
    {
        private readonly APIService _porukaService = new APIService("Poruka");
        private readonly APIService _klijentService = new APIService("Klijent");

        private int _KlijentID, _UposlenikID = 0;

        public frmNovaPoruka(int KID, int UID)
        {
            _KlijentID = KID;
            _UposlenikID = UID;
            InitializeComponent();
        }

        private async void frmNovaPoruka_Load(object sender, EventArgs e)
        {
            var klijent = await _klijentService.GetById<Model.Models.Klijent>(_KlijentID);
            lblPrimaoc.Text = klijent.Ime + " " + klijent.Prezime + " (" + klijent.Username + " )";

        }
        //Slanje poruke
        private async void btnPosalji_Click(object sender, EventArgs e)
        {
           

            PorukaUpsertRequest porukaUpsert = new PorukaUpsertRequest();

            porukaUpsert.DatumVrijeme = DateTime.Now;
            porukaUpsert.UposlenikId = _UposlenikID;
            porukaUpsert.KlijentId = _KlijentID;
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

        }

      
    }
}
