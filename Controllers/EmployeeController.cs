using EasyBank.DTOs;
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
        [HttpGet("/api/Employees")]
        [Authorize(Roles = "Admin,Director")]
        public async Task<IActionResult> Get()
        {
            var employees = await _employeeService.GetAllEmployee();
            return Ok(employees);
        }

        // GET api/<Employee>/5
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,Director")]
        public async Task<IActionResult> Get(Guid id)
        {
            var employee = await _employeeService.GetEmployeeById(id);
            return Ok(employee);
        }

        // POST api/<Employee>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Post([FromBody] EmployeeDto employee)
        {
            var result = await _employeeService.CreateEmployee(employee);
            return Ok(result);
        }

        // PUT api/<Employee>/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Put(Guid id, [FromBody] EmployeeDto emp)
        {
            var result = await _employeeService.UpdateEmployee(id, emp);
            return Ok(result);
        }

        // DELETE api/<Employee>/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _employeeService.DeleteEmployee(id);
            return Ok(result);
        }
    }
}
