using MovieDot.Core.DTOs;
using MovieDot.Core.DTOs.DtoMovie;

namespace MovieDot.Web.Services
{
    public class MovieApiService
    {
        private readonly HttpClient _httpClient;

        public MovieApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<MovieWithAllDto>> GetAllMovie()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<MovieWithAllDto>>>("Movies");
            return response.Data;
        }

        public async Task<MoviePostDto> PostMovie(MoviePostDto movieDto)
        {
            var response = await _httpClient.PostAsJsonAsync("Movies", movieDto);
            if (!response.IsSuccessStatusCode) return null;
            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<MoviePostDto>>();
            return responseBody.Data;
           
        }

        public async Task<MovieWithCategoryDto> GetMovieById(string id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<MovieWithCategoryDto>> ($"Movies/{id}");
            return response.Data;
        }
    }
}
