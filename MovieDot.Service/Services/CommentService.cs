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
    public class CommentService : Service<Comment>, ICommentService
    {
        public CommentService(IUnitOfWork unitOfWork, IGenericRepository<Comment> repository) : base(unitOfWork, repository)
        {
        }
    }
}
