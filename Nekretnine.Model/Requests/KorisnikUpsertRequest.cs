using Nekretnine.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nekretnine.Model.Requests
{
    public class KorisnikUpsertRequest
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Password { get; set; }
        public string PasswordPotvrda { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int? GradId { get; set; }
        public bool Status { get; set; }
        public string Username { get; set; }


        //public virtual ICollection<KorisniciUloge> KorisniciUloge { get; set; }
    }
}
