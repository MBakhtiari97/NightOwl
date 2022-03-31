using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using NightOwl.Core.Services.Interfaces;
using NightOwl.DataLayer.Entities;
using Microsoft.AspNetCore.HttpOverrides;

namespace NightOwl.Web.Controller
{
    public class ReviewController : Microsoft.AspNetCore.Mvc.Controller
    {
        IReviewRepository _reviewRepository;
        public INotyfService _notifyService { get; }

        public ReviewController(IReviewRepository reviewRepository, INotyfService notifyService)
        {
            _reviewRepository = reviewRepository;
            _notifyService = notifyService;
        }

        [HttpPost]
        public IActionResult AddReview(Reviews newReview)
        {
            newReview.ReviewDate=DateTime.Now;
            newReview.ReviewerIpAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            if (_reviewRepository.SubmitReview(newReview))
            {
                _notifyService.Success("Your Review Successfully Has Been Sent !");
                
            }
            else
            {
                _notifyService.Error("Can't Submit Your Review , Try Again !");
            }
            return Redirect($"/ShowDetails-{newReview.ItemId}");
        }
    }
}
