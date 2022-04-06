using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NightOwl.Core.DTOs;
using NightOwl.Core.Services.Interfaces;
using NightOwl.DataLayer.Context;
using NightOwl.DataLayer.Entities;
using NightOwl.Utility.Generators;

namespace NightOwl.Web.Areas.Admin.Controller
{
    [Area("Admin")]
    public class GalleriesController : Microsoft.AspNetCore.Mvc.Controller
    {
        #region Injection

        private INotyfService _notyfServicel;
        private IGalleryRepository _galleryRepository;

        public GalleriesController(INotyfService notyfService, IGalleryRepository galleryRepository)
        {
            _notyfServicel = notyfService;
            _galleryRepository = galleryRepository;
        }


        #endregion

        #region BindingProperty

        [BindProperty]
        public GalleriesViewModel Galleries { get; set; }


        #endregion

        #region Index

        [Route("/Admin/Galleries/{itemId}")]
        public ActionResult Index(int itemId)
        {
            ViewBag.ItemId = itemId;
            return View(_galleryRepository.GetGalleriesByItemId(itemId));
        }

        #endregion

        #region Details

        // GET: GalleriesController/Details/5
        [Route("/Admin/Galleries/Details/{galleryId}")]
        public ActionResult Details(int galleryId)
        {
            return View(_galleryRepository.GetGalleryByGalleryId(galleryId));
        }


        #endregion

        #region CreateNew

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

                    using (var stream = new FileStream(newPath, FileMode.Create))
                    {
                        Galleries.ImageName.CopyTo(stream);
                    }

                }
                else
                {
                    gallery.ImageName = "Default.jpg";
                }

                _galleryRepository.AddNewGallery(gallery);
                _notyfServicel.Success("Image Has Successfully Added To Gallery !");

                return Redirect($"/Admin/Galleries/{gallery.ItemId}");
            }
            catch
            {
                _notyfServicel.Error("Something Wrong Happened During Saving Image On Gallery !");
                return View();
            }
        }


        #endregion

        #region Update

        // GET: GalleriesController/Edit/5
        [Route("/Admin/Galleries/Update/{galleryId}")]
        public ActionResult Edit(int galleryId)
        {
            var galleryImage = _galleryRepository.GetGalleryByGalleryId(galleryId);

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

                var currentImageDetails = _galleryRepository.GetGalleryAsNoTracking(galleryId);

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

                    using (var stream = new FileStream(newPath, FileMode.Create))
                    {
                        Galleries.ImageName.CopyTo(stream);
                    }

                    gallery.ImageName = newName;
                }
                else
                {
                    gallery.ImageName = currentImageDetails.ImageName;
                }

                _galleryRepository.UpdateGallery(gallery);
                _notyfServicel.Success("Changes Saved !");

                return Redirect($"/Admin/Galleries/{gallery.ItemId}");
            }
            catch
            {
                _notyfServicel.Error("Something Wrong Happened !");
                return View();
            }
        }


        #endregion

        #region Remove

        // GET: GalleriesController/Delete/5
        [Route("/Admin/Galleries/Remove/{galleryId}")]
        public ActionResult Delete(int galleryId)
        {
            return View(_galleryRepository.GetGalleryByGalleryId(galleryId));
        }

        // POST: GalleriesController/Delete/5
        [Route("/Admin/Galleries/Remove/{galleryId}")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int galleryId)
        {
            try
            {
                var currentImageDetails = _galleryRepository.GetGalleryAsNoTracking(galleryId);

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

                _galleryRepository.RemoveGallery(currentImageDetails);
                _notyfServicel.Success("Image Has Been Removed Successfully !");

                return Redirect($"/Admin/Galleries/{currentImageDetails.ItemId}");
            }
            catch
            {
                _notyfServicel.Error("Something Wrong Happened !");
                return View();
            }
        }

        #endregion
    }
}
