using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            // Получаем операции для выбранного сотрудника в заданном временном интервале
            var operations = _context.History
                .Where(x => x.EmployeeId == reportDto.EmployeeId
                    && x.Timestamp >= reportDto.StartDate
                    && x.Timestamp <= reportDto.EndDate);

            // Группируем операции по типу и дате выполнения
            var groupedOperations = operations
                .GroupBy(x => new { x.OperationType, x.Timestamp.Date })
                .Select(group => new
                {
                    OperationType = group.Key.OperationType,
                    Date = group.Key.Date,
                    Count = group.Count()
                })
                .ToList();

            // Формируем информацию для отчета
            var info = groupedOperations.Select(item =>
                $"{item.OperationType.ToString()}: {item.Count} операций ({item.Date:yyyy-MM-dd})");

            // Создаем объект отчета
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
