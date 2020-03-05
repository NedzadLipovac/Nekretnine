using Nekretnine.Mobile.ViewModels;
using Nekretnine.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nekretnine.Mobile.Views.Poruke
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MessagesPage : ContentPage
	{
        int KlijentID;
        private PorukaViewModel model = null;

        public MessagesPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, true);

        }
        public MessagesPage (int KlijentId)
		{
			InitializeComponent ();
            KlijentID = KlijentId;
            BindingContext = model = new PorukaViewModel(KlijentID);
            NavigationPage.SetHasNavigationBar(this, true);


        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewMessagePage(KlijentID));
        }

        private async void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Poruka;
            if (item.Posiljaoc == "Uposlenik")
                await model.OznaciKaoProcitanu(item);
            await Navigation.PushAsync(new MessageDetailsPage(item));

        }
    }
}