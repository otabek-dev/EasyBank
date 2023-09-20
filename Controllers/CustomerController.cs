using EasyBank.DTOs;
using EasyBank.Models;
using EasyBank.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin,Director,Employee")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _customerService;
        private readonly HistoryService _historyService;

        public CustomerController(CustomerService customerService, HistoryService historyService)
        {
            _customerService = customerService;
            _historyService = historyService;
        }

        // GET: api/<CustomerController>
        [HttpGet("/api/Customers")]
        public async Task<IActionResult> Get()
        {
            await _historyService.CreateHistoyrAsync(User,
                OperationType.Customer, OperationDescription.ReadCustomer);

            var customers = await _customerService.GetCustomersAsync();
            return Ok(customers);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            await _historyService.CreateHistoyrAsync(User,
                OperationType.Customer, OperationDescription.ReadCustomer);

            var customer = await _customerService.GetCustomerByIdAsync(id);
            return Ok(customer);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CustomerDto model)
        {
            await _historyService.CreateHistoyrAsync(User,
                OperationType.Customer, OperationDescription.CreateCustomer);

            var newCustomer = await _customerService.CreateCustomerAsync(model);
            return Ok(newCustomer);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] CustomerDto model)
        {
            await _historyService.CreateHistoyrAsync(User,
                OperationType.Customer, OperationDescription.UpdateCustomer);
            var updCustomer = await _customerService.UpdateCustomerAsync(id, model);
            return Ok(updCustomer);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _historyService.CreateHistoyrAsync(User,
                OperationType.Customer, OperationDescription.DeleteCustomer);
            await _customerService.DeleteCustomerAsync(id);
            return Ok();
        }
    }
}
