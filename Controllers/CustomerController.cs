using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.Models;
using EasyBank.Services;
using Microsoft.AspNetCore.Mvc;

namespace EasyBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
        [HttpGet]
        public async Task<IEnumerable<Customer>> Get()
        {
            await _historyService.CreateHistoyr(User, 
                OperationType.Customer, OperationDescription.ReadCustomer);

            var customers = await _customerService.GetCustomers();
            return customers;
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<Customer> Get(Guid id)
        {
            await _historyService.CreateHistoyr(User, 
                OperationType.Customer, OperationDescription.ReadCustomer);

            var customer = await _customerService.GetCustomerById(id);
            return customer;
        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CustomerDto model)
        {
            await _historyService.CreateHistoyr(User, 
                OperationType.Customer, OperationDescription.CreateCustomer);

            var newCustomer = await _customerService.CreateCustomer(model);
            return Ok(newCustomer);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] CustomerDto model)
        {
            await _historyService.CreateHistoyr(User,
                OperationType.Customer, OperationDescription.UpdateCustomer);
            var updCustomer = await _customerService.UpdateCustomer(id, model);
            return Ok(updCustomer);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _historyService.CreateHistoyr(User,
                OperationType.Customer, OperationDescription.DeleteCustomer);
            await _customerService.DeleteCustomer(id);
            return Ok();
        }
    }
}
