using Projeto_ASPNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_ASPNET.Services
{
    public class DepartmentService
    {
        private readonly Projeto_ASPNETContext _context;

        public DepartmentService(Projeto_ASPNETContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
