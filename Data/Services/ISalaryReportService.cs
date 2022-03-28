using System.Collections.Generic;
using test.Data.ViewModels;
using test.Models;

namespace test.Services
{
    public interface ISalaryReportService
    {
        List<Attendance> MonthDtails(int Id, int Month, int Year);
        List<SalaryReportViewModel> Index(int year, int month);
        Employee GetEmployee(int id);
    }
}