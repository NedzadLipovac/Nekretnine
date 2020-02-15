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
    public class NekretninaController : BaseCRUDController<Model.Models.Nekretnina, Model.Requests.NekretninaSearchRequest, Model.Requests.NekretninaUpsertRequest, Model.Requests.NekretninaUpsertRequest>
    {
        public NekretninaController(ICRUDService<Nekretnina, NekretninaSearchRequest, NekretninaUpsertRequest, NekretninaUpsertRequest> service) : base(service)
        {
        }
    }
}