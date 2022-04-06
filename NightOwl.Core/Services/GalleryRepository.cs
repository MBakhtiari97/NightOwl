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
    public class GalleryRepository :IGalleryRepository
    {
        NightOwlContext _context;

        public GalleryRepository(NightOwlContext context)
        {
            _context = context;
        }

        public IEnumerable<Galleries> GetItemGalleryByItemId(int itemId)
        {
            return _context.Galleries.Where(g => g.ItemId == itemId).ToList();
        }
    }
}
