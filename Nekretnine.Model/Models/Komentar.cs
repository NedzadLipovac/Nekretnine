﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Nekretnine.Model.Models
{
   public class Komentar
    {
        public int KomentarId { get; set; }
        public int KlijentId { get; set; }
        public int NekretninaId { get; set; }
        public string KomentarValue { get; set; }
        public DateTime DatumVrijeme { get; set; }
    }
}
