using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Nekretnine.Model.Models;
using Nekretnine.Model.Requests;
using Nekretnine.WebApi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nekretnine.WebApi.Services
{
    public class SastanciService : BaseCrudService<Model.Models.Sastanak, SastanakSearchRequest, WebApi.Database.Sastanak, SastanakUpsertRequest, SastanakUpsertRequest>
    {
        public SastanciService(NekretnineContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Models.Sastanak>Get(SastanakSearchRequest search)
        {
            var query = _context.Set<WebApi.Database.Sastanak>().Include(x => x.Klijent).AsQueryable();

            if(search.Mjesto!=null)
            {
                query = query.Where(x => x.Mjesto.StartsWith(search.Mjesto));
            }
            List<Model.Models.Sastanak> result = new List<Model.Models.Sastanak>();
            result = query.Select(x => new Model.Models.Sastanak()
            {
                Mjesto=x.Mjesto,
                DatumVrijeme=x.DatumVrijeme,
                KlijentId=x.KlijentId,
                Opis=x.Opis,
                Klijent=x.Klijent.Ime+" "+x.Klijent.Prezime,
                SastanakId=x.SastanakId
               
            }).ToList();
            return result;
        }
        public override Model.Models.Sastanak GetById(int id)
        {
            var query = _context.Sastanak.Include(x => x.Klijent).Where(x=>x.SastanakId==id).FirstOrDefault();


            Model.Models.Sastanak result = new Model.Models.Sastanak()
            {
                Mjesto = query.Mjesto,
                DatumVrijeme = query.DatumVrijeme,
                KlijentId = query.KlijentId,
                Opis = query.Opis,
                Klijent = query.Klijent.Ime + " " + query.Klijent.Prezime,
                SastanakId = query.SastanakId
            };
        
            return result;
        }
    }
}
