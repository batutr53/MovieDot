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
    public class MovieSeed : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasData(
                new Movie {
                    Id = 1,
                    Descr = "Uzay Yolcuları, Morten Tyldum tarafından yönetilen ve senaryosu Jon Spaihts tarafından yazılan 2016 yılı ABD yapımı bilimkurgu-macera filmi. Başrollerinde Chris Pratt ve Jennifer Lawrence yer almaktadır.",
                    Image= "https://tr.web.img3.acsta.net/pictures/16/11/17/14/42/364666.jpg",
                    IsActive = true,
                    Imdb=6,
                    Time=155,
                    Title="Uzay Yolcuları",
                    Url= "https://tr.web.img4.acsta.net/c_310_420/pictures/16/11/17/14/42/364666.jpg",
                    Year=2017,
                    Views=1222,
                    UserId=1
                }
                );
        }
    }
}
