using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieDot.Core.DTOs.DtoUser;
using MovieDot.Core.Models;
using MovieDot.Core.Services;

namespace MovieDot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost("[action]")]
        public IActionResult Authenticate(UserAuthenticateDto user)
        {
            var users = _userService.Authenticate(user.Email, user.Password);
            return Ok(users);
        }

        [HttpPost("[action]")]
        public IActionResult Register(UserRegisterDto userRegister)
        {
            bool userBool = _userService.IsUniqueUser(userRegister.Email);
            if (!userBool)
            {
                return BadRequest(new { message = "Email zaten mevcut." });
            }
            var user = _userService.Register(userRegister.UserName, userRegister.Email, userRegister.Password);
            var userDto = _mapper.Map<UserRegisterDto>(user);

            return Ok(userDto);

        }

    }
}
