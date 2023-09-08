using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EasyBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CustomerController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<IEnumerable<Customer>> Get()
        {
            return await _context.Customers.ToListAsync();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null) return Ok("User not found!");

            _context.Cards.Where(x => x.CustomerId == customer.Id).Load();

            return Ok(customer);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CustomerDto model)
        {
            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                Address = model.Address,
                FullName = model.FullName
            };

            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
            return Ok(customer);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] CustomerDto model)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null) return Ok("Customer not found!");

            var entry = _context.Entry(customer);
            entry.CurrentValues.SetValues(model);
            await _context.SaveChangesAsync();
            return Ok("Customer updated!");
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer is null) return Ok("Customer not found!");
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return Ok("Customer deleted!");
        }
    }
}
