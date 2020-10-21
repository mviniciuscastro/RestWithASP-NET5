﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using ApiREST.Model;
using ApiREST.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiREST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {


        private readonly ILogger<PessoaController> _logger;
        private IPessoaService _pessoaService;

        public PessoaController(ILogger<PessoaController> logger, IPessoaService pessoaService)
        {
            _logger = logger;
            _pessoaService = pessoaService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_pessoaService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var pessoa = _pessoaService.FindByID(id);
            if (pessoa == null) return NotFound();
            return Ok(pessoa);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Pessoa pessoa)
        {

            if (pessoa == null) return BadRequest();
            return Ok(_pessoaService.Create(pessoa));
        }  
        
        [HttpPut]
        public IActionResult Put([FromBody] Pessoa pessoa)
        {

            if (pessoa == null) return BadRequest();
            return Ok(_pessoaService.Update(pessoa));
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
           _pessoaService.Delete(id);
            
            return NoContent();
        }

    }
}
