using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NightOwl.Core.DTOs;
using NightOwl.DataLayer.Context;
using NightOwl.DataLayer.Entities;

namespace NightOwl.Web.Areas.Admin.Controller
{
    [Area("Admin")]
    public class ManageItemsController : Microsoft.AspNetCore.Mvc.Controller
    {
        private NightOwlContext _context;
        private INotyfService _notyfService;

        public ManageItemsController(NightOwlContext context , INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        [BindProperty] 
        public ItemsViewModel Items { get; set; }


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
        [Route("/Admin/Items/NewItem")]
        // GET: ManageItemsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManageItemsController/Create
        [Route("/Admin/Items/NewItem")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("ItemId", "Title", "Description", "ReleaseYear", "ManufacturerCountry", "Language", "ImdbScore",
            "RottenTomatoScore", "MetaCriticScore","AvailableQualities","RunningTime","Banner","Actors","Director","AgeRating","AddedTime","Episodes",
            "Seasons","EndRunningYear","TrailerLink")] Items items)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(items);

                items.AddedTime = DateTime.Now;
                _context.Items.Add(items);
                _context.SaveChanges();

                if (Items.Banner?.Length>0)
                {
                    var createName = items.Title.Replace(" ", "").Replace(":", "").ToString();
                    var bannerName = items.ItemId + "-" + createName;
                    items.Banner = bannerName + Path.GetExtension(Items.Banner.FileName);


                    var bannerPath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot",
                        "img",
                        "Movies",
                        bannerName +
                        Path.GetExtension(Items.Banner.FileName));

                    using (var stream = new FileStream(bannerPath,FileMode.Create))
                    {
                        Items.Banner.CopyTo(stream);
                    }
                }
                else
                {
                    items.Banner = "Default.png";
                }

                _context.SaveChanges();

                _notyfService.Success("Item Successfully Added");
                return Redirect("/Admin/Items/1");
            }
            catch
            {
                _notyfService.Error("Something wrong happened while trying to add item !");
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
