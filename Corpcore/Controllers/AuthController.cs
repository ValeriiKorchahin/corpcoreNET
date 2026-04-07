using Corpcore.Dtos.Auth;
using Corpcore.Services.Auth;
using Microsoft.AspNetCore.Mvc;

namespace Corpcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService _authService) : ControllerBase
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto request)
        {
            try
            {
                var response = await _authService.Login(request);
                return Ok(response);
            }
            catch
            {
                throw new Exception("Failded.");
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto request)
        {
            try
            {
                var response = await _authService.Register(request);
                return Ok(response);
            }
            catch
            {
                throw new Exception("Register Failed.");
            }
        }
    }
}
