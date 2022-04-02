using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NightOwl.Core.Services.Interfaces;

namespace NightOwl.Web.Areas.Admin.Controller
{
    [Authorize]
    [Area("Admin")]
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        IReviewRepository _reviewRepository;
        IMovieRepository _movieRepository;

        public HomeController(IReviewRepository reviewRepository, IMovieRepository movieRepository)
        {
            _reviewRepository = reviewRepository;
            _movieRepository = movieRepository;
        }

        public IActionResult Index()
        {
            ViewBag.ReviewsNo = _reviewRepository.GetTotalReviews();
            ViewBag.MoviesNo = _movieRepository.GetTotalMovies();
            ViewBag.SeriesNo = _movieRepository.GetTotalSeries();
            ViewBag.ComingSoonNo = _movieRepository.GetTotalComingSoon();

            ViewBag.UnPublishedReviews = _reviewRepository.GetUnPublishedReviews();
            return View();
        }
    }
}
