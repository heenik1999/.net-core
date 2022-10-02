using DiiDemo.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiiDemo.Controllers
{
    public class DiiController : Controller
    {
        private readonly IVisitorCount _count;
        public DiiController(IVisitorCount count)
        {
            _count = count;
        }
        public IActionResult Index([FromServices] IVisitorCount _cnt)
        {
            ViewBag.count = _count.GetCount();
            ViewBag.count = _count.GetCount();
            ViewBag.count = _count.GetCount();
            ViewBag.count = _cnt.GetCount();

            ViewBag.cnt = _cnt.GetCount();
            return View();
        }
    }
}
