using MovieDot.Core.Models;
using MovieDot.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Repository.Repositories
{
    public class GenreRepository : GenericRepository<Genre>, IGenreRepository
    {
      
        public GenreRepository(AppDbContext context) : base(context)
        {
        }
    }
}
