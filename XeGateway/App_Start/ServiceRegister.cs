using System;
using Xe.Gateway.ServiceInterface.Oanda;
using Xe.Gateway.ServiceInterface.Yahoo;
using XeGateway.ApplicationManager;

using XeGateway.Data.Services;
using XeGateWay.Domain;

namespace XeGateway.App_Start
{

    /// <summary>
    /// Register services
    /// </summary>
    public static class ServiceRegister
    {
        public static void Register(ISourceManager sourceManager, IServiceLocator serviceLocator)
        {

            #region YahooServiceRegistery
            var YahooSourceName = typeof(ExchangeInterfaceYahoo).FullName;
            var sourceYahoo = sourceManager.GetSourceByName(YahooSourceName);
            if (sourceYahoo == null)
            {
                sourceManager.AddSource(new XeGatewaySource()
                {
                    Active = true,
                    AdditionalParms = "",
                    Endpoint = "",
                    Name = YahooSourceName
                });

            }
            serviceLocator.AddService((IXeService)Activator.CreateInstance(typeof(ExchangeInterfaceYahoo)));
            #endregion

            #region OandaServiceRegistery
            var OandaSourceName = typeof(ExchangeInterfaceOanda).FullName;
            var sourceOanda = sourceManager.GetSourceByName(OandaSourceName);
            if (sourceOanda == null)
            {
                sourceManager.AddSource(new XeGatewaySource()
                {
                    Active = true,
                    AdditionalParms = "",
                    Endpoint = "",
                    Name = OandaSourceName
                });

            }
            serviceLocator.AddService((IXeService)Activator.CreateInstance(typeof(ExchangeInterfaceOanda)));
            #endregion
        }
    }
}