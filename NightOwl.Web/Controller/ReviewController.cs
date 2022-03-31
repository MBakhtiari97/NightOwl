using Microsoft.AspNetCore.Mvc;
using NightOwl.Core.Services.Interfaces;
using NightOwl.DataLayer.Entities;
using Microsoft.AspNetCore.HttpOverrides;

namespace NightOwl.Web.Controller
{
    public class ReviewController : Microsoft.AspNetCore.Mvc.Controller
    {
        IReviewRepository _reviewRepository;

        public ReviewController(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        [HttpPost]
        public IActionResult AddReview(Reviews newReview)
        {
            newReview.ReviewDate=DateTime.Now;
            newReview.ReviewerIpAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            if (_reviewRepository.SubmitReview(newReview))
            {
                //Notify User
                
            }
            else
            {
                //Notify User
            }
            return Redirect($"/ShowDetails-{newReview.ItemId}");
        }
    }
}
