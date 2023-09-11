using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Director")]
    public class ReportController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ReportController(AppDbContext context) 
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post(ReportDto reportDto)
        {
            var operations = _context.History
                .Where(x => x.EmployeeId == reportDto.EmployeeId
                    && x.Timestamp >= reportDto.StartDate
                    && x.Timestamp <= reportDto.EndDate);

            var groupedOperations = operations
                .GroupBy(x => new { x.OperationType, x.Timestamp.Date })
                .Select(group => new
                {
                    OperationType = group.Key.OperationType,
                    Date = group.Key.Date,
                    Count = group.Count()
                })
                .ToList();

            var info = groupedOperations.Select(item =>
                $"{item.OperationType.ToString()}: {item.Count} операций ({item.Date:yyyy-MM-dd})");

            var report = new Report()
            {
                Id = Guid.NewGuid(),
                EmployeeId = reportDto.EmployeeId,
                StartDate = reportDto.StartDate,
                EndDate = reportDto.EndDate,
                OperationInfo = string.Join("\n", info)
            };

            return Ok(report);
        }
    }
}
