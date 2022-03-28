using System.Collections.Generic;
using test.ViewModel;

namespace test.Data.ViewModels
{
    public class DashboardViewModel
    {
        public double EmployeeNumber { get; set; }
        public double AbsentNumber { get; set; }
        public double CheckInNumber { get; set; }
        public double CheckOutNumber { get; set; }
        public double CheckInAvg { get; set; }
        public double CheckOutAvg { get; set; }
        public double AbsentAvg { get; set; }
        public List<AttendenceViewModel> attendenceViewModels { get; set; }


    }
}
