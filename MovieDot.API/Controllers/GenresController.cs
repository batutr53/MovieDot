using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieDot.API.Filters;
using MovieDot.Core.DTOs;
using MovieDot.Core.DTOs.DtoGenre;
using MovieDot.Core.Models;
using MovieDot.Core.Services;

namespace MovieDot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : CustomBaseController
    {
        private readonly IGenreService _genreService;
        private readonly IMapper _mapper;
        public GenresController(IGenreService genreService, IMapper mapper)
        {
            _genreService = genreService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var genres = await _genreService.GetAllAsync();
            var genresDto = _mapper.Map<List<GenreDto>>(genres.ToList());
            return CreateActionResult(CustomResponseDto<List<GenreDto>>.Success(200, genresDto));
        }
        
        [ServiceFilter(typeof(NotFoundFilter<Genre>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var genre = await _genreService.GetByIdAsync(id);
            var genreDto = _mapper.Map<GenreDto>(genre);
            return CreateActionResult(CustomResponseDto<GenreDto>.Success(200, genreDto));
        } 

        [HttpPost]
        public async Task<IActionResult> Save(GenreDto genreDto)
        {
            var genre = await _genreService.AddAsync(_mapper.Map<Genre>(genreDto));
            var genresDto = _mapper.Map<GenreDto>(genre);
            return CreateActionResult(CustomResponseDto<GenreDto>.Success(201, genresDto));
        }
        
        [HttpPut]
        public async Task<IActionResult> Update(GenreDto genreDto)
        {
            await _genreService.UpdateAsync(_mapper.Map<Genre>(genreDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [ServiceFilter(typeof(NotFoundFilter<Genre>))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var genre = await _genreService.GetByIdAsync(id);
            await _genreService.RemoveAsync(genre);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(200));
        }
    }
}
