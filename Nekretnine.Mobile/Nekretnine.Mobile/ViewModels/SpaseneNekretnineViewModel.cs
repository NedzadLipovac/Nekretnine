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
    public class SpaseneNekretnineViewModel:BaseViewModel
    {
        public int KlijentID, NekretninaID;
        private readonly APIService _spaseneNekretnineService = new APIService("SpaseneNekretnine");
        private readonly APIService _nekretnineService = new APIService("Nekretnina");

        public SpaseneNekretnineViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }
        public SpaseneNekretnineViewModel(int KlijentId,int NekretninaId)
        {
            KlijentID = KlijentId;
            NekretninaID = NekretninaId;
            InitCommand = new Command(async () => await Init());

        }

        public ObservableCollection<Nekretnina> NekretninaList { get; set; } = new ObservableCollection<Nekretnina>();

        public ObservableCollection<SpaseneNekretnine> SpaseneNekretnineList { get; set; } = new ObservableCollection<SpaseneNekretnine>();
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
        
            SpaseneNekretnineSearchRequest search = new SpaseneNekretnineSearchRequest();

            search.NekretninaId = 0;
            search.KlijentId = KlijentID;
            var list = await _spaseneNekretnineService.Get<List<Model.Models.SpaseneNekretnine>>(search);
            var nek = await _nekretnineService.Get<List<Model.Models.Nekretnina>>(null);
            SpaseneNekretnineList.Clear();
            NekretninaList.Clear();
            foreach (var nekretnina in list)
            {
                SpaseneNekretnineList.Add(nekretnina);
                for (int i = 0; i < nek.Count; i++)
                {
                    if(nek[i].NekretninaId==nekretnina.NekretninaId)
                    {
                        NekretninaList.Add(nek[i]);
                        break;
                    }
                }                
            }

        }
    }
}
