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

        public EmployeeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Result> GetAllEmployee()
        {
            var employees = await _context.Employees.ToListAsync();
            return new DataResult<List<Employee>>(employees);
        }

        public async Task<Result> GetEmployeeById(Guid id)
        {
            var employee = await _context.Employees
                .FirstOrDefaultAsync(e => e.Id == id);

            if (employee is null)
                return new Result(false, "Employee not found");

            return new DataResult<Employee>(employee);
        }

        public async Task<Result> CreateEmployee(EmployeeDto employee)
        {
            var emp = GenerateEmployee(employee);
            await _context.Employees.AddAsync(emp);
            await _context.SaveChangesAsync();
            return new Result(true, "Employee created!");
        }

        public async Task<Result> UpdateEmployee(Guid id, EmployeeDto newEmployeeData)
        {
            var emp = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
            if (emp is null)
                return new Result(false, "User not found!");

            var entry = _context.Entry(emp);
            entry.CurrentValues.SetValues(newEmployeeData);
            await _context.SaveChangesAsync();
            return new Result(true, "Employee updated!");
        }

        public async Task<Result> DeleteEmployee(Guid id)
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
            var emp = new Employee()
            {
                Id = id,
                Email = employee.Email,
                FullName = employee.FullName,
                Password = employee.Password,
                Position = employee.Position,
                Role = employee.Role ?? "Employee",
                Phone = employee.Phone
            };

            return emp;
        }
    }
}
