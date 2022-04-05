using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
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
    }
}
