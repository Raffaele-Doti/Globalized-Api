using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalizedApi.ActionFilter
{
    public class ValidateModel : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                //return first model validation error
                context.Result = new BadRequestObjectResult($"error : {context.ModelState.Values.First().Errors.First().ErrorMessage}");
            }
        }
    }
}
