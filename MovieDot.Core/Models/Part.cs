using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Core.Models
{
    public class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

    }
}
