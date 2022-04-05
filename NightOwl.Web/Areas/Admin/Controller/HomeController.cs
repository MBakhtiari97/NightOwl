using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NightOwl.Core.Services.Interfaces;
using NightOwl.DataLayer.Context;

namespace NightOwl.Web.Areas.Admin.Controller
{
    [Area("Admin")]
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        IReviewRepository _reviewRepository;
        IMovieRepository _movieRepository;
        private NightOwlContext _context;

        public HomeController(IReviewRepository reviewRepository, IMovieRepository movieRepository,NightOwlContext context)
        {
            _reviewRepository = reviewRepository;
            _movieRepository = movieRepository;
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.ReviewsNo = _reviewRepository.GetTotalReviews();
            ViewBag.MoviesNo = _movieRepository.GetTotalMovies();
            ViewBag.SeriesNo = _movieRepository.GetTotalSeries();
            ViewBag.ComingSoonNo = _movieRepository.GetTotalComingSoon();
            ViewBag.AdminRequests = _context.Admins.Where(a => a.IsActive==false).ToList();
            ViewBag.UnPublishedReviews = _reviewRepository.GetUnPublishedReviews();
            return View();
        }
    }
}
