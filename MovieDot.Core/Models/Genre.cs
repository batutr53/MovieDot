using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Core.Models
{
    public class Genre: Entity
    {
        public string Name { get; set; }
        public List<MovieGenre> MovieGenres { get; set; } = new();

    }
}
