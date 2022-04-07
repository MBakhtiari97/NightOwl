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
    public class GalleryRepository :IGalleryRepository
    {
        NightOwlContext _context;

        public GalleryRepository(NightOwlContext context)
        {
            _context = context;
        }

        public void AddNewGallery(Galleries gallery)
        {
            _context.Galleries
                .Add(gallery);

            _context.SaveChanges();
        }

        public IEnumerable<Galleries> GetGalleriesByItemId(int itemId)
        {
            return _context.Galleries
                .Where(g => g.ItemId == itemId)
                .ToList();
        }

        public Galleries GetGalleryAsNoTracking(int galleryId)
        {
            return _context.Galleries
                .AsNoTracking()
                .Single(g => g.GalleryId == galleryId);
        }

        public Galleries GetGalleryByGalleryId(int galleryId)
        {
            return _context.Galleries
                .Find(galleryId);
        }

        public IEnumerable<Galleries> GetItemGalleryByItemId(int itemId)
        {
            return _context.Galleries
                .Where(g => g.ItemId == itemId)
                .ToList();
        }

        public void RemoveGallery(Galleries gallery)
        {
            _context.Galleries
                .Remove(gallery);

            _context.SaveChanges();
        }

        public void UpdateGallery(Galleries gallery)
        {
            _context.Galleries
                .Update(gallery);

            _context.SaveChanges();
        }
    }
}
