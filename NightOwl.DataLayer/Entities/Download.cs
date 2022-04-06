using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightOwl.DataLayer.Entities
{
    public class Download
    {
        [Key]
        public int DownloadId { get; set; }
        [Required]
        [MaxLength(50)]
        public string ItemSize { get; set; }
        [Required]
        public DateTime UploadDate { get; set; }
        [Required]
        [MaxLength(250)]
        public string QualityDetails { get; set; }
        [MaxLength(10)]
        public string? SeasonDetails { get; set; }
        [MaxLength(10)]
        public string? EpisodeDetails { get; set; }
        [Required]
        [MaxLength(350)]
        public string DownloadLink { get; set; }
        [Required]
        public int ItemId { get; set; }
        //nav
        [ForeignKey("ItemId")]
        public Items Items { get; set; }
    }
}
