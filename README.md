# EasyBank
## Create EndPoints for CRUD Operations for Bank Employees
1. Create an EndPoint for creating an employee with the following fields:
   - Full Name
   - Position
   - Role
   - Additional fields for system work
2. Create an EndPoint for reading (retrieving) employee information.
3. Create an EndPoint for updating employee information.
4. Create an EndPoint for deleting an employee from the system.
5. Define user roles: Administrator, Director, Employee.
6. Implement role management:
   - Role "Administrator":
     - Create, delete, and edit users.
     - System management access.
   - Role "Director":
     - Monitoring of employees.
   - Role "Employee":
     - Interaction with clients.
---
## Implement EndPoints for CRUD Operations with Bank Customers and Manage Cards
1. Create an EndPoint for creating a customer with the following fields:
   - Full Name
   - Address
   - Card ID (related to the cards table)
2. Create an EndPoint for reading (retrieving) customer information.
3. Create an EndPoint for updating customer information.
4. Create an EndPoint for deleting a customer from the system.
5. Create EndPoints for operations related to customer cards:
   - Generate a new card for a customer.
   - Modify certain card parameters, such as the PIN code.
   - Block/unblock a customer's card.
   - Deactivate a customer's card.
6. Record all customer and card operations in the History table, including the operation type, operator ID and timestamp.
---
### Implement an EndPoint for Directors to Generate Employee Performance Reports
1. Create an EndPoint for directors that allows them to generate reports on employee performance.
2. The report should include the following information:
   - The quantity and type of operations performed by the selected employee.
   - Breakdown of operations by their execution dates.

![Alt text](https://github.com/otabek-dev/EasyBank/blob/master/apiEasyBank.png)
