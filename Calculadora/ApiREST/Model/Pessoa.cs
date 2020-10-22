using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiREST.Model
{
    [Table("pessoa")]
    public class Pessoa
    {
        [Column("id")]
        public long Id { get; set; }
        
        [Column("primeiro_nome")]
        public string PrimeiroNome { get; set; }
        
        [Column("sobrenome")]
        public string SobreNome { get; set; }
        
        [Column("endereco")]
        public string Endereco { get; set; }
        
        [Column("sexo")]
        public string Sexo { get; set; }

    }
}
