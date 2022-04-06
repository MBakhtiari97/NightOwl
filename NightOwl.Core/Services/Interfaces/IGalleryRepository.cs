using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NightOwl.DataLayer.Entities;

namespace NightOwl.Core.Services.Interfaces
{
    public interface IGalleryRepository
    {
        IEnumerable<Galleries> GetItemGalleryByItemId(int itemId);
        IEnumerable<Galleries> GetGalleriesByItemId(int itemId);
        Galleries GetGalleryByGalleryId(int galleryId);
        void AddNewGallery(Galleries gallery);
        Galleries GetGalleryAsNoTracking(int galleryId);
        void UpdateGallery(Galleries gallery);
        void RemoveGallery(Galleries gallery);
    }
}
