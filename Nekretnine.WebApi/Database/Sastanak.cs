using System;
using System.Collections.Generic;

namespace Nekretnine.WebApi.Database
{
    public partial class Sastanak
    {
        public int SastanakId { get; set; }
        public int KlijentId { get; set; }
        public string Mjesto { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public string Opis { get; set; }

        public virtual Klijent Klijent { get; set; }
    }
}
