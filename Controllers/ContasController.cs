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
    public class ContasController : ControllerBase
    {
        private IContas _contaRepository;
        private IFebraban _febrabanService;

        public ContasController (IContas contaRepository, IFebraban febrabanService) {
           _contaRepository = contaRepository;
           _febrabanService = febrabanService;
        }
        // GET api/values
        [HttpGet]
        public List<conta> Get()
        {
            return _contaRepository.getContasList();

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public conta Get(int id)
        {
           return _contaRepository.getContaById(id);
        }

        // POST api/values
        [HttpPost]
        public Task<conta> Post([FromBody] conta conta)
        {
            return _contaRepository.gravarDados(conta);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Task<conta> Put(int id, [FromBody] conta conta)
        {
            conta.id = id;
            return _contaRepository.gravarDados(conta);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult  Delete(int id)
        {
           return _contaRepository.deleteConta(id)? StatusCode(200) : NotFound();
        }
    }
}
