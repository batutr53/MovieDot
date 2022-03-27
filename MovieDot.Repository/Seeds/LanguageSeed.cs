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
    public class LanguageSeed : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasData(
                new Language
                {
                    Id = 1,
                    Name = "Türkçe Dublaj",
                    Image = "image.jpg"
                },
                new Language
                { 
                    Id=2,
                    Name="Türkçe Altyazı",
                    Image = "image.jpg"
                },
                new Language 
                {
                    Id=3, 
                    Name="Orjinal",
                    Image = "image.jpg"
                });
        }
    }
}
