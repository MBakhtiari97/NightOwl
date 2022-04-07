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
        [Display(Name = "Download ID")]
        public int DownloadId { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Download Size")]
        public string ItemSize { get; set; }
        [Required]
        [Display(Name = "Upload Date")]
        public DateTime UploadDate { get; set; }
        [Required]
        [MaxLength(250)]
        [Display(Name = "Quality")]
        public string QualityDetails { get; set; }
        [MaxLength(10)]
        [Display(Name = "Seasons Detail's")]
        public string? SeasonDetails { get; set; }
        [Display(Name = "Episode Detail's")]
        [MaxLength(10)]
        public string? EpisodeDetails { get; set; }
        [Required]
        [MaxLength(350)]
        [Display(Name = "Link")]
        public string DownloadLink { get; set; }
        [Required]
        [Display(Name = "Item")]
        public int ItemId { get; set; }
        //nav
        [ForeignKey("ItemId")]
        public Items Items { get; set; }
    }
}
