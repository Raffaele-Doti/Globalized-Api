using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using GlobalizedApi.Abstracts;
using GlobalizedApi.ActionFilter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;

namespace GlobalizedApi.Controllers
{
   
    public class WeatherForecastController : DefaultController<WeatherForecastController>
    {
        #region Attributes 
        
 
        #endregion

        #region Ctor 

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="stringLocalizer"></param>
        /// <param name="logger"></param>
        public WeatherForecastController(IStringLocalizer<WeatherForecastController> stringLocalizer, ILogger<WeatherForecastController> logger) : base( stringLocalizer, logger)
        {
            // Other operations here
        }

        #endregion

        #region Endpoints

        /// <summary>
        /// Endpoint to get a weather forecast
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("WeatherForecast/{date}")]
        public async Task<IActionResult> Get(DateTime date)
        {
            // Create a fake weather forecast model ( teorically it should be retrieved from a repository/helper ) 
            var weatherForecast = new WeatherForecast { Date = date, TemperatureC = 25 };           
            // Retrieve string from resx file in resources folder ( see microsoft documentation for resources naming conventions )
            var message = base.stringLocalizer.GetString("ForecastMessage", weatherForecast.Date, weatherForecast.TemperatureC, weatherForecast.TemperatureF);
            // Returning message value
            return Ok(message.Value);
        }

        /// <summary>
        /// Endpoint to save a weather forecast
        /// </summary>
        /// <param name="weatherForecast"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("WeatherForecast")]
        [ValidateModel]
        public async Task<IActionResult> Post(WeatherForecast weatherForecast)
        {
            return Ok(weatherForecast);
        }
        #endregion
    }
}
