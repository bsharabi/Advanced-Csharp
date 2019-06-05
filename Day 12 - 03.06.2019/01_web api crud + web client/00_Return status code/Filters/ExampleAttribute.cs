using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
namespace _00_Return_status_code.Filters
{
    public class ExampleAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (!actionContext.ModelState.IsValid)
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(
                   HttpStatusCode.BadRequest, actionContext.ModelState);
            }    
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {

        }
       

    }
}