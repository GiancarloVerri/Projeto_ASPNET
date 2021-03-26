using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_ASPNET.Models;

namespace Projeto_ASPNET.Data
{
    public class Projeto_ASPNETContext : DbContext
    {
        public Projeto_ASPNETContext (DbContextOptions<Projeto_ASPNETContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Seller> Seller { get; set; }
    }
}
