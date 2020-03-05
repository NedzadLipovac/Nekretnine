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

namespace Nekretnine.WinUI.Home
{
    public partial class frmHome : Form
    {
        private readonly APIService _klijentService = new APIService("Klijent");
        private readonly APIService _nekretninaService = new APIService("Nekretnina");
        private readonly APIService _ocjenaService = new APIService("Ocjena");

        public frmHome()
        {
            InitializeComponent();
        }

        private async  void frmHome_Load(object sender, EventArgs e)
        {
            await Ucitaj();
        }

        private async Task Ucitaj()
        {
            string brojNekretnina, brojKlijenata;
            KlijentSearchRequest klijentSearch = new KlijentSearchRequest();
            klijentSearch.Status = true;
            var listaKlijenata = await _klijentService.Get<List<Model.Models.Klijent>>(klijentSearch);

            NekretninaSearchRequest nekretninaSearch = new NekretninaSearchRequest();
            var listaNekretnina = await _nekretninaService.Get<List<Model.Models.Nekretnina>>(null);

            var listaOcjena = await _ocjenaService.Get<List<Model.Models.Ocjena>>(null);

            double suma = 0;
            int brojOcjenaNekretnine=0;
            double prosjekNekretnine = 0;
            foreach (var n in listaNekretnina)
            {
                suma = 0;
                brojOcjenaNekretnine = 0;
                foreach (var o in listaOcjena)
                {
                    if(o.NekretninaId==n.NekretninaId)
                    {
                        suma += o.Ocjena1;
                        brojOcjenaNekretnine++;
                    }
                }
                if(suma>0)
                {
                    prosjekNekretnine += (suma / brojOcjenaNekretnine);
                }

            }

            prosjekNekretnine = prosjekNekretnine / listaNekretnina.Count;
            lblProsjecnaOcjena.Text = prosjekNekretnine.ToString();

            brojNekretnina = listaNekretnina.Count.ToString();
            brojKlijenata = listaKlijenata.Count.ToString();
            lblBrojKlijenata.Text = brojKlijenata;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblProsjecnaOcjena_Click(object sender, EventArgs e)
        {

        }
    }
}
