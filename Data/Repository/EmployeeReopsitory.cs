using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Linq;
using test.Models;

namespace test.Data.Repository
{
    public class EmployeeReopsitory : IEmployeeReopsitory
    {
        ApplicationDbContext applicationDbContext;
        public EmployeeReopsitory(ApplicationDbContext applicationDb)
        {
            applicationDbContext = applicationDb;
        }

        public List<Employee> GetAll()
        {
            List<Employee> EmployeeList = applicationDbContext.Employees.ToList();
            return EmployeeList;
        }
        public Employee GetById(int id)
        {
            Employee employee = applicationDbContext.Employees.FirstOrDefault(x => x.Id == id);
            return employee;
        }
        public Employee GetByName(string name)
        {
            Employee Employee = applicationDbContext.Employees.FirstOrDefault(x => x.Name == name);
            return Employee;
        }
        public int Insert(Employee employee)
        {
            applicationDbContext.Employees.Add(employee);
            int newEmployee = applicationDbContext.SaveChanges();
            return newEmployee;
        }
        public void Update( Employee employeeEdit)
        {
            
            EntityEntry UpdateEmployee = applicationDbContext.Entry(employeeEdit);
            UpdateEmployee.State=EntityState.Modified;
            applicationDbContext.SaveChanges();
            
        }
        public int Delete(int id)
        {
            Employee deleteEmployee = applicationDbContext.Employees.FirstOrDefault(s => s.Id == id);
            applicationDbContext.Employees.Remove(deleteEmployee);
            int deleteEmployeee = applicationDbContext.SaveChanges();
            return deleteEmployeee;
        }
    }
}
