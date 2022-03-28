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
        private IActorsRepository _actorsRepository;

        public MoviesController(ICategoryRepository categoryRepository,
            IGenresRepository genresRepository,
            INotyfService notyfService,
            IMovieRepository movieRepository,
            IActorsRepository actorsRepository)
        {
            _categoryRepository = categoryRepository;
            _genresRepository = genresRepository;
            _notyfService = notyfService;
            _movieRepository = movieRepository;
            _actorsRepository = actorsRepository;
        }


        [Route("Category-{categoryId}")]
        public IActionResult ShowMoviesByCategory(int categoryId)
        {
            if (categoryId == 1)
            {
                ViewBag.CategoryName = "Movies";
            }
            else
            {
                ViewBag.CategoryName = "Series";
            }
            
            ViewBag.Genres = _genresRepository.GetAllGenres();
            ViewBag.LatestMovies = _movieRepository.GetLatestMovies();
            return View("_ShowMoviesList", _movieRepository.GetMoviesByCategoryId(categoryId));
        }
        [Route("ShowDetails-{itemId}")]
        public IActionResult ShowMovieDetails(int itemId)
        {
            var movieDetails = _movieRepository.GetMovieDetailsByItemId(itemId);
            if (movieDetails == null)
            {
                return NotFound();
            }
            else
            {
                var genreId = movieDetails.SelectedGenres.First().GenreId;
                ViewBag.SimilarItems = _movieRepository.GetSimilarMovies(genreId);

                return View("_SingleItemDetails",movieDetails);
            }
        }
        [Route("SortByAge-{ageRating}")]
        public IActionResult ShowMoviesByAgeRating(string ageRating)
        {
            ViewBag.Genres = _genresRepository.GetAllGenres();
            ViewBag.LatestMovies = _movieRepository.GetLatestMovies();
            return View("_ShowMoviesList", _movieRepository.GetMoviesByAge(ageRating));
        }
        [Route("SortByQuality-{quality}")]
        public IActionResult ShowMoviesByQuality(string quality)
        {
            ViewBag.Genres = _genresRepository.GetAllGenres();
            ViewBag.LatestMovies = _movieRepository.GetLatestMovies();
            return View("_ShowMoviesList", _movieRepository.GetMoviesByQuality(quality));
        }
        [Route("Genre-{genreId}")]
        public IActionResult ShowMoviesByGenre(int genreId)
        {
            ViewBag.GenreName = _genresRepository.GetGenreNameByGenreId(genreId);
            ViewBag.Genres = _genresRepository.GetAllGenres();
            ViewBag.LatestMovies = _movieRepository.GetLatestMovies();
            return View("_ShowMoviesList", _movieRepository.GetMoviesByGenreId(genreId));
        }
        [Route("SortByYear-{year}")]
        public IActionResult ShowMoviesByYear(string year)
        {
            ViewBag.Genres = _genresRepository.GetAllGenres();
            ViewBag.LatestMovies = _movieRepository.GetLatestMovies();
            ViewBag.Year = year;
            return View("_ShowMoviesList", _movieRepository.GetMoviesByReleaseYear(year));
        }
        [Route("SortByActor-{actorName}")]
        public IActionResult ShowMoviesByActorName(string actorName)
        {
            ViewBag.ActorName = actorName;
            ViewBag.ActorImage = _actorsRepository.GetActorImage(actorName);

            return View("_ShowActorsMovies", _movieRepository.GetMoviesByActorName(actorName));
        }
    }
}
