﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Core.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public List<MovieGenre> MovieGenres { get; set; }

    }
}