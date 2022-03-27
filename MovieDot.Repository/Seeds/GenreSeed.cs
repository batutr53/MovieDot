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
    public class GenreSeed : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(
                new Genre 
                {
                    Id = 1,
                    Name = "Aksiyon"
                    
                },
                new Genre
                { 
                    Id=2,
                    Name = "Bilim Kurgu"
                },
                new Genre
                { 
                    Id=3,
                    Name = "Aile"
                },
                new Genre
                { 
                    Id=4,
                    Name ="Romantik"
                }
                );
        }
    }
}
