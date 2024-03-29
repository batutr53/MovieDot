﻿using MovieDot.Core.Models;

namespace MovieDot.Core.Repositories
{
    public interface IMovieRepository : IGenericRepository<Movie>
    {
        Task<List<Movie>> GetAllMovie(int page , int pageSize);
        Task<List<Movie>> GetMovieByName(string movieUrl,int? part);
        Task<List<Movie>> GetMovieWithCategory(int categoryId, int page, int pageSize);
        Task<List<Movie>> GetMovieWithGenre(int genreId, int page, int pageSize);
        Task<List<Movie>> GetMovieById(int movieId);
        Task<List<Movie>> GetMoviePopular();
        Task<List<Movie>> MovieSearch(string movieName);
 
    }
}
