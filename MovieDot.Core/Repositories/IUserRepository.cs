﻿using MovieDot.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Core.Repositories
{
    public interface IUserRepository: IGenericRepository<User>
    {
        Task<bool> IsUniqueUser(string mail);
        Task<User>Authenticate(string mail, string password);
        Task<User> FindByEmail(string mail);
        Task<User> Register(string userName,string mail, string password);
    }
}
