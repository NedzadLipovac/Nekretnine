using System;
using System.Collections.Generic;

namespace Nekretnine.WebApi.Database
{
    public partial class SpaseneNekretnine
    {
        public int SpasenaNekretninaId { get; set; }
        public int KlijentId { get; set; }
        public int NekretninaId { get; set; }
        public DateTime DatumIzmjene { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Nekretnina Nekretnina { get; set; }
    }
}
