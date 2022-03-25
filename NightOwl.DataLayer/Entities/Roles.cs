using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightOwl.DataLayer.Entities
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }
        [MaxLength(50)]
        [Required]
        public string RoleName { get; set; }

        //nav
        [ForeignKey("UserId")]
        public Users Users { get; set; }
    }
}
