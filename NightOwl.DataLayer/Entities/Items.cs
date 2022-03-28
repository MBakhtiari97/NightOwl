using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightOwl.DataLayer.Entities
{
    public class Items
    {
        [Key]
        public int ItemId { get; set; }
        [Required]
        [MaxLength(250)]
        public string Title { get; set; }
        [Required]
        [MaxLength(2500)]
        public string Description { get; set; }
        [MaxLength(4)]
        public string? ReleaseYear { get; set; }
        [MaxLength(250)]
        public string? ManufacturerCountry { get; set; }
        [MaxLength(250)]
        public string? Language { get; set; }
        [MaxLength(10)]
        public string? ImdbScore { get; set; }
        [MaxLength(10)]
        public string? RottenTomatoScore { get; set; }
        [MaxLength(10)]
        public string? MetaCriticScore { get; set; }
        [MaxLength(250)]
        public string? AvailableQualities { get; set; }
        [MaxLength(10)]
        public string? RunningTime { get; set; }
        [MaxLength(250)]
        public string? Banner { get; set; }
        [MaxLength(800)]
        public string? Actors { get; set; }
        [MaxLength(250)]
        public string? Director { get; set; } 
        [MaxLength(250)]
        public string? AgeRating { get; set; }
        public DateTime? AddedTime { get; set; }
        public int? Episodes { get; set; }
        public int? Seasons { get; set; }
        public string? EndRunningYear { get; set; }
        public string? TrailerLink { get; set; }

        //nav
        public List<SelectedGenres> SelectedGenres { get; set; }
        public List<SelectedCategory> SelectedCategory { get; set; }
        public List<Galleries> Galleries { get; set; }
        public List<Actors> Actor { get; set; }
        public List<SelectedMovies> SelectedMovies { get; set; }
        public List<Download> Downloads { get; set; }
    }
}
