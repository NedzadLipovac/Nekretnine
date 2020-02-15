using System;
using System.Collections.Generic;
using System.Text;

namespace Nekretnine.Model.Requests
{
    public class KorisnikSearchRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public int? GradId { get; set; }
        public bool Status { get; set; }
        public string Username { get; set; }


    }
}
