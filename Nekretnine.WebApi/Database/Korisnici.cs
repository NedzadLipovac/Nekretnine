using System;
using System.Collections.Generic;

namespace Nekretnine.WebApi.Database
{
    public partial class Korisnici
    {
        public Korisnici()
        {
            KorisniciUloge = new HashSet<KorisniciUloge>();
            Poruka = new HashSet<Poruka>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prazime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int? GradId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual ICollection<KorisniciUloge> KorisniciUloge { get; set; }
        public virtual ICollection<Poruka> Poruka { get; set; }
    }
}
