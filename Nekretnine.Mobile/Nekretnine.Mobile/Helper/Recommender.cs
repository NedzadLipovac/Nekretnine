using Nekretnine.Model.Models;
using Nekretnine.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nekretnine.Mobile.Helper
{
    public class Recommender
    {
        private readonly APIService _ocjeneService = new APIService("Ocjena");
        private readonly APIService _nekretninaService = new APIService("Nekretnina");

        Dictionary<int, List<Model.Models.Ocjena>> nekretnine = new Dictionary<int, List<Model.Models.Ocjena>>();
        List<Ocjena> ocjenePosmatraneNekretnine;
        List<Nekretnina> _nekretnine;


        public async Task<List<Nekretnina>> GetPreporuceneNekretnine(int nekretninaId)
        {
            List<Nekretnina> _preporuceneNekretnine = new List<Nekretnina>();

            Nekretnina posmatranaNekretnina = new Nekretnina();
            posmatranaNekretnina = await _nekretninaService.GetById<Nekretnina>(nekretninaId);

            NekretninaSearchRequest nekretninaSearchRequest = new NekretninaSearchRequest();
            nekretninaSearchRequest.GradId = posmatranaNekretnina.GradId;

            OcjenaSearchRequest ocjenaSearchRequest = new OcjenaSearchRequest();

            List<Nekretnina> nekretnine = await _nekretninaService.Get<List<Model.Models.Nekretnina>>(nekretninaSearchRequest);
            foreach (var nekretnina in nekretnine)
            {
                if (nekretnina.NekretninaId!=nekretninaId)
                {

                    ocjenaSearchRequest.NekretninaId = nekretnina.NekretninaId;
                    List<Ocjena> ocjeneNekretnine = await _ocjeneService.Get<List<Ocjena>>(ocjenaSearchRequest);

                    double prosjekOcjena = 0;
                    foreach (var o in ocjeneNekretnine)
                    {
                        prosjekOcjena += o.Ocjena1;
                    }

                    prosjekOcjena = prosjekOcjena / ocjeneNekretnine.Count;

                    if (prosjekOcjena >= 2.5 && nekretnina.NekretninaId != nekretninaId)
                    {
                        _preporuceneNekretnine.Add(nekretnina);
                    }

                }
            }
            return _preporuceneNekretnine;
        }


        public List<Model.Models.Nekretnina>GetSlicneNekretnine(int nekretninaID)
        {
            UcitajNekretnine(nekretninaID);

            List<Ocjena> zajednickeOcjene1 = new List<Ocjena>();
            List<Ocjena> zajednickeOcjene2 = new List<Ocjena>();
            List<Model.Models.Nekretnina> preporuceneNekretnine = new List<Nekretnina>();

            foreach (var item in nekretnine)
            {
                bool prvi = true;
                foreach (var o in ocjenePosmatraneNekretnine)
                {  
                    foreach (var ocjeneNekretnine in item.Value.ToArray())
                    {
                        if (ocjeneNekretnine.KlijentId==o.KlijentId)
                        {
                            zajednickeOcjene1.Add(o);
                            if (prvi)
                            {
                                zajednickeOcjene2.Add(ocjeneNekretnine);
                                prvi = false;
                            } 
                        }
                    }

                    double slicnost = GetSlicnost(zajednickeOcjene1, zajednickeOcjene2);
                    if (slicnost > 0.5)
                    {
                        bool ima = true;
                        foreach (var v in _nekretnine)
                        {
                            if (v.NekretninaId == nekretninaID && ima)
                            {
                                preporuceneNekretnine.Add(v);
                                ima = false;
                            }
                        }

                    }
                    zajednickeOcjene1.Clear();
                    zajednickeOcjene2.Clear();
                }

            }
            return preporuceneNekretnine;
        }

        private double GetSlicnost(List<Ocjena> zajednickeOcjene1, List<Ocjena> zajednickeOcjene2)
        {
            if (zajednickeOcjene1.Count != zajednickeOcjene2.Count)
                return 0;

            double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;

            for (int i = 0; i < zajednickeOcjene1.Count; i++)
            {
                brojnik = zajednickeOcjene1[i].Ocjena1 * zajednickeOcjene2[i].Ocjena1;
                nazivnik1 = zajednickeOcjene1[i].Ocjena1 * zajednickeOcjene1[i].Ocjena1;
                nazivnik2 = zajednickeOcjene2[i].Ocjena1 * zajednickeOcjene2[i].Ocjena1;
            }
            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);

            double nazivnik = nazivnik1 * nazivnik2;
            if (nazivnik == 0)
                return 0;
            else
                return brojnik / nazivnik;
        }

        private async void UcitajNekretnine(int nekretninaID)
        {
            NekretninaSearchRequest request = new NekretninaSearchRequest();
            OcjenaSearchRequest ocjenaSearch = new OcjenaSearchRequest();

            ocjenaSearch.NekretninaId = nekretninaID;
            ocjenePosmatraneNekretnine = await _ocjeneService.Get<List<Model.Models.Ocjena>>(ocjenaSearch);
            _nekretnine = await _nekretninaService.Get<List<Nekretnina>>(request);

            List<Model.Models.Nekretnina> _aktivneNekretnine =await _nekretninaService.Get<List<Model.Models.Nekretnina>>(null);
            List<Model.Models.Ocjena> ocjene;

            foreach (var item in _aktivneNekretnine)
            {
                ocjenaSearch.NekretninaId = item.NekretninaId;
                ocjene = await _ocjeneService.Get<List<Model.Models.Ocjena>>(ocjenaSearch);
                if (ocjene.Count > 0)
                    nekretnine.Add(item.NekretninaId, ocjene);

            }



        }
    }
}
