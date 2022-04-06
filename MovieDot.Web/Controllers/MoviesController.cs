using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieDot.Core.DTOs.DtoActor;
using MovieDot.Core.DTOs.DtoCategory;
using MovieDot.Core.DTOs.DtoGenre;
using MovieDot.Core.DTOs.DtoMovie;
using MovieDot.Core.Models;
using MovieDot.Core.Services;
using MovieDot.Core.UnitOfWorks;
using MovieDot.Web.Services;

namespace MovieDot.Web.Controllers
{
    public class MoviesController : Controller
    {
        /*  private readonly IMovieService _movieServices;
          private readonly ICategoryService _categoryService;
          private readonly IGenreService _genreService;
          private readonly IActorService _actorService;
          private readonly IMapper _mapper;
          private readonly IUnitOfWork _unitOfWork;

        public MoviesController(IMovieService services, ICategoryService categoryService, IMapper mapper, IGenreService genreService, IActorService actorService, IUnitOfWork unitOfWork)
          {
              _movieServices = services;
              _categoryService = categoryService;
              _mapper = mapper;
              _genreService = genreService;
              _actorService = actorService;
              _unitOfWork = unitOfWork;
          }

          public async Task<IActionResult> Index()
          {
              var movies = await _movieServices.GetAllMovie();
              return View(movies.Data);
          }

          public async Task<IActionResult> Save()
          {
              var categories = await _categoryService.GetAllAsync();
              var genres = await _genreService.GetAllAsync();
              var actors = await _actorService.GetAllAsync();
              var categoriesDto = _mapper.Map<List<CategoryDto>>(categories.ToList());
              var genresDto = _mapper.Map<List<GenreDto>>(genres.ToList());
              var actorsDto = _mapper.Map<List<ActorDto>>(actors.ToList());
              ViewBag.categories = new SelectList(categoriesDto,"Id","Name");
              ViewBag.genres = new SelectList(genresDto, "Id", "Name");
              ViewBag.actors = new SelectList(actorsDto, "Id", "Name");
              return View();
          }
          [HttpPost]
          public async Task<IActionResult> Save(MoviePostDto moviePostDto)
          {

              var movies = await _movieServices.AddAsync(_mapper.Map<Movie>(moviePostDto));

              movies.MovieActors.Add(new()
              {
                  ActorId = 1,
                  MovieId = movies.Id
              });

              _mapper.Map<MoviePostDto>(movies);
              return RedirectToAction(nameof(Index));

              var categories = await _categoryService.GetAllAsync();
              var genres = await _genreService.GetAllAsync();
              var actors = await _actorService.GetAllAsync();
              var categoriesDto = _mapper.Map<List<CategoryDto>>(categories.ToList());
              var genresDto = _mapper.Map<List<GenreDto>>(genres.ToList());
              var actorsDto = _mapper.Map<List<ActorDto>>(actors.ToList());
              ViewBag.categories = new SelectList(categoriesDto, "Id", "Name");
              ViewBag.genres = new SelectList(genresDto, "Id", "Name");
              ViewBag.actors = new SelectList(actorsDto, "Id", "Name");

              return View();
          }*/

        private readonly MovieApiService _movieApiService;

        public MoviesController(MovieApiService movieApiService)
        {
            _movieApiService = movieApiService;
        }

      
        public async Task<IActionResult> Index()
        {
            return View(await _movieApiService.GetAllMovie());
        }

        public async Task<IActionResult> Save()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Save(MoviePostDto movieDto)
        {
            var movie = await _movieApiService.PostMovie(movieDto);
            movie.MovieActors.Add(new()
            {
                ActorId = movieDto.Actors.Select(x => x.Id).SingleOrDefault(),
                MovieId = movie.Id
            });

            return RedirectToAction(nameof(Index));

        }
        [HttpPost]
        public async Task<IActionResult> GetMovieById(string id)
        {
            var movie = await _movieApiService.GetMovieById(id);
            return View(movie);
    

        }

    }
}
