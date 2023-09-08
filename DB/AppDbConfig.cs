﻿using EasyBank.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyBank.DB
{
    public class AppDbConfig
    {
        private readonly ModelBuilder _modelBuilder;

        public AppDbConfig(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        public void Configure()
        {
            var faker = new Bogus.Faker();

            var positions = new List<string>() { "developer", "hr", "cook", "security" };
            var role = new List<string>() { "Admin", "Director", "Employee" };

            // Add 1 admin
            var adminUser = new Employee
            {
                Id = Guid.NewGuid(),
                Email = "otabek.pro@hotmail.com",
                FullName = "Otabek Rustamov",
                Password = "123123123",
                Position = "Developer",
                Role = "Admin",
                Phone = faker.Person.Phone
            };
            _modelBuilder.Entity<Employee>().HasData(adminUser);

            // Add 5 users
            for (int i = 0; i < 5; i++)
            {
                var user = new Employee
                {
                    Id = Guid.NewGuid(),
                    Email = faker.Person.Email,
                    FullName = faker.Person.FullName,
                    Password = "123123123",
                    Position = positions[faker.Random.Int(0, 3)],
                    Role = role[faker.Random.Int(0, 2)],
                    Phone = faker.Person.Phone
                };
                _modelBuilder.Entity<Employee>().HasData(user);
            }

            // Add 10 customers and cards
            for (int i = 0; i < 10; i++)
            {
                var customer = new Customer
                {
                    Id = Guid.NewGuid(),
                    FullName = faker.Person.FullName,
                    Address = faker.Person.Phone
                };

                var card = new Card
                {
                    Id = Guid.NewGuid(),
                    CardNumber = faker.Finance.CreditCardNumber(),
                    PinCode = faker.Finance.CreditCardCvv(),
                    CustomerId = customer.Id,
                };

                _modelBuilder.Entity<Customer>().HasData(customer);
                _modelBuilder.Entity<Card>().HasData(card);
            }
        }
    }
}
