
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NightOwl.Core.Services.Interfaces;
using NightOwl.DataLayer.Context;
using NightOwl.DataLayer.Entities;

namespace NightOwl.Web.Areas.Admin.Controller
{
    [Area("Admin")]
    public class GenresController : Microsoft.AspNetCore.Mvc.Controller
    {
        #region Injection

        private INotyfService _notyfService;
        IGenresRepository _genresRepository;

        public GenresController(INotyfService notyfService, IGenresRepository genresRepository)
        {
            _notyfService = notyfService;
            _genresRepository = genresRepository;
        }


        #endregion

        #region Index

        // GET: GenresController
        [Route("/Admin/Genres")]
        public ActionResult Index()
        {
            return View(_genresRepository.GetAllGenres());
        }


        #endregion

        #region CreateNew

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

                _genresRepository.AddNewGenre(genre);

                _notyfService.Success($"{genre.GenreName} Genre Successfully Added To Genres !");

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                _notyfService.Error("Failed To Submit Genre !");
                return View();
            }
        }


        #endregion

        #region Update

        // GET: GenresController/Edit/5
        [Route("/Admin/Genres/Update/{genreId}")]
        public ActionResult Edit(int genreId)
        {
            return View(_genresRepository.GetGenreByGenreId(genreId));
        }

        // POST: GenresController/Edit/5
        [Route("/Admin/Genres/Update/{genreId}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int genreId, [Bind("GenreId", "GenreName")] Genres genre)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(genre);

                var currentGenre = _genresRepository.GetGenreAsNoTracking(genreId);

                _genresRepository.UpdateGenre(genre);

                _notyfService.Success("Changes Saved !");

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                _notyfService.Error("Failed To Save Changes !");
                return View();
            }
        }

        #endregion

        #region Remove

        // GET: GenresController/Delete/5
        [Route("/Admin/Genres/Remove/{genreId}")]
        public ActionResult Delete(int genreId)
        {
            return View(_genresRepository.GetGenreByGenreId(genreId));
        }

        // POST: GenresController/Delete/5
        [Route("/Admin/Genres/Remove/{genreId}")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int genreId)
        {
            try
            {
                var currentGenre = _genresRepository.GetGenreAsNoTracking(genreId);

                _genresRepository.RemoveGenre(currentGenre);

                _notyfService.Success($"{currentGenre.GenreName} Genre Has Been Deleted Successfully !");
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                _notyfService.Error("Failed To Delete Genre !");
                return View();
            }
        }

        #endregion
    }
}
