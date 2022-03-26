using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NightOwl.DataLayer.Entities;

namespace NightOwl.Core.Services.Interfaces
{
    public interface IMovieRepository
    {
        List<Items> GetMoviesByCategoryId(int categoryId);
        List<Items> GetLatestMovies();
        Items GetMovieDetailsByItemId(int itemId);
        List<Items> GetSimilarMovies(int genreId);
        List<Items> GetLatest();
        List<Items> GetMoviesByAge(string ageRating);

    }
}
