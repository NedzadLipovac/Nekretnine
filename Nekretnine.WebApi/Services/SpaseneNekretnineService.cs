using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Nekretnine.WebApi.Database;

namespace Nekretnine.WebApi.Services
{
    public class SpaseneNekretnineService : BaseCrudService<Model.Models.SpaseneNekretnine, Model.Requests.SpaseneNekretnineSearchRequest, WebApi.Database.SpaseneNekretnine, Model.Requests.SpaseneNekretnineUpsertRequest, Model.Requests.SpaseneNekretnineUpsertRequest>
    {
        public SpaseneNekretnineService(NekretnineContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
