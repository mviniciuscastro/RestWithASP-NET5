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
    public class Calculadora : ControllerBase
    {
        

        private readonly ILogger<Calculadora> _logger;

        public Calculadora(ILogger<Calculadora> logger)
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

        public bool isNumeric(string numero)
        {
            double resposta;
            return double.TryParse(numero, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out resposta);
        }

        private decimal subtrair(string primeiro, string segundo)
        {
            var resultado = Convert.ToDecimal(primeiro) - Convert.ToDecimal(segundo);
            return resultado; 
        }

        private decimal soma(string primeiro, string segundo)
        {

            var resultado = Convert.ToDecimal(primeiro) + Convert.ToDecimal(segundo);
            return resultado;
            
        }

        private decimal multiplicacao(string primeiro, string segundo)
        {

            var resultado = Convert.ToDecimal(primeiro) * Convert.ToDecimal(segundo);
            return resultado;

        }

        private decimal divisao(string primeiro, string segundo)
        {

            var resultado = Convert.ToDecimal(primeiro) / Convert.ToDecimal(segundo);
            return resultado;

        }


        [HttpGet("raiz/{numero}")]
        public IActionResult Get(string numero)
        {
            if (!isNumeric1(numero))
            {
                return BadRequest("Valores inválidos");
            }


            return Ok(Math.Sqrt(Convert.ToDouble(numero)));
        }git cd 

        public bool isNumeric1(string numero)
        {
            double resposta;
            return double.TryParse(numero, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out resposta);
        }



    }
}
