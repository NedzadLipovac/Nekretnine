using Nekretnine.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Nekretnine.WebApi.Services
{
    public class GenerateHashHelperService : IGenerateHashHelper
    {
        public GenerateHashHelperService()
        {

        }
        public GenerateHashGet GenerateHash2(GenerateHashSearch request)
        {
            byte[] src = Convert.FromBase64String(request.LozinkaSalt);
            byte[] bytes = Encoding.Unicode.GetBytes(request.LozinkaHash);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            var s = Convert.ToBase64String(inArray);
            GenerateHashGet result = new GenerateHashGet();
            result.Hash = s;

            return result;

        }
    }
}
