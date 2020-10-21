using ApiREST.Model;
using System.Collections.Generic;

namespace ApiREST.Services
{
    public interface IPessoaService
    {
        Pessoa Create(Pessoa pessoa);

        Pessoa FindByID(long id);

        Pessoa Update(Pessoa pessoa);

        void Delete(long id);

        List<Pessoa> FindAll();

    }
}
