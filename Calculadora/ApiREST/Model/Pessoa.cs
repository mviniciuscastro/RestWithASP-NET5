using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiREST.Model
{
    public class Pessoa
    {
        public long Id { get; set; }
        public long PrimeiroNome { get; set; }
        public long SobreNome { get; set; }
        public long Endereco { get; set; }
        public long Sexo { get; set; }

    }
}
