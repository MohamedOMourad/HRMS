using System;
using System.Collections.Generic;
using test.Data.Repository;
using test.Models;

namespace test.Services
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeReopsitory _employeeReopsitory;
        IAttendanceRepository _attendanceRepository;
        public EmployeeService(IEmployeeReopsitory employeeReopsitory, IAttendanceRepository attendanceRepository)
        {
            _employeeReopsitory = employeeReopsitory;
            _attendanceRepository = attendanceRepository;
        }
        public List<Employee> GetAllEmployees()
        {
            return _employeeReopsitory.GetAll();
        }
        public void AddEmployee(Employee employee)
        {
            _employeeReopsitory.Insert(employee);

            //make employee absent before start work 
            DateTime dt = new DateTime(employee.StartWork.Year, employee.StartWork.Month, 1);
            for (; dt <= employee.StartWork; dt = dt.AddDays(1))
            {
                Attendance att = new Attendance()
                {
                    Absent = 1,
                    Attend = 0,
                    CheckIn = new System.TimeSpan(),
                    CheckOut = new System.TimeSpan(),
                    DiscountTime = System.TimeSpan.Zero,
                    OverTime = System.TimeSpan.Zero,
                    EmployeeId = employee.Id,
                    Date = dt
                };
                _attendanceRepository.Insert(att);
            }
        }
        public Employee GetUpdate(int id)
        {
            return _employeeReopsitory.GetById(id);
        }
        public void PostUpdate( Employee employee)
        {
            _employeeReopsitory.Update( employee);
        }
        public Employee Details(int id)
        {
            return _employeeReopsitory.GetById(id);
        }
        public void Delete(int id)
        {
            _employeeReopsitory.Delete(id);
        }
        public int CountEmployee()
        {
            return GetAllEmployees().Count;
        }
    }
}
