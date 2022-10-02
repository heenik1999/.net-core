
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doctor_Finder.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DrController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
    }
}
