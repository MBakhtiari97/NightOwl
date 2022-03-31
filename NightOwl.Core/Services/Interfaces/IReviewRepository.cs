using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NightOwl.DataLayer.Entities;

namespace NightOwl.Core.Services.Interfaces
{
    public interface IReviewRepository
    {
        List<Reviews> GetReviewsByItem(int itemId);
        bool SubmitReview(Reviews newReview);
    }
}
