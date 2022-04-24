using MovieDot.Core.DTOs.DtoGenre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Core.DTOs.DtoMovie
{
    public class MovieWithGenreDto:MovieDto
    {
        public List<GenreDto> Genre { get; set; }
    }
}
