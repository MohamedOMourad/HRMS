using System.Collections.Generic;
using test.ViewModel;

namespace test.Services
{
    public interface IAttendanceService
    {
        List<AttendenceViewModel> GetAllEmployee();
        AttendenceViewModel GetEmployeeAttendance(int id);
        void UpdateAttendance(AttendenceViewModel attendenceVM);
        int CountCheckIn();
        int CountCheckOut();
        int CountCheckAbsent();
    }
}