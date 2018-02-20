using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using XeGateway.App_Start;
using XeGateway.ApplicationManager;
using XeGateway.Ioc;
using Unity;

namespace XeGateway
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();           
            GlobalConfiguration.Configure(WebApiConfig.Register);
            var unityContainer = UnityConfiguration.Configure(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
            var sourceManager = unityContainer.Resolve<ISourceManager>();
            var serviceLocator = unityContainer.Resolve<IServiceLocator>();
            // 
            //Cash Service  for Service lookup         
            ServiceRegister.Register(sourceManager, serviceLocator);
            
        }
    }
}
