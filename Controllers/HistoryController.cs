using EasyBank.DB;
using EasyBank.Models;
using EasyBank.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin,Director")]
    public class HistoryController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HistoryController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/<HistoryController>
        [HttpGet]
        public DataResult<List<History>> Get()
        {
            var result = _context.History.ToList();
            return new DataResult<List<History>>(result);
        }
    }
}
