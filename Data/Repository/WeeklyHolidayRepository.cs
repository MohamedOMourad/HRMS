using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using test.Models;

namespace test.Data.Repository
{

    public class WeeklyHolidayRepository : IWeeklyHolidayRepository
    {
        ApplicationDbContext applicationDbContext;
        public WeeklyHolidayRepository(ApplicationDbContext applicationDb)
        {
            applicationDbContext = applicationDb;
        }
        
        public List<WeeklyHoliday> GetAll()
        {
            List<WeeklyHoliday> weeklyHoldaiesList = applicationDbContext.WeeklyHolidays.ToList();
            return weeklyHoldaiesList;
        }
        public List<WeeklyHoliday> GetAllDaysOff()
        {
            List<WeeklyHoliday> weeklyHoldaiesList = applicationDbContext.WeeklyHolidays.Where(h=>h.IsDayOff==true).ToList();
            return weeklyHoldaiesList;
        }
        public bool CheckIsWeeklyHoliday(DateTime dt)
        {           
            foreach (var holiday in GetAllDaysOff())
            {
                if (holiday.Name ==dt.DayOfWeek.ToString())
                {
                    return true;
                }
            }

            return false;
        }
        public WeeklyHoliday GetById(int id)
        {
            WeeklyHoliday weeklyHolidays = applicationDbContext.WeeklyHolidays.FirstOrDefault(x => x.Id == id);
            return weeklyHolidays;
        }

        public int Update( int id,WeeklyHoliday weeklyHoliday)
        {
            EntityEntry UpdateAttendance = applicationDbContext.Entry(weeklyHoliday);
            UpdateAttendance.State = EntityState.Modified;
            int weeklyHolidayChanges = applicationDbContext.SaveChanges();
            return weeklyHolidayChanges;
        }

    }
}
