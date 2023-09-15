using EasyBank.DTOs;
using EasyBank.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

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
            var tokens = await _employeeAuthService.Login(employee);
            return Ok(tokens);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto employee)
        {
            var result = await _employeeAuthService.Register(employee);
            return Ok(result);
        }

        [HttpPost("refresh-token")]
        [Authorize]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenDto refreshTokenRequest)
        {
            var tokens = await _tokenService.RefreshToken(refreshTokenRequest);
            return Ok(tokens);
        }
    }
}
