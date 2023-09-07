using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.JWT;
using EasyBank.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace EasyBank.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        public AuthController(AppDbContext context) 
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto employee)
        {
            var emp = _context.Employees.SingleOrDefault(e => e.Email == employee.Email);
            if (emp is null)
            {
                return BadRequest("User nut found!");
            }

            var token = CreateToken(emp);
            return Ok(token);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto employee)
        {
            var emp = new Employee()
            {
                Id = Guid.NewGuid(),
                Email = employee.Email,
                FullName = employee.FullName,
                Password = employee.Password,
                Position = employee.Position,
                Role = "Employee",
                Phone = employee.Phone
            };

            await _context.Employees.AddAsync(emp);
            await _context.SaveChangesAsync();
            return Ok();
        }

        private string CreateToken(Employee employee)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Role, employee.Role)
            };

            var token = new JwtSecurityToken(
                issuer: JwtData.ISSUER,
                audience: JwtData.AUDIENCE,
                claims: claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: new SigningCredentials(
                    JwtData.GetSymmetricSecurityKey(),
                    SecurityAlgorithms.HmacSha256));

            var encodedToken = new JwtSecurityTokenHandler().WriteToken(token);
            return encodedToken;
        }

    }
}
