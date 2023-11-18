using api_tfg_template;
using TFG.Application.Repositories;
using TFG.SharedKernel.Enums;

namespace TFG.Infrastructure.Repositories
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        public Task<WeatherForecast> CreateAsync(WeatherForecast entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(WeatherForecast entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<WeatherForecast>> GetAllAsync()
        {
            return await Task.Run(() => Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = (Summaries)(Random.Shared.Next(Enum.GetValues<Summaries>().Length)),
                CreationDate = DateTime.Now,
                Id = Random.Shared.Next(0, 55)
            })
          .ToArray());

        }

        public Task<WeatherForecast> GetAllFilteredAsync(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Task<WeatherForecast> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<WeatherForecast> UpdateAsync(WeatherForecast entity)
        {
            throw new NotImplementedException();
        }
    }
}
