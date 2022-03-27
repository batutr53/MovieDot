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
    public class CommentSeed : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(
                new Comment 
                {
                   Id = 1,
                   MovieId = 1,
                   UserId = 1,
                   CText = "Çok güzel bir film.",
                   Liked = 1234,

                },
                new Comment
                { 
                    Id=2,
                    MovieId = 1,
                    UserId=2,
                    CommentingId = 1,
                    CText = "Çok güzel bir film. Alt Yorum.",
                    Liked=5,
                }
                );
        }
    }
}
