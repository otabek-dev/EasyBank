using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.Models;
using EasyBank.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EasyBank.Services
{
    public class AuthService
    {
        private readonly AppDbContext _context;
        private readonly TokenService _tokenService;
        private readonly PasswordHashService _passwordHashService;

        public AuthService(
            AppDbContext context,
            TokenService tokenService,
            PasswordHashService passwordHashService)
        {
            _context = context;
            _tokenService = tokenService;
            _passwordHashService = passwordHashService;
        }

        public async Task<Result> LoginAsync(LoginDto employee)
        {
            var emp = await _context.Employees.SingleOrDefaultAsync(e => e.Email == employee.Email);
            if (emp is null)
                return new Result(false, "User nut found!");

            var verifyPassword = _passwordHashService.VerifyPassword(emp.Password, employee.Password);

            if (!verifyPassword)
                return new Result(false, "Password wrong!!");

            var tokens = await _tokenService.CreateTokensAsync(emp);
            return new DataResult<TokensDto>(tokens);
        }

        public async Task<Result> RegisterAsync([FromBody] RegisterDto employee)
        {
            var findEmployeeByEmail = await _context.Employees
                .FirstOrDefaultAsync(e => e.Email == employee.Email);

            if (findEmployeeByEmail != null)
                return new Result(true, "Email already exist!");

            var passwordHash = _passwordHashService.HashPassword(employee.Password);

            var emp = new Employee()
            {
                Id = Guid.NewGuid(),
                Email = employee.Email,
                FullName = employee.FullName,
                Password = passwordHash,
                Position = employee.Position,
                Role = employee.Role,
                Phone = employee.Phone
            };

            await _context.Employees.AddAsync(emp);
            await _context.SaveChangesAsync();
            return new DataResult<Employee>(emp, true, "Account created!");
        }
    }
}
