using test.Data.ViewModels;
using test.Services;

namespace test.Data.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly IAttendanceService attendanceService;
        private readonly IEmployeeService employeeService;

        public DashboardService(IAttendanceService attendanceService, IEmployeeService employeeService)

        {
            this.attendanceService = attendanceService;
            this.employeeService = employeeService;
        }
        public DashboardViewModel Index()
        {
            DashboardViewModel dashboardVM = new DashboardViewModel();
            dashboardVM.attendenceViewModels = attendanceService.GetAllEmployee();
            dashboardVM.EmployeeNumber = employeeService.CountEmployee();
            dashboardVM.AbsentNumber = attendanceService.CountCheckAbsent();
            dashboardVM.CheckInNumber = attendanceService.CountCheckIn();
            dashboardVM.CheckOutNumber = attendanceService.CountCheckOut();
            if (dashboardVM.EmployeeNumber==0)
            {
                dashboardVM.AbsentAvg = 0;
                dashboardVM.CheckInAvg = 0;
                dashboardVM.CheckOutAvg = 0;
            }
            else
            {
                dashboardVM.AbsentAvg = (dashboardVM.AbsentNumber / dashboardVM.EmployeeNumber) * 100;
                dashboardVM.CheckInAvg = (dashboardVM.CheckInNumber / dashboardVM.EmployeeNumber) * 100;
                dashboardVM.CheckOutAvg = (dashboardVM.CheckOutNumber / dashboardVM.EmployeeNumber) * 100;
            }

            return dashboardVM;
        }
    }
}
