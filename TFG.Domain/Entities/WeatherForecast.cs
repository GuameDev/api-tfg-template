using TFG.Domain;
using TFG.SharedKernel.Enums;

namespace api_tfg_template
{
    public class WeatherForecast : BaseEntity
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public Summaries? Summary { get; set; }
    }
}
