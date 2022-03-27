using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public List<Genres> GetAllGenres()
        {
            return _context.Genres.ToList();
        }

        public string GetGenreNameByGenreId(int genreId)
        {
            return _context.Genres.Single(g => g.GenreId == genreId).GenreName;
        }
    }
}
