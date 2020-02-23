using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nekretnine.WebApi.Mappers
{

    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Klijent, Model.Models.Klijent>().ReverseMap();
            CreateMap<Database.Klijent, Model.Requests.KlijentUpsertRequest>().ReverseMap();

            CreateMap<Database.Korisnici, Model.Models.Korisnik>().ReverseMap();
            CreateMap<Database.Korisnici, Model.Requests.KorisnikUpsertRequest>().ReverseMap();

            CreateMap<Database.Sastanak, Model.Models.Sastanak>().ReverseMap();
            CreateMap<Database.Sastanak, Model.Requests.SastanakUpsertRequest>().ReverseMap();

            CreateMap<Database.UpitZaSastanak, Model.Models.UpitZaSastanak>().ReverseMap();
            CreateMap<Database.UpitZaSastanak, Model.Requests.UpitZaSastanakUpsertRequest>().ReverseMap();

            CreateMap<Database.Nekretnina, Model.Models.Nekretnina>().ReverseMap();
            CreateMap<Database.Nekretnina, Model.Requests.NekretninaUpsertRequest>().ReverseMap();

            CreateMap<Database.Slika, Model.Models.Slika>().ReverseMap();
            CreateMap<Database.Slika, Model.Requests.SlikaUpsertRequest>().ReverseMap();

            CreateMap<Database.Komentar, Model.Models.Komentar>().ReverseMap();
            CreateMap<Database.Komentar, Model.Requests.KomentarUpsertRequest>().ReverseMap();

            CreateMap<Database.Poruka, Model.Models.Poruka>().ReverseMap();
            CreateMap<Database.Poruka, Model.Requests.PorukaUpsertRequest>().ReverseMap();

        }
    }
}
