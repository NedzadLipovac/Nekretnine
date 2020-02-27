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
	public partial class SpaseneNekretninePage : ContentPage
	{
        int _KlijentId;
        SpaseneNekretnineViewModel model = null;
		public SpaseneNekretninePage ()
		{

			InitializeComponent ();
            BindingContext = model = new SpaseneNekretnineViewModel()
            {
                KlijentID = _KlijentId
            };
		}
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        public SpaseneNekretninePage(int KlijentId)
        {
            InitializeComponent();

            _KlijentId = KlijentId;
            BindingContext = model = new SpaseneNekretnineViewModel()
            {
                KlijentID = _KlijentId
            };

        }


        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var Item = e.SelectedItem as Model.Models.Nekretnina;
            await Navigation.PushAsync(new NekretnineDetailsPage(_KlijentId,Item.NekretninaId));
        }
    }
}