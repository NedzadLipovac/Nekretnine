using System;
using System.Collections.Generic;

namespace Nekretnine.WebApi.Database
{
    public partial class Grad
    {
        public Grad()
        {
            Klijent = new HashSet<Klijent>();
            Korisnici = new HashSet<Korisnici>();
            Nekretnina = new HashSet<Nekretnina>();
        }

        public int GradId { get; set; }
        public string Naziv { get; set; }
        public int? DrzavaId { get; set; }

        public virtual Drzava Drzava { get; set; }
        public virtual ICollection<Klijent> Klijent { get; set; }
        public virtual ICollection<Korisnici> Korisnici { get; set; }
        public virtual ICollection<Nekretnina> Nekretnina { get; set; }
    }
}
