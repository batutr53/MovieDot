using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieDot.Core.DTOs.DtoUser;
using MovieDot.Core.Models;
using MovieDot.Core.Services;
using System.Security.Claims;

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
        public async Task<IActionResult> Authenticate(UserAuthenticateDto user)
        {
            var users = await _userService.Authenticate(user.Email, user.Password);
            return Ok(users);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Register(UserRegisterDto userRegister)
        {
            bool userBool = await _userService.IsUniqueUser(userRegister.Email);
            if (!userBool)
            {
                return BadRequest(new { message = "Email zaten mevcut." });
            }
            var user = _userService.Register(userRegister.UserName, userRegister.Email, userRegister.Password);

            return Ok(userRegister);

        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<UserDto>> GetCurrentUser()
        {

            var email = HttpContext.User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value;
            var user =await _userService.FindByEmail(email);
            return new UserDto 
            { 
                Email = user.Email,
                UserName = user.UserName,
                Image =user.Image
            };
        }

    }
}
