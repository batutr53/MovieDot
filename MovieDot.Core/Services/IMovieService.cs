﻿using MovieDot.Core.DTOs;
using MovieDot.Core.DTOs.DtoMovie;
using MovieDot.Core.Models;

namespace MovieDot.Core.Services
{
    public interface IMovieService : IService<Movie>
    {
        Task<CustomResponseDto<List<MovieWithAllDto>>> GetAllMovie(int page,int pageSize);
        Task<CustomResponseDto<List<MovieWithCategoryDto>>> GetMovieWithCategory(int categoryId, int page, int pageSize);
        Task<CustomResponseDto<List<MovieWithGenreDto>>> GetMovieWithGenre(int genreId, int page, int pageSize);
        Task<CustomResponseDto<List<MovieWithAllDto>>> GetMovieById(int movieId);
        Task<CustomResponseDto<List<MovieWithAllDto>>> GetMovieByName(string movieUrl,int? part);
        Task<CustomResponseDto<List<MovieDto>>> GetMoviePopular();
        Task<CustomResponseDto<List<MovieSearchDto>>> MovieSearch(string movieName);
    }
}
