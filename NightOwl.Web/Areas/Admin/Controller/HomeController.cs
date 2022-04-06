using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NightOwl.Core.Services.Interfaces;
using NightOwl.DataLayer.Context;

namespace NightOwl.Web.Areas.Admin.Controller
{
    [Area("Admin")]
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        #region Injection

        IReviewRepository _reviewRepository;
        IMovieRepository _movieRepository;
        IAccountRepository _accountRepository;
        private NightOwlContext _context;

        public HomeController(IReviewRepository reviewRepository
            , IMovieRepository movieRepository
            , IAccountRepository accountRepository)
        {
            _reviewRepository = reviewRepository;
            _movieRepository = movieRepository;
            _accountRepository = accountRepository;
        }

        #endregion

        #region Index

        public IActionResult Index()
        {
            #region RequiredViewBags

            ViewBag.ReviewsNo = _reviewRepository.GetTotalReviews();
            ViewBag.MoviesNo = _movieRepository.GetTotalMovies();
            ViewBag.SeriesNo = _movieRepository.GetTotalSeries();
            ViewBag.ComingSoonNo = _movieRepository.GetTotalComingSoon();
            ViewBag.AdminRequests = _accountRepository.GetAdminRequests();
            ViewBag.UnPublishedReviews = _reviewRepository.GetUnPublishedReviews();

            #endregion

            return View();
        }

        #endregion
    }
}
