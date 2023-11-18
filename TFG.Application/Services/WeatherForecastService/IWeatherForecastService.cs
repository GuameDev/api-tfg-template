using TFG.Application.Services.WeatherForecastService.GetWeatherForecast.DTOs;

namespace TFG.Application.Services.WeatherForecastService
{
    public interface IWeatherForecastService
    {
        Task<GetAllWeatherForecastResponse> GetAllWeatherForecastAsync();
    }
}
