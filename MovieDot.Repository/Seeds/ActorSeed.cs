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
    public class ActorSeed : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.HasData(
            new Actor
            {
                Id = 1,
                Name = "Lee Min Ho",
                Image ="https://i.pinimg.com/originals/bc/11/eb/bc11eb657ae97991c053ec8dde6fc421.jpg"
            },
            new Actor 
            {
                Id=2,
                Name = "Jennifer Lawrence",
                Image = "https://i3.posta.com.tr/i/posta/75//750x0/620762d145d2a0c0140efdb1"
            });
        }
    }
}
