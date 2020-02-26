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
    public class OcjenaController : BaseCRUDController<Model.Models.Ocjena, Model.Requests.OcjenaSearchRequest, Model.Requests.OcjenaUpsertRequest, Model.Requests.OcjenaUpsertRequest>
    {
        public OcjenaController(ICRUDService<Ocjena, OcjenaSearchRequest, OcjenaUpsertRequest, OcjenaUpsertRequest> service) : base(service)
        {
        }
    }
}