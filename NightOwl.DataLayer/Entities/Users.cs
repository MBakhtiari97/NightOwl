using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightOwl.DataLayer.Entities
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [MaxLength(150)]
        public string Username { get; set; }
        [Required]
        [MaxLength(250)]
        public string EmailAddress { get; set; }
        [MaxLength(50)]
        public string? PhoneNumber { get; set; }
        [Required]
        [MaxLength(250)]
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; }
        [MaxLength(50)]
        public string IpAddress { get; set; }
        [Required]
        public int RoleId { get; set; }

    }
}
