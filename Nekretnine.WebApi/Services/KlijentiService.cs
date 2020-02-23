using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Nekretnine.Model.Models;
using Nekretnine.Model.Requests;
using Nekretnine.WebApi.Database;

namespace Nekretnine.WebApi.Services
{
    public class KlijentiService : IKlijentiService
    {
        protected readonly NekretnineContext _context;
        protected readonly IMapper _mapper;

        public KlijentiService(NekretnineContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Model.Models.Klijent Autentificiraj(string username, string password)
        {
            var user = _context.Klijent.FirstOrDefault(x => x.Username == username);
            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, password);

                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Models.Klijent>(user);
                }
            }
            return null;
        }

        public List<Model.Models.Klijent> Get(KlijentSearchRequest request)
        {
            var query = _context.Set<Database.Klijent>().AsQueryable();
            if (request.GradId > 0)
            {
                query = query.Where(x => x.GradId == request.GradId);
            }
            if (!string.IsNullOrEmpty(request?.Ime))
            {
                query = query.Where(x => x.Ime.ToLower().StartsWith(request.Ime));
            }
            if (!string.IsNullOrEmpty(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.ToLower().StartsWith(request.Prezime));
            }
            if (!string.IsNullOrEmpty(request?.Email))
            {
                query = query.Where(x => x.Email.ToLower().StartsWith(request.Email));
            }
            if (!string.IsNullOrEmpty(request?.Username))
            {
                query = query.Where(x => x.Username == request.Username);
            }
            query = query.Where(x => x.Status == request.Status);

            var list = query.ToList();

            return _mapper.Map<List<Model.Models.Klijent>>(list);
        }

        public Model.Models.Klijent GetById(int Id)
        {
            var entity = _context.Klijent.Find(Id);
            return _mapper.Map<Model.Models.Klijent>(entity);

        }

        public Model.Models.Klijent Insert(KlijentUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Klijent>(request);
            if(request.Password!=request.PotvrdaPassworda)
            {
                throw new Exception("Passwordi se ne slazu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);


            _context.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Models.Klijent>(entity);
        }

        public Model.Models.Klijent Update(int Id, KlijentUpsertRequest request)
        {
            var entity = _context.Klijent.Find(Id);
            _context.Klijent.Attach(entity);
            _context.Klijent.Update(entity);
            request.KlijentId = entity.KlijentId;
            if (!string.IsNullOrEmpty(request.Password))
            {
                if(request.Password != request.PotvrdaPassworda)
                {
                    throw new Exception("Passwordi se ne slazu");
                }
                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            }
            _mapper.Map(request, entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Models.Klijent>(entity);
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
