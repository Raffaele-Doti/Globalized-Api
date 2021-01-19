using GlobalizedApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalizedApi.Abstracts
{
    [ApiController]
    public class DefaultController<ControllerType> : ControllerBase
    {
        #region Attributes

        /// <summary>
        /// Current culture from "accept-language" http request header
        /// </summary>
        internal readonly CultureInfo currentCulture;

        /// <summary>
        /// String localizer istance
        /// </summary>
        internal readonly IStringLocalizer<ControllerType> stringLocalizer;

        /// <summary>
        /// logger
        /// </summary>
        internal readonly ILogger<ControllerType> logger;

        #endregion

        #region Ctor

        public DefaultController(IStringLocalizer<ControllerType> stringLocalizer, ILogger<ControllerType> logger)
        {
            // Inject dependencies
            this.stringLocalizer = stringLocalizer;
            this.logger = logger;
            // Other operations here
            currentCulture = CultureInfo.CurrentCulture;
        }

        #endregion 
    }
}
