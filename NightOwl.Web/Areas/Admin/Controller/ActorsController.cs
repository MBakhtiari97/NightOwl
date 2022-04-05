using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NightOwl.Core.DTOs;
using NightOwl.DataLayer.Context;
using NightOwl.DataLayer.Entities;

namespace NightOwl.Web.Areas.Admin.Controller
{
    [Area("Admin")]
    public class ActorsController : Microsoft.AspNetCore.Mvc.Controller
    {
        NightOwlContext _context;
        private INotyfService _notyfService;

        public ActorsController(NightOwlContext context,INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        [BindProperty] 
        public ActorsViewModel Actors { get; set; }

        [Route("/Admin/Actors")]
        public IActionResult Index()
        {
            var actors = _context.Actors.ToList();
            return View(actors);
        }

        [Route("/Admin/Actors/Details/{actorId}")]
        public IActionResult ActorDetails(int actorId)
        {
            var actorsDetails = _context.Actors.Find(actorId);
            return View(actorsDetails);
        }

        [Route("/Admin/Actors/New")]
        public IActionResult CreateActor()
        {
            return View();
        }

        [Route("/Admin/Actors/New")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateActor([Bind("ActorId,ActorName,ActorGender,ActorImage")] Actors actor)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(actor);

                if (Actors.ActorImage?.Length > 0)
                {
                    var actorImageName = actor.ActorName.Replace(" ", "").ToString()
                                         + Path.GetExtension(Actors.ActorImage.FileName);
                    actor.ActorImage = actorImageName;

                    var actorImagePath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot",
                        "img",
                        "Actors",
                        actorImageName);

                    using (var stream = new FileStream(actorImagePath, FileMode.Create))
                    {
                        Actors.ActorImage.CopyTo(stream);
                    }

                }
                else
                {
                    actor.ActorImage = "Default.jpg";
                }

                _context.Actors.Add(actor);
                _context.SaveChanges();

                _notyfService.Success($"{actor.ActorName} Has Been Added Successfully !");

                return RedirectToAction("Index");
            }
            catch
            {
                _notyfService.Error("Cannot Add Actor ! Something Wrong Happened :(");
                return View();
            }
            
        }

        [Route("/Admin/Actors/Update/{actorId}")]
        public IActionResult UpdateActor(int actorId)
        {
            var actorDetails = _context.Actors.Find(actorId);
            return View(actorDetails);
        }

        [HttpPost]
        [Route("/Admin/Actors/Update/{actorId}")]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateActor(int actorId, [Bind("ActorId,ActorName,ActorGender,ActorImage")] Actors actor)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(actor);

                var actorDetails = _context.Actors
                    .AsNoTracking()
                    .SingleOrDefault(a => a.ActorId == actorId);

                if (actorDetails == null)
                    return NotFound();

                if (Actors.ActorImage?.Length > 0)
                {
                    var newName = actor.ActorName.Replace(" ", "")
                                  + Path.GetExtension(Actors.ActorImage.FileName);

                    var newPath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot",
                        "img",
                        "Actors",
                        newName);

                    var oldPath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot",
                        "img",
                        "Actors",
                        actorDetails.ActorImage);

                    if (System.IO.File.Exists(oldPath) && actorDetails.ActorImage != "Default.jpg")
                    {
                        System.IO.File.Delete(oldPath);
                    }

                    using (var stream = new FileStream(newPath,FileMode.Create))
                    {
                        Actors.ActorImage.CopyTo(stream);
                    }

                    actor.ActorImage = newName;
                }
                else
                {
                    actor.ActorImage = actorDetails.ActorImage;
                }

                _context.Actors.Update(actor);
                _context.SaveChanges();
                _notyfService.Success("Changes Saved !");

                return RedirectToAction("Index");
            }
            catch
            {
                _notyfService.Error("Cannot Save Changes ! Something Wrong Happened !");
                return View();
            }
            
        }

        [Route("/Admin/Actors/Remove/{actorId}")]
        public IActionResult RemoveActor(int actorId)
        {
            var actorDetails = _context.Actors.Find(actorId);
            return View(actorDetails);
        }

        [Route("/Admin/Actors/Remove/{actorId}")]
        [HttpPost,ActionName("RemoveActor")]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmRemoveActor(int actorId)
        {
            try
            {
                var actorDetails = _context.Actors
                    .AsNoTracking()
                    .SingleOrDefault(a => a.ActorId == actorId);

                if (actorDetails.ActorId != actorId)
                    return NotFound();

                var imagePath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot",
                    "img",
                    "Actors",
                    actorDetails.ActorImage);

                if (System.IO.File.Exists(imagePath) && actorDetails.ActorImage != "Default.jpg")
                {
                    System.IO.File.Delete(imagePath);
                }

                _context.Actors.Remove(actorDetails);
                _context.SaveChanges();

                _notyfService.Success($"{actorDetails.ActorName} Has Been Removed Successfully !");
                return RedirectToAction("Index");
            }
            catch 
            {
                _notyfService.Error("Something Wrong Happened During Removing Actor !");
                return View();
            }
           
        }
    }
}
