using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace NightOwl.Core.DTOs
{
    public class GalleriesViewModel
    {
        public int GalleryId { get; set; }
        public IFormFile? ImageName { get; set; }
        public string ImageAltName { get; set; }
        public int ItemId { get; set; }
    }
}
