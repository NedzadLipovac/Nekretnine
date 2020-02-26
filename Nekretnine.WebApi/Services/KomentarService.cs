using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Nekretnine.WebApi.Database;

namespace Nekretnine.WebApi.Services
{
    public class KomentarService : BaseCrudService<Model.Models.Komentar, Model.Requests.KomentarSearchRequest, WebApi.Database.Komentar, Model.Requests.KomentarUpsertRequest, Model.Requests.KomentarUpsertRequest>
    {
        public KomentarService(NekretnineContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
