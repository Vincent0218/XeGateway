using System.Web.Http;
using Unity;
using Xe.Gateway.data.Contract;
using XeGateway.ApplicationManager;
using XeGateway.Data.EFRepository;

namespace XeGateway.Ioc
{
    public static class UnityConfiguration
    {
        public static UnityContainer Configure(HttpConfiguration config)
        {
            var container = new UnityContainer();
            container.RegisterType<ISourceManager, SourceManager>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<SqlDBContext, SqlDBContext>();
            container.RegisterInstance<IServiceLocator>(ServiceLocator.Instance);
            config.DependencyResolver = new UnityResolver(container);
            return container;
        }
    }
}