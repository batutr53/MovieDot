using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieDot.API.Filters;
using MovieDot.Core.Models;
using MovieDot.Core.Services;

namespace MovieDot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : CustomBaseController
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;
        public MoviesController(IMovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
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
    }
}
