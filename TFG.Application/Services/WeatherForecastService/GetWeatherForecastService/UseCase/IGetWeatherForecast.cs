using TFG.Application.Services.WeatherForecastService.GetWeatherForecast.DTOs;

namespace TFG.Application.Services.WeatherForecastService.GetWeatherForecastService.UseCase
{
    public interface IGetWeatherForecast
    {
        Task<GetAllWeatherForecastResponse> GetAllWeatherForecastAsync();
    }
}
