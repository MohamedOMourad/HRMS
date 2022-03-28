using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using test.Services;

namespace test.Controllers
{
    [Authorize]
    public class SalaryReportController : Controller
    {
        private readonly ISalaryReportService salaryReportService;
        

        public SalaryReportController(ISalaryReportService salaryReportService)
        {
            this.salaryReportService = salaryReportService;
            
        }
        
        public IActionResult Index(int year=2022,int month =3)
        {
            ViewData["Year"] = year;
            ViewData["Month"] = month;
            return View("Index", salaryReportService.Index( year,  month));
        }
        public IActionResult MonthDtails(int Id,int Month,int Year)
        {
            var emp=salaryReportService.GetEmployee( Id);
            ViewData["Name"] = emp.Name;
            ViewData["Id"] = Id;
            return View(salaryReportService.MonthDtails(Id,Month,Year));
        }
        
    }
}
