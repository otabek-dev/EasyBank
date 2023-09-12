using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EasyBank.Services
{
    public class AuthService
    {
        private readonly AppDbContext _context;
        private readonly TokenService _tokenService;
        private readonly IPasswordHasher<LoginDto> _passwordHasher;

        public AuthService(
            AppDbContext context,
            TokenService tokenService,
            IPasswordHasher<LoginDto> passwordHasher)
        {
            _context = context;
            _tokenService = tokenService;
            _passwordHasher = passwordHasher;
        }

        public async Task<TokensDto> Login(LoginDto employee)
        {
            var emp = await _context.Employees.SingleOrDefaultAsync(e => e.Email == employee.Email);
            if (emp is null)
                return null; //"User nut found!"

            /*HashPassword
            //var verifPassword = _passwordHasher.VerifyHashedPassword(employee, emp.Password, employee.Password);
            //if (verifPassword == PasswordVerificationResult.Failed)
            //    return BadRequest("Email or password wrong!");
            */

            if (emp.Password != employee.Password)
                return null; //"Password wrong!"

            var tokens = await _tokenService.CreateTokens(emp);
            return tokens;
        }

        public async Task<string> Register([FromBody] RegisterDto employee)
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
                return "Email already exist!";

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
            return "Account created!";
        }
    }
}
