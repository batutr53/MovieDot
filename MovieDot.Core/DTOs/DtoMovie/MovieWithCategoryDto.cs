using MovieDot.Core.DTOs.DtoCategory;
using MovieDot.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Core.DTOs.DtoMovie
{
    public class MovieWithCategoryDto:MovieDto
    {
     public List<CategoryDto> Category { get; set; }

    }
}
