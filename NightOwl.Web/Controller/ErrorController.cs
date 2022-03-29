using Microsoft.AspNetCore.Mvc;

namespace NightOwl.Web.Controller
{
    public class ErrorController : Microsoft.AspNetCore.Mvc.Controller
    {
        [Route("404")]
        public IActionResult PageNotFound()
        {
            return View();
        }
        
    }
}
