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
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
             new User
            {
                Id = 1,
                Email = "batuhanturk34@gmail.com",
                UserName = "admin",
                Image = "adminprofileimage",
                IsActive = true,
                Password = "admin",
                UserRoleId = 1

             },
             new User
             {
                 Id = 2,
                 Email = "info@batulab.com",
                 UserName = "info",
                 Image = "infoprofileimage",
                 IsActive = true,
                 Password = "info",
                 UserRoleId = 2

             });
            
        }
    }
}
