using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContaBancariaServer.Entities;
using ContaBancariaServer.Interfaces;
using ContaBancariaServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContaBancariaServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BancosController : ControllerBase
    {
        private IFebraban _febrabanService;

        public BancosController (IFebraban febrabanService) {
           _febrabanService = febrabanService;
        }
        // GET api/values
        [HttpGet]
        public febrabanLista Get()
        {
            return _febrabanService.getBancos();

        }
    }
}
