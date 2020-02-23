using System;
using System.Collections.Generic;

namespace Nekretnine.WebApi.Database
{
    public partial class Klijent
    {
        public Klijent()
        {
            Komentar = new HashSet<Komentar>();
            Ocjena = new HashSet<Ocjena>();
            Poruka = new HashSet<Poruka>();
            Sastanak = new HashSet<Sastanak>();
            SpaseneNekretnine = new HashSet<SpaseneNekretnine>();
            UpitZaSastanak = new HashSet<UpitZaSastanak>();
        }

        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int? GradId { get; set; }
        public bool? Status { get; set; }
        public string Username { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual ICollection<Komentar> Komentar { get; set; }
        public virtual ICollection<Ocjena> Ocjena { get; set; }
        public virtual ICollection<Poruka> Poruka { get; set; }
        public virtual ICollection<Sastanak> Sastanak { get; set; }
        public virtual ICollection<SpaseneNekretnine> SpaseneNekretnine { get; set; }
        public virtual ICollection<UpitZaSastanak> UpitZaSastanak { get; set; }
    }
}
