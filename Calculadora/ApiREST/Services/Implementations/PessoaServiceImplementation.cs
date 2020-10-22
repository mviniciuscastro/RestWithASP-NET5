using ApiREST.Model;
using ApiREST.Model.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ApiREST.Services.Implementations
{
    public class PessoaServiceImplementation : IPessoaService
    {
        private MySQLContext _context;
        
        public PessoaServiceImplementation(MySQLContext context)
        {
            _context = context;
        }

      
        public List<Pessoa> FindAll()
        {
            
                return _context.Pessoas.ToList();
        }

        public Pessoa FindByID(long id)
        {
            return _context.Pessoas.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Pessoa Create(Pessoa pessoa)
        {
            try
            {
                _context.Add(pessoa);
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
            return pessoa;
        }

        public Pessoa Update(Pessoa pessoa)
        {
            if (!Exists(pessoa.Id)) return new Pessoa();
            var result = _context.Pessoas.SingleOrDefault(p => p.Id.Equals(pessoa.Id));

            if (result != null)
            {


                try
                {
                    _context.Entry(result).CurrentValues.SetValues(pessoa);
                    _context.SaveChanges();

                }
                catch (Exception)
                {

                    throw;
                }
                
            }
            return pessoa;

        }

        public void Delete(long id)
        {

            var result = _context.Pessoas.SingleOrDefault(p => p.Id.Equals(id));

            if (result != null)
            {


                try
                {
                    _context.Pessoas.Remove(result);
                    _context.SaveChanges();

                }
                catch (Exception)
                {

                    throw;
                }

            }

        }

        private bool Exists(long id)
        {
            return _context.Pessoas.Any(p => p.Id.Equals(id));
        }
    }
}
