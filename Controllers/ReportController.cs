using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.Models;
using EasyBank.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin,Director")]
    public class ReportController : ControllerBase
    {
        private readonly ReportService _reportService;

        public ReportController(ReportService reportService) 
        {
            _reportService = reportService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(ReportDto reportDto)
        {
            var result = await _reportService.CreateReport(reportDto);
            return Ok(result);
        }
    }
}
