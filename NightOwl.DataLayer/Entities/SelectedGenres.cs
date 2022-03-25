using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightOwl.DataLayer.Entities
{
    public class SelectedGenres
    {
        [Key]
        public int SelectedGenresId { get; set; }
        [Required]
        public int GenreId { get; set; }
        [Required]
        public int ItemId { get; set; }

        //nav
        [ForeignKey("GenreId")]
        public Genres Genres { get; set; }

        [ForeignKey("ItemId")]
        public Items Items { get; set; }
    }
}
