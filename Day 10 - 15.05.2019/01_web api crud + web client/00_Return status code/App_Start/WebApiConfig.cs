using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace _00_Return_status_code
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();


            config.Routes.MapHttpRoute(
               name: "PriceRouter",
               routeTemplate: "api/ProductPrice/{price}",
               defaults: new { controller="product", action= "ProductByPrice", price=6}
           );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
