using ECommerce.Core.DTO;
using ECommerce.Core.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest login)
        {
            var result = await _userService.Login(login);
            if (result == null)
            {
                return Unauthorized("Invalid Login");
            }
            return Ok(result);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest register)
        {
            var result = await _userService.Register(register);
            if (result == null)
            {
                return BadRequest("User registration failed.");
            }
            return Ok(result);
        }
    }
}
