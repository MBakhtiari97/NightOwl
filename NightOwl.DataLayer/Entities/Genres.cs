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
        public int GenreId { get; set; }
        [Required]
        [MaxLength(250)]
        public string GenreName { get; set; }
        public int ItemId { get; set; }

        //nav
        public List<SelectedGenres> SelectedGenres { get; set; }
    }
}
