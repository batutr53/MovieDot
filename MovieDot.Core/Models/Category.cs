using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Core.Models
{
    public class Category: Entity
    {
        public string Name { get; set; }
        public List<MovieCategory> MovieCategories { get; set; } = new();
    }
}
