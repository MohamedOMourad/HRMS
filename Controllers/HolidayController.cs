using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using test.Data.Repository;
using test.Models;
using test.Services;

namespace test.Controllers
{
    [Authorize]
    public class HolidayController : Controller
    {
        private readonly IHolidayService holidayService;

        public HolidayController(IHolidayService holidayService)
        {
            this.holidayService = holidayService;
        }
        public IActionResult Index()
        {
            return View(holidayService.GetAll());
        }

        [HttpGet]
        public IActionResult AddHoliday() 
        {
            return View(); 
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult AddHoliday(Holidays holiday)
        {
            holidayService.AddHoliday(holiday);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateHoliday(int id)
        {
            return View(holidayService.GetUpdateHoliday(id));
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult UpdateHoliday( Holidays holidays)
        {
            holidayService.PostUpdateHoliday(holidays);           
            return RedirectToAction(nameof(Index));

        }


    }
}
