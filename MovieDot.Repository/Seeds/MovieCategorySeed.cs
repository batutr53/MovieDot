using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieDot.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Repository.Seeds
{
    public class MovieCategorySeed : IEntityTypeConfiguration<MovieCategory>
    {
        public void Configure(EntityTypeBuilder<MovieCategory> builder)
        {
            builder.HasData(
                new MovieCategory
                {
                MovieId =1,
                CategoryId =1
                },
                new MovieCategory
                {
                MovieId = 1,
                CategoryId = 2
                }
                );
        }
    }
}
