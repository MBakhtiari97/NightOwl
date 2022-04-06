using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NightOwl.Core.Services.Interfaces;

namespace NightOwl.Web.Areas.Admin.Controller
{
    [Area("Admin")]
    public class ReviewController : Microsoft.AspNetCore.Mvc.Controller
    {
        #region Injection

        private IReviewRepository _reviewRepository;
        private INotyfService _notyfService;

        public ReviewController(IReviewRepository reviewRepository, INotyfService notyfService)
        {
            _reviewRepository = reviewRepository;
            _notyfService = notyfService;
        }


        #endregion

        #region Index

        [Route("/Admin/Items/Reviews/{itemId}")]
        public IActionResult ReviewsIndex(int itemId)
        {
            return View(_reviewRepository.GetReviewsByItemId(itemId));
        }


        #endregion

        #region Confirm

        public IActionResult ConfirmReview(int reviewId)
        {
            if (_reviewRepository.ConfirmReview(reviewId))
            {
                _notyfService.Success("Review Has Been Confirmed Successfully !");
            }
            else
            {
                _notyfService.Success("Failed To Confirm Review !");
            }
            return Redirect("/Admin");
        }


        #endregion

        #region Remove

        public IActionResult RemoveReview(int reviewId)
        {
            if (_reviewRepository.RemoveReview(reviewId))
            {
                _notyfService.Success("Review Has Been Deleted Successfully !");
            }
            else
            {
                _notyfService.Success("Failed To Remove Review !");
            }

            return Redirect("/Admin");
        }

        #endregion

    }
}
