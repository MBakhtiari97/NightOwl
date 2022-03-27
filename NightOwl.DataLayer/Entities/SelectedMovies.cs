using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightOwl.DataLayer.Entities
{
    public class SelectedMovies
    {
        [Key]
        public int SelectedMovieId { get; set; }
        [Required]
        public int ItemId { get; set; }
        [Required]
        public int ActorId { get; set; }

        //nav
        [ForeignKey("ActorId")]
        public Actors Actors { get; set; }
        [ForeignKey("ItemId")]
        public Items Items { get; set; }

    }
}
