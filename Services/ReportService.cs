using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.Models;
using EasyBank.Results;
using Microsoft.EntityFrameworkCore;

namespace EasyBank.Services
{
    public class ReportService
    {
        private readonly AppDbContext _context;

        public ReportService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Result> CreateReport(ReportDto reportDto)
        {
            var operations = _context.History
                .Where(x => x.EmployeeId == reportDto.EmployeeId
                    && x.Timestamp >= reportDto.StartDate.ToUniversalTime()
                    && x.Timestamp <= reportDto.EndDate.ToUniversalTime());

            var groupedOperations = await operations
                .GroupBy(x => new { x.OperationType, x.Timestamp.ToUniversalTime().Date })
                .Select(group => new
                {
                    OperationType = group.Key.OperationType,
                    Date = group.Key.Date,
                    Count = group.Count()
                })
                .ToListAsync();

            var info = groupedOperations.Select(item =>
                $"{item.OperationType}: {item.Count} операций ({item.Date:yyyy-MM-dd})");

            var report = new Report()
            {
                EmployeeId = reportDto.EmployeeId,
                StartDate = reportDto.StartDate,
                EndDate = reportDto.EndDate,
                OperationInfo = string.Join("\n\t", info)
            };

            return new DataResult<Report>(report);
        }
    }
}
