using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Nekretnine.Model.Requests;
using Nekretnine.WebApi.Database;

namespace Nekretnine.WebApi.Services
{
    public class OcjenaService : BaseCrudService<Model.Models.Ocjena, Model.Requests.OcjenaSearchRequest, WebApi.Database.Ocjena, Model.Requests.OcjenaUpsertRequest, Model.Requests.OcjenaUpsertRequest>
    {
        public OcjenaService(NekretnineContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Models.Ocjena> Get(OcjenaSearchRequest search)
        {
            var query = _context.Set<Database.Ocjena>().AsQueryable();

            if (search.KlijentId > 0)
            {
                query = query.Where(x => x.KlijentId==search.KlijentId);
            }

            if (search.NekretninaId > 0)
            {
                query = query.Where(x => x.NekretninaId == search.NekretninaId);
            }

            var list = query.ToList();

            List<Model.Models.Ocjena> result = _mapper.Map<List<Model.Models.Ocjena>>(list);
     
            return result;
        }
    }
}
