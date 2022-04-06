using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NightOwl.Core.DTOs;
using NightOwl.DataLayer.Context;
using NightOwl.DataLayer.Entities;
using NightOwl.Utility.Generators;

namespace NightOwl.Web.Areas.Admin.Controller
{
    [Area("Admin")]
    public class ManageItemsController : Microsoft.AspNetCore.Mvc.Controller
    {
        private NightOwlContext _context;
        private INotyfService _notyfService;

        public ManageItemsController(NightOwlContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        [BindProperty] public ItemsViewModel Items { get; set; }


        // GET: ManageItemsController
        [Route("/Admin/Items/{categoryId}")]
        public ActionResult Index(int categoryId)
        {
            var moviesOrSeries = _context.SelectedCategories
                .Where(c => c.CategoryId == categoryId)
                .Select(c => c.Items)
                .ToList();
            return View(moviesOrSeries);
        }

        // GET: ManageItemsController/Details/5
        [Route("/Admin/Details/{itemId}")]
        public ActionResult Details(int itemId)
        {
            var itemDetails = _context.Items.Find(itemId);

            if (itemDetails == null)
                return NotFound();

            return View(itemDetails);
        }

        // GET: ManageItemsController/Create
        [Route("/Admin/Items/NewItem")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManageItemsController/Create
        [Route("/Admin/Items/NewItem")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("ItemId", "Title", "Description", "ReleaseYear", "ManufacturerCountry",
                "Language", "ImdbScore",
                "RottenTomatoScore", "MetaCriticScore", "AvailableQualities", "RunningTime", "Banner", "Actors",
                "Director", "AgeRating", "AddedTime", "Episodes",
                "Seasons", "EndRunningYear", "TrailerLink")]
            Items items)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(items);

                items.AddedTime = DateTime.Now;
                _context.Items.Add(items);
                _context.SaveChanges();

                if (Items.Banner?.Length > 0)
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

                    using (var stream = new FileStream(bannerPath, FileMode.Create))
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
        [Route("/Admin/Items/Update/{itemId}")]
        public ActionResult Edit(int itemId)
        {
            var currentItem = _context.Items.Find(itemId);
            return View(currentItem);
        }

        // POST: ManageItemsController/Edit/5
        [Route("/Admin/Items/Update/{itemId}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int itemId, [Bind("ItemId", "Title", "Description", "ReleaseYear",
                "ManufacturerCountry", "Language", "ImdbScore",
                "RottenTomatoScore", "MetaCriticScore", "AvailableQualities", "RunningTime", "Banner", "Actors",
                "Director", "AgeRating", "AddedTime", "Episodes",
                "Seasons", "EndRunningYear", "TrailerLink")]
            Items items)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(items);

                var currentItem = _context.Items.AsNoTracking().SingleOrDefault(i => i.ItemId == itemId);

                if (currentItem.ItemId != items.ItemId)
                    return NotFound();

                _context.Items.Update(items);
                _context.SaveChanges();

                if (Items.Banner?.Length > 0)
                {
                    var newName = itemId + "-" + items.Title.Replace(" ", "").Replace(":", "")
                                      .ToString() +
                                  Path.GetExtension(Items.Banner.FileName);

                    var newPath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot",
                        "img",
                        "Movies",
                        newName);

                    var oldPath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot",
                        "img",
                        "Movies",
                        currentItem.Banner);

                    if (System.IO.File.Exists(oldPath))
                    {
                        System.IO.File.Delete(oldPath);
                    }

                    using (var stream = new FileStream(newPath, FileMode.Create))
                    {
                        Items.Banner.CopyTo(stream);
                    }

