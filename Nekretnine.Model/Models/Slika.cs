using System;
using System.Collections.Generic;
using System.Text;

namespace Nekretnine.Model.Models
{
    public class Slika
    {
        public int SlikaId { get; set; }
        public byte[] NazivSlike { get; set; }
        public int NekretninaId { get; set; }
    }
}
