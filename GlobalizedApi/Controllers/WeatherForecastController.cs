using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;

namespace GlobalizedApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        #region Attributes 
        /// <summary>
        /// String localizer istance.
        /// </summary>
        private readonly IStringLocalizer<WeatherForecastController> stringLocalizer;

        /// <summary>
        /// logger
        /// </summary>
        private readonly ILogger<WeatherForecastController> _logger;

        #endregion

        #region Ctor 

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="stringLocalizer"></param>
        /// <param name="logger"></param>
        public WeatherForecastController(IStringLocalizer<WeatherForecastController> stringLocalizer, ILogger<WeatherForecastController> logger)
        {
            //dependency injection 
            this.stringLocalizer = stringLocalizer;
            _logger = logger;
        }

        #endregion

        #region Endpoints

        [HttpGet]
        [Route("/GetMessage")]
        public async Task<IActionResult> GetMessage()
        {
            // getting current culture -> auto injected from default request culture provider via cookie,accept-language http header or "culture" http query string param
            var currentCulture = CultureInfo.CurrentCulture;
            // retrieve string from resx file in resources folder ( see microsoft documentation for resources naming conventions )
            var message = stringLocalizer.GetString("MessaggioBenvenuto");
            //returning message value
            return Ok(message.Value);
        }

        #endregion
    }
}
