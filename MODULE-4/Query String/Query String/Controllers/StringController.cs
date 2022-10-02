using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace Query_String.Controllers
{
    public class StringController : Controller
    {
        public IActionResult Index(string uname)
        { 
            return View();
        }
        public IActionResult String()
        {
            return View();
        }
    }
}
