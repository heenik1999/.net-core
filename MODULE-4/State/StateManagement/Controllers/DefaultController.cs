using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace StateManagement.Controllers
{
    public class DefaultController : Controller
    {
        public IHttpContextAccessor _ContextAccessor;
        public DefaultController(IHttpContextAccessor contextAccessor)
        {
            _ContextAccessor = contextAccessor;
        }
        public IActionResult Cookies()
        {
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(5);
            _ContextAccessor.HttpContext.Response.Cookies.Append("Username", "Nik ");

            return View();
        }
        public IActionResult Index()
        {
            ViewBag.data = _ContextAccessor.HttpContext.Request.Cookies["Username"].ToString();
            return View();
        }
        //Quary String
        public IActionResult ShowMsg(string name, int? id)
        {

            ViewBag.msg = name;
            ViewBag.msg1 = id;
            return View();
        }
        public IActionResult Login()
        {
            _ContextAccessor.HttpContext.Session.SetString("Uname", "Nikhil");
            return View();
        }
        public IActionResult svar()
        {
            ViewBag.msg = "Message from ViewBag";
            ViewData["info"] = "Message from ViewData";
            TempData["data"] = "Displaying TempData";
            return View();
        }
        public IActionResult Second()
        {
            return View();
        }
    }
}
