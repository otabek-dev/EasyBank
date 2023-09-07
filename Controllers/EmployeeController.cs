using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.Models;
using EasyBank.Services;
using Microsoft.AspNetCore.Mvc;

namespace EasyBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService ,AppDbContext dbContext)
        {
            _context = dbContext;
            _employeeService = employeeService;
        }

        // GET: api/<Employee>
        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {
            return await _employeeService.GetAllEmployee();
        }

        // GET api/<Employee>/5
        [HttpGet("{id}")]
        public async Task<Employee> Get(Guid id)
        {
            return await _employeeService.GetEmployeeById(id);
        }

        // POST api/<Employee>
        [HttpPost]
        public async Task Post([FromBody] EmployeeDto employee)
        {
            await _employeeService.CreateEmployee(employee);
        }
        
        // PUT api/<Employee>/5
        [HttpPut("{id}")]
        public async Task Put(Guid id, [FromBody] EmployeeDto emp)
        {
            await _employeeService.UpdateEmployee(id, emp);
        }

        // DELETE api/<Employee>/5
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _employeeService.DeleteEmployee(id);
        }
    }
}
