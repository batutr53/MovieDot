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
    public class LanguageService : Service<Language>, ILanguageService
    {
        public LanguageService(IUnitOfWork unitOfWork, IGenericRepository<Language> repository) : base(unitOfWork, repository)
        {
        }
    }
}
