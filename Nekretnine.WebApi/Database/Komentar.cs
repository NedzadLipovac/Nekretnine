using System;
using System.Collections.Generic;

namespace Nekretnine.WebApi.Database
{
    public partial class Komentar
    {
        public int KomentarId { get; set; }
        public int KlijentId { get; set; }
        public int NekretninaId { get; set; }
        public string Komentar1 { get; set; }
        public DateTime DatumVrijeme { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Nekretnina Nekretnina { get; set; }
    }
}
