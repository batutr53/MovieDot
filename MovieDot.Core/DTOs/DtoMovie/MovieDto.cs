using MovieDot.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Core.DTOs.DtoMovie
{
    public class MovieDto:BaseDto
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        public double Imdb { get; set; }
        public double Voting { get; set; }
        public int Views { get; set; }
        public int Year { get; set; }
        public string Descr { get; set; }
        public bool IsPopular { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
