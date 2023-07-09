using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;
        private readonly IWeatherService _obj2;

        public WeatherController(IWeatherService weatherService,IWeatherService obj2)
        {
            _weatherService = weatherService;
            _obj2 = obj2;
        }

        [HttpGet]
        public IActionResult GetWeather()
        {
            List<string> listResult = new List<string>();
            listResult.Add(_weatherService.GetWeather());
            listResult.Add(_weatherService.guid.ToString());
            listResult.Add(_obj2.guid.ToString());
            string weather = _weatherService.GetWeather();
            Guid newGuid = _weatherService.guid;
            //return Ok(weather);
            return new JsonResult(listResult);
        }
        [HttpGet]
        public IActionResult TransientResult()
        {
            List<string> listResult = new List<string>();
            listResult.Add(_weatherService.GetWeather());
            listResult.Add(_weatherService.guid.ToString());
            listResult.Add(_obj2.guid.ToString());
            string weather = _weatherService.GetWeather();
            Guid newGuid = _weatherService.guid;
            //return Ok(weather);
            return new JsonResult(listResult);
        }
    }
}
