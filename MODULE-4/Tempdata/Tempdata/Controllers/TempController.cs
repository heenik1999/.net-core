using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tempdata.Controllers
{
    public class TempController : Controller
    {
        public IActionResult Msg()
        {
            TempData["data"] = "This Is TempData";
            return View();
        }
        public IActionResult Other()
        {
            return View();
        }
    }
}
