using Microsoft.AspNetCore.Mvc;
using TFG.Application.Services.WeatherForecastService;
using TFG.Application.Services.WeatherForecastService.GetWeatherForecast.DTOs;

namespace TFG.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastService _watherForecastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService watherForecastService)
        {
            _logger = logger;
            _watherForecastService = watherForecastService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<ActionResult<GetAllWeatherForecastResponse>> GetAll()
        {
            var response = await _watherForecastService.GetAllWeatherForecastAsync();
            return Ok(response);
        }
    }
}
