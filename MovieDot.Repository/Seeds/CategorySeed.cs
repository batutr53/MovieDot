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
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
            new Category
            {
                Id=1,
                Name="Marvel"
            },
            new Category
            {
                Id = 2,
                Name= "Dc"
            },
            new Category 
            { 
                Id=3,
                Name= "Netflix"
            },
            new Category
            {
                Id=4,
                Name= "Amazon"
            });
        }
    }
}
