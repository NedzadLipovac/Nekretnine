using Nekretnine.Model.Models;
using Nekretnine.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Nekretnine.Mobile.ViewModels
{
    public class NovaPorukaViewModel:BaseViewModel
    {
        private readonly APIService _porukaService = new APIService("Poruka");
        private readonly APIService _klijentService = new APIService("Klijent");
       public int KlijentID;
        public NovaPorukaViewModel()
        {
            PosaljiCommand = new Command(async () => await PosaljiPoruku());
            InitCommand = new Command(async () => await Init());
            Poruka = new Poruka();
            Poruka.DatumVrijeme = DateTime.Now;
        }
        public NovaPorukaViewModel(Poruka p)
        {

        }
        

        public PorukaUpsertRequest novaPoruka { get; set; } = new PorukaUpsertRequest();
        public Poruka Poruka { get; set; }

        public string _sadrzajPoruke = string.Empty;
        public string SadrzajPoruke
        {
            get { return _sadrzajPoruke; }
            set { SetProperty(ref _sadrzajPoruke, value); }
        }
        public string _naslovPoruke = string.Empty;
        public string NaslovPoruke
        {
            get { return _naslovPoruke; }
            set { SetProperty(ref _naslovPoruke, value); }
        }

        public byte[] _posiljaocSlikaThumb;
        public byte[] PosiljaocSlikaThumb
        {
            get { return _posiljaocSlikaThumb; }
            set { SetProperty(ref _posiljaocSlikaThumb, value); }
        }

        public Command PosaljiCommand { get; set; }
        public ICommand InitCommand { get; set; }

        private string posiljaoc = string.Empty;
        public string Posiljaoc
        {
            get { return posiljaoc; }
            set { SetProperty(ref posiljaoc, value); }
        }

        public async Task Init()
        {
            var k = await _klijentService.GetById<Model.Models.Klijent>(KlijentID);
            Poruka.PosiljaocInfo = k.Ime + " " + k.Prezime;
            Posiljaoc = k.Ime + " " + k.Prezime;
        }


        public async Task PosaljiPoruku()
        {

            novaPoruka.KlijentId = Poruka.KlijentId;
            novaPoruka.UposlenikId = 6;
            novaPoruka.DatumVrijeme = DateTime.Now;
            novaPoruka.Naslov = NaslovPoruke;
            novaPoruka.Procitano = false;
            novaPoruka.Posiljaoc = "Klijent";
            novaPoruka.Sadrzaj = SadrzajPoruke;
            if(SadrzajPoruke.Equals(0) || NaslovPoruke.Length.Equals(0))
            {
                await Application.Current.MainPage.DisplayAlert("Greska", "Naslov i sadrzaj su obavezni", "OK");
                return;

            }
            try
            {
              var entitny=  await _porukaService.Insert<Model.Models.Poruka>(novaPoruka);
                if(entitny!=null)
                {
                    await Application.Current.MainPage.DisplayAlert("Obavijest","Uspjesno ste poslali poruku", "OK");
                    SadrzajPoruke = "";
                    NaslovPoruke = "";

                }

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "OK");

            }
        }

    }
}
