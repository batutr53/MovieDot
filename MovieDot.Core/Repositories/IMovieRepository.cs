using MovieDot.Core.Models;

namespace MovieDot.Core.Repositories
{
    public interface IMovieRepository : IGenericRepository<Movie>
    {
        Task<List<Movie>> GetMovieWithCategory(int categoryId);
        Task<List<Movie>> GetMovieById(int movieId);
 
    }
}
