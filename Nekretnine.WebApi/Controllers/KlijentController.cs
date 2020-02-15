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
    public class KlijentController : ControllerBase
    {
        private readonly IKlijentiService _service;

        public KlijentController(IKlijentiService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Klijent> Get([FromQuery]KlijentSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Klijent GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public Klijent Insert(KlijentUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Klijent Update(int id, [FromBody]KlijentUpsertRequest request)
        {
            return _service.Update(id, request);
        }

    }
}