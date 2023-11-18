using TFG.Application.Repositories;
using TFG.Application.Services.WeatherForecastService.GetWeatherForecast.DTOs;

namespace TFG.Application.Services.WeatherForecastService.GetWeatherForecastService.UseCase
{
    public class GetWeatherForecast : IGetWeatherForecast
    {
        private readonly IWeatherForecastRepository _weatherRepository;


        public GetWeatherForecast(IWeatherForecastRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }

        public async Task<GetAllWeatherForecastResponse> GetAllWeatherForecastAsync()
        {

            var entities = await _weatherRepository.GetAllAsync();
            var response = entities.Select(x => new WeatherForecastDto()
            {
                CreationDate = x.CreationDate,
                Id = x.Id,
                Date = x.Date,
                Summary = x.Summary,
                TemperatureC = x.TemperatureC
            }).ToList();

            return new GetAllWeatherForecastResponse()
            {
                WeatherForecasts = response
            };
        }


    }
}
