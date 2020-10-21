using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiREST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        

        private readonly ILogger<PessoaController> _logger;

        public PessoaController(ILogger<PessoaController> logger)
        {
            _logger = logger;
        }

        [HttpGet("acao/{acao}/{primeiro}/{segundo}")]
        public IActionResult Get(string acao, string primeiro, string segundo)
        {
            if (!isNumeric(primeiro) || !isNumeric(segundo))
            {
                return BadRequest("Valores inválidos");
            }

            decimal valor = 0;
            switch (acao)
            {
                case "soma":
                    valor = soma(primeiro, segundo);
                    break;
                case "subtrair":
                    valor = subtrair(primeiro, segundo);
                    break;
                case "divisao":
                    valor = divisao(primeiro, segundo);
                    break;
                case "multiplicacao":
                    valor = multiplicacao(primeiro, segundo);
                    break;

            }

            return Ok(valor);
        }


    }
}
