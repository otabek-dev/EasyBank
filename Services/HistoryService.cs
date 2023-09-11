using EasyBank.DB;
using EasyBank.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using System.Security.Claims;

namespace EasyBank.Services
{
    public class HistoryService
    {
        private readonly AppDbContext _context;

        public HistoryService(AppDbContext context)
        {
            _context = context;
        }

        private async Task<Employee> GetEmployee(ClaimsPrincipal user)
        {
            var employeeId = Guid.Empty;
            Guid.TryParse(user.FindFirstValue(ClaimTypes.NameIdentifier), out employeeId);
            var employee = await _context.Employees.FindAsync(employeeId);
            return employee;
        }

        public async Task CreateHistoyr(
            ClaimsPrincipal user, 
            OperationType operationType,
            OperationDescription operationDescription)
        {
            var employee = await GetEmployee(user);
            if (employee == null)
                return;

            var history = new History
            {
                Id = Guid.NewGuid(),
                Timestamp = DateTime.UtcNow,
                OperationType = operationType,
                OperationDescription = operationDescription,
                EmployeeId = employee.Id
            };

            await _context.History.AddAsync(history);
            await _context.SaveChangesAsync();
        }
    }
}
