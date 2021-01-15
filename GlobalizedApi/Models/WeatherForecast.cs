using Microsoft.AspNetCore.Mvc;
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
        public DateTime Date { get; set; }

        /// <summary>
        /// Temperature in celsius 
        /// </summary>
        [Display(Name = "CelsiusTemperature")]
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
        public string Summary { get; set; }
    }
}
