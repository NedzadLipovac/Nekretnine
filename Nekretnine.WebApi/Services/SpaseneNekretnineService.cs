using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Nekretnine.Model.Requests;
using Nekretnine.WebApi.Database;

namespace Nekretnine.WebApi.Services
{
    public class SpaseneNekretnineService : BaseCrudService<Model.Models.SpaseneNekretnine, Model.Requests.SpaseneNekretnineSearchRequest, WebApi.Database.SpaseneNekretnine, Model.Requests.SpaseneNekretnineUpsertRequest, Model.Requests.SpaseneNekretnineUpsertRequest>
    {
        public SpaseneNekretnineService(NekretnineContext context, IMapper mapper) : base(context, mapper)
        {
        }
        

        public override List<Model.Models.SpaseneNekretnine>Get(SpaseneNekretnineSearchRequest searchRequest)
        {
            var query = _context.Set<WebApi.Database.SpaseneNekretnine>().AsQueryable();

            if(searchRequest.KlijentId>0)
            {
                query = query.Where(x => x.KlijentId == searchRequest.KlijentId);
            }
            if (searchRequest.NekretninaId > 0)
            {
                query = query.Where(x => x.NekretninaId == searchRequest.NekretninaId);
            }
            var list = query.ToList();
            var result = _mapper.Map<List<Model.Models.SpaseneNekretnine>>(list);
            return result;
        }
    }
}
