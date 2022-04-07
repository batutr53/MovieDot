using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieDot.API.Filters;
using MovieDot.Core.DTOs;
using MovieDot.Core.DTOs.DtoCategory;
using MovieDot.Core.Models;
using MovieDot.Core.Services;

namespace MovieDot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> All(int page)
        {
            const int pageSize = 10;
            var categories = await _categoryService.GetAllAsync(page,pageSize);
            var categoriesDto = _mapper.Map<List<CategoryDto>>(categories.ToList());
            return CreateActionResult(CustomResponseDto<List<CategoryDto>>.Success(200, categoriesDto));
        }

        [ServiceFilter(typeof(NotFoundFilter<Category>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            var categoryDto = _mapper.Map<CategoryDto>(category);
            return CreateActionResult(CustomResponseDto<CategoryDto>.Success(200, categoryDto));

        }
        
        [HttpPost]
        public async Task<IActionResult> Save(CategoryDto categoryDto)
        {
            var category = await _categoryService.AddAsync(_mapper.Map<Category>(categoryDto));
            var categoriesDto = _mapper.Map<CategoryDto>(category);
            return CreateActionResult(CustomResponseDto<CategoryDto>.Success(201, categoriesDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(CategoryDto categoryDto) 
        {
            await _categoryService.UpdateAsync(_mapper.Map<Category>(categoryDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [ServiceFilter(typeof(NotFoundFilter<Category>))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            await _categoryService.RemoveAsync(category);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(200));
        }
    }
}
