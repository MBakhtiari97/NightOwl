using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NightOwl.Core.Services.Interfaces;
using NightOwl.DataLayer.Context;
using NightOwl.DataLayer.Entities;

namespace NightOwl.Core.Services
{
    public class MovieRepository : IMovieRepository
    {
        private NightOwlContext _context;

        public MovieRepository(NightOwlContext context)
        {
            _context = context;
        }

        public void AddNewItem(Items item)
        {
            _context.Items
                .Add(item);

            _context.SaveChanges();
        }

        public List<Items> GetComingSoon()
        {
            return _context.Items
                .Where(i => i.ReleaseYear == "-")
                .Include(i => i.SelectedGenres)
                .ThenInclude(i => i.Genres)
                .Take(6)
                .ToList();
        }

        public Download GetDownloadAsNoTracking(int downloadId)
        {
            return _context.Download
                .AsNoTracking()
                .SingleOrDefault(d => d.DownloadId == downloadId);
        }

        public Download GetDownloadLinkDetails(int downloadId)
        {
            return _context.Download
                .Include(d => d.Items)
                .AsNoTracking()
                .SingleOrDefault(d => d.DownloadId == downloadId);
        }

        public IEnumerable<Download> GetDownloadLinksByItemId(int itemId)
        {
            return _context.Download
                .Where(d => d.ItemId == itemId)
                .ToList();
        }

        public Items GetItemAsNoTracking(int itemId)
        {
            return _context.Items
                .AsNoTracking()
                .SingleOrDefault(i => i.ItemId == itemId);
        }

        public Items GetItemByItemId(int itemId)
        {
            return _context.Items
                .Find(itemId);
        }

        public List<Items> GetLatest()
        {
            return _context.Items
                .OrderByDescending(i => i.AddedTime)
                .Include(i => i.SelectedGenres)
                .ThenInclude(i => i.Genres)
                .Take(8)
                .ToList();
        }

        public List<Items> GetLatestMovies()
        {
            return _context.Items
                .OrderByDescending(i => i.AddedTime)
                .Include(i => i.SelectedGenres)
                .ThenInclude(i => i.Genres)
                .Take(6)
                .ToList();
        }

        public Items GetMovieDetailsByItemId(int itemId)
        {
            return _context.Items
                .Include(i => i.SelectedGenres)
                .ThenInclude(i => i.Genres)
                .Include(i=>i.Downloads)
                .SingleOrDefault(i => i.ItemId == itemId);
        }

        public List<Items> GetMoviesByActorName(string actorName)
        {
            return _context.Items
                .Where(i => i.Actors.Contains(actorName))
                .Include(i => i.SelectedGenres)
                .ThenInclude(i => i.Genres)
                .ToList();
        }

        public List<Items> GetMoviesByAge(string ageRating)
        {
            return _context.Items
                .Where(i => i.AgeRating == ageRating)
                .Include(i => i.SelectedGenres)
                .ThenInclude(i => i.Genres)
                .ToList();
        }

        public List<Items> GetMoviesByCategoryId(int categoryId)
        {
            return _context.SelectedCategories
                .Include(i => i.Items.SelectedGenres)
                .ThenInclude(i => i.Genres)
                .Where(i => i.CategoryId == categoryId)
                .Select(i => i.Items)
                .OrderByDescending(i => i.AddedTime)
                .ToList();
        }

        public List<Items> GetMoviesByGenreId(int genreId)
        {
            return _context.SelectedGenres
                 .Where(g => g.GenreId == genreId)
                 .Select(g => g.Items)
                 .OrderByDescending(g => g.AddedTime)
                 .ToList();
        }

        public List<Items> GetMoviesByQuality(string quality)
        {
            return _context.Items
                .Where(i => i.AvailableQualities.Contains(quality))
                .Include(i => i.SelectedGenres)
                .ThenInclude(i => i.Genres)
                .ToList();
        }

        public List<Items> GetMoviesByReleaseYear(string year)
        {
            return _context.Items
                .Where(i => i.ReleaseYear == year)
                .Include(i => i.SelectedGenres)
                .ThenInclude(i => i.Genres)
                .ToList();
        }

        public List<Items> GetMoviesBySearchPhrase(string searchPhrase)
        {
            return _context.Items.Where(i =>
                    i.Title.Contains(searchPhrase) ||
                    i.Actors.Contains(searchPhrase) ||
                    i.Director.Contains(searchPhrase))
                .Include(i => i.SelectedGenres)
                .ThenInclude(i => i.Genres)
                .Distinct()
                .ToList();
        }

        public List<Items> GetNewAnimations()
        {
            return _context.SelectedGenres
                .Where(g => g.GenreId == 7)
                .Select(g => g.Items)
                .OrderByDescending(g=>g.AddedTime)
                .Take(12)
                .ToList();
        }

        public List<Items> GetNewMovies()
        {
            return _context.SelectedCategories
                .Where(c => c.CategoryId == 1)
                .Include(c => c.Items)
                .ThenInclude(c => c.SelectedGenres)
                .ThenInclude(c => c.Genres)
                .Select(c => c.Items)
                .OrderByDescending(c => c.AddedTime)
                .Take(12)
                .ToList();
        }

        public List<Items> GetNewSeries()
        {
            return _context.SelectedCategories
                .Where(c => c.CategoryId == 2)
                .Include(c => c.Items)
                .ThenInclude(c => c.SelectedGenres)
                .ThenInclude(c => c.Genres)
                .Select(c => c.Items)
                .OrderByDescending(c => c.AddedTime)
                .Take(12)
                .ToList();
        }

        public List<Items> GetSimilarMovies(int genreId)
        {
            return _context.SelectedGenres
                .Where(g => g.GenreId == genreId)
                .Select(g => g.Items)
                .OrderByDescending(g => g.TrailerLink)
                .Take(6)
                .ToList();
        }

        public int GetTotalComingSoon()
        {
            return _context.Items
                .Count(i => i.ReleaseYear == "-");
        }

        public int GetTotalMovies()
        {
            return _context.SelectedCategories
                .Count(c => c.CategoryId == 1);
        }

        public int GetTotalSeries()
        {
            return _context.SelectedCategories
                .Count(c => c.CategoryId == 2);
        }

        public void Remove(Items item)
        {
            _context.Items
                .Remove(item);

            _context.SaveChanges();
        }

        public void RemoveDownloadLink(Download download)
        {
            _context.Download
                .Remove(download);

            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void UpdateDownloadDetails(Download download)
        {
            _context.Download
                .Update(download);

            _context.SaveChanges();
        }

        public void UpdateItem(Items item)
        {

            _context.Items
                .Update(item);

            _context.SaveChanges();
        }

        public void UploadNewDownload(Download download)
        {
            _context.Download
                .Add(download);

            _context.SaveChanges();
        }
    }
}
