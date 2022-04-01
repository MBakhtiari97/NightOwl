using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightOwl.Core.DTOs
{
    public class AdminLoginViewModel
    {
        [Required]
        [MaxLength(250)]
        [EmailAddress(ErrorMessage = "Please enter a valid email address !")]
        public string EmailAddress { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(250)]
        public string Password { get; set; }
        [Required]
        public bool RememberMe { get; set; }
    }

    public class RegisterAdminViewModel
    {
        [Required]
        [MaxLength(250)]
        [EmailAddress(ErrorMessage = "Please enter a valid email address !")]
        public string EmailAddress { get; set; }
        [Required]
        [MaxLength(250)]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(250)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(250)]
        [Compare("Password",ErrorMessage = "Password and confirm password doesn't match !")]
        public string ConfirmPassword { get; set; }
        [Required]
        [MaxLength(250)]
        public string PhoneNumber { get; set; }
    }
}
