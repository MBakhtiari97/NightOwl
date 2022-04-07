using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NightOwl.Core.DTOs;
using NightOwl.Core.Services.Interfaces;
using NightOwl.DataLayer.Context;
using NightOwl.DataLayer.Entities;

namespace NightOwl.Web.Areas.Admin.Controller
{
    [Area("Admin")]
    public class ActorsController : Microsoft.AspNetCore.Mvc.Controller
    {
        #region Injection

        private INotyfService _notyfService;
        private IActorsRepository _actorsRepository;

        public ActorsController(INotyfService notyfService, IActorsRepository actorsRepository)
        {
            _notyfService = notyfService;
            _actorsRepository = actorsRepository;
        }


        #endregion

        #region Binding Properties

        [BindProperty]
        public ActorsViewModel Actors { get; set; }


        #endregion

        #region Index

        [Route("/Admin/Actors")]
        public IActionResult Index()
        {
            return View(_actorsRepository.GetAllActors());
        }

        #endregion

        #region Details

        [Route("/Admin/Actors/Details/{actorId}")]
        public IActionResult ActorDetails(int actorId)
        {
            return View(_actorsRepository.GetActor(actorId));
        }


        #endregion

        #region CreateNew

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

                //Checking if the actor image was selected then do these
                if (Actors.ActorImage?.Length > 0)
                {
                    //Creating a new  name for image
                    var actorImageName = actor.ActorName.Replace(" ", "").ToString()
                                         + Path.GetExtension(Actors.ActorImage.FileName);
                    actor.ActorImage = actorImageName;

                    //Initializing image directory for saving image
                    var actorImagePath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot",
                        "img",
                        "Actors",
                        actorImageName);

                    //Saving image on server 
                    using (var stream = new FileStream(actorImagePath, FileMode.Create))
                    {
                        Actors.ActorImage.CopyTo(stream);
                    }

                }
                else
                {
                    actor.ActorImage = "Default.jpg";
                }

                _actorsRepository.AddNewActor(actor);

                _notyfService.Success($"{actor.ActorName} Has Been Added Successfully !");

                return RedirectToAction("Index");
            }
            catch
            {
                _notyfService.Error("Cannot Add Actor ! Something Wrong Happened :(");
                return View();
            }

        }


        #endregion

        #region Update

        [Route("/Admin/Actors/Update/{actorId}")]
        public IActionResult UpdateActor(int actorId)
        {
            var actorDetails = _actorsRepository.GetActor(actorId);
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

                var actorDetails = _actorsRepository.GetActorAsNoTracking(actorId);

                //Checking if the image was selected then do these
                if (Actors.ActorImage?.Length > 0)
                {
                    //Giving aa new  name for image
                    var newName = actor.ActorName.Replace(" ", "")
                                  + Path.GetExtension(Actors.ActorImage.FileName);

                    //Initializing path's , new for saving new image and old for current image
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

                    //Deleting current image
                    if (System.IO.File.Exists(oldPath) && actorDetails.ActorImage != "Default.jpg")
                    {
                        System.IO.File.Delete(oldPath);
                    }

                    //Saving new image
                    using (var stream = new FileStream(newPath, FileMode.Create))
                    {
                        Actors.ActorImage.CopyTo(stream);
                    }

                    actor.ActorImage = newName;
                }
                else
                {
                    actor.ActorImage = actorDetails.ActorImage;
                }

                _actorsRepository.UpdateActor(actor);
                _notyfService.Success("Changes Saved !");

                return RedirectToAction("Index");
            }
            catch
            {
                _notyfService.Error("Cannot Save Changes ! Something Wrong Happened !");
                return View();
            }

        }


        #endregion

        #region Remove

        [Route("/Admin/Actors/Remove/{actorId}")]
        public IActionResult RemoveActor(int actorId)
        {
            var actorDetails = _actorsRepository.GetActor(actorId);
            return View(actorDetails);
        }

        [Route("/Admin/Actors/Remove/{actorId}")]
        [HttpPost, ActionName("RemoveActor")]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmRemoveActor(int actorId)
        {
            try
            {
                var actorDetails = _actorsRepository.GetActorAsNoTracking(actorId);

                if (actorDetails.ActorId != actorId)
                    return NotFound();

                //Getting image path in order to removing it 
                var imagePath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot",
                    "img",
                    "Actors",
                    actorDetails.ActorImage);

                //Removing image
                if (System.IO.File.Exists(imagePath) && actorDetails.ActorImage != "Default.jpg")
                {
                    System.IO.File.Delete(imagePath);
                }

                _actorsRepository.DeleteActor(actorDetails);

                _notyfService.Success($"{actorDetails.ActorName} Has Been Removed Successfully !");
                return RedirectToAction("Index");
            }
            catch
            {
                _notyfService.Error("Something Wrong Happened During Removing Actor !");
                return View();
            }

        }

        #endregion
    }
}
