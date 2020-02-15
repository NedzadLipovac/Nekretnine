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
    public class UpitZaSastanakController : BaseCRUDController<Model.Models.UpitZaSastanak, object, Model.Requests.UpitZaSastanakUpsertRequest, Model.Requests.UpitZaSastanakUpsertRequest>
    {
        public UpitZaSastanakController(ICRUDService<UpitZaSastanak, object, UpitZaSastanakUpsertRequest, UpitZaSastanakUpsertRequest> service) : base(service)
        {
        }
    }
}