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
        [Display(Name = "Item ID")]
        public int ItemId { get; set; }
        [Required]
        [MaxLength(250)]
        [Display(Name = "Item Title")]
        public string Title { get; set; }
        [Required]
        [MaxLength(2500)]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [MaxLength(4)]
        [Display(Name = "Release Year")]
        public string? ReleaseYear { get; set; }
        [MaxLength(250)]
        [Display(Name = "Country")]
        public string? ManufacturerCountry { get; set; }
        [MaxLength(250)]
        [Display(Name = "Language")]
        public string? Language { get; set; }
        [MaxLength(10)]
        [Display(Name = "IMDB Score")]
        public string? ImdbScore { get; set; }
        [MaxLength(10)]
        [Display(Name = "Rotten Tomato Score")]
        public string? RottenTomatoScore { get; set; }
        [MaxLength(10)]
        [Display(Name = "Meta Score")]
        public string? MetaCriticScore { get; set; }
        [MaxLength(250)]
        [Display(Name = "Qualities")]
        public string? AvailableQualities { get; set; }
        [MaxLength(10)]
        [Display(Name = "Time")]
        public string? RunningTime { get; set; }
        [MaxLength(250)]
        [Display(Name = "Image")]
        public string? Banner { get; set; }
        [MaxLength(800)]
        [Display(Name = "Actors")]
        public string? Actors { get; set; }
        [MaxLength(250)]
        [Display(Name = "Director")]
        public string? Director { get; set; } 
        [MaxLength(250)]
        [Display(Name = "Age")]
        public string? AgeRating { get; set; }
        [Display(Name = "Added In")]
        public DateTime? AddedTime { get; set; }
        [Display(Name = "Episodes")]
        public int? Episodes { get; set; }
        [Display(Name = "Seasons")]
        public int? Seasons { get; set; }
        [Display(Name = "End Date")]
        public string? EndRunningYear { get; set; }
        [Display(Name = "Trailer Link")]
        public string? TrailerLink { get; set; }

        //nav
        public List<SelectedGenres> SelectedGenres { get; set; }
        public List<SelectedCategory> SelectedCategory { get; set; }
        public List<Galleries> Galleries { get; set; }
        public List<Actors> Actor { get; set; }
        public List<SelectedMovies> SelectedMovies { get; set; }
        public List<Download> Downloads { get; set; }
        public List<Reviews> Reviews { get; set; }
    }
}