                    items.Banner = newName;
                }
                else
                {
                    items.Banner = currentItem.Banner;
                }

                _context.SaveChanges();
                _notyfService.Success("New Changes Saved !");
                return Redirect("/Admin/Items/1");
            }
            catch
            {
                _notyfService.Error("Something Wrong Happened During Saving Changes !");
                return View();
            }
        }

        // GET: ManageItemsController/Delete/5
        [Route("/Admin/Items/Remove/{itemId}")]
        public ActionResult Delete(int itemId)
        {
            var currentItem = _context.Items.Find(itemId);
            return View(currentItem);
        }

        // POST: ManageItemsController/Delete/5
        [Route("/Admin/Items/Remove/{itemId}")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int itemId)
        {
            try
            {
                var currentItem = _context.Items.AsNoTracking().SingleOrDefault(i => i.ItemId == itemId);

                if (currentItem == null)
                    return NotFound();

                var oldPath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot",
                    "img",
                    "Movies",
                    currentItem.Banner);


                if (System.IO.File.Exists(oldPath))
                {
                    System.IO.File.Delete(oldPath);
                }

                _context.Items.Remove(currentItem);
                _context.SaveChanges();
                _notyfService.Success("Item Has Been Removed Successfully !");

                return Redirect("/Admin/Items/1");
            }
            catch
            {
                _notyfService.Error("Something Wrong Happened During Deleting Item !");
                return View();
            }
        }

        [Route("/Admin/ManageDownload/{itemId}")]
        public IActionResult DownloadLinks(int itemId)
        {
            ViewBag.itemId = itemId;
            return View(_context.Download.Where(d => d.ItemId == itemId).ToList());
        }

        [Route("/Admin/ManageDownload/Update/{downloadId}")]
        public IActionResult UpdateDownloadDetails(int downloadId)
        {
            return View(_context.Download
                .Include(d => d.Items)
                .Single(d => d.DownloadId == downloadId));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Admin/ManageDownload/Update/{downloadId}")]
        public IActionResult UpdateDownloadDetails(int downloadId
            , [Bind("DownloadId", "ItemSize", "UploadDate", "QualityDetails", "SeasonDetails", "EpisodeDetails", "DownloadLink", "ItemId")] Download download)
        {
            try
            {
                var currentDetails = _context.Download
                    .Include(d => d.Items)
                    .AsNoTracking()
                    .SingleOrDefault(d => d.DownloadId == downloadId);

                if (currentDetails == null)
                    return NotFound();

                _context.Download.Update(download);
                _context.SaveChanges();

                _notyfService.Success("Download Detail's Has Been Updated Successfully !");

                return Redirect($"/Admin/ManageDownload/{download.ItemId}");
            }
            catch
            {
                _notyfService.Error("Something Wrong Happened During Update Operation !");
                return View(download);
            }



        }

        [Route("/Admin/ManageDownload/Upload/{itemId}")]
        public IActionResult UploadNewFile(int itemId)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Admin/ManageDownload/Upload/{itemId}")]
        public IActionResult UploadNewFile(int itemId,[Bind("DownloadId", "ItemSize", "UploadDate", "QualityDetails", "SeasonDetails", "EpisodeDetails", "DownloadLink", "ItemId")] Download download)
        {
            try
            {
                download.UploadDate = DateTime.Now;

                _context.Download.Add(download);
                _context.SaveChanges();

                _notyfService.Success("New Download Details Added");

                return Redirect($"/Admin/ManageDownload/{download.ItemId}");
            }
            catch
            {
                _notyfService.Error("Something Wrong Happened !");
                return View();
            }
 
        }

        [Route("/Admin/ManageDownload/Remove/{downloadId}")]
        public IActionResult RemoveDownloadLinks(int downloadId)
        {
            var downloadDetails = _context.Download
                .Find(downloadId);

            return View(downloadDetails);
        }

        [HttpPost,ActionName("RemoveDownloadLinks")]
        [ValidateAntiForgeryToken]
        [Route("/Admin/ManageDownload/Remove/{downloadId}")]
        public IActionResult ConfirmRemoveDownloadLinks(int downloadId)
        {
            try
            {
                var downloadDetails = _context.Download
                    .AsNoTracking()
                    .SingleOrDefault(d=>d.DownloadId==downloadId);

                _context.Download.Remove(downloadDetails);
                _context.SaveChanges();

                _notyfService.Success("Download Link Removed Successfully !");

                return Redirect($"/Admin/ManageDownload/{downloadDetails.ItemId}");
            }
            catch
            {
                _notyfService.Error("Something Wrong Happened !");
                return View();
            }

        }
    }
}
