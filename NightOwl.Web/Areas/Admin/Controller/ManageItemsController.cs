using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NightOwl.DataLayer.Context;

namespace NightOwl.Web.Areas.Admin.Controller
{
    [Area("Admin")]
    public class ManageItemsController : Microsoft.AspNetCore.Mvc.Controller
    {
        private NightOwlContext _context;

        public ManageItemsController(NightOwlContext context)
        {
            _context = context;
        }

        [Route("/Admin/Items/{categoryId}")]
        // GET: ManageItemsController
        public ActionResult Index(int categoryId)
        {
            var moviesOrSeries = _context.SelectedCategories
                .Where(c => c.CategoryId == categoryId)
                .Select(c => c.Items)
                .ToList();
            return View(moviesOrSeries);
        }
        [Route("/Admin/Details/{itemId}")]
        // GET: ManageItemsController/Details/5
        public ActionResult Details(int itemId)
        {
            var itemDetails = _context.Items.Find(itemId);

            if (itemDetails == null)
                return NotFound();

            return View(itemDetails);
        }

        // GET: ManageItemsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManageItemsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ManageItemsController/Edit/5
        public ActionResult Edit(int itemId)
        {
            return View();
        }

        // POST: ManageItemsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int itemId, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ManageItemsController/Delete/5
        public ActionResult Delete(int itemId)
        {
            return View();
        }

        // POST: ManageItemsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int itemId, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
