using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using test.Services;
using test.ViewModel;

namespace test.Controllers
{
    [Authorize]
    public class AttendanceController : Controller
    {
        private readonly IAttendanceService attendanceService;

        public AttendanceController(IAttendanceService attendanceService)

        {
            this.attendanceService = attendanceService;
        }

        public IActionResult Index()
        {

            return View(attendanceService.GetAllEmployee());
        }

        public IActionResult getEmployeeAttendance(int id)
        {
            return PartialView("_getEmployeeAttendance", attendanceService.GetEmployeeAttendance(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateAttendance(AttendenceViewModel attendenceVM)
        {
            if (ModelState.IsValid && attendenceVM.CheckIn < attendenceVM.CheckOut)

                attendanceService.UpdateAttendance(attendenceVM);

            return RedirectToAction("Index");
        }

    }
}
