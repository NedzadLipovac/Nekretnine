using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Nekretnine.Model.Requests;
using Nekretnine.WebApi.Database;

namespace Nekretnine.WebApi.Services
{
    public class KomentarService : BaseCrudService<Model.Models.Komentar, Model.Requests.KomentarSearchRequest, WebApi.Database.Komentar, Model.Requests.KomentarUpsertRequest, Model.Requests.KomentarUpsertRequest>
    {
        public KomentarService(NekretnineContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.Models.Komentar>  Get(KomentarSearchRequest request)
        {
            var query = _context.Set<Database.Komentar>().AsQueryable();
            if (request.KlijentId > 0)
            {
                query = query.Where(x => x.KlijentId == request.KlijentId);
            }
            if (request.NekretninaId > 0)
            {
                query = query.Where(x => x.NekretninaId == request.NekretninaId);
            }
            var list = query.ToList();

            return _mapper.Map<List<Model.Models.Komentar>>(list);
        }
    }
}
