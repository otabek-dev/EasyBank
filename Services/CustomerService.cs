using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EasyBank.Services
{
    public class CustomerService
    {
        private readonly AppDbContext _context;
        private readonly HistoryService _historyService;

        public CustomerService(AppDbContext context, HistoryService historyService)
        {
            _context = context;
            _historyService = historyService;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            //await _historyService.CreateHistoyr(User, "get all");

            var customers = await _context.Customers.ToListAsync();
            return customers;
        }

        public async Task<Customer> GetCustomerById(Guid id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null) return null;
            _context.Cards.Where(x => x.CustomerId == customer.Id).Load();
            return customer;
        }

        public async Task<Customer> CreateCustomer([FromBody] CustomerDto model)
        {
            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                Address = model.Address,
                FullName = model.FullName
            };

            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer> UpdateCustomer(Guid id, CustomerDto model)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null) return null;

            var entry = _context.Entry(customer);
            entry.CurrentValues.SetValues(model);
            await _context.SaveChangesAsync();
            return entry.Entity;
        }

        public async Task DeleteCustomer(Guid id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer is null) return;
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
        }
    }
}
