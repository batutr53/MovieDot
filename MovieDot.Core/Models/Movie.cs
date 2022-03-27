using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Core.Models
{
    public class Movie:BaseEntity
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Descr { get; set; }
        public string Image { get; set; }
        public int? Time { get; set; }
        public float? Voting { get; set; } = 0;
        public int? Year { get; set; }
        public float? Imdb { get; set; } = 0;
        public int? Views { get; set; }
        public bool IsActive { get; set; } = false;
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Part> Parts { get; set; }
        public List<Comment> Comments { get; set; }
        public List<MovieCategory> MovieCategories { get; set; }
        public List<MovieGenre> MovieGenres { get; set; }
        public List<MovieActor> MovieActors { get; set; }
      
       
    }
}
