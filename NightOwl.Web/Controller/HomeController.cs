using Microsoft.AspNetCore.Mvc;
using NightOwl.Core.Services;
using NightOwl.Core.Services.Interfaces;

namespace NightOwl.Web.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private IMovieRepository _movieRepository;

        public HomeController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public IActionResult Index()
        {
            ViewBag.Latest = _movieRepository.GetLatest();
            return View();
        }
    }
}
