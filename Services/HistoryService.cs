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

        public async Task CreateHistoyr(ClaimsPrincipal user, string operationType)
        {
            var employeeId = Guid.Empty;
            Guid.TryParse(user.FindFirstValue(ClaimTypes.NameIdentifier), out employeeId);
            var employee = await _context.Employees.FindAsync(employeeId);
            if (employee == null)
                return;

            var faker = new Bogus.Faker();
            var history = new History
            {
                Id = Guid.NewGuid(),
                Timestamp = DateTime.UtcNow,
                OperationType = operationType,
                OperatorId = faker.Random.Uuid().ToString(),
                EmployeeId = employeeId
            };

            await _context.History.AddAsync(history);
            await _context.SaveChangesAsync();
        }
    }
}
