using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nekretnine.Model.Models;
using Nekretnine.Model.Requests;
using Nekretnine.WebApi.Services;

namespace Nekretnine.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SlikaController : BaseCRUDController<Model.Models.Slika, SlikaSearchRequest, Model.Requests.SlikaUpsertRequest, Model.Requests.SlikaUpsertRequest>
    {
        public SlikaController(ICRUDService<Slika, SlikaSearchRequest, SlikaUpsertRequest, SlikaUpsertRequest> service) : base(service)
        {
        }
    }
    //public class SlikaController:ControllerBase
    //{
    //    public ISlikaService _service;
    //    public SlikaController(ISlikaService service)
    //    {
    //        _service = service;
    //    }

    //    [HttpGet]
    //    public List<Model.Models.Slika>getSlikeByNekretninaId(int nekretninaId)
    //    {
    //        return _service.GetSlikeByNekretninaId(nekretninaId);
    //    }
    //}
}