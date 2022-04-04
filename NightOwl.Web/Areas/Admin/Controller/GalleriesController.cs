using AspNetCoreHero.ToastNotification.Abstractions;
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
    public class GalleriesController : Microsoft.AspNetCore.Mvc.Controller
    {
        private NightOwlContext _context;
        private INotyfService _notyfServicel;

        public GalleriesController(NightOwlContext context,INotyfService notyfService)
        {
            _context = context;
            _notyfServicel = notyfService;
        }

        [BindProperty]
        public GalleriesViewModel Galleries { get; set; }


        [Route("/Admin/Galleries/{id}")]
        public ActionResult Index(int id)
        {
            ViewBag.ItemId = id;
            var galleries = _context.Galleries.Where(g => g.ItemId == id).ToList();
            return View(galleries);
        }

        // GET: GalleriesController/Details/5
        [Route("/Admin/Galleries/Details/{id}")]
        public ActionResult Details(int id)
        {
            var gallery = _context.Galleries.Find(id);
            return View(gallery);
        }

        // GET: GalleriesController/Create
        [Route("/Admin/Galleries/Create/{itemId}")]
        public ActionResult Create(int itemId)
        {
            ViewBag.ItemId = itemId;
            return View();
        }

        // POST: GalleriesController/Create
        [Route("/Admin/Galleries/Create/{itemId}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("GalleryId,ImageName,ImageAltName,ItemId")] Galleries gallery)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(gallery);

                if (Galleries.ImageName?.Length > 0)
                {
                    var newName = StringGenerator.GenerateUniqueString() +
                                  Path.GetExtension(Galleries.ImageName.FileName);

                    gallery.ImageName = newName;

                    var newPath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot",
                        "img",
                        "Galleries",
                        newName);

                    using (var stream = new FileStream(newPath,FileMode.Create))
                    {
                        Galleries.ImageName.CopyTo(stream);
                    }

                }
                else
                {
                    gallery.ImageName = "Default.jpg";
                }
                _context.Galleries.Add(gallery);
                _context.SaveChanges();

                _notyfServicel.Success("Image Has Successfully Added To Gallery !");

                return Redirect($"/Admin/Galleries/{gallery.ItemId}");
            }
            catch
            {
                _notyfServicel.Error("Something Wrong Happened During Saving Image On Gallery !");
                return View();
            }
        }

        // GET: GalleriesController/Edit/5
        [Route("/Admin/Galleries/Update/{galleryId}")]
        public ActionResult Edit(int galleryId)
        {
            var galleryImage = _context.Galleries.Find(galleryId);

            if (galleryImage == null)
                return NotFound();

            ViewBag.ItemId = galleryImage.ItemId;

            return View(galleryImage);
        }

        // POST: GalleriesController/Edit/5
        [Route("/Admin/Galleries/Update/{galleryId}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int galleryId, [Bind("GalleryId,ImageName,ImageAltName,ItemId")] Galleries gallery)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(gallery);

                var currentImageDetails = _context.Galleries
                    .AsNoTracking()
                    .Single(g=>g.GalleryId==galleryId);

                if (currentImageDetails.GalleryId != galleryId)
                    return NotFound();

                if (Galleries.ImageName?.Length > 0)
                {
                    var newName = StringGenerator.GenerateUniqueString() 
                                  + Path.GetExtension(Galleries.ImageName.FileName);

                    var newPath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot",
                        "img",
                        "Galleries",
                        newName);

                    var oldPath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot",
                        "img",
                        "Galleries",
                        currentImageDetails.ImageName);

                    if (System.IO.File.Exists(oldPath) && currentImageDetails.ImageName != "Default.jpg")
                    {
                        System.IO.File.Delete(oldPath);
                    }

                    using (var stream = new FileStream(newPath,FileMode.Create))
                    {
                        Galleries.ImageName.CopyTo(stream);
                    }

                    gallery.ImageName = newName;
                }
                else
                {
                    gallery.ImageName = currentImageDetails.ImageName;
                }

                _context.Galleries.Update(gallery);
                _context.SaveChanges();
                _notyfServicel.Success("Changes Saved !");

                return Redirect($"/Admin/Galleries/{gallery.ItemId}");
            }
            catch
            {
                _notyfServicel.Error("Something Wrong Happened !");
                return View();
            }
        }

        // GET: GalleriesController/Delete/5
        [Route("/Admin/Galleries/Remove/{galleryId}")]
        public ActionResult Delete(int galleryId)
        {
            var currentGallery = _context.Galleries.Find(galleryId);
            return View(currentGallery);
        }

        // POST: GalleriesController/Delete/5
        [Route("/Admin/Galleries/Remove/{galleryId}")]
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int galleryId)
        {
            try
            {
                var currentImageDetails = _context.Galleries
                    .AsNoTracking()
                    .Single(g => g.GalleryId == galleryId);

                if (currentImageDetails.GalleryId != galleryId)
                    return NotFound();

                var imagePath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot",
                    "img",
                    "Galleries",
                    currentImageDetails.ImageName);

                if (System.IO.File.Exists(imagePath) && currentImageDetails.ImageName != "Default.jpg")
                {
                    System.IO.File.Delete(imagePath);
                }

                _context.Galleries.Remove(currentImageDetails);
                _context.SaveChanges();
                _notyfServicel.Success("Image Has Been Removed Successfully !");

                return Redirect($"/Admin/Galleries/{currentImageDetails.ItemId}");
            }
            catch
            {
                _notyfServicel.Error("Something Wrong Happened !");
                return View();
            }
        }
    }
}
