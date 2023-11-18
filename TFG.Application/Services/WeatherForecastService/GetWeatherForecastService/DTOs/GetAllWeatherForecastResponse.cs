namespace TFG.Application.Services.WeatherForecastService.GetWeatherForecast.DTOs
{
    public class GetAllWeatherForecastResponse
    {
        public IEnumerable<WeatherForecastDto> WeatherForecasts { get; set; }
    }
}
