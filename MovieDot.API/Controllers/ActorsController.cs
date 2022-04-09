using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieDot.API.Filters;
using MovieDot.Core.DTOs;
using MovieDot.Core.DTOs.DtoActor;
using MovieDot.Core.Models;
using MovieDot.Core.Services;

namespace MovieDot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : CustomBaseController
    {
        private readonly IActorService _actorService;
        private readonly IMapper _mapper;

        public ActorsController(IActorService actorService, IMapper mapper)
        {
            _actorService = actorService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var actors = await _actorService.AllAsync();
            var actorsDto = _mapper.Map<List<ActorDto>>(actors.ToList());
            return CreateActionResult(CustomResponseDto<List<ActorDto>>.Success(200, actorsDto));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllPage(int page)
        {
            const int pageSize = 10;
            var actors = await _actorService.GetAllAsync(page,pageSize);
            var actorsDto = _mapper.Map<List<ActorDto>>(actors.ToList());
            return CreateActionResult(CustomResponseDto<List<ActorDto>>.Success(200, actorsDto));
        }

        [ServiceFilter(typeof(NotFoundFilter<Actor>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var actor = await _actorService.GetByIdAsync(id);
            var actorDto = _mapper.Map<ActorDto>(actor);
            return CreateActionResult(CustomResponseDto<ActorDto>.Success(200, actorDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(ActorDto actorDto)
        {
            var actor = await _actorService.AddAsync(_mapper.Map<Actor>(actorDto));
            var actorsDto = _mapper.Map<ActorDto>(actor);
            return CreateActionResult(CustomResponseDto<ActorDto>.Success(201,actorsDto));
        }
        [HttpPut]
        public async Task<IActionResult> Update(ActorDto actorDto)
        {
            await _actorService.UpdateAsync(_mapper.Map<Actor>(actorDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [ServiceFilter(typeof(NotFoundFilter<Actor>))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var actor = await _actorService.GetByIdAsync(id);
            await _actorService.RemoveAsync(actor);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(200));
        }
    }
}
