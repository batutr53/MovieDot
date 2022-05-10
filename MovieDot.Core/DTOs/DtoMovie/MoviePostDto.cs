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
        public int? Year { get; set; }
        public float? Imdb { get; set; }
        public int? Views { get; set; }
        public string? Fragman { get; set; }
        public bool IsActive { get; set; }
        public bool? IsPopular { get; set; }
        public int UserId { get; set; }

        public ICollection<PartPostDto> Parts { get; set; }
        public ICollection<MovieCategoryDto> MovieCategories { get; set; }
        public ICollection<MovieActorDto> MovieActors { get; set; } 
        public ICollection<MovieGenreDto> MovieGenres { get; set; } 
    
    }
}
