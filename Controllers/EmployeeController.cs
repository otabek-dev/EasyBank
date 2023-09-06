using EasyBank.DTOs;
using EasyBank.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;

namespace EasyBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        // GET: api/<Employee>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _context.Employees.ToList();
        }

        // GET api/<Employee>/5
        [HttpGet("{id}")]
        public Employee Get(Guid id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.Id == id);
            return employee;
        }

        // POST api/<Employee>
        [HttpPost]
        public void Post([FromBody] EmployeeDto emp)
        {
            var employee = new Employee() 
            { 
                Id = Guid.NewGuid(),
                Email = emp.Email,
                FullName = emp.FullName,
                Password = emp.Password,
                Position = emp.Position,
                Role = "Employee",
                Phone = emp.Phone
            };

            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
        
        // PUT api/<Employee>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] EmployeeDto emp)
        {
            var employee = new Employee()
            {
                Id = id,
                Email = emp.Email,
                FullName = emp.FullName,
                Password = emp.Password,
                Position = emp.Position,
                Role = "Employee",
                Phone = emp.Phone
            };

            _context.Employees.Update(employee);
            _context.SaveChanges();
        }

        // DELETE api/<Employee>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var employee = _context.Employees.First(e => e.Id == id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }
    }
}
