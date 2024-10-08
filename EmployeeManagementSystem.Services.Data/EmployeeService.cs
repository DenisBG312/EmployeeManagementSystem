﻿using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Data.Models;
using EmployeeManagementSystem.Services.Data.Interfaces;
using EmployeeManagementSystem.Web.ViewModels.Employee;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EmployeeManagementSystem.Services.Data
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeManagementDbContext dbContext;

        public EmployeeService(EmployeeManagementDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddEmployee(AddEmployeeFormModel employeeModel)
        {
            Employee newEmployee = new Employee()
            {
                FirstName = employeeModel.FirstName,
                LastName = employeeModel.LastName,
                DateOfBirth = employeeModel.DateOfBirth,
                Email = employeeModel.Email,
                DateOfHire = employeeModel.DateOfHire,
                PhoneNumber = employeeModel.PhoneNumber,
                Role = employeeModel.Role
            };

            await dbContext.Employees.AddAsync(newEmployee);
            await dbContext.SaveChangesAsync();
        }

        public async Task<EditEmployeeFormModel> GetEmployeeById(int id)
        {
            var employee = await dbContext.Employees
                .FirstOrDefaultAsync(e => e.Id == id);

            if (employee == null)
            {
                throw new ArgumentNullException();
            }

            var employeeSearch = new EditEmployeeFormModel()
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                DateOfBirth = employee.DateOfBirth,
                DateOfHire = employee.DateOfHire,
                PhoneNumber = employee.PhoneNumber,
                Role = employee.Role
            };

            return employeeSearch;

        }

        public async Task EditEventById(int id, EditEmployeeFormModel model)
        {
            var employeeToEdit = await dbContext.Employees
                .FirstAsync(e => e.Id == id);

            employeeToEdit.FirstName = model.FirstName;
            employeeToEdit.LastName = model.LastName;
            employeeToEdit.DateOfHire = model.DateOfHire;
            employeeToEdit.PhoneNumber = model.PhoneNumber;
            employeeToEdit.Email = model.Email;
            employeeToEdit.Role = model.Role;
            employeeToEdit.DateOfBirth = model.DateOfBirth;

            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteEventById(int id)
        {
            var employee = await dbContext.Employees.FindAsync(id);

            if (employee == null)
            {
                throw new ArgumentNullException();
            }

            employee.IsDeleted = true;
            dbContext.Employees.Update(employee);
            await dbContext.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            var allEmployees = await dbContext.Employees.ToListAsync();

            return allEmployees;
        }

        public async Task<EditEmployeeFormModel> GetEmployeeDetailsById(int id)
        {
            var employeeModel = await dbContext.Employees.FindAsync(id);

            if (employeeModel == null)
            {
                throw new ArgumentNullException();
            }

            var employeeDetails = new EditEmployeeFormModel()
            {
                FirstName = employeeModel.FirstName,
                LastName = employeeModel.LastName,
                Email = employeeModel.Email,
                DateOfBirth = employeeModel.DateOfBirth,
                DateOfHire = employeeModel.DateOfHire,
                PhoneNumber = employeeModel.PhoneNumber,
                Role = employeeModel.Role
            };

            return employeeDetails;
        }
    }
}
