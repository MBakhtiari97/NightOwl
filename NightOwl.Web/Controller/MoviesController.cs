using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using NightOwl.Core.Services.Interfaces;

namespace NightOwl.Web.Controller
{
    public class MoviesController : Microsoft.AspNetCore.Mvc.Controller
    {
        private ICategoryRepository _categoryRepository;
        private IGenresRepository _genresRepository;
        private INotyfService _notyfService;
        private IMovieRepository _movieRepository;

        public MoviesController(ICategoryRepository categoryRepository, IGenresRepository genresRepository, INotyfService notyfService,IMovieRepository movieRepository)
        {
            _categoryRepository = categoryRepository;
            _genresRepository = genresRepository;
            _notyfService = notyfService;
            _movieRepository = movieRepository;
        }
        [Route("Category-{categoryId}")]
        public IActionResult ShowMoviesByCategory(int categoryId)
        {
            return View("_ShowMoviesList", _movieRepository.GetMoviesByCategoryId(categoryId));
        }
    }
}
