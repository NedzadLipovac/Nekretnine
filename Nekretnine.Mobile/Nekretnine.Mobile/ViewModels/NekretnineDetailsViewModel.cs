using Nekretnine.Mobile.Helper;
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
        private readonly APIService _spaseneNekretnineService = new APIService("SpaseneNekretnine");


        public static int KlijentID, NekretninaID;
        public NekretnineDetailsViewModel()
        {
            OcjenaKomentarCommand = new Command(() => OcjenaKomentar());

        }
        Model.Models.Nekretnina Nekretnina = new Model.Models.Nekretnina();
        public ObservableCollection<Slika> Slike { get; set; } = new ObservableCollection<Slika>();
        public ObservableCollection<Nekretnina> PreporuceneNekretnine { get; set; } = new ObservableCollection<Nekretnina>();

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
        private bool _mozeSpasti = false;
        public bool MozeSpasit
        {
            get { return _mozeSpasti; }
            set { SetProperty(ref _mozeSpasti, value); }
        }

        private bool _imaPreporucenih = false;
        public bool ImaPreporucenih
        {
            get { return _imaPreporucenih; }
            set { SetProperty(ref _imaPreporucenih, value); }
        }

        public ICommand SpasiCommand { get; set; }

        public async Task SpasiNekretninu()
        {
           
            SpaseneNekretnineUpsertRequest upsertRequest = new SpaseneNekretnineUpsertRequest();
            upsertRequest.DatumIzmjene = DateTime.Now;
            upsertRequest.KlijentId = KlijentID;
            upsertRequest.NekretninaId = NekretninaID;

            var entity = await _spaseneNekretnineService.Insert<Model.Models.SpaseneNekretnine>(upsertRequest);
            if(entity!=null)
            {
                await Application.Current.MainPage.DisplayAlert("Obavijest", "Uspjesno ste spasili nekretninu", "OK");
            }
        }
         public async Task UcitajPreporucene()
        {
            PreporuceneNekretnine.Clear();
            Recommender recommender = new Recommender();
            List<Nekretnina> slicneNekretnine = await recommender.GetPreporuceneNekretnine(NekretninaID);
            PreporuceneNekretnine.Clear();
            foreach (var sn in slicneNekretnine)
            {
                PreporuceneNekretnine.Add(sn);
            }

        }
        public async Task Init()
        {
            Recommender recommender = new Recommender();
            List<Nekretnina> slicneNekretnine = await recommender.GetPreporuceneNekretnine(NekretninaID);
            if (slicneNekretnine.Count > 0)
            {
                _imaPreporucenih = true;
            }

            else
                _imaPreporucenih = false;

            var nekretnina = await _nekretnineService.GetById<Model.Models.Nekretnina>(NekretninaID);
            var searchSlika = new SlikaSearchRequest();
            searchSlika.NekretninaId = NekretninaID;
            var slike = await _slikaService.Get<List<Model.Models.Slika>>(searchSlika);
            Slike.Clear();
            foreach (var item in slike)
            {
                Slike.Add(item);
            }

            SpaseneNekretnineSearchRequest searchRequestNekretnina = new SpaseneNekretnineSearchRequest();
            searchRequestNekretnina.KlijentId = KlijentID;
            searchRequestNekretnina.NekretninaId = NekretninaID;
            var entity = await _spaseneNekretnineService.Get<List<Model.Models.SpaseneNekretnine>>(searchRequestNekretnina);
            if(entity.Count>0)
            {
                MozeSpasit = false;
            }
            else
            {
                MozeSpasit = true;
            }
            //Slika = slike[0];
            //SlikaValue = slike[0].NazivSlike;
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
