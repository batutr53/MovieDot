using AutoMapper;
using MovieDot.Core.Models;
using MovieDot.Core.Repositories;
using MovieDot.Core.Services;
using MovieDot.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Service.Services
{
    
    public class GenreService : Service<Genre>, IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;
        public GenreService(IUnitOfWork unitOfWork, IGenericRepository<Genre> repository, IGenreRepository genreRepository, IMapper mapper) : base(unitOfWork, repository)
        {
            _genreRepository = genreRepository;
            _mapper = mapper;
        }
    }
}
