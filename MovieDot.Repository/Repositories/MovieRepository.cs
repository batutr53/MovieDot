using Microsoft.EntityFrameworkCore;
using MovieDot.Core.Models;
using MovieDot.Core.Repositories;

namespace MovieDot.Repository.Repositories
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(AppDbContext context) : base(context)
        {
        }

    

        public async Task<List<Movie>> GetMovieWithCategory(int categoryId)
        {
            return await _context.Movies.Where(c => c.MovieCategories.Where(ca => ca.CategoryId == categoryId).Any()).Include(x => x.MovieCategories).ThenInclude(a => a.Category).ToListAsync();
        }
    }
}
