using Microsoft.AspNetCore.Mvc;

namespace PrimeiraApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController()
        {
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
