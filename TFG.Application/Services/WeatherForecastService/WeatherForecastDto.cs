using TFG.SharedKernel;
using TFG.SharedKernel.Enums;

namespace TFG.Application.Services.WeatherForecastService
{
    public class WeatherForecastDto : BaseDto
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public Summaries? Summary { get; set; }
    }
}
