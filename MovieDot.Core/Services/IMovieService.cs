using MovieDot.Core.DTOs;
using MovieDot.Core.DTOs.DtoMovie;
using MovieDot.Core.Models;

namespace MovieDot.Core.Services
{
    public interface IMovieService : IService<Movie>
    {
        Task<CustomResponseDto<List<MovieWithCategoryDto>>> GetMovieWithCategory(int categoryId);
        Task<CustomResponseDto<List<MovieWithAllDto>>> GetMovieById(int movieId);
        Task<CustomResponseDto<List<MovieSearchDto>>> MovieSearch(string movieName);
    }
}
