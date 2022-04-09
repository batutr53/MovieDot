using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieDot.API.Filters;
using MovieDot.Core.DTOs;
using MovieDot.Core.DTOs.DtoComment;
using MovieDot.Core.Models;
using MovieDot.Core.Services;

namespace MovieDot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : CustomBaseController
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;
        public CommentsController(ICommentService commentService, IMapper mapper)
        {
            _commentService = commentService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var comment = await _commentService.AllAsync();
            var commentDto = _mapper.Map<List<CommentDto>>(comment.ToList());
            return CreateActionResult(CustomResponseDto<List<CommentDto>>.Success(200, commentDto));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllPage(int page)
        {
            const int pageSize = 10;
            var comment = await _commentService.GetAllAsync(page, pageSize);
            var commentDto = _mapper.Map<List<CommentDto>>(comment.ToList());
            return CreateActionResult(CustomResponseDto<List<CommentDto>>.Success(200, commentDto));
        }

        [ServiceFilter(typeof(NotFoundFilterBase<Comment>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var comment = await _commentService.GetByIdAsync(id);
            var categoryDto = _mapper.Map<CommentDto>(comment);
            return CreateActionResult(CustomResponseDto<CommentDto>.Success(200, categoryDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CommentPostDto commentPostDto)
        {
            var comment = await _commentService.AddAsync(_mapper.Map<Comment>(commentPostDto));
            var commentDto = _mapper.Map<CommentPostDto>(comment);
            return CreateActionResult(CustomResponseDto<CommentPostDto>.Success(201, commentDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(CommentUpdateDto commentUpdateDto)
        {
            await _commentService.UpdateAsync(_mapper.Map<Comment>(commentUpdateDto));
            return CreateActionResult(CustomResponseDto<CommentUpdateDto>.Success(204, commentUpdateDto));
        }

        [ServiceFilter(typeof(NotFoundFilterBase<Comment>))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var comment = await _commentService.GetByIdAsync(id);
            await _commentService.RemoveAsync(comment);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(200));
        }
    }
}
