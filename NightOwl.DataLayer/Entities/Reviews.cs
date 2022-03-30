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
        public int ReviewId { get; set; }
        [MaxLength(250)]
        [Required]
        public string ReviewersName { get; set; }
        [Required]
        [MaxLength(250)]
        public string ReviewTitle { get; set; }
        [Required]
        [MaxLength(1200)]
        public string ReviewDescription { get; set; }
        [Required]
        public float ReviewRating { get; set; }
        public DateTime ReviewDate { get; set; }
        [MaxLength(50)]
        public string? ReviewerIpAddress { get; set; }
        [Required]
        public int ItemId { get; set; }
        //nav
        [ForeignKey("ItemId")]
        public Items Items { get; set; }
    }
}
