using MovieDot.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Core.Services
{
    public interface IUserService:IService<User>
    {
       Task<bool> IsUniqueUser(string mail);
       Task<User> Authenticate(string mail, string password);
       Task<User> Register(string userName,string mail, string password);
    }
}
