using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightOwl.DataLayer.Entities
{
    public class Actors
    {
        [Key]
        public int ActorId { get; set; }
        [Required]
        [MaxLength(250)]
        [Display(Name = "Actor Name")]
        public string ActorName { get; set; }
        [MaxLength(250)]
        [Display(Name = "Gender")]
        public string ActorGender { get; set; }
        [MaxLength(250)]
        [Display(Name = "Photo")]
        public string ActorImage { get; set; }

        //nav
        public List<SelectedMovies> SelectedMovies { get; set; }
    }
}
