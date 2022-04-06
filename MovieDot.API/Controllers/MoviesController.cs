using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieDot.API.Filters;
using MovieDot.Core.DTOs;
using MovieDot.Core.DTOs.DtoMovie;
using MovieDot.Core.Models;
using MovieDot.Core.Services;
using MovieDot.Core.UnitOfWorks;

namespace MovieDot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : CustomBaseController
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public MoviesController(IMovieService movieService, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _movieService = movieService;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMovie()
        {
            return CreateActionResult(await _movieService.GetAllMovie());
        }
       
        [HttpGet("category/{categoryId}")]
        public async Task<IActionResult> GetMovieWithCategory(int categoryId)
        {
            return CreateActionResult(await _movieService.GetMovieWithCategory(categoryId));
        }

        [HttpGet("{movieId}")]         
        public async Task<IActionResult> GetMovieById(int movieId)
        {
            return CreateActionResult(await _movieService.GetMovieById(movieId));
        }

        [HttpGet("search")]
        public async Task<IActionResult> MovieSearch(string movieName)
        {
            return CreateActionResult(await _movieService.MovieSearch(movieName));
        }

        [HttpPost]
        public async Task<IActionResult> PostMovie(MoviePostDto movieDto)
        {
            var movie = await _movieService.AddAsync(_mapper.Map<Movie>(movieDto));
            movie.MovieActors.Add(new ()
            { 
                ActorId = movieDto.Actors.Select(x=>x.Id).SingleOrDefault(),
                MovieId = movie.Id
            });

            var movieDtos= _mapper.Map<MoviePostDto>(movie);
       
           
            return CreateActionResult(CustomResponseDto<MoviePostDto>.Success(204,movieDtos));
        }
    }
}
