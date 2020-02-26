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
   public class NekretnineViewModel:BaseViewModel
    {
        private readonly APIService _nekretnineService = new APIService("Nekretnina");
        private readonly APIService _gradService = new APIService("Grad");

        public NekretnineViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Nekretnina> NekretninaList { get; set; } = new ObservableCollection<Nekretnina>();
        public ObservableCollection<Grad> GradNekretnine { get; set; } = new ObservableCollection<Grad>();

        Grad _gradNekretnine = null;
        public Grad SelectedGradNekretnine
        {
            get { return _gradNekretnine; }
            set
            {
                SetProperty(ref _gradNekretnine, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (GradNekretnine.Count == 0)
            {
                var gradNekretninelaList = await _gradService.Get<List<Grad>>(null);

                foreach (var grad in gradNekretninelaList)
                {
                    GradNekretnine.Add(grad);
                }
            }
            NekretninaSearchRequest search= new NekretninaSearchRequest();
            if(SelectedGradNekretnine!=null)
            {
                search.GradId = SelectedGradNekretnine.GradId;
            }

            var list = await _nekretnineService.Get<List<Model.Models.Nekretnina>>(search);
            NekretninaList.Clear();
            foreach (var nekretnina in list)
            {
                NekretninaList.Add(nekretnina);
            }

        }


    }
}
