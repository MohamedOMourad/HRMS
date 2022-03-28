using System.Collections.Generic;
using test.Models;

namespace test.Services
{
    public interface IHolidayService
    {
        void AddHoliday(Holidays holiday);
        List<Holidays> GetAll();
        Holidays GetUpdateHoliday(int id);
        void PostUpdateHoliday( Holidays holidays);
    }
}