using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace NightOwl.Core.DTOs
{
    public class ItemsViewModel
    {
        public int ItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? ReleaseYear { get; set; }
        public string? ManufacturerCountry { get; set; }
        public string? Language { get; set; }
        public string? ImdbScore { get; set; }
        public string? RottenTomatoScore { get; set; }
        public string? MetaCriticScore { get; set; }
        public string? AvailableQualities { get; set; }
        public string? RunningTime { get; set; }
        public IFormFile? Banner { get; set; }
        public string? Actors { get; set; }
        public string? Director { get; set; }
        public string? AgeRating { get; set; }
        public DateTime? AddedTime { get; set; }
        public int? Episodes { get; set; }
        public int? Seasons { get; set; }
        public string? EndRunningYear { get; set; }
        public string? TrailerLink { get; set; }
    }

    public class DownloadViewModel
    {
        public int DownloadId { get; set; }
        public string ItemSize { get; set; }
        public DateTime UploadDate { get; set; }
        public string QualityDetails { get; set; }
        public string? SeasonDetails { get; set; }
        public string? EpisodeDetails { get; set; }
        public IFormFile? DownloadLink { get; set; }
        public int ItemId { get; set; }
    }
}
