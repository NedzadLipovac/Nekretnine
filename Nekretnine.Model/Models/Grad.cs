using System;
using System.Collections.Generic;
using System.Text;

namespace Nekretnine.Model.Models
{
    public class Grad
    {
        public int GradId { get; set; }
        public string Naziv { get; set; }
        public int? DrzavaId { get; set; }
    }
}
