using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieDot.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Repository.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasMany(b => b.MovieCategories).WithOne(b => b.Movie).HasForeignKey(b => b.MovieId);
            builder.HasMany(b => b.MovieActors).WithOne(x=> x.Movie).HasForeignKey(b => b.MovieId);
            builder.HasMany(b => b.MovieGenres).WithOne(x=> x.Movie).HasForeignKey(b => b.MovieId);
            builder.HasMany(b => b.Parts).WithOne(x => x.Movie).HasForeignKey(b => b.MovieId);
            builder.Property(x=>x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.Descr).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Url).IsRequired().HasMaxLength(int.MaxValue);
            builder.Property(x => x.Image).IsRequired().HasMaxLength(100);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsPopular).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
        }
    }
}
