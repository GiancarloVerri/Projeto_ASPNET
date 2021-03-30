using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_ASPNET.Models;

namespace Projeto_ASPNET.Services
{
    public class SellerService
    {
        private readonly Projeto_ASPNETContext _context;

        public SellerService(Projeto_ASPNETContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
