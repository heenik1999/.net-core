using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSAndValidation.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Datepicker()
        {
            return View();
        }
        public IActionResult Nivos()
        {
            return View();
        }
        public IActionResult Bval()
        {
            return View();
        }
        public IActionResult Dataval()
        {
            return View();
        }
    }
}
