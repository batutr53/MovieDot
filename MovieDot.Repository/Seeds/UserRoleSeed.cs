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
    public class UserRoleSeed : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasData(
                new UserRole 
                {
                    Id = 1,
                    Name = "Admin"
                },
                new UserRole
                {
                    Id = 2,
                    Name = "Moderatör"
                },
                new UserRole
                {
                    Id = 3,
                    Name = "VİP"
                },
                new UserRole
                {
                    Id = 4,
                    Name = "Üye"
                }

                );
        }
    }
}
