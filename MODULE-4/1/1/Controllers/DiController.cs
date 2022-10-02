using _1.DBContext;
using Di.services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Controllers
{
    public class DiController : Controller
    {
        private readonly IViCount _data;
        public DiController(IViCount data)
        {
            _data = data;
        }
        public IActionResult Result()
        {
            List<Stud> students = _data.getData();
            return View(students);
        }
    }
}
