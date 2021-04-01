using Projeto_ASPNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Projeto_ASPNET.Services
{
    public class DepartmentService
    {
        private readonly Projeto_ASPNETContext _context;

        public DepartmentService(Projeto_ASPNETContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
