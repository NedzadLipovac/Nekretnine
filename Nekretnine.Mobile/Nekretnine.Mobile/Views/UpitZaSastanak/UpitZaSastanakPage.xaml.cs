using Nekretnine.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nekretnine.Mobile.Views.UpitZaSastanak
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UpitZaSastanakPage : ContentPage
	{
        UpitZaSastanakViewModel model = null;

		public UpitZaSastanakPage(int KlijentId)
		{
            InitializeComponent();

            BindingContext = model = new UpitZaSastanakViewModel(KlijentId)
            {
                _KlijentID = KlijentId
            };
		}
   
	}
}