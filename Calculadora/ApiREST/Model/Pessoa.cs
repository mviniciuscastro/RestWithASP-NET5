using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiREST.Model
{
    public class Pessoa
    {
        public long Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string SobreNome { get; set; }
        public string Endereco { get; set; }
        public string Sexo { get; set; }

    }
}
