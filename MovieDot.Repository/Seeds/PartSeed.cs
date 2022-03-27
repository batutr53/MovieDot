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
    public class PartSeed : IEntityTypeConfiguration<Part>
    {
        public void Configure(EntityTypeBuilder<Part> builder)
        {
            builder.HasData(
            new Part
            {
                Id = 1,
                Name = "Part1 ",
                LanguageId = 1,
                MovieId = 1,
                Url = "https://youtu.be/8GKyQ1S5594"
            },
            new Part
             {
               Id = 2,
               Name = "Part2",
               LanguageId = 2,
               MovieId = 1,
               Url = "https://youtu.be/8GKyQ1S5594"
             });
        }
    }
}
