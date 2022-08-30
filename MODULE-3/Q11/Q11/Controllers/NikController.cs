using Microsoft.AspNetCore.Mvc;
using Q11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Q11.Controllers
{
    public class NikController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StuInfo()
        {
            List<Student> s = new List<Student>();
            s.Add(new Student { RollNo = 1, FName = "Nikhilesh", LName = "Badgu", MobileNo = "1234567890", EmailId = "Nik123@gmail.com" });
            s.Add(new Student { RollNo = 2, FName = "Aakash", LName = "Panchal", MobileNo = "7894561230", EmailId = "Aak123@gmail.com" });
            s.Add(new Student { RollNo = 3, FName = "Hardik", LName = "Panchal", MobileNo = "4561237890", EmailId = "Har123@gmail.com" });
            return View(s);
        }
    }
}
