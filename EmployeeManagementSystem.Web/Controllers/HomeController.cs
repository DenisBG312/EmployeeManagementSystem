using EmployeeManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using EmployeeManagementSystem.Data;

namespace EmployeeManagementSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeManagementDbContext dbContext;

        public HomeController(EmployeeManagementDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
