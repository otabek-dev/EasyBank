using EasyBank.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyBank
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
                Email = faker.Person.Email,
                FullName = faker.Person.FullName,
                Password = "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==",
                Position = "Developer",
                Role = "Admin",
                Phone = faker.Person.Phone
            };
            _modelBuilder.Entity<Employee>().HasData(adminUser);

            // Add 10 users
            for (int i = 0; i < 10; i++)
            {
                faker = new Bogus.Faker();
                var user = new Employee
                {
                    Id = Guid.NewGuid(),
                    Email = faker.Person.Email,
                    FullName = faker.Person.FullName,
                    Password = "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==",
                    Position = positions[faker.Random.Int(0,3)],
                    Role = role[faker.Random.Int(0, 2)],
                    Phone = faker.Person.Phone
                };
                _modelBuilder.Entity<Employee>().HasData(user);
            }
        }
    }
}
