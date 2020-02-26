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
    public class SpaseneNekretnineController : BaseCRUDController<Model.Models.SpaseneNekretnine, Model.Requests.SpaseneNekretnineSearchRequest, Model.Requests.SpaseneNekretnineUpsertRequest, Model.Requests.SpaseneNekretnineUpsertRequest>
    {
        public SpaseneNekretnineController(ICRUDService<SpaseneNekretnine, SpaseneNekretnineSearchRequest, SpaseneNekretnineUpsertRequest, SpaseneNekretnineUpsertRequest> service) : base(service)
        {
        }
    }
}