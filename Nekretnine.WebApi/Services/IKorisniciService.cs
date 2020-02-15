using Nekretnine.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nekretnine.WebApi.Services
{
  public  interface IKorisniciService
    {
        List<Model.Models.Korisnik> Get(KorisnikSearchRequest request);
        Model.Models.Korisnik GetById(int Id);
        Model.Models.Korisnik Update(int Id, KorisnikUpsertRequest request);
        Model.Models.Korisnik Insert(KorisnikUpsertRequest request);
        Model.Models.Korisnik Autentificiraj(string username, string password);
    }
}
