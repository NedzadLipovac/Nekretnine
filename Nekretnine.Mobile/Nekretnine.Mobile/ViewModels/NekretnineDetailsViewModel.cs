using Nekretnine.Mobile.Views.Nekretnine;
using Nekretnine.Model.Models;
using Nekretnine.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Nekretnine.Mobile.ViewModels
{
    public class NekretnineDetailsViewModel : BaseViewModel
    {
        private readonly APIService _nekretnineService = new APIService("Nekretnina");
        private readonly APIService _slikaService = new APIService("Slika");


        public int KlijentID, NekretninaID;
        public NekretnineDetailsViewModel()
        {
            OcjenaKomentarCommand = new Command(() => OcjenaKomentar());

        }
        Model.Models.Nekretnina Nekretnina = new Model.Models.Nekretnina();
        public ObservableCollection<Slika> Slike { get; set; } = new ObservableCollection<Slika>();

        public ICommand OcjenaKomentarCommand { get; set; }
        public void OcjenaKomentar()
        {
            Application.Current.MainPage = new OcjenaKomentarPage();
        }

        private string _nazivNekretnine = string.Empty;
        public string NazivNekretnine
        {
            get { return _nazivNekretnine; }
            set { SetProperty(ref _nazivNekretnine,value); }
        }
        private string _adresa = string.Empty;
        public string Adresa
        {
            get { return _adresa; }
            set { SetProperty(ref _adresa, value); }
        }
        private string _godinaIzgradnje = string.Empty;
        public string GodinaIzgradnje
        {
            get { return _godinaIzgradnje; }
            set { SetProperty(ref _godinaIzgradnje, value); }
        }
        private int _kvadratura = 0;
        public int Kvadratura
        {
            get { return _kvadratura; }
            set { SetProperty(ref _kvadratura, value); }
        }
        private Slika _slika=null;
        public Slika Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
        }
        private byte[] _slikaValue = null;
        public byte[] SlikaValue
        {
            get { return _slikaValue; }
            set { SetProperty(ref _slikaValue, value); }
        }
        public async Task Init()
        {
            var nekretnina = await _nekretnineService.GetById<Model.Models.Nekretnina>(NekretninaID);
            var searchSlika = new SlikaSearchRequest();
            searchSlika.NekretninaId = NekretninaID;
            var slike = await _slikaService.Get<List<Model.Models.Slika>>(searchSlika);
          
            foreach (var item in slike)
            {
                Slike.Add(item);
            }


            Slika = slike[0];
            SlikaValue = slike[0].NazivSlike;
            Nekretnina.Adresa = nekretnina.Adresa;
            Nekretnina.GodinaIzgradnje = nekretnina.GodinaIzgradnje;
            Nekretnina.Grad = nekretnina.Grad;
            Nekretnina.Kvadratura = nekretnina.Kvadratura;
            Nekretnina.Naziv = nekretnina.Naziv;
            Nekretnina.Vlasnik = nekretnina.Vlasnik;
            NazivNekretnine = nekretnina.Naziv;
            GodinaIzgradnje = nekretnina.GodinaIzgradnje;
            Adresa = nekretnina.Adresa;
            Kvadratura = nekretnina.Kvadratura;

        }
    }
}
