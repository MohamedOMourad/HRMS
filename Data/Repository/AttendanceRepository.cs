using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using test.Models;

namespace test.Data.Repository
{
    public class AttendanceRepository : IAttendanceRepository
    {
        ApplicationDbContext applicationDbContext;
        public AttendanceRepository(ApplicationDbContext applicationDb)
        {
            applicationDbContext = applicationDb;
        }
        public List<Attendance> GetAll()
        {
            List<Attendance> EmployeeList = applicationDbContext.Attendances.ToList();
            return EmployeeList;
        }
        public List<Attendance> GetAllByDate(DateTime date)
        {
            var attendance=applicationDbContext.Attendances.Where(x => x.Date==date).ToList();
            return attendance;
        }
        public Attendance GetById(int id)
        {
            Attendance attendance = applicationDbContext.Attendances.FirstOrDefault(x => x.Id == id);
            return attendance;
        }
        public Attendance GetEmployeeId(int id)
        {
            Attendance attendance = applicationDbContext.Attendances.Where(x => x.Date == DateTime.Now.Date).FirstOrDefault(x => x.EmployeeId == id);
            return attendance;
        }
        public List<Attendance> GetMonthlyAttendance(int id, DateTime dt)
        {
            DateTime nDT = new DateTime(dt.Year, dt.Month, 1, 0, 0, 0);
            List<Attendance> attendance = applicationDbContext.Attendances.Where(x => ( x.Date.Month == nDT.Month && x.EmployeeId==id)&&( x.Absent == 1 || x.OverTime != new TimeSpan(0, 0, 0) || x.DiscountTime != new TimeSpan(0, 0, 0))).ToList();
            return attendance;
            
        }
        public int Insert(Attendance attendance)
        {
            applicationDbContext.Attendances.Add(attendance);
            int attendancee = applicationDbContext.SaveChanges();
            return attendancee;
        }
        public int Update( Attendance attendanceEdit)
        {
            
            EntityEntry UpdateAttendance = applicationDbContext.Entry(attendanceEdit);
            UpdateAttendance.State = EntityState.Modified;
            int AttendanceChanges = applicationDbContext.SaveChanges();
            return AttendanceChanges;
        }
        public int Delete(int id)
        {
            Attendance deleteAttendance = applicationDbContext.Attendances.FirstOrDefault(s => s.Id == id);
            applicationDbContext.Attendances.Remove(deleteAttendance);
            int deleteAttendancee = applicationDbContext.SaveChanges();
            return deleteAttendancee;
        }
        public bool IsDateExist( DateTime date )
        {            
             var data=GetAll().Find(x=>x.Date==date);
            if (data==null)
            {
                return false;
            }
            else return true;
        }
        public int CountCheckInEmployees()
        {
            return GetAllByDate(DateTime.Now.Date).Where(x => x.CheckIn != new TimeSpan()).Count();
        }
        public int CountCheckOutEmployees()
        {
            return GetAllByDate(DateTime.Now.Date).Where(x => x.CheckOut != new TimeSpan()).Count();
        }
        public int CountAbsentEmployees()
        {
            return GetAllByDate(DateTime.Now.Date).Where(x => x.Absent == 1).Count();
        }
      
    }
}
