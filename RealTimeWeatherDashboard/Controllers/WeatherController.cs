using Microsoft.AspNetCore.Mvc;
using RealTimeWeatherDashboard.Services;

namespace RealTimeWeatherDashboard.Controllers
{
    public class WeatherController : Controller
    {
        private readonly WeatherService _weatherService;

        public WeatherController (WeatherService weatherService) 
        { 
            _weatherService = weatherService; 
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetWeather(string city)
        {
            var WeatherData = await _weatherService.GetWeatherDataAsync(city);
            return PartialView("_WeatherPartial", WeatherData);
        }
    }
}
