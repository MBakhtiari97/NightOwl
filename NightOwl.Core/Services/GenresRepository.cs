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
    public class GenresRepository : IGenresRepository
    {
        private NightOwlContext _context;

        public GenresRepository(NightOwlContext context)
        {
            _context = context;
        }

        public void AddNewGenre(Genres genre)
        {
            _context.Genres.Add(genre);
            _context.SaveChanges();
        }

        public List<Genres> GetAllGenres()
        {
            return _context.Genres.ToList();
        }

        public Genres GetGenreAsNoTracking(int genreId)
        {
            return _context.Genres.AsNoTracking().SingleOrDefault(g => g.GenreId == genreId);
        }

        public Genres GetGenreByGenreId(int genreId)
        {
            return _context.Genres.Find(genreId);
        }

        public string GetGenreNameByGenreId(int genreId)
        {
            return _context.Genres.Single(g => g.GenreId == genreId).GenreName;
        }

        public void RemoveGenre(Genres genre)
        {
            _context.Genres.Remove(genre);
            _context.SaveChanges();
        }

        public void UpdateGenre(Genres genre)
        {
            _context.Genres.Update(genre);
            _context.SaveChanges();
        }
    }
}
