using Empl.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empl.Controllers
{
    public class DefaultController : Controller
    {
        public EmployeeContext _empl;
        public DefaultController(EmployeeContext empl)
        {
            _empl = empl;
        }
        public IActionResult users()
        {
            return View(_empl.Empls.ToList());
        }
    }
}
