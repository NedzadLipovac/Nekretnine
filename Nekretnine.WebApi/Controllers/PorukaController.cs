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
    public class PorukaController : BaseCRUDController<Model.Models.Poruka, Model.Requests.PorukaSearchRequest, Model.Requests.PorukaUpsertRequest, Model.Requests.PorukaUpsertRequest>
    {
        public PorukaController(ICRUDService<Poruka, PorukaSearchRequest, PorukaUpsertRequest, PorukaUpsertRequest> service) : base(service)
        {
        }
    }
}