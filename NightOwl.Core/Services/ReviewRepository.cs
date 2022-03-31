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
    public class ReviewRepository:IReviewRepository
    {
        NightOwlContext _context;

        public ReviewRepository(NightOwlContext context)
        {
            _context = context; 
        }

        public List<Reviews> GetReviewsByItem(int itemId)
        {
           return _context.Reviews.Where(r => r.ItemId == itemId).ToList();
        }

        public bool SubmitReview(Reviews newReview)
        {
            _context.Reviews.Add(newReview);
            _context.SaveChanges();
            return true;
        }
    }
}
