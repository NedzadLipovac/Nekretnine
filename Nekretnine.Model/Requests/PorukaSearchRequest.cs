using System;
using System.Collections.Generic;
using System.Text;

namespace Nekretnine.Model.Requests
{
    public class PorukaSearchRequest
    {
        public int PorukaId { get; set; }
        public int KlijentId { get; set; }
        public int UposlenikId { get; set; }
        public string Sadrzaj { get; set; }
        public string Naslov { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public bool Procitano { get; set; }
        public string Posiljaoc { get; set; }
        public string PosiljaocInfo { get; set; }
        public string PrimaocInfo { get; set; }
        public byte[] PosiljaocSlikaThumb { get; set; }
        public string PosiljaocIme { get; set; }
        public string PosiljaocPrezime { get; set; }
        public string PosiljaocUsername { get; set; }
        public string PrimaocIme { get; set; }
        public string PrimaocPrezime { get; set; }
        public string PrimaocUsername { get; set; }
    }

}
