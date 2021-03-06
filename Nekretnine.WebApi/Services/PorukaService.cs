﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Nekretnine.Model.Requests;
using Nekretnine.WebApi.Database;

namespace Nekretnine.WebApi.Services
{
    public class PorukaService : BaseCrudService<Model.Models.Poruka, Model.Requests.PorukaSearchRequest, WebApi.Database.Poruka, Model.Requests.PorukaUpsertRequest, Model.Requests.PorukaUpsertRequest>
    {
        public PorukaService(NekretnineContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.Models.Poruka> Get(PorukaSearchRequest search)
        {
            var query = _context.Set<Database.Poruka>().Include(x => x.Klijent)
                                                       .Include(y => y.Uposlenik)
                                                       .OrderByDescending(x => x.DatumVrijeme)
                                                       .AsQueryable();

            if (search.KlijentId > 0)
            {
                query = query.Where(x => x.KlijentId == search.KlijentId);
            }
            //if (search.UposlenikId > 0)
            //{
            //    query = query.Where(x => x.UposlenikId == search.UposlenikId);
            //}
            if (!string.IsNullOrWhiteSpace(search?.Posiljaoc))
            {
                query = query.Where(x => x.Posiljaoc == search.Posiljaoc);
            }
            if (!string.IsNullOrWhiteSpace(search?.PrimaocIme))
            {
                query = query.Where(x => x.Klijent.Ime.ToLower().StartsWith(search.PrimaocIme));
            }
            if (!string.IsNullOrWhiteSpace(search?.PrimaocPrezime))
            {
                query = query.Where(x => x.Klijent.Prezime.ToLower().StartsWith(search.PrimaocPrezime));
            }
            if (!string.IsNullOrWhiteSpace(search?.PrimaocUsername))
            {
                query = query.Where(x => x.Klijent.Username.ToLower().StartsWith(search.PrimaocUsername));
            }
            if (!string.IsNullOrWhiteSpace(search?.PosiljaocIme))
            {
                query = query.Where(x => x.Klijent.Ime.ToLower().StartsWith(search.PosiljaocIme));
            }
            if (!string.IsNullOrWhiteSpace(search?.PosiljaocPrezime))
            {
                query = query.Where(x => x.Klijent.Prezime.ToLower().StartsWith(search.PosiljaocPrezime));
            }
            if (!string.IsNullOrWhiteSpace(search?.PosiljaocUsername))
            {
                query = query.Where(x => x.Klijent.Username.ToLower().StartsWith(search.PosiljaocUsername));
            }

            var list = query.ToList();

            List<Model.Models.Poruka> result = _mapper.Map<List<Model.Models.Poruka>>(list);
            foreach (var item in result)
            {
                var uposlenik = _context.Korisnici.FirstOrDefault(x => x.KorisnikId == item.UposlenikId);
                var klijent = _context.Klijent.FirstOrDefault(x => x.KlijentId == item.KlijentId);

                if (item.Posiljaoc == "Klijent")
                {
                    item.PosiljaocInfo = klijent.Ime + " " + klijent.Prezime + " (" + klijent.Username + ")";
                    item.PrimaocInfo = uposlenik.Ime + " " + uposlenik.Prezime + " (" + uposlenik.Username + ")";
                    if (klijent.SlikaThumb.Length > 0)
                        item.PosiljaocSlikaThumb = klijent.SlikaThumb;
                }
                else
                {
                    item.PosiljaocInfo = uposlenik.Ime + " " + uposlenik.Prezime + " (" + uposlenik.Username + ")";
                    item.PrimaocInfo = klijent.Ime + " " + klijent.Prezime + " (" + klijent.Username + ")";
                    if (uposlenik.SlikaThumb.Length > 0)
                        item.PosiljaocSlikaThumb = uposlenik.SlikaThumb;
                }

            }

            return result;
        }
        public override Model.Models.Poruka GetById(int id)
        {
            var poruka = _context.Poruka.FirstOrDefault(x => x.PorukaId == id);
            var uposlenik = _context.Korisnici.FirstOrDefault(x => x.KorisnikId == poruka.UposlenikId);
            var klijent = _context.Klijent.FirstOrDefault(x => x.KlijentId == poruka.KlijentId);


            var result = _mapper.Map<Model.Models.Poruka>(poruka);
            if (result.Posiljaoc == "Klijent")
            {
                result.PosiljaocInfo = klijent.Ime + " " + klijent.Prezime + " (" + klijent.Username + ")";
                result.PrimaocInfo = uposlenik.Ime + " " + uposlenik.Prezime + " (" + uposlenik.Username + ")";
                if (klijent.SlikaThumb.Length > 0)
                    result.PosiljaocSlikaThumb = klijent.SlikaThumb;
            }
            else
            {
                result.PosiljaocInfo = uposlenik.Ime + " " + uposlenik.Prezime + " (" + uposlenik.Username + ")";
                result.PrimaocInfo = klijent.Ime + " " + klijent.Prezime + " (" + klijent.Username + ")";
                if (uposlenik.SlikaThumb.Length > 0)
                    result.PosiljaocSlikaThumb = uposlenik.SlikaThumb;
            }


            return result;
        }
    }
}
