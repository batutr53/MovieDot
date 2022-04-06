using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Core.Models
{
    public class Actor:Entity
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public List<MovieActor> MovieActors { get; set; } = new();
    }
}
