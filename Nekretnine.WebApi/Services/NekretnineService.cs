using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Nekretnine.Model.Requests;
using Nekretnine.WebApi.Database;

namespace Nekretnine.WebApi.Services
{
    public class NekretnineService : BaseCrudService<Model.Models.Nekretnina, Model.Requests.NekretninaSearchRequest, WebApi.Database.Nekretnina, Model.Requests.NekretninaUpsertRequest, Model.Requests.NekretninaUpsertRequest>
    {
        public NekretnineService(NekretnineContext context, IMapper mapper) : base(context, mapper)
        {
        }


        public override List<Model.Models.Nekretnina>Get(NekretninaSearchRequest search)
        {
            var query = _context.Set<WebApi.Database.Nekretnina>().Include(x=>x.Grad).AsQueryable();
            if(search.GradId>0)
            {
                query = query.Where(x => x.GradId == search.GradId);
            }
            if(search.Kvadratura>0)
            {
                query = query.Where(x => x.Kvadratura >= search.Kvadratura);
            }

            List<Model.Models.Nekretnina> result = new List<Model.Models.Nekretnina>();
            result = query.Select(x => new Model.Models.Nekretnina()
            {
                 Adresa=x.Adresa,
                  GodinaIzgradnje=x.GodinaIzgradnje,
                   Grad=x.Grad.Naziv,
                    GradId=x.GradId,
                     Kvadratura=x.Kvadratura,
                      Naziv=x.Naziv,
                       NekretninaId=x.NekretninaId,
                        Prodaja=x.Prodaja,
                         Vlasnik=x.Vlasnik
            }).ToList();
            return result;
        }

        public override Model.Models.Nekretnina GetById(int Id)
        {
            var x = _context.Set<Database.Nekretnina>().Include(k=>k.Grad).Where(k=>k.NekretninaId==Id).FirstOrDefault();

            Model.Models.Nekretnina result = new Model.Models.Nekretnina()
            {
                Adresa = x.Adresa,
                GodinaIzgradnje = x.GodinaIzgradnje,
                Grad = x.Grad.Naziv,
                GradId = x.GradId,
                Kvadratura = x.Kvadratura,
                Naziv = x.Naziv,
                NekretninaId = x.NekretninaId,
                Prodaja = x.Prodaja,
                Vlasnik = x.Vlasnik
            };
            return result;
        }


    }
}
