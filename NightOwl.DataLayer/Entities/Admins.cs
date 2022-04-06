using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightOwl.DataLayer.Entities
{
    public class Admins
    {
        [Key]
        public int AdminId { get; set; }
        [Required]
        [MaxLength(250)]
        public string AdminName { get; set; }
        [Required]
        [MaxLength(50)]
        public string AdminIpAddress { get; set; }
        [Required]
        [MaxLength(250)]
        public string AdminEmailAddress { get; set; }
        [Required]
        [MaxLength(50)]
        public string AdminPhoneNumber { get; set; }
        [Required]
        [MaxLength(250)]
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsModerator { get; set; }
    }
}
