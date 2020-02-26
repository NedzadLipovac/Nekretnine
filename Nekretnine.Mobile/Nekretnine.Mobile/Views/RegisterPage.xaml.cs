using Nekretnine.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nekretnine.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterPage : ContentPage
	{
        private RegisterViewModel model = null;
		public RegisterPage ()
		{
			InitializeComponent ();
            BindingContext = model = new RegisterViewModel();
		}
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }

        private async void Entry_Unfocused(object sender, FocusEventArgs e)
        {
            Entry password = (Entry)FindByName("password");
            Entry passwordConfirm = (Entry)FindByName("passwordConfirm");

            if (password.Text != "" && password.Text != passwordConfirm.Text)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Lozinke se ne podudaraju", "OK");

            }
        }
    }
}