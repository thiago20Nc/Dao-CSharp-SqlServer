using Dao_CSharp_SQLServer.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_C__SQLServer.Context
{
    class DBContext : DbContext
    {
        public DbSet<Pessoa> pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=BancoTreino;Trusted_Connection=True; TrustServerCertificate=True;");
        }
    }
}
