﻿using System;
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

        public List<Items> GetLatestMovies()
        {
            return _context.Items
                .OrderByDescending(i => i.AddedTime)
                .Include(i=>i.SelectedGenres)
                .ThenInclude(i=>i.Genres)
                .Take(6)
                .ToList();
        }

        public Items GetMovieDetailsByItemId(int itemId)
        {
            return _context.Items
                .Include(i=>i.SelectedGenres)
                .ThenInclude(i=>i.Genres)
                .SingleOrDefault(i=>i.ItemId==itemId);
        }

        public List<Items> GetMoviesByCategoryId(int categoryId)
        {
            return _context.SelectedCategories
                .Include(i => i.Items.SelectedGenres)
                .ThenInclude(i => i.Genres)
                .Where(i => i.CategoryId == categoryId)
                .Select(i => i.Items)
                .OrderByDescending(i=>i.AddedTime)
                .ToList();
        }

        public List<Items> GetSimilarMovies(int genreId)
        {
            return _context.SelectedGenres
                .Where(g => g.GenreId == genreId)
                .Select(g => g.Items)
                .OrderByDescending(g=>g.TrailerLink)
                .Take(6)
                .ToList();
        }
    }
}