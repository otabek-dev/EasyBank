using EasyBank.DTOs;
using EasyBank.Models;
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

        public async Task<IEnumerable<Employee>> GetAllEmployee()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(Guid id)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
            return employee;
        }

        public async Task CreateEmployee(EmployeeDto employee)
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
        }

        public async Task UpdateEmployee(Guid id, EmployeeDto employee)
        {
            var emp = new Employee()
            {
                Id = id,
                Email = employee.Email,
                FullName = employee.FullName,
                Password = employee.Password,
                Position = employee.Position,
                Role = "Employee",
                Phone = employee.Phone
            };

            _context.Employees.Update(emp);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEmployee(Guid id)
        {
            var emp = _context.Employees.FirstAsync(e => e.Id == id).Result;
            _context.Employees.Remove(emp);
            await _context.SaveChangesAsync();
        }
    }
}
