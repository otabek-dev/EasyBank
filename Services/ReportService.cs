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

        public async Task<Result> CreateReportAsync(ReportDto reportDto)
        {
            var operations = _context.History
                .Where(x => x.EmployeeId == reportDto.EmployeeId
                    && x.Timestamp >= reportDto.StartDate.ToUniversalTime()
                    && x.Timestamp <= reportDto.EndDate.ToUniversalTime());

            var groupedOperations = await operations
                .GroupBy(x => new { 
                    x.OperationType, 
                    x.OperationDescription,
                    x.Timestamp.ToUniversalTime().Date 
                })
                .Select(group => new Report
                {
                    OperationType = group.Key.OperationType.ToString(),
                    OperationDescription = group.Key.OperationDescription.ToString(),
                    Date = group.Key.Date.ToShortDateString().ToString(),
                    Count = group.Count()
                })
                .ToListAsync();

            return new DataResult<List<Report>>(groupedOperations);
        }
    }
}
