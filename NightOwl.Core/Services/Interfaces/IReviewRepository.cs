using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NightOwl.DataLayer.Entities;

namespace NightOwl.Core.Services.Interfaces
{
    public interface IReviewRepository
    {
        List<Reviews> GetReviewsByItem(int itemId);
        bool SubmitReview(Reviews newReview);
        int GetTotalReviews();
        bool RemoveReview(int reviewId);
        bool ConfirmReview(int reviewId);
        IEnumerable<Reviews> GetUnPublishedReviews();
    }
}
