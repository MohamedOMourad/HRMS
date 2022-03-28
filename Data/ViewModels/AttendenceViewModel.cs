using System;
using test.Data.Validate;

namespace test.ViewModel
{
    public class AttendenceViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan CheckIn { get; set; }
       // [AttendanceValidation]
        public TimeSpan CheckOut { get; set; }

    }
}
