using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XeGateWay.Domain;
using System.Web.Http.Routing;
using System.Net.Http;

namespace XeGateway.Models
{
    public class ModelFactory
    {
        UrlHelper _helper;
        public ModelFactory(HttpRequestMessage request)
        {
            _helper = new UrlHelper(request);
        }

        public XeGatewaySourceModel Create(XeGatewaySource Source)
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
                Actions = _actions,
                Id = Source.Id
            };
        }

        public ConversionResponseModel Create(ConversionServiceResponse req)
        {
            return new ConversionResponseModel()
            {

            };
        }

        public XeGatewaySource Parse(XeGatewaySourceModel SourceModel)
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