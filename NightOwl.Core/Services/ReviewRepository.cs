using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NightOwl.Core.Services.Interfaces;
using NightOwl.DataLayer.Context;
using NightOwl.DataLayer.Entities;

namespace NightOwl.Core.Services
{
    public class ReviewRepository:IReviewRepository
    {
        NightOwlContext _context;

        public ReviewRepository(NightOwlContext context)
        {
            _context = context; 
        }

        public bool ConfirmReview(int reviewId)
        {
            var review = _context.Reviews.Find(reviewId);
            if (review == null)
                return false;

            review.IsPublished = true;
            _context.SaveChanges();
            return true;
        }

        public List<Reviews> GetReviewsByItem(int itemId)
        {
           return _context.Reviews.Where(r => r.ItemId == itemId).ToList();
        }

        public int GetTotalReviews()
        {
            return _context.Reviews.Count();
        }

        public IEnumerable<Reviews> GetUnPublishedReviews()
        {
            return _context.Reviews.Where(r => !r.IsPublished).ToList();
        }

        public bool RemoveReview(int reviewId)
        {
            var review = _context.Reviews.Find(reviewId);
            if (review == null)
                return false;

            _context.Reviews.Remove(review);
            _context.SaveChanges();
            return true;
        }

        public bool SubmitReview(Reviews newReview)
        {
            _context.Reviews.Add(newReview);
            _context.SaveChanges();
            return true;
        }
    }
}
