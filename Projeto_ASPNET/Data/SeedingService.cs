using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_ASPNET.Models;
using Projeto_ASPNET.Models.Enums;

namespace Projeto_ASPNET.Data
{
    public class SeedingService
    {
        private Projeto_ASPNETContext _context;

        public SeedingService(Projeto_ASPNETContext context)
        {
            _context = context;

        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria", "Maria@gmail.com", new DateTime(1979, 5, 22), 1000.0, d2);
            Seller s3 = new Seller(3, "Alex", "alex@gmail.com", new DateTime(1988, 6, 23), 1000.0, d1);
            Seller s4 = new Seller(4, "Martha", "martha@gmail.com", new DateTime(1993, 7, 24), 1000.0, d4);
            Seller s5 = new Seller(5, "Donald", "donald@gmail.com", new DateTime(2000, 8, 25), 1000.0, d3);
            Seller s6 = new Seller(6, "Pink", "pink@gmail.com", new DateTime(1997, 9, 26), 1000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2020, 12, 12), 5000.0, SalesStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2020, 12, 13), 15000.0, SalesStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2020, 12, 14), 8000.0, SalesStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2020, 12, 15), 3000.0, SalesStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2020, 12, 16), 1000.0, SalesStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2020, 12, 17), 4000.0, SalesStatus.Billed, s6);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6);

            _context.SaveChanges();
        }
    }
}
