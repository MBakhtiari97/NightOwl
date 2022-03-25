using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightOwl.DataLayer.Entities
{
    public class Galleries
    {
        [Key]
        public int GalleryId { get; set; }
        [Required]
        [MaxLength(250)]
        public string ImageName { get; set; }
        [Required]
        [MaxLength(250)]
        public string ImageAltName { get; set; }
        [Required]
        public int ItemId { get; set; }
        //nav
        [ForeignKey("ItemId")]
        public Items Items { get; set; }
    }
}
