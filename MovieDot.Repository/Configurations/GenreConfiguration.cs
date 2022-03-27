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
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasMany(b => b.MovieGenres).WithOne(b => b.Genre).HasForeignKey(b => b.GenreId);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);
        }
    }
}
