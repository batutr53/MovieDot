using AutoMapper;
using MovieDot.Core.DTOs;
using MovieDot.Core.DTOs.DtoMovie;
using MovieDot.Core.Models;
using MovieDot.Core.Repositories;
using MovieDot.Core.Services;
using MovieDot.Core.UnitOfWorks;

namespace MovieDot.Service.Services
{
    public class MovieService : Service<Movie>, IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public MovieService(IUnitOfWork unitOfWork, IGenericRepository<Movie> repository, IMovieRepository movieRepository, IMapper mapper) : base(unitOfWork, repository)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<List<MovieWithAllDto>>> GetAllMovie(int page, int pageSize)
        {
          var movies = await _movieRepository.GetAllMovie(page, pageSize);
          var moviesDto= _mapper.Map<List<MovieWithAllDto>>(movies);
            return CustomResponseDto<List<MovieWithAllDto>>.Success(200,moviesDto);
        }

        public async Task<CustomResponseDto<List<MovieWithAllDto>>> GetMovieById(int movieId)
        {
            var movies = await _movieRepository.GetMovieById(movieId);
            var moviesDto = _mapper.Map<List<MovieWithAllDto>>(movies);
            return CustomResponseDto<List<MovieWithAllDto>>.Success(200,moviesDto);
        }

        public async Task<CustomResponseDto<List<MovieWithAllDto>>> GetMovieByName(string movieUrl,int? part)
        {
            var movies = await _movieRepository.GetMovieByName(movieUrl,part);
            var moviesDto = _mapper.Map<List<MovieWithAllDto>>(movies);
            return CustomResponseDto<List<MovieWithAllDto>>.Success(200, moviesDto);
        }

        public async Task<CustomResponseDto<List<MovieDto>>> GetMoviePopular()
        {
            var movies = await _movieRepository.GetMoviePopular();
            var moviesDto = _mapper.Map<List<MovieDto>>(movies);
            return CustomResponseDto<List<MovieDto>>.Success(200, moviesDto);
        }

        public async Task<CustomResponseDto<List<MovieWithCategoryDto>>> GetMovieWithCategory(int categoryId, int page, int pageSize)
        {
            var movies = await _movieRepository.GetMovieWithCategory(categoryId, page, pageSize);
            var moviesDto = _mapper.Map<List<MovieWithCategoryDto>>(movies);
            return CustomResponseDto<List<MovieWithCategoryDto>>.Success(200, moviesDto);
        }

        public async Task<CustomResponseDto<List<MovieWithGenreDto>>> GetMovieWithGenre(int genreId, int page, int pageSize)
        {
            var movies = await _movieRepository.GetMovieWithGenre(genreId, page, pageSize);
            var moviesDto = _mapper.Map<List<MovieWithGenreDto>>(movies);
            return CustomResponseDto<List<MovieWithGenreDto>>.Success(200, moviesDto);
        }

        public async Task<CustomResponseDto<List<MovieSearchDto>>> MovieSearch(string movieName)
        {
           var movies = await _movieRepository.MovieSearch(movieName);
           var moviesDto=_mapper.Map<List<MovieSearchDto>>(movies);
            return CustomResponseDto<List<MovieSearchDto>>.Success(200, moviesDto);
        }
    }
}
