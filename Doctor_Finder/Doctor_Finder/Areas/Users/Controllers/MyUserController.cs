using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doctor_Finder.Areas.Users.Controllers
{
    [Area("Users")]
    public class MyUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
