using System.Collections.Generic;
using test.Data.Repository;
using test.Models;

namespace test.Services
{
    public class HolidayService : IHolidayService
    {
        IHolidayRepository _holidayRepository;
        public HolidayService(IHolidayRepository holidayRepository)
        {
            _holidayRepository = holidayRepository;
        }
        public List<Holidays> GetAll()
        {
            return _holidayRepository.GetAll();
        }
        public void AddHoliday(Holidays holiday)
        {
            _holidayRepository.Insert(holiday);
        }
        public Holidays GetUpdateHoliday(int id)
        {
            return _holidayRepository.GetById(id);
        }
        public void PostUpdateHoliday( Holidays holidays)
        {
            _holidayRepository.Update( holidays);
        }
    }
}
