using System;
using System.Collections.Generic;

namespace Nekretnine.WebApi.Database
{
    public partial class Ocjena
    {
        public int OcjenaId { get; set; }
        public int KlijentId { get; set; }
        public int NekretninaId { get; set; }
        public int Ocjena1 { get; set; }
        public DateTime DatumVrijeme { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Nekretnina Nekretnina { get; set; }
    }
}
