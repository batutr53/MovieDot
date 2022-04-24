using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MovieDot.Core.Models;
using MovieDot.Core.Repositories;
using MovieDot.Shared;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MovieDot.Repository.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly AppSettings _appSettings;
        public UserRepository(AppDbContext context,IOptions<AppSettings> appSettings) : base(context)
        {
            _appSettings = appSettings.Value;
        }

        public async Task<User> Authenticate(string mail, string password)
        {
            var user = _context.Users.SingleOrDefault(x => x.Email == mail && x.Password == password);
            if (user == null) {
                return null;
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokendDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                    {
                         new Claim(ClaimTypes.Email,user.Email),
                         new Claim(ClaimTypes.Role,user.UserRoleId.ToString())
                    }),
                Expires = DateTime.UtcNow.AddDays(5),
                SigningCredentials = new SigningCredentials(
                         new SymmetricSecurityKey(key),
                         SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokendDescriptor);
            user.Token = tokenHandler.WriteToken(token);
            user.Password = "";
            
            return user;
        }

        public async Task<User> FindByEmail(string mail)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == mail);
          
            return user;
        }

        public async Task<bool> IsUniqueUser(string mail)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x=>x.Email == mail);
            if (user == null)
            {
                return true;
            }
            return false;
        }

        public async Task<User> Register(string userName,string mail, string password)
        {
            User user = new User()
            {   
                UserName = userName,
                Email = mail,
                Password = password,
                UserRoleId = 3,
            };
            await _context.Users.AddAsync(user);
            return user;
        }
    }
}
