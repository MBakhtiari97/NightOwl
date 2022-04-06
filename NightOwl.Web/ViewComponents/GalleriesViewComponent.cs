using Microsoft.AspNetCore.Mvc;
using NightOwl.Core.Services.Interfaces;

namespace NightOwl.Web.ViewComponents
{
    public class GalleriesViewComponent : ViewComponent
    {
        private IGalleryRepository _galleryRepository;

        public GalleriesViewComponent(IGalleryRepository galleryRepository)
        {
            _galleryRepository = galleryRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync(int itemId)
        {
            return View("/Views/ViewComponents/GalleriesViewComponent.cshtml", _galleryRepository.GetItemGalleryByItemId(itemId));
        }
    }
}