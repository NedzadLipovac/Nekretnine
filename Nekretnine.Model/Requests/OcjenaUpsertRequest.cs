using System;
using System.Collections.Generic;
using System.Text;

namespace Nekretnine.Model.Requests
{
    public class OcjenaUpsertRequest
    {
        public int OcjenaId { get; set; }
        public int KlijentId { get; set; }
        public int NekretninaId { get; set; }
        public int Ocjena1 { get; set; }
        public DateTime DatumVrijeme { get; set; }
    }
}
