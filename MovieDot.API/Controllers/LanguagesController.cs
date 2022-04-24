using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieDot.API.Filters;
using MovieDot.Core.DTOs;
using MovieDot.Core.DTOs.DtoLanguage;
using MovieDot.Core.Models;
using MovieDot.Core.Services;

namespace MovieDot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : CustomBaseController
    {
        private readonly ILanguageService _languageService;
        private readonly IMapper _mapper;
        public LanguagesController(ILanguageService languageService, IMapper mapper)
        {
            _languageService = languageService;
            _mapper = mapper;

            
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var languages = await _languageService.AllAsync();
            var languagesDto = _mapper.Map<List<LanguageDto>>(languages.ToList());
            return CreateActionResult(CustomResponseDto<List<LanguageDto>>.Success(200, languagesDto));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllPage(int page)
        {
            const int pageSize = 10;
            var languages = await _languageService.GetAllAsync(page, pageSize);
            var languagesDto = _mapper.Map<List<LanguageDto>>(languages.ToList());
            return CreateActionResult(CustomResponseDto<List<LanguageDto>>.Success(200, languagesDto));
        }

        [ServiceFilter(typeof(NotFoundFilter<Language>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var language = await _languageService.GetByIdAsync(id);
            var languageDto = _mapper.Map<LanguageDto>(language);
            return CreateActionResult(CustomResponseDto<LanguageDto>.Success(200, languageDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(LanguageDto languageDto)
        {
            var language = await _languageService.AddAsync(_mapper.Map<Language>(languageDto));
            var languagesDto = _mapper.Map<LanguageDto>(language);
            return CreateActionResult(CustomResponseDto<LanguageDto>.Success(201, languagesDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(LanguageDto languageDto)
        {
            await _languageService.UpdateAsync(_mapper.Map<Language>(languageDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [ServiceFilter(typeof(NotFoundFilter<Language>))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var language = await _languageService.GetByIdAsync(id);
            await _languageService.RemoveAsync(language);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
