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
        [Display(Name = "Admin ID")]
        public int AdminId { get; set; }
        [Required]
        [MaxLength(250)]
        [Display(Name = "Admin Name")]
        public string AdminName { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Registered IP Address")]
        public string AdminIpAddress { get; set; }
        [Required]
        [MaxLength(250)]
        [Display(Name = "Email Address")]
        public string AdminEmailAddress { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Phone Number")]
        public string AdminPhoneNumber { get; set; }
        [Required]
        [MaxLength(250)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Display(Name = "Active Status")]
        public bool IsActive { get; set; }
        [Display(Name = "Moderator Status")]
        public bool IsModerator { get; set; }
        [Display(Name = "Forgot Password Status")]
        public bool? ForgotPassword { get; set; }
    }
}
