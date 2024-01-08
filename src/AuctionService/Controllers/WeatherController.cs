using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuctionService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {

        [HttpGet("GetWeather")]
        public IActionResult GetWeather()
        {
            WeatherForecast[] forecast = Enumerable.Range(1, 5).Select(index =>
            new WeatherForecast
            (
                DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Random.Shared.Next(-20, 55),
                Random.Shared.Next(20,50).ToString()
            ))
            .ToArray();
            return Ok(forecast);
        }
    }
}
