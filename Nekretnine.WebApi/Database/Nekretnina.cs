using System;
using System.Collections.Generic;

namespace Nekretnine.WebApi.Database
{
    public partial class Nekretnina
    {
        public Nekretnina()
        {
            Komentar = new HashSet<Komentar>();
            Ocjena = new HashSet<Ocjena>();
            Slika = new HashSet<Slika>();
            SpaseneNekretnine = new HashSet<SpaseneNekretnine>();
        }

        public int NekretninaId { get; set; }
        public string Adresa { get; set; }
        public string GodinaIzgradnje { get; set; }
        public int Kvadratura { get; set; }
        public string Vlasnik { get; set; }
        public bool? Prodaja { get; set; }
        public int? GradId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual ICollection<Komentar> Komentar { get; set; }
        public virtual ICollection<Ocjena> Ocjena { get; set; }
        public virtual ICollection<Slika> Slika { get; set; }
        public virtual ICollection<SpaseneNekretnine> SpaseneNekretnine { get; set; }
    }
}
