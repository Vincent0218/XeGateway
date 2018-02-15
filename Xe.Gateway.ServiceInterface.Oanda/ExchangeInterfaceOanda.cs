using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XeGateway.Data.Services;
using XeGateWay.Domain;

namespace Xe.Gateway.ServiceInterface.Oanda
{
    public class ExchangeInterfaceOanda : IXeService
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
