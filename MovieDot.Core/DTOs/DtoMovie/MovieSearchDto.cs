using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Core.DTOs.DtoMovie
{
    public class MovieSearchDto
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        public float Imdb { get; set; }
        public int Views { get; set; }
    }
}
