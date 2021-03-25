using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_ASPNET.Models;

namespace Projeto_ASPNET.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department{ Id = 1, Name = "Eletronics"});
            departments.Add(new Department { Id = 2, Name = "Fashion" });
            return View(departments);
        }
    }
}
