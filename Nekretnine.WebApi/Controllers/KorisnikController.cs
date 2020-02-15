using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nekretnine.Model.Requests;
using Nekretnine.WebApi.Services;

namespace Nekretnine.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikController : ControllerBase
    {
        private IKorisniciService _service;

        public KorisnikController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Models.Korisnik> Get([FromQuery]KorisnikSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Models.Korisnik Insert(KorisnikUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Models.Korisnik Update(int id, [FromBody]KorisnikUpsertRequest request)
        {
            var r = _service.Update(id, request);

            return r;
        }

        [HttpGet("{id}")]
        public Model.Models.Korisnik GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}