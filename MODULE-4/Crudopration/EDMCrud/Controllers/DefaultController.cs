using EDMCrud.EDM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDMCrud.Controllers
{
    public class DefaultController : Controller
    {
        private StudentContext _context = null;
        public DefaultController(StudentContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Studs.ToList());
        }
        public IActionResult Details(int id )
        {
            return View(_context.Studs.Find(id));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Stud stu)
        {
            _context.Studs.Add(stu);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            return View(_context.Studs.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Stud edi)
        {
            _context.Studs.Update(edi);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            return View(_context.Studs.Find(id));
        }
        [HttpPost]
        /*[ActionName("Delete")]
        public IActionResult DeleteRec (int id)
        {
            _context.Studs.Remove(_context.Studs.Find(id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }*/
        public IActionResult Delete(Stud del)
        {
            del.Is_Delete = true;
            _context.Studs.Update(del);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
