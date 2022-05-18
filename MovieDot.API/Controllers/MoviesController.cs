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
        private readonly IWebHostEnvironment hostEnvironment;

        public MoviesController(IMovieService movieService, IMapper mapper, IUnitOfWork unitOfWork,IWebHostEnvironment hostEnvironment)
        {
            _movieService = movieService;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            this.hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMovie()
        {
            int page = 1;
            const int pageSize = 20;
            return CreateActionResult(await _movieService.GetAllMovie(page, pageSize));
        }
        [Authorize]
        [HttpGet("[action]")]
        public async Task<IActionResult> GetMoviePopular()
        {

            return CreateActionResult(await _movieService.GetMoviePopular());
        }

        [HttpGet("category/{categoryId}")]
        public async Task<IActionResult> GetMovieWithCategory(int categoryId, int page)
        {
            const int pageSize = 10;
            return CreateActionResult(await _movieService.GetMovieWithCategory(categoryId, page, pageSize));
        }
        [HttpGet("genre/{genreId}")]
        public async Task<IActionResult> GetMovieWithGenre(int genreId, int page)
        {
            const int pageSize = 10;
            return CreateActionResult(await _movieService.GetMovieWithGenre(genreId, page, pageSize));
        }

        [HttpGet("{movieId}")]
        public async Task<IActionResult> GetMovieById(int movieId)
        {
            return CreateActionResult(await _movieService.GetMovieById(movieId));
        }

        [HttpGet("Movie/{movieUrl}")]
        public async Task<IActionResult> GetMovieByName(string movieUrl, int? part)
        {
            return CreateActionResult(await _movieService.GetMovieByName(movieUrl, part));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Search(string movieName)
        {
            return CreateActionResult(await _movieService.MovieSearch(movieName));
        }


        [HttpPost]
        public async Task<IActionResult> PostMovie(MoviePostDto movieDto)
        {
            movieDto.Image = await SaveImage(movieDto.ImageFile);
            var movie = await _movieService.AddAsync(_mapper.Map<Movie>(movieDto));
            var movieDtos = _mapper.Map<MoviePostDto>(movie);
            return CreateActionResult(CustomResponseDto<MoviePostDto>.Success(204, movieDtos));
        }

        [NonAction]
        public async Task<string> SaveImage(IFormFile file)
        {
             var extention = Path.GetExtension(file.FileName).ToLower();
                var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                var path = Path.Combine(Directory.GetCurrentDirectory(), "Resources\\Images", randomName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            return randomName;
        }
       
        [HttpPut]
        public async Task<IActionResult> Update(MoviePostDto movieUpdateDto)
        {
            await _movieService.UpdateAsync(_mapper.Map<Movie>(movieUpdateDto));
           
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [ServiceFilter(typeof(NotFoundFilterBase<Movie>))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var movie = await _movieService.GetByIdAsync(id);
            await _movieService.RemoveAsync(movie);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(200));
        }
    }
}
