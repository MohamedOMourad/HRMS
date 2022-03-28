using System.Collections.Generic;
using test.Models;

namespace test.Services
{
    public interface IEmployeeService
    {
        void AddEmployee(Employee employee);
        void Delete(int id);
        Employee Details(int id);
        Employee GetUpdate(int id);
        void PostUpdate( Employee employee);
        List<Employee> GetAllEmployees();
        int CountEmployee();
    }
}