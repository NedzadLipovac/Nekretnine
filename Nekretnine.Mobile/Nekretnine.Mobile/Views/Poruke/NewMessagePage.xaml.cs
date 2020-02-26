using Nekretnine.Mobile.ViewModels;
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
	public partial class NewMessagePage : ContentPage
	{
        public NovaPorukaViewModel model = null;
        int KliljentID;
        public NewMessagePage ()
		{

			InitializeComponent ();
            BindingContext = model = new NovaPorukaViewModel();
            
		}
        public NewMessagePage(int KlijentId)
        {

            KliljentID = KlijentId;
            InitializeComponent();
            BindingContext = model = new NovaPorukaViewModel();
            model.Poruka.KlijentId = KliljentID;
            model.KlijentID = KliljentID;

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void ButtonPosalji_Clicked(object sender, EventArgs e)
        {

        }
    }
}