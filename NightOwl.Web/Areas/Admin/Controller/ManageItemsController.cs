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
        // GET: ManageItemsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ManageItemsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ManageItemsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
