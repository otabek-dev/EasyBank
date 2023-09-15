using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.Models;
using EasyBank.Results;
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

        public async Task<Result> Login(LoginDto employee)
        {
            var emp = await _context.Employees.SingleOrDefaultAsync(e => e.Email == employee.Email);
            if (emp is null)
                return new Result(false,"User nut found!"); //"User nut found!"

            /*HashPassword
            //var verifPassword = _passwordHasher.VerifyHashedPassword(employee, emp.Password, employee.Password);
            //if (verifPassword == PasswordVerificationResult.Failed)
            //    return BadRequest("Email or password wrong!");
            */

            if (emp.Password != employee.Password)
                return new Result(false, "Password wrong!!"); //"Password wrong!"

            var tokens = await _tokenService.CreateTokens(emp);
            return new DataResult<TokensDto>(tokens);
        }

        public async Task<Result> Register([FromBody] RegisterDto employee)
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
                .FirstAsync(e => e.Email == employee.Email);

            if (findEmployeeByEmail != null)
                return new Result(true, "Email already exist!");

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
            return new Result(true, "Account created!");
        }
    }
}
