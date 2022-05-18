using AutoMapper;
using Microsoft.Extensions.Configuration;
using MovieDot.Core.DTOs.DtoMovie;
using MovieDot.Core.Models;
namespace MovieDot.Service.Helper
{
    public class MovieUrlResolver : IValueResolver<Movie, MovieWithAllDto, string>
    {
        private readonly IConfiguration _config;
        public MovieUrlResolver(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(Movie source, MovieWithAllDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.Image))
            {
                return _config["ApiUrl"]+"Images/"+ source.Image;
            }
            return null;
        }
    }
}
