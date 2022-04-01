using MovieDot.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Core.Repositories
{
    public interface IUserRepository: IGenericRepository<User>
    {
        bool IsUniqueUser(string mail);
        User Authenticate(string mail, string password);
        User Register(string userName,string mail, string password);
    }
}
