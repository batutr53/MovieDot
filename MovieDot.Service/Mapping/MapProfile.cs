﻿using AutoMapper;
using MovieDot.Core.DTOs.DtoActor;
using MovieDot.Core.DTOs.DtoCategory;
using MovieDot.Core.DTOs.DtoComment;
using MovieDot.Core.DTOs.DtoGenre;
using MovieDot.Core.DTOs.DtoLanguage;
using MovieDot.Core.DTOs.DtoMovie;
using MovieDot.Core.DTOs.DtoPart;
using MovieDot.Core.DTOs.DtoUser;
using MovieDot.Core.Models;

namespace MovieDot.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<User, UserRegisterDto>().ReverseMap();
            CreateMap<User, UserAuthenticateDto>();

            CreateMap<Category, CategoryDto>();
            CreateMap<Movie, MovieDto>();
            CreateMap<Movie, MovieSearchDto>();
            CreateMap<Movie, MoviePostDto>().ReverseMap();
            CreateMap<MovieActor, MovieActorDto>().ReverseMap();
            CreateMap<Genre, GenreDto>();
            CreateMap<Actor, ActorDto>();
            CreateMap<User, UserDto>();
            CreateMap<Language, LanguageDto>();
            CreateMap<Part, PartDto>();
            CreateMap<Comment, CommentDto>();

            CreateMap<MovieDto, MovieWithCategoryDto>().ReverseMap();
            CreateMap<Movie, MovieWithCategoryDto>().ReverseMap();
            CreateMap<Movie, MovieWithCategoryDto>().ForMember(dto => dto.Category, opt => opt.MapFrom(x => x.MovieCategories.Select(y => y.Category).ToList()));

            CreateMap<Movie, MovieWithAllDto>().ForMember(dto => dto.Categories, opt => opt.MapFrom(mc => mc.MovieCategories.Select(c => c.Category).ToList()))
                                              .ForMember(dto => dto.Actors, opt => opt.MapFrom(ma => ma.MovieActors.Select(a => a.Actor).ToList()))
                                              .ForMember(dto => dto.Genres, opt => opt.MapFrom(mg => mg.MovieGenres.Select(g => g.Genre).ToList()));
            CreateMap<Movie, MoviePostDto>().ForMember(dto => dto.Categories, opt => opt.MapFrom(mc => mc.MovieCategories.Select(c => c.Category).ToList()))
                                             .ForMember(dto => dto.Actors, opt => opt.MapFrom(ma => ma.MovieActors.Select(a => a.Actor).ToList()))
                                             .ForMember(dto => dto.Genres, opt => opt.MapFrom(mg => mg.MovieGenres.Select(g => g.Genre).ToList()));


            CreateMap<Genre, GenreDto>();
        }
    }
}
