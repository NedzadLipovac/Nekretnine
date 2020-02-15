using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nekretnine.WebApi.Services
{
    public interface ISlikaService
    {
         List<Model.Models.Slika> GetSlikeByNekretninaId(int nekretninaId);
    }
}
