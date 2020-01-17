using System;
using System.Collections.Generic;

namespace Nekretnine.WebApi.Database
{
    public partial class Poruka
    {
        public int PorukaId { get; set; }
        public int? KlijentId { get; set; }
        public int? UposlenikId { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime? DatumVrijeme { get; set; }
        public bool? Procitano { get; set; }
        public string Posiljaoc { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Korisnici Uposlenik { get; set; }
    }
}
