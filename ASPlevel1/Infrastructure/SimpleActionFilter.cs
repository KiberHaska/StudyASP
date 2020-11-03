using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPlevel1.Infrastructure
{
    public class SimpleActionFilter : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            //before
            //throw new NotImplementedException();
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //after
            //throw new NotImplementedException();
        }
    }
}
