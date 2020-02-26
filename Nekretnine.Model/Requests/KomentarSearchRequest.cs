using System;
using System.Collections.Generic;
using System.Text;

namespace Nekretnine.Model.Requests
{
    public class KomentarSearchRequest
    {
        public int KlijentId { get; set; }
        public int NekretninaId { get; set; }
    }
}
