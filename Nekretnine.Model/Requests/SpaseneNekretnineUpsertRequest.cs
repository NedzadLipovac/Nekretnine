using System;
using System.Collections.Generic;
using System.Text;

namespace Nekretnine.Model.Requests
{
    public class SpaseneNekretnineUpsertRequest
    {
        public int SpasenaNekretninaId { get; set; }
        public int KlijentId { get; set; }
        public int NekretninaId { get; set; }
        public DateTime DatumIzmjene { get; set; }
    }
}
