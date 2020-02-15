using System;
using System.Collections.Generic;
using System.Text;

namespace Nekretnine.Model.Requests
{
   public  class SastanakUpsertRequest
    {
        public int SastanakId { get; set; }
        public int KlijentId { get; set; }
        public string Mjesto { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public string Opis { get; set; }
        
    }
}
