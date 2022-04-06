using MovieDot.Core.DTOs;
using MovieDot.Core.DTOs.DtoCategory;

namespace MovieDot.Web.Services
{
    public class CategoryService
    {
        private readonly HttpClient _httpClient;

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CategoryDto>> GetCategory()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<CategoryDto>>>("category/");
            return response.Data;
        }
    }
}
