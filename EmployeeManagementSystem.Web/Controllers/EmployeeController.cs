using EmployeeManagementSystem.Services.Data.Interfaces;
using EmployeeManagementSystem.Web.ViewModels.Employee;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await employeeService.AddEmployee(model);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (!id.HasValue)
            {
                return RedirectToAction("Index", "Home");
            }

            try
            {
                var formModel = await employeeService.GetEventById(id.Value);

                return View(formModel);
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, EditEmployeeFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await employeeService.EditEventById(id.Value, model);

                return RedirectToAction("All", "Employee");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (!id.HasValue)
            {
                throw new InvalidOperationException();
            }

            await employeeService.DeleteEventById(id.Value);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> All()
        {
            var employees = await employeeService.GetAllEmployees();

            return View(employees);
        }
    }
}
