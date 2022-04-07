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

        public async Task<List<Movie>> GetAllMovie(int page, int pageSize)
        {
            return await _context.Movies
                 .Include(mc => mc.MovieCategories).ThenInclude(c => c.Category)
                 .Include(ma => ma.MovieActors).ThenInclude(a => a.Actor)
                 .Include(mg => mg.MovieGenres).ThenInclude(g => g.Genre)
                 .Include(c => c.Comments).ThenInclude(u => u.User)
                 .Include(p => p.Parts).ThenInclude(l => l.Language)
                 .AsNoTracking().Skip((page - 1)*pageSize).Take(pageSize)
                 .ToListAsync();
        }

        public async Task<List<Movie>> GetMovieById(int movieId)
        {
            return await _context.Movies.Where(x => x.Id == movieId)
                 .Include(mc => mc.MovieCategories).ThenInclude(c => c.Category)
                 .Include(ma => ma.MovieActors).ThenInclude(a => a.Actor)
                 .Include(mg => mg.MovieGenres).ThenInclude(g => g.Genre)
                 .Include(c => c.Comments).ThenInclude(u => u.User)
                 .Include(p => p.Parts).ThenInclude(l => l.Language)
                 .AsNoTracking()
                 .ToListAsync(); 
        }

        public async Task<List<Movie>> GetMovieWithCategory(int categoryId, int page, int pageSize)
        {
            return await _context.Movies.Where(c => c.MovieCategories.Where(ca => ca.CategoryId == categoryId).Any())
                .Include(x => x.MovieCategories)
                .ThenInclude(a => a.Category)
                .AsNoTracking().Skip((page - 1) * pageSize).Take(pageSize)
                .ToListAsync();
            
        }

        public async Task<List<Movie>> MovieSearch(string movieName)
        {
            return await _context.Movies.Where(m=>m.Title.Contains(movieName)||m.MovieCategories.Where(c=>c.Category.Name==movieName).Any()).Include(m=>m.MovieCategories).ThenInclude(c=>c.Category).AsNoTracking().ToListAsync();
        }
    }
}
