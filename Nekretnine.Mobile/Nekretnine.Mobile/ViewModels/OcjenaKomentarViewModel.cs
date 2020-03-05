using Nekretnine.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Nekretnine.Mobile.ViewModels
{
    public class OcjenaKomentarViewModel:BaseViewModel
    {
        private readonly APIService _komentarService = new APIService("Komentar");
        private readonly APIService _ocjeneService = new APIService("Ocjena");

        public OcjenaKomentarViewModel()
        {
            InitCommand = new Command(async () => await Init());
            CommentCommand = new Command(() => DodajKomentar());
        }

        public void DodajKomentar()
        {
            if (KomentarValue.Length.Equals(0))
            {
                Application.Current.MainPage.DisplayAlert("Greska", "Unesite validan komentar ", "OK");
                return;
            }
            KomentarUpsertRequest komentarUpsertRequest = new KomentarUpsertRequest();
            komentarUpsertRequest.DatumVrijeme = DateTime.Now;
            komentarUpsertRequest.KlijentId = KlijentId;
            komentarUpsertRequest.NekretninaId = NekretninaId;
            komentarUpsertRequest.KomentarValue = KomentarValue;

            var entity = _komentarService.Insert<Model.Models.Komentar>(komentarUpsertRequest);
            if(entity!=null)
            {
                Application.Current.MainPage.DisplayAlert("Obavijest", "Uspjesno ste dodali komentar", "OK");
                KomentarValue = "";
            }
        }
       public OcjenaUpsertRequest novaOcjena { get; set; } = new OcjenaUpsertRequest();
        public List<int> ocjene { get; set; } = new List<int>();

        string _komentarValue = string.Empty;
        public string KomentarValue
        {
            get { return _komentarValue; }
            set { SetProperty(ref _komentarValue, value); }
        }
        bool _mozeOcijenit = true;
        public bool MozeOcijenit
        {
            get { return _mozeOcijenit; }
            set { SetProperty(ref _mozeOcijenit, value); }
        }


        int _klijentId =0;
        public int KlijentId
        {
            get { return _klijentId; }
            set { SetProperty(ref _klijentId, value); }
        }

        int _nekretninaId = 0;
        public int NekretninaId
        {
            get { return _nekretninaId; }
            set { SetProperty(ref _nekretninaId, value); }
        }
        public ICommand CommentCommand;
        public ICommand InitCommand;

        public async Task Init()
        {
            OcjenaSearchRequest searchRequest = new OcjenaSearchRequest();
            searchRequest.KlijentId = _klijentId;
            searchRequest.NekretninaId = _nekretninaId;
            var entity =await _ocjeneService.Get<List<Model.Models.Ocjena>>(searchRequest);
            if(entity.Count>0)
            {
                MozeOcijenit = false;
            }
            else
            {
                MozeOcijenit = true;
            }
        }

        public async Task DodajOcjenu(float ocjena)
        {
            novaOcjena.Ocjena1 = (int)ocjena;
            novaOcjena.DatumVrijeme = DateTime.Now;
            novaOcjena.KlijentId = _klijentId;
            novaOcjena.NekretninaId = _nekretninaId;

            try
            {
                var entity = await _ocjeneService.Insert<Model.Models.Ocjena>(novaOcjena);
               

                if (entity != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Obavijest", "Upješno ste ocijenili nekretninu", "OK");
                    await Init();
                }
            }
            catch (Exception ex)
            {

                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "OK");


            }
        }
    }
}
