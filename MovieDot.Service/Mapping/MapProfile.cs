﻿using AutoMapper;
using MovieDot.Core.DTOs.DtoActor;
using MovieDot.Core.DTOs.DtoCategory;
using MovieDot.Core.DTOs.DtoComment;
using MovieDot.Core.DTOs.DtoGenre;
using MovieDot.Core.DTOs.DtoLanguage;
using MovieDot.Core.DTOs.DtoMovie;
using MovieDot.Core.DTOs.DtoPart;
using MovieDot.Core.DTOs.DtoUser;
using MovieDot.Core.DTOs.DtoVoting;
using MovieDot.Core.Models;
using MovieDot.Service.Helper;

namespace MovieDot.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<User, UserRegisterDto>().ReverseMap();
            CreateMap<User, UserAuthenticateDto>();
            CreateMap<User, UserDto>().ReverseMap();


            CreateMap<Movie, MovieDto>();
            CreateMap<Movie, MovieSearchDto>();
            CreateMap<Movie, MoviePostDto>().ReverseMap();

            CreateMap<MovieActor, MovieActorDto>().ReverseMap();
            CreateMap<MovieGenre, MovieGenreDto>().ReverseMap();
            CreateMap<MovieCategory, MovieCategoryDto>().ReverseMap();

            CreateMap<Genre, GenreDto>().ReverseMap();
            CreateMap<Actor, ActorDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Language, LanguageDto>().ReverseMap();
            CreateMap<Part, PartDto>();
            CreateMap<Part, PartPostDto>().ReverseMap();

            CreateMap<Comment, CommentDto>();
            CreateMap<Comment, CommentPostDto>().ReverseMap();
            CreateMap<Comment, CommentUpdateDto>().ReverseMap();


            CreateMap<Movie, MovieWithCategoryDto>().ForMember(dto => dto.Category, opt => opt.MapFrom(x => x.MovieCategories.Select(y => y.Category).ToList()));
            CreateMap<Movie, MovieWithGenreDto>().ForMember(dto => dto.Genre, opt => opt.MapFrom(x => x.MovieGenres.Select(y => y.Genre).ToList()));

            CreateMap<Movie, MovieWithAllDto>().ForMember(dto => dto.Categories, opt => opt.MapFrom(mc => mc.MovieCategories.Select(c => c.Category).ToList()))
                                              .ForMember(dto => dto.Actors, opt => opt.MapFrom(ma => ma.MovieActors.Select(a => a.Actor).ToList()))
                                              .ForMember(dto => dto.Genres, opt => opt.MapFrom(mg => mg.MovieGenres.Select(g => g.Genre).ToList()))
                                              .ForMember(a => a.Image, b => b.MapFrom<MovieUrlResolver>());
        }
    }
}
