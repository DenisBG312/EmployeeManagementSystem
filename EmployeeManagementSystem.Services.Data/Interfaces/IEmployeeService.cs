using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem.Data.Models;
using EmployeeManagementSystem.Web.ViewModels.Employee;

namespace EmployeeManagementSystem.Services.Data.Interfaces
{
    public interface IEmployeeService
    {
        Task AddEmployee(AddEmployeeFormModel employeeModel);
        Task<EditEmployeeFormModel> GetEmployeeById(int id);
        Task EditEventById(int id, EditEmployeeFormModel model);
        Task DeleteEventById(int id);
        Task<List<Employee>> GetAllEmployees();
        Task<EditEmployeeFormModel> GetEmployeeDetailsById(int id);
    }
}
