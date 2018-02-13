using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace XeGateway
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "XeSource",
                routeTemplate: "api/Exchange/XeSources/{Sourceid}",
                defaults: new { controller = "XeSources", Sourceid = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "Conversion",
                routeTemplate: "api/Exchange/XeSources/{SourceId}/Conversions/{Action}",
                defaults: new { controller = "Conversions" }
            );
        }
    }
}
