using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nekretnine.Model.Models;
using Nekretnine.WebApi.Services;

namespace Nekretnine.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerateHashHelperController : ControllerBase
    {
        private readonly IGenerateHashHelper _service;

        public GenerateHashHelperController(IGenerateHashHelper service)
        {
            _service = service;
        }

        [HttpGet]
        public GenerateHashGet GenerateHash2([FromQuery]GenerateHashSearch search)
        {
            return _service.GenerateHash2(search);
        }

    }
}