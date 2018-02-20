using System.Collections.Generic;
using XeGateWay.Domain;
using System.Web.Http.Routing;
using System.Net.Http;

namespace XeGateway.Models
{
    internal class ModelFactory
    {
        UrlHelper _helper;
        public ModelFactory(HttpRequestMessage request)
        {
            _helper = new UrlHelper(request);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Source"></param>
        /// <returns></returns>
        internal XeGatewaySourceModel Create(XeGatewaySource Source)
        {
            Dictionary<string, string> _actions = new Dictionary<string, string>
            {
                { "GetConversion", _helper.Link("Conversion", new { SourceId = Source.Id, Action = "GetConversion" }) },
                { "GetCurrencyCodes", _helper.Link("Conversion", new { SourceId = Source.Id, Action = "GetCurrencyCodes" }) }
            };
            return new XeGatewaySourceModel()
            {
                Url = _helper.Link("XeSource", new { Sourceid = Source.Id }),
                Active = Source.Active,
                AdditionalParms = Source.AdditionalParms,
                Endpoint = Source.Endpoint,
                Name = Source.Name,
                Actions =  Source.Active? _actions: null,
                Id = Source.Id
            };
        }



        internal ConversionServiceRequest Parse(ConversionRequestModel request)
        {
            return new ConversionServiceRequest()
            {
                AdditionalParam = request.AdditionalParam,
                Amount = request.Amount,
                CurrencyCodeFrom = request.CurrencyCodeFrom,
                CurrencyCodeTo = request.CurrencyCodeTo,
                OnDate = request.OnDate
            };
        }

        internal ConversionResponseModel Create(ConversionServiceResponse response)
        {
            return new ConversionResponseModel()
            {
                Amount = response.Amount,
                CurrencyCodeFrom = response.CurrencyCodeFrom,
                CurrencyCodeTo = response.CurrencyCodeTo,
                OnDate = response.OnDate
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SourceModel"></param>
        /// <returns></returns>
        internal XeGatewaySource Parse(XeGatewaySourceModel SourceModel)
        {
            return new XeGatewaySource()
            {
                Id = SourceModel.Id,
                Active = SourceModel.Active,
                AdditionalParms = SourceModel.AdditionalParms,
                Endpoint = SourceModel.Endpoint,
                Name = SourceModel.Name
            };
        }
    }
}