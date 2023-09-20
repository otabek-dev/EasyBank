using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.Models;
using EasyBank.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EasyBank.Services
{
    public class CustomerService
    {
        private readonly AppDbContext _context;

        public CustomerService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Result> GetCustomersAsync()
        {
            var customers = await _context.Customers.ToListAsync();
            return new DataResult<List<Customer>>(customers);
        }

        public async Task<Result> GetCustomerByIdAsync(Guid id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
                return new Result(false, "Customer not found!");

            _context.Cards.Where(x => x.CustomerId == customer.Id).Load();
            return new DataResult<Customer>(customer);
        }

        public async Task<Result> CreateCustomerAsync([FromBody] CustomerDto model)
        {
            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                Address = model.Address,
                FullName = model.FullName
            };

            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();

            return new DataResult<Customer>(customer, true, "Customer created!");
        }

        public async Task<Result> UpdateCustomerAsync(Guid id, CustomerDto model)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null) 
                return new Result(false, "Customer not found!");

            var entry = _context.Entry(customer);
            entry.CurrentValues.SetValues(model);
            await _context.SaveChangesAsync();
            return new DataResult<Customer>(entry.Entity, true, "Customer Updated");
        }

        public async Task<Result> DeleteCustomerAsync(Guid id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer is null)
                return new Result(false, "Customer not found!");

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return new Result(true, "Customer deleted!");
        }
    }
}
