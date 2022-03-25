using Microsoft.AspNetCore.Mvc;

namespace NightOwl.Web.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
