using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Projeto_ASPNET.Models
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
