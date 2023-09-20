using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.Models;
using EasyBank.Results;
using Microsoft.EntityFrameworkCore;

namespace EasyBank.Services
{
    public class EmployeeService
    {
        private readonly AppDbContext _context;
        private readonly PasswordHashService _passwordHash;
        public EmployeeService(AppDbContext context, PasswordHashService passwordHash)
        {
            _context = context;
            _passwordHash = passwordHash;
        }

        public async Task<Result> GetAllEmployeeAsync()
        {
            var employees = await _context.Employees.ToListAsync();
            return new DataResult<List<Employee>>(employees);
        }

        public async Task<Result> GetEmployeeByIdAsync(Guid id)
        {
            var employee = await _context.Employees
                .FirstOrDefaultAsync(e => e.Id == id);

            if (employee is null)
                return new Result(false, "Employee not found");

            return new DataResult<Employee>(employee);
        }

        public async Task<Result> CreateEmployeeAsync(EmployeeDto employee)
        {
            var emp = GenerateEmployee(employee);
            await _context.Employees.AddAsync(emp);
            await _context.SaveChangesAsync();
            return new Result(true, "Employee created!");
        }

        public async Task<Result> UpdateEmployeeAsync(Guid id, EmployeeDto newEmployeeData)
        {
            var emp = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
            if (emp is null)
                return new Result(false, "User not found!");

            var passwordHash = _passwordHash.HashPassword(newEmployeeData.Password);
            newEmployeeData.Password = passwordHash;

            var entry = _context.Entry(emp);
            entry.CurrentValues.SetValues(newEmployeeData);
            await _context.SaveChangesAsync();
            return new Result(true, "Employee updated!");
        }

        public async Task<Result> DeleteEmployeeAsync(Guid id)
        {
            var emp = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
            if (emp is null)
                return new Result(false, "User nut found!");

            _context.Employees.Remove(emp);
            await _context.SaveChangesAsync();
            return new Result(true, "Employee deleted!");
        }

        private Employee GenerateEmployee(EmployeeDto employee)
        {
            return GenerateEmployee(Guid.NewGuid(), employee);
        }

        private Employee GenerateEmployee(Guid id, EmployeeDto employee)
        {
            var passwordHash = _passwordHash.HashPassword(employee.Password);
            var emp = new Employee()
            {
                Id = id,
                Email = employee.Email,
                FullName = employee.FullName,
                Password = passwordHash,
                Position = employee.Position,
                Role = employee.Role ?? "Employee",
                Phone = employee.Phone
            };

            return emp;
        }
    }
}
