using EasyBank.DTOs;
using EasyBank.Services;
using Microsoft.AspNetCore.Mvc;

namespace EasyBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly EmployeeAuthService _employeeAuthService;

        public AuthController(EmployeeAuthService employeeAuthService)
        {
            _employeeAuthService = employeeAuthService;
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
    }
}
