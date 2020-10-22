﻿using Microsoft.EntityFrameworkCore;

namespace ApiREST.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base (options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
