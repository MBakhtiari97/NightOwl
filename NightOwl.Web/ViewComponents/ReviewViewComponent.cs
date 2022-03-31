using Microsoft.AspNetCore.Mvc;
using NightOwl.Core.Services.Interfaces;

namespace NightOwl.Web.ViewComponents
{
    public class ReviewViewComponent:ViewComponent
    {
        private IReviewRepository _reviewRepository;

        public ReviewViewComponent(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync(int itemId)
        {
            return View("/Views/ViewComponents/ReviewViewComponent.cshtml",_reviewRepository.GetReviewsByItem(itemId));
        }
    }
}
