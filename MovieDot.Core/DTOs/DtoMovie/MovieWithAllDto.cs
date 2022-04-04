using MovieDot.Core.DTOs.DtoActor;
using MovieDot.Core.DTOs.DtoCategory;
using MovieDot.Core.DTOs.DtoComment;
using MovieDot.Core.DTOs.DtoGenre;
using MovieDot.Core.DTOs.DtoLanguage;
using MovieDot.Core.DTOs.DtoPart;
using MovieDot.Core.DTOs.DtoUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Core.DTOs.DtoMovie
{
    public class MovieWithAllDto:MovieDto
    {
        public List<CategoryDto> Categories { get; set; }
        public List<GenreDto> Genres { get; set; }
        public List<ActorDto> Actors { get; set; }
        public List<PartDto> Parts { get; set; }
        public List<CommentDto> Comments { get; set; }
    }
}
