using System;
using System.Collections.Generic;
using System.Text;

namespace Nekretnine.Model.Requests
{
   public class NekretninaUpsertRequest
    {
        public int NekretninaId { get; set; }
        public string Adresa { get; set; }
        public string GodinaIzgradnje { get; set; }
        public int Kvadratura { get; set; }
        public string Vlasnik { get; set; }
        public bool? Prodaja { get; set; }
        public int? GradId { get; set; }
        public string Naziv { get; set; }

    }
}
