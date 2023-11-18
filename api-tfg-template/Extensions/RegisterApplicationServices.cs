using TFG.Application.Repositories;
using TFG.Application.Services.WeatherForecastService;
using TFG.Application.Services.WeatherForecastService.GetWeatherForecastService.UseCase;
using TFG.Infrastructure.Repositories;

namespace TFG.API.Extensions
{
    public static class RegisterApplicationServices
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();
            services.AddScoped<IWeatherForecastService, WeatherForecastService>();
            services.AddScoped<IGetWeatherForecast, GetWeatherForecast>();
            return services;
        }
    }
}
