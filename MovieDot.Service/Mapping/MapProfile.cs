using AutoMapper;
using MovieDot.Core.DTOs.DtoCategory;
using MovieDot.Core.DTOs.DtoMovie;
using MovieDot.Core.DTOs.DtoUser;
using MovieDot.Core.Models;

namespace MovieDot.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<User, UserRegisterDto>().ReverseMap();

            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Movie, MovieDto>().ReverseMap();
            CreateMap<MovieDto, MovieWithCategoryDto>().ReverseMap();
            CreateMap<Movie, MovieWithCategoryDto>().ReverseMap();
            CreateMap<Movie, MovieWithCategoryDto>().ForMember(dto => dto.Category, opt => opt.MapFrom(x => x.MovieCategories.Select(y => y.Category).ToList()));
            CreateMap<User, UserAuthenticateDto>();
        }
    }
}
