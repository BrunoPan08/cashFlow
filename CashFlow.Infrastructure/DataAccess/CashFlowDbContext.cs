using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Infrastructure.DataAccess
{
    public class CashFlowDbContext : DbContext
    {
        public DbSet<Expanse> Expenses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost; Database=cashflowdb;Uid=root;Pwt=12345";

            var serverVersion = new MySqlServerVersion(new Version(8, 0, 35));

            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}
