using System;
using System.Collections.Generic;
using System.Text;

namespace Nekretnine.Model.Requests
{
    public class NekretninaSearchRequest
    {
        public int Kvadratura { get; set; }
        public int? GradId { get; set; }

    }
}
