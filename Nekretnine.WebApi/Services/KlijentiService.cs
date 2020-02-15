using System;
using System.Collections.Generic;
using System.Linq;
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
            throw new NotImplementedException();
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
            entity.LozinkaSalt = "test";
            entity.LozinkaHash = "test";
            
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
                entity.LozinkaSalt = "test";
                entity.LozinkaHash = "test";
            }
            _mapper.Map(request, entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Models.Klijent>(entity);
        }
    }
}
