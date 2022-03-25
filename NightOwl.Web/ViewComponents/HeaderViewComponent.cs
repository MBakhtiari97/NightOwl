using Microsoft.AspNetCore.Mvc;
using NightOwl.Core.Services.Interfaces;

namespace NightOwl.Web.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private ICategoryRepository _categoryRepository;
        private IGenresRepository _genresRepository;

        public HeaderViewComponent(ICategoryRepository categoryRepository, IGenresRepository genresRepository)
        {
            _categoryRepository = categoryRepository;
            _genresRepository = genresRepository;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.Categories = _categoryRepository.GetAllCategories();
            return View("/Views/ViewComponents/HeaderViewComponent.cshtml", _genresRepository.GetAllGenres());

        }
    }
}
