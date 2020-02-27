using Nekretnine.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nekretnine.Mobile.Views.Nekretnine
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NekretnineDetailsPage : ContentPage
	{
        private NekretnineDetailsViewModel model = null;
        public int KlijentID, NekretninaID; 
        public NekretnineDetailsPage()
        {
            BindingContext = model = new NekretnineDetailsViewModel();
        }

        private async  void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OcjenaKomentarPage(NekretninaID,KlijentID));
        }
        private async void Button1_Clicked(object sender, EventArgs e)
        {
            await model.SpasiNekretninu();
            model.Init();
        }
        public NekretnineDetailsPage (int KlijentId,int NekretninaId)
		{
            KlijentID = KlijentId;
            NekretninaID = NekretninaId;
			InitializeComponent ();
            BindingContext = model = new NekretnineDetailsViewModel();
            model.KlijentID = KlijentID;
            model.NekretninaID = NekretninaID;
            
		} 
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
	}
}