using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EasyBank.Services
{
    public class EmployeeService : Controller
    {
        private readonly AppDbContext _context;

        public EmployeeService(AppDbContext context)
        {
            _context = context;
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

        public Employee GenerateEmployee(EmployeeDto employee) 
        {
            return GenerateEmployee(Guid.NewGuid(), employee);
        }

        public async Task<IEnumerable<Employee>> GetAllEmployee()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<IActionResult> GetEmployeeById(Guid id)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
            if (employee is null)
                return NotFound("Employee not found");
            return Ok(employee);
        }

        public async Task<IActionResult> CreateEmployee(EmployeeDto employee)
        {
            var emp = GenerateEmployee(employee);
            await _context.Employees.AddAsync(emp);
            await _context.SaveChangesAsync();
            return Ok("Employee created!");
        }

        public async Task<IActionResult> UpdateEmployee(Guid id, EmployeeDto newEmployeeData)
        {
            var emp = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
            if (emp is null)
                return NotFound("User not found!");

            var entry = _context.Entry(emp);

            entry.CurrentValues.SetValues(newEmployeeData);

            await _context.SaveChangesAsync();

            return Ok("Employee updated!");
        }

        public async Task<IActionResult> DeleteEmployee(Guid id)
        {
            var emp = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
            if (emp is null)
                return NotFound("User nut found!");

            _context.Employees.Remove(emp);
            await _context.SaveChangesAsync();
            return Ok("Employee deleted!");
        }
    }
}
