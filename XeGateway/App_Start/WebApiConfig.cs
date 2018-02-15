using System.Web.Http;
using Unity;
using Xe.Gateway.data.Contract;
using XeGateway.ApplicationManager;
using XeGateway.Data.EFRepository;
using XeGateway.Ioc;

namespace XeGateway
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            ///
            var container = new UnityContainer();
            container.RegisterType<ISourceManager, SourceManager>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<SqlDBContext, SqlDBContext>();
            config.DependencyResolver = new UnityResolver(container);

            // Web API routes
            config.MapHttpAttributeRoutes();

            // Exchange source Resource Rout 
            config.Routes.MapHttpRoute(
                name: "XeSource",
                routeTemplate: "api/Exchange/XeSources/{Sourceid}",
                defaults: new { controller = "XeSources", Sourceid = RouteParameter.Optional }
            );


            //Functional Route 
            config.Routes.MapHttpRoute(
                name: "Conversion",
                routeTemplate: "api/Exchange/XeSources/{SourceId}/Conversions/{Action}",
                defaults: new { controller = "Conversions" }
            );
        }
    }
}
