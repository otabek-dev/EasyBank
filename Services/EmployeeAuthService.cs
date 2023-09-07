using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.JWT;
using EasyBank.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace EasyBank.Services
{
    public class EmployeeAuthService : Controller
    {
        public readonly AppDbContext _context;
        public readonly IPasswordHasher<LoginDto> _passwordHasher;

        public EmployeeAuthService(AppDbContext context, IPasswordHasher<LoginDto> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
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

        public async Task<IActionResult> Login([FromBody] LoginDto employee)
        {
            var emp = await _context.Employees.SingleOrDefaultAsync(e => e.Email == employee.Email);
            if (emp is null)
            {
                return BadRequest("User nut found!");
            }
            /*HashPassword
            //var verifPassword = _passwordHasher.VerifyHashedPassword(employee, emp.Password, employee.Password);
            //if (verifPassword == PasswordVerificationResult.Failed)
            //    return BadRequest("Email or password wrong!");
            */
            
            if (emp.Password != employee.Password)
                return BadRequest("Password wrong!");

            var token = CreateToken(emp);
            return Ok(token);
        }

        public async Task<IActionResult> Register([FromBody] RegisterDto employee)
        {
            /*HashPassword
            //var loginDto = new LoginDto()
            //{
            //    Email = employee.Email,
            //    Password = employee.Password
            //};

            //var passwordHash = _passwordHasher.HashPassword(loginDto, loginDto.Password);
            */
            
            var findEmployeeByEmail = await _context.Employees
                .FirstOrDefaultAsync(e => e.Email == employee.Email);
            
            if (findEmployeeByEmail != null)
                return BadRequest("Email already exist!");

            var emp = new Employee()
            {
                Id = Guid.NewGuid(),
                Email = employee.Email,
                FullName = employee.FullName,
                Password = employee.Password,
                Position = employee.Position,
                Role = employee.Role,
                Phone = employee.Phone
            };

            await _context.Employees.AddAsync(emp);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
