using Microsoft.AspNetCore.Mvc;
using NightOwl.Core.Services.Interfaces;

namespace NightOwl.Web.Controller
{
    public class ActorsController : Microsoft.AspNetCore.Mvc.Controller
    {
        private IActorsRepository _actorsRepository;

        public ActorsController(IActorsRepository actorsRepository)
        {
            _actorsRepository = actorsRepository;
        }

        [Route("/Actors-{gender}")]
        public IActionResult ShowActors(string gender)
        {
            return View("_ActorsSinglePage",_actorsRepository.GetActorsByGender(gender));
        }
    }
}
