using System;
using System.Collections.Generic;
using System.Text;

namespace Nekretnine.Model.Requests
{
   public class OcjenaSearchRequest
    {
        public int OcjenaId { get; set; }
        public int KlijentId { get; set; }
        public int NekretninaId { get; set; } 
    }
}
