using Nekretnine.Mobile.Models;
using Nekretnine.Mobile.Views.Nekretnine;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nekretnine.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        int KlijentID;
        public MainPage(int KlijentId)
        {
            InitializeComponent();

            KlijentID = KlijentId;
            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.Nekretnine:
                        MenuPages.Add(id, new NavigationPage(new Nekretnine.Nekretnine(KlijentID)));
                        break;
                    case (int)MenuItemType.Poruke:
                        MenuPages.Add(id, new NavigationPage(new Poruke.MessagesPage(KlijentID)));
                        break;
                    case (int)MenuItemType.UpitZaSastanak:
                        MenuPages.Add(id, new NavigationPage(new UpitZaSastanak.UpitZaSastanakPage(KlijentID)));
                        break;
                    case (int)MenuItemType.MojeNekretnine:
                        MenuPages.Add(id, new NavigationPage(new Nekretnine.SpaseneNekretninePage(KlijentID)));
                        break;

                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}