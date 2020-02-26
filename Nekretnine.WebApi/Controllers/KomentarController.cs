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
    public class KomentarController : BaseCRUDController<Model.Models.Komentar, Model.Requests.KomentarSearchRequest, Model.Requests.KomentarUpsertRequest, Model.Requests.KomentarUpsertRequest>
    {
        public KomentarController(ICRUDService<Komentar, KomentarSearchRequest, KomentarUpsertRequest, KomentarUpsertRequest> service) : base(service)
        {

        }
    }
}