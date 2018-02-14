using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using XeGateway.App_Start;

namespace XeGateway
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
           
            // 
            //Cash Service  for Service lookup 
            ServiceRegister.RegisterAll();
        }
    }
}
