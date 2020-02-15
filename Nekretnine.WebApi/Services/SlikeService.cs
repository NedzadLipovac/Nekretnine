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

    public class SlikeService : BaseCrudService<Model.Models.Slika,Model.Requests.SlikaSearchRequest, WebApi.Database.Slika, Model.Requests.SlikaUpsertRequest, Model.Requests.SlikaUpsertRequest>
    {
        public SlikeService(NekretnineContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.Models.Slika>Get(SlikaSearchRequest request)
        {
            var entity = _context.Set<WebApi.Database.Slika>().Where(x => x.NekretninaId == request.NekretninaId).ToList();
            var result = _mapper.Map<List<Model.Models.Slika>>(entity);
            return result;
        }
 
    }

    //public class SlikeService : ISlikaService
    //{
    //    private readonly NekretnineContext _context;
    //    private readonly IMapper _mapper;
    //    public SlikeService(NekretnineContext context, IMapper mapper)
    //    {
    //        _context = context;
    //        _mapper = mapper;

    //    }
    //    public List<Model.Models.Slika> GetSlikeByNekretninaId(int nekretninaId)
    //    {
    //        var entity = _context.Slika.Where(x => x.NekretninaId == nekretninaId).ToList();
    //        var result = _mapper.Map<List<Model.Models.Slika>>(entity);
    //        return result;
    //    }
    //}
}
