using System;
using System.Collections.Generic;
using System.Text;

namespace Nekretnine.Model.Requests
{
    public class SlikaUpsertRequest
    {
        public int SlikaId { get; set; }
        public byte[] NazivSlike{ get; set; }
        public int NekretninaId { get; set; }
    }
}
