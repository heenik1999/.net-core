using DIDEMO.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDEMO.Controllers
{
    public class DiController : Controller
    {
        private readonly IVisitorCount _count;
        public DiController(IVisitorCount count)
        {
            _count = count;
        }
        public IActionResult Index([FromServices] IVisitorCount _cnt)
        {
            ViewBag.count = _count.GetCount();
            ViewBag.count = _count.GetCount();
            ViewBag.count = _count.GetCount();
            ViewBag.count = _count.GetCount();
            
            ViewBag.cnt = _cnt.GetCount();

            return View();
        }
    }
}
