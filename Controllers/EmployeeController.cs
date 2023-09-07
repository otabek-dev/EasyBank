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
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: api/<Employee>
        [HttpGet]
        [Authorize(Roles = "Admin,Director")]
        public async Task<IEnumerable<Employee>> Get()
        {
            return await _employeeService.GetAllEmployee();
        }

        // GET api/<Employee>/5
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,Director")]
        public async Task<IActionResult> Get(Guid id)
        {
            return await _employeeService.GetEmployeeById(id);
        }

        // POST api/<Employee>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Post([FromBody] EmployeeDto employee)
        {
            return await _employeeService.CreateEmployee(employee);
        }
        
        // PUT api/<Employee>/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Put(Guid id, [FromBody] EmployeeDto emp)
        {
            return await _employeeService.UpdateEmployee(id, emp);
        }

        // DELETE api/<Employee>/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return await _employeeService.DeleteEmployee(id);
        }
    }
}
