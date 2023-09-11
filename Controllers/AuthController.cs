using EasyBank.DTOs;
using EasyBank.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EasyBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _employeeAuthService;
        private readonly TokenService _tokenService;

        public AuthController(AuthService employeeAuthService, TokenService tokenService)
        {
            _employeeAuthService = employeeAuthService;
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto employee)
        {
            return await _employeeAuthService.Login(employee);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto employee)
        {
            return await _employeeAuthService.Register(employee);
        }

        [HttpPost("refresh")]
        public IActionResult RefreshToken([FromBody] RefreshTokenDto refreshTokenRequest)
        {
            var tokens = _tokenService.RefreshToken(refreshTokenRequest);
            return Ok(new
            {
                AccessToken = tokens.AccessToken,
                RefreshToken = tokens.NewRefreshToken
            });
        }
    }
}
