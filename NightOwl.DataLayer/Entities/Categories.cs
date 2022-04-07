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
        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }
        [MaxLength(250)]
        [Required]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        //nav
        public List<SelectedCategory> SelectedCategory { get; set; }
    }
}
