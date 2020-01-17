using System;
using System.Collections.Generic;

namespace Nekretnine.WebApi.Database
{
    public partial class Slika
    {
        public int SlikaId { get; set; }
        public byte[] Slika1 { get; set; }
        public int? NekretninaId { get; set; }

        public virtual Nekretnina Nekretnina { get; set; }
    }
}
