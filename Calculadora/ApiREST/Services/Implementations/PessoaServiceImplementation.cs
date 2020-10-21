using ApiREST.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ApiREST.Services.Implementations
{
    public class PessoaServiceImplementation : IPessoaService
    {
        public Pessoa Create(Pessoa pessoa)
        {
            return pessoa;
        }

        public void Delete(long id)
        {
            
        }

        public List<Pessoa> FindAll()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            for (int i = 0; i < 8; i++)
            {
                Pessoa pessoa = MockPessoa(i);
                pessoas.Add(pessoa);

            }
                return pessoas;
        }

        private volatile int count;
        private Pessoa MockPessoa(int i)
        {
            return new Pessoa
            {
                Id = IncrementGet(),
                PrimeiroNome = "nome" + i,
                SobreNome = "sobrenome" + i,
                Endereco = "Santos" + i,
                Sexo = "Masculino" + i
            };
        }

        private long IncrementGet()
        {
           return Interlocked.Increment(ref count);
        }

        public Pessoa FindByID(long id)
        {
            return new Pessoa
            {
                Id = IncrementGet(),
                PrimeiroNome = "Marcus",
                SobreNome = "Castro",
                Endereco = "Santos",
                Sexo = "Masculino"
            };
        }

        public Pessoa Update(Pessoa pessoa)
        {
            return pessoa;
        }
    }
}
