using System;
using System.Collections.Generic;

namespace Nekretnine.WebApi.Database
{
    public partial class UpitZaSastanak
    {
        public int UpitZaSastanakId { get; set; }
        public string NazivSastanka { get; set; }
        public DateTime? PredlozeniDatum { get; set; }
        public int? KlijentId { get; set; }

        public virtual Klijent Klijent { get; set; }
    }
}
