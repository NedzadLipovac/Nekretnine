using Nekretnine.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nekretnine.WebApi.Services
{
    public interface IGenerateHashHelper
    {
          //string GenerateHash(string salt, string password);
          GenerateHashGet GenerateHash2(GenerateHashSearch search);
    }
}
