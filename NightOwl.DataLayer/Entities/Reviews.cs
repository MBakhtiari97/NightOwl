using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightOwl.DataLayer.Entities
{
    public class Reviews
    {
        [Key]
        [Display(Name = "Review ID")]
        public int ReviewId { get; set; }
        [MaxLength(250)]
        [Required]
        [Display(Name = "Name")]
        public string ReviewersName { get; set; }
        [Required]
        [MaxLength(250)]
        [Display(Name = "Title")]
        public string ReviewTitle { get; set; }
        [Required]
        [MaxLength(1200)]
        [Display(Name = "Description")]
        public string ReviewDescription { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Rating")]
        public string ReviewRating { get; set; }
        [Display(Name = "Date")]
        public DateTime ReviewDate { get; set; }
        [MaxLength(50)]
        [Display(Name = "IP Address")]
        public string? ReviewerIpAddress { get; set; }
        [Required]
        [Display(Name = "Item")]
        public int ItemId { get; set; }
        [Display(Name = "Publish Status")]
        public bool IsPublished { get; set; }
        //nav
        [ForeignKey("ItemId")]
        public Items Items { get; set; }
    }
}
