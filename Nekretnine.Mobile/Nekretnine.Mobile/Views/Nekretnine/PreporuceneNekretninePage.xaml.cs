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
	public partial class PreporuceneNekretninePage : ContentPage
	{
        private NekretnineDetailsViewModel model = null;
		public PreporuceneNekretninePage ()
		{
			InitializeComponent ();
            BindingContext = model = new NekretnineDetailsViewModel();
		}
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.UcitajPreporucene();
        }
    }
}