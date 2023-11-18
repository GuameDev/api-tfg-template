
using TFG.Application.Services.WeatherForecastService.GetWeatherForecast.DTOs;
using TFG.Application.Services.WeatherForecastService.GetWeatherForecastService.UseCase;

namespace TFG.Application.Services.WeatherForecastService
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IGetWeatherForecast _getWeatherForecastService;

        public WeatherForecastService(IGetWeatherForecast getWeatherForecastService)
        {
            _getWeatherForecastService = getWeatherForecastService;
        }
        public async Task<GetAllWeatherForecastResponse> GetAllWeatherForecastAsync()
        {
            return await _getWeatherForecastService.GetAllWeatherForecastAsync();
        }
    }
}
