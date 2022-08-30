using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Q_13.Controllers
{
    public class ActionController : Controller
    {
        public readonly IWebHostEnvironment _env;
        public ActionController(IWebHostEnvironment env)
        {
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_env.WebRootPath);
        }
        public ViewResult Showmsg(string msg)
        {
            ViewBag.msg = msg;
            return View();
        }
        public RedirectResult GoToURL()
        {
            return Redirect("http://www.google.com");
        }
        public RedirectResult GoToURLPermanently()
        {
            return RedirectPermanent("http://www.google.com");
        }
        public RedirectToActionResult GotoMsg()
        {
            return RedirectToAction("ShowMsg", new { msg = "Happy Indipendence Day." });
        }
        public RedirectToRouteResult GotoAbout()
        {
            return RedirectToRoute("ShowMsg");
        }
        public FileResult downloadFile()
        {
            return File("/css/site.css", "text/html", "ReturnFile.css");
        }
    }
}
