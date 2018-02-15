using XeGateway.Data.Services;
using XeGateWay.Domain;

namespace Xe.Gateway.ServiceInterface.Yahoo
{
    public class ExchangeInterfaceYahoo : IXeService
    {
        public ConversionServiceResponse Convert(ConversionServiceRequest Request)
        {            
            return new ConversionServiceResponse()
            {
                Amount = 100,
                CurrencyCodeFrom = "USD",
                CurrencyCodeTo = "INR",
                OnDate = System.DateTime.UtcNow
            };
        }
    }
}
