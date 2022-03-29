using Microsoft.AspNetCore.Mvc;

namespace NightOwl.Web.Areas.Admin.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
