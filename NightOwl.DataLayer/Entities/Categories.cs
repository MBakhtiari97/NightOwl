using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightOwl.DataLayer.Entities
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        [MaxLength(250)]
        [Required]
        public string CategoryName { get; set; }

        //nav
        public List<SelectedCategory> SelectedCategory { get; set; }
    }
}
