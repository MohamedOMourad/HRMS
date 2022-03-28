using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using test.Models;

namespace test.Data.Repository
{
    public class HolidayRepository : IHolidayRepository
    {
        ApplicationDbContext applicationDbContext;
        public HolidayRepository(ApplicationDbContext applicationDb)
        {
            applicationDbContext = applicationDb;
        }
        public List<Holidays> GetAll()
        {
            List<Holidays> holdaiesList = applicationDbContext.Holidays.ToList();
            return holdaiesList;
        }
        public Holidays GetById(int id)
        {
            Holidays holidays = applicationDbContext.Holidays.FirstOrDefault(x => x.Id == id);
            return holidays;
        }
        public bool CheckIsHoliday(DateTime dt)
        {
            List<Holidays> holidies = GetAll();
            foreach (var holiday in holidies)
            {
                if (holiday.Date == dt.Date)
                {
                    return true;
                }
            }
           
            return false;
        }

        public int Insert(Holidays holidays)
        {
            applicationDbContext.Holidays.Add(holidays);
            int holidayes = applicationDbContext.SaveChanges();
            return holidayes;
        }
        public int Update(Holidays holidays)
        {            
            EntityEntry UpdateAttendance = applicationDbContext.Entry(holidays);
            UpdateAttendance.State = EntityState.Modified;
            int holidaysChanges = applicationDbContext.SaveChanges();
            return holidaysChanges;
        }
        public int Delete(int id)
        {
            Holidays deleteHoliday = applicationDbContext.Holidays.FirstOrDefault(s => s.Id == id);
            applicationDbContext.Holidays.Remove(deleteHoliday);
            int deleteeHoliday = applicationDbContext.SaveChanges();
            return deleteeHoliday;
        }
    }
}
