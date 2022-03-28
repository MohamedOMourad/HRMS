using System;
using System.Collections.Generic;
using System.Linq;
using test.Data.Repository;
using test.Models;
using test.ViewModel;

namespace test.Services
{
    public class AttendanceService : IAttendanceService
    {
        IAttendanceRepository _attendanceRepository;
        IEmployeeReopsitory _employeeReopsitory;
        public AttendanceService(IAttendanceRepository attendaceReposatory, IEmployeeReopsitory employeeReposatory)

        {
            _attendanceRepository = attendaceReposatory;
            _employeeReopsitory = employeeReposatory;
        }
        public List<AttendenceViewModel> GetAllEmployee()
        {
            List<AttendenceViewModel> attendenceData = new();
            List<Employee> employees = _employeeReopsitory.GetAll();
            List<Attendance> attendances = _attendanceRepository.GetAllByDate(DateTime.Now.Date);


            foreach (var att in attendances)
            {
                var empId = employees.Find(e => e.Id == att.EmployeeId).Id;
                var empName = employees.Find(e => e.Id == att.EmployeeId).Name;

                attendenceData.Add(new AttendenceViewModel
                {
                    Id = empId,
                    Name = empName,
                    Date = att.Date,
                    CheckIn = att.CheckIn,
                    CheckOut = att.CheckOut
                });
            }
            return attendenceData;
        }
        public AttendenceViewModel GetEmployeeAttendance(int id)
        {
            Attendance attendance = _attendanceRepository.GetEmployeeId(id);
            Employee employee = _employeeReopsitory.GetById(id);
            AttendenceViewModel attendenceData = new AttendenceViewModel
            {
                Id = attendance.Id,
                Name = employee.Name,
                Date = attendance.Date,
                CheckIn = attendance.CheckIn,
                CheckOut = attendance.CheckOut
            };
            return attendenceData;
        }
        public void UpdateAttendance(AttendenceViewModel attendenceVM)
        {
            Attendance attendance = _attendanceRepository.GetEmployeeId(attendenceVM.Id);
            attendance.Date = attendenceVM.Date;
            attendance.Absent = 0;
            attendance.Attend = 1;
            attendance.CheckIn = attendenceVM.CheckIn;
            attendance.CheckOut = attendenceVM.CheckOut;
            attendance.DiscountTime = CalcDiscountTime(attendance.CheckIn);
            attendance.OverTime = CalcOverTime(attendance.CheckOut);
            _attendanceRepository.Update(attendance);

        }
        public TimeSpan CalcOverTime(TimeSpan CheckOut)
        {

            TimeSpan overTime = new TimeSpan();
            TimeSpan leaveTime = new TimeSpan(17, 00, 00);

            if (CheckOut > leaveTime)
            {
                overTime = CheckOut.Subtract(leaveTime);
            }
            return overTime;
        }
        public TimeSpan CalcDiscountTime(TimeSpan CheckIn)
        {
            TimeSpan discountTime = new TimeSpan();
            TimeSpan attendTime = new TimeSpan(09, 00, 00);

            if (CheckIn > attendTime)
            {
                discountTime = CheckIn.Subtract(attendTime);
            }
            return discountTime;
        }
        public int CountCheckIn()
        {
            return _attendanceRepository.CountCheckInEmployees();
        }
        public int CountCheckOut()
        {
            return _attendanceRepository.CountCheckOutEmployees();
        }
        public int CountCheckAbsent()
        {
            return _attendanceRepository.CountAbsentEmployees();
        }
    }
}
