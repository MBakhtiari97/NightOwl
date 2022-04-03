
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NightOwl.DataLayer.Context;
using NightOwl.DataLayer.Entities;

namespace NightOwl.Web.Areas.Admin.Controller
{
    [Area("Admin")]
    public class GenresController : Microsoft.AspNetCore.Mvc.Controller
    {
        private NightOwlContext _context;
        private INotyfService _notyfService;

        public GenresController(NightOwlContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }


        // GET: GenresController
        [Route("/Admin/Genres")]
        public ActionResult Index()
        {
            var genres = _context.Genres.ToList();
            return View(genres);
        }

        // GET: GenresController/Create
        [Route("/Admin/Genres/Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: GenresController/Create
        [Route("/Admin/Genres/Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("GenreId", "GenreName")] Genres genre)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(genre);

                _context.Genres.Add(genre);
                _context.SaveChanges();

                _notyfService.Success($"{genre.GenreName} Genre Successfully Added To Genres !");

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                _notyfService.Error("Failed To Submit Genre !");
                return View();
            }
        }

        // GET: GenresController/Edit/5
        [Route("/Admin/Genres/Update/{genreId}")]
        public ActionResult Edit(int genreId)
        {
            var genre = _context.Genres.Find(genreId);

            if (genre == null)
                return NotFound();

            return View(genre);
        }

        // POST: GenresController/Edit/5
        [Route("/Admin/Genres/Update/{genreId}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int genreId,[Bind("GenreId", "GenreName")] Genres genre)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(genre);

                var currentGenre = _context.Genres.AsNoTracking().SingleOrDefault(g => g.GenreId == genreId);
                if (currentGenre == null)
                    return NotFound();

                _context.Genres.Update(genre);
                _context.SaveChanges();

                _notyfService.Success("Changes Saved !");

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                _notyfService.Error("Failed To Save Changes !");
                return View();
            }
        }

        // GET: GenresController/Delete/5
        [Route("/Admin/Genres/Remove/{genreId}")]
        public ActionResult Delete(int genreId)
        {
            var genreDetails = _context.Genres.Find(genreId);
            return View(genreDetails);
        }

        // POST: GenresController/Delete/5
        [Route("/Admin/Genres/Remove/{genreId}")]
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int genreId)
        {
            try
            {
                var currentGenre = _context.Genres.AsNoTracking().SingleOrDefault(g => g.GenreId == genreId);

                if (currentGenre == null)
                    return NotFound();

                _context.Genres.Remove(currentGenre);
                _context.SaveChanges();

                _notyfService.Success($"{currentGenre.GenreName} Genre Has Been Deleted Successfully !");
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                _notyfService.Error("Failed To Delete Genre !");
                return View();
            }
        }
    }
}
