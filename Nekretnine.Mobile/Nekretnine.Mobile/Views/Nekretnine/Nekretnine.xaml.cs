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
	public partial class Nekretnine : ContentPage
	{
        private NekretnineViewModel model = null;
        public int KlijentID;
		public Nekretnine(int KlijentId)
		{
            KlijentID = KlijentId;
			InitializeComponent ();
            BindingContext = model = new NekretnineViewModel();

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var Item = e.SelectedItem as Model.Models.Nekretnina;
            await Navigation.PushAsync(new NekretnineDetailsPage(KlijentID,Item.NekretninaId));
        }
    }
}