using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using test.Models;
using test.Services;

namespace test.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {

        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public IActionResult GetAllEmployees()
        {
            
            return View(employeeService.GetAllEmployees());
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult AddEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeService.AddEmployee(employee);
                return RedirectToAction("GetAllEmployees");
            }
            return View();
        }

        [HttpGet]
        public IActionResult updateEmployee(int id)
        {
            return View(employeeService.GetUpdate(id));
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult updateEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeService.PostUpdate( employee);
                return RedirectToAction(nameof(GetAllEmployees));
            }
            return View("updateEmployee", employee.Id);
        }

        [HttpGet]
        public IActionResult DetailsEmployee(int id)
        {
            return View(employeeService.Details(id));
        }
        
        public IActionResult DeleteEmployee(int id)
        {
            employeeService.Delete(id);
            return RedirectToAction("GetAllEmployees");
        }

    }
}
