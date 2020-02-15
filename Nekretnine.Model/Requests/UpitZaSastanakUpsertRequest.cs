using System;
using System.Collections.Generic;
using System.Text;

namespace Nekretnine.Model.Requests
{
   public class UpitZaSastanakUpsertRequest
    {
        public int UpitZaSastanakId { get; set; }
        public string NazivSastanka { get; set; }
        public DateTime? PredlozeniDatum { get; set; }
        public int? KlijentId { get; set; }
    }
}
