using System;
using System.Collections.Generic;
using System.Text;

namespace Nekretnine.Model.Models
{
     public class UpitZaSastanak
    {
        public int UpitZaSastanakId { get; set; }
        public string NazivSastanka { get; set; }
        public DateTime? PredlozeniDatum { get; set; }

        public string Klijent { get; set; }
        public int? KlijentId { get; set; }
    }
}
