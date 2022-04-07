using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightOwl.DataLayer.Entities
{
    public class Genres
    {
        [Key]
        [Display(Name = "Genre ID")]
        public int GenreId { get; set; }
        [Required]
        [MaxLength(250)]
        [Display(Name = "Genre Name")]
        public string GenreName { get; set; }

        //nav
        public List<SelectedGenres> SelectedGenres { get; set; }
    }
}
