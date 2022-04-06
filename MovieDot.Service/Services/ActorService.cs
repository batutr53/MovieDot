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
    public class ActorService : Service<Actor>, IActorService
    {
        public ActorService(IUnitOfWork unitOfWork, IGenericRepository<Actor> repository) : base(unitOfWork, repository)
        {
        }
    }
}
