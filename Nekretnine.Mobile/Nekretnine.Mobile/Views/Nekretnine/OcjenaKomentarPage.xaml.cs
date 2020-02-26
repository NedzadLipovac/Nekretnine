using Nekretnine.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nekretnine.Mobile.Views.Nekretnine
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OcjenaKomentarPage : ContentPage
	{
        OcjenaKomentarViewModel model = null;
        public int KlijentID, NekretninaID;
        public OcjenaKomentarPage ()
		{
            InitializeComponent();

            BindingContext = model = new OcjenaKomentarViewModel();

		}
        public OcjenaKomentarPage(int NekretninaId,int KlijentId)
        {
            InitializeComponent();

            BindingContext = model = new OcjenaKomentarViewModel();

            KlijentID = KlijentId;
            NekretninaID = NekretninaId;
            model.KlijentId = KlijentID;
            model.NekretninaId = NekretninaID;
            //model.novaOcjena = new Model.Requests.OcjenaUpsertRequest();
        }
        protected async override void  OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            model.DodajKomentar();
        }

        private void OnRatingChanged(object sender, float e)
        {
        }

        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            //model.novaOcjena.Ocjena1 = 1;
            await model.DodajOcjenu(1);

        }

        private async void Btn2_Clicked(object sender, EventArgs e)
        {
            //model.novaOcjena.Ocjena1 = 2;
            await model.DodajOcjenu(2);

        }

        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            //model.novaOcjena.Ocjena1 = 3;
            await model.DodajOcjenu(3);

        }

        private async void Btn4_Clicked(object sender, EventArgs e)
        {
            //model.novaOcjena.Ocjena1 = 4;
            await model.DodajOcjenu(4);


        }

        private async void Btn5_Clicked(object sender, EventArgs e)
        {
            //model.novaOcjena.Ocjena1 = 5;
            await model.DodajOcjenu(1);


        }

        private  void CustomRatingBar_RatingChanged(object sender, float e)
        {

        }

    }
}