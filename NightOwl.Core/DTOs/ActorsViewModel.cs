using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace NightOwl.Core.DTOs
{
    public class ActorsViewModel
    {
        public int ActorId { get; set; }
        public string ActorName { get; set; }
        public string ActorGender { get; set; }
        public IFormFile? ActorImage { get; set; }
    }
}
