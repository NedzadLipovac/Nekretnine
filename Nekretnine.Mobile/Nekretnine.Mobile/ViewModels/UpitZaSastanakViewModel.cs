using Nekretnine.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Nekretnine.Mobile.ViewModels
{
    public class UpitZaSastanakViewModel:BaseViewModel
    {
        private readonly APIService _upitService = new APIService("UpitZaSastanak");
        public int _KlijentID;
        public UpitZaSastanakViewModel()
        {
            predloziCommand = new Command(async () => await Predlozi());
        }
        public UpitZaSastanakViewModel(int KlijentId)
        {
            _KlijentID = KlijentId;
            predloziCommand = new Command(async () => await Predlozi());

        }
        public ICommand predloziCommand { get; set; }

        public UpitZaSastanakUpsertRequest upit = new UpitZaSastanakUpsertRequest();

        private string _nazivSastanka;
        public string NazivSastanka
        {
            get { return _nazivSastanka; }
            set { SetProperty(ref _nazivSastanka, value); }
        }
        private DateTime _datum;
        public DateTime Datum
        {
            get { return _datum; }
            set { SetProperty(ref _datum, value); }
        }
        public async Task Predlozi()
        {
            if(_KlijentID>0)
            {
                upit.KlijentId = _KlijentID;
                upit.NazivSastanka = NazivSastanka;
                upit.PredlozeniDatum = Datum;
                var entity = await _upitService.Insert<Model.Models.UpitZaSastanak>(upit);
                if(entity!=null)
                {
                    await Application.Current.MainPage.DisplayAlert("Obavijest", "Uspjesno ste predlozili sastanak", "OK");
                }
            }
        }
    }
}
