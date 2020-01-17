using System;
using System.Collections.Generic;

namespace Nekretnine.WebApi.Database
{
    public partial class Uloga
    {
        public Uloga()
        {
            KorisniciUloge = new HashSet<KorisniciUloge>();
        }

        public int UogaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<KorisniciUloge> KorisniciUloge { get; set; }
    }
}
