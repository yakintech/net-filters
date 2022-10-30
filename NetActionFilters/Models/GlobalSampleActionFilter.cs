using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace NetActionFilters.Models
{
    public class GlobalSampleActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
        }
    }
}

