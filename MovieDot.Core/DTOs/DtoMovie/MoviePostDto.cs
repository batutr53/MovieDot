using MovieDot.Core.DTOs.DtoActor;
using MovieDot.Core.DTOs.DtoCategory;
using MovieDot.Core.DTOs.DtoComment;
using MovieDot.Core.DTOs.DtoGenre;
using MovieDot.Core.DTOs.DtoPart;
using MovieDot.Core.DTOs.DtoVoting;
using MovieDot.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Core.DTOs.DtoMovie
{
    public class MoviePostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Descr { get; set; }
        public string Image { get; set; }
        public int? Time { get; set; }
        public float? Voting { get; set; } 
        public int? Year { get; set; }
        public float? Imdb { get; set; }
        public int? Views { get; set; }
        public string? Fragman { get; set; }
        public bool IsActive { get; set; }
        public bool? IsPopular { get; set; }
        public int UserId { get; set; }

        public List<PartPostDto> Parts { get; set; } = new();
        public List<MovieCategoryDto> MovieCategories { get; set; } = new();
        public List<MovieActorDto> MovieActors { get; set; } = new();
        public List<MovieGenreDto> MovieGenres { get; set; } = new();
    
    }
}
