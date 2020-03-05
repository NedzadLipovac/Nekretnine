using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Nekretnine.Model.Models;
using Nekretnine.Model.Requests;
using Nekretnine.WebApi.Database;

namespace Nekretnine.WebApi.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly NekretnineContext _context;
        private readonly IMapper _mapper;

        public KorisniciService(NekretnineContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Korisnik Autentificiraj(string username, string password)
        {
            var user = _context.Korisnici.FirstOrDefault(x => x.Username == username);
            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, password);

                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Models.Korisnik>(user);
                }
            }
            return null;
        }

        public List<Korisnik> Get(KorisnikSearchRequest search)
        {
            var query = _context.Set<Database.Korisnici>().AsQueryable();
            if (search.GradId > 0)
            {
                query = query.Where(x => x.GradId == search.GradId);
            }
            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Ime.ToLower().StartsWith(search.Ime));
            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Prezime.ToLower().StartsWith(search.Prezime));
            }
            if (!string.IsNullOrWhiteSpace(search?.Email))
            {
                query = query.Where(x => x.Email.ToLower().StartsWith(search.Email));
            }
             if (!string.IsNullOrWhiteSpace(search?.Username))
            {
                query = query.Where(x => x.Username==search.Username);
            }

            query = query.Where(x => x.Status == search.Status);

            var korisnici = query.ToList();
            List<Model.Models.Korisnik> result = _mapper.Map<List<Model.Models.Korisnik>>(korisnici);
            return result;
        }

        public Korisnik GetById(int Id)
        {
            var entity = _context.Korisnici.Find(Id);

            return _mapper.Map<Model.Models.Korisnik>(entity);
        }

        public Korisnik Insert(KorisnikUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnici>(request);

            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.Korisnici.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Models.Korisnik>(entity);
        }

        public Korisnik Update(int Id, KorisnikUpsertRequest request)
        {
            var entity = _context.Korisnici.FirstOrDefault(x => x.KorisnikId == Id);
            _context.Korisnici.Attach(entity);
            _context.Korisnici.Update(entity);
            request.KorisnikId = entity.KorisnikId;

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordPotvrda)
                {
                    throw new Exception("Passwordi se ne slažu");
                }

                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Models.Korisnik>(entity);

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
