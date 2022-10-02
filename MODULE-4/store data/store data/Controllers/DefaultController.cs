using Microsoft.AspNetCore.Mvc;
using store_data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store_data.Controllers
{
    public class DefaultController : Controller
    {
        public EmployeeContext _emp;
        public DefaultController(EmployeeContext emp)
        {
            _emp = emp;
        }
        public IActionResult GetDBData()
        {
            return View(_emp.Empls.ToList());
        }
    }
}
