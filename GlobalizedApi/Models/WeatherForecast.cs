
using GlobalizedApi.Resources;
using System;
using System.ComponentModel.DataAnnotations;

namespace GlobalizedApi
{

    public class WeatherForecast
    {
        /// <summary>
        /// Date in which weather forecast is valid
        /// </summary>
        [Display(Name = "Date")]
        [Required(ErrorMessageResourceName = "WeatherDateRequired", ErrorMessageResourceType = typeof(ValidationResource))]
        public DateTime Date { get; set; }

        /// <summary>
        /// Temperature in celsius 
        /// </summary>
        [Display(Name = "CelsiusTemperature")]
        [Range(0, 1000, ErrorMessageResourceName = "WeatherCelsiusTemperature", ErrorMessageResourceType = typeof(ValidationResource))]
        public int TemperatureC { get; set; }

        /// <summary>
        /// Temperature in fahrenheit
        /// </summary>
        [Display(Name = "FahrenheitTemperature")]
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        /// <summary>
        /// Summary
        /// </summary>
        [Display(Name = "Summary")]
        [Required(ErrorMessageResourceName = "WeatherSummaryRequired", ErrorMessageResourceType = typeof(ValidationResource))]
        public string Summary { get; set; }
    }
}
