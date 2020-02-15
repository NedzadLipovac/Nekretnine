using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Nekretnine.WebApi.Database;

namespace Nekretnine.WebApi.Services
{
    public class UpitiZaSastankeService : BaseCrudService<Model.Models.UpitZaSastanak, object, WebApi.Database.UpitZaSastanak, Model.Requests.UpitZaSastanakUpsertRequest, Model.Requests.UpitZaSastanakUpsertRequest>
    {
        public UpitiZaSastankeService(NekretnineContext context, IMapper mapper) : base(context, mapper)
        {
        }



        public override List<Model.Models.UpitZaSastanak> Get(object o)
        {
            var query = _context.Set<WebApi.Database.UpitZaSastanak>().Include(x => x.Klijent).AsQueryable();

            List<Model.Models.UpitZaSastanak> result = new List<Model.Models.UpitZaSastanak>();
            result = query.Select(x => new Model.Models.UpitZaSastanak()
            {

                NazivSastanka = x.NazivSastanka,
                KlijentId = x.KlijentId,
                PredlozeniDatum = x.PredlozeniDatum,
                UpitZaSastanakId = x.UpitZaSastanakId,
                Klijent = x.Klijent.Ime + " " + x.Klijent.Prezime,
               
            }).ToList();
            return result;
        }

        public override Model.Models.UpitZaSastanak GetById(int id)
        {
            var query = _context.UpitZaSastanak.Include(x => x.Klijent).Where(x => x.UpitZaSastanakId == id).FirstOrDefault();


            Model.Models.UpitZaSastanak result = new Model.Models.UpitZaSastanak()
            {
                NazivSastanka = query.NazivSastanka,
                KlijentId = query.KlijentId,
                PredlozeniDatum = query.PredlozeniDatum,
                UpitZaSastanakId = query.UpitZaSastanakId,
                Klijent = query.Klijent.Ime + " " + query.Klijent.Prezime
            };
            return result;
        }
    }
}
