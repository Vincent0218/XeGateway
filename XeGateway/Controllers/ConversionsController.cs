using System.Web.Http;
using XeGateway.Models;
using System;
using System.Collections.Generic;
using XeGateway.ApplicationManager;

namespace XeGateway.Controllers
{


    /// <summary>
    /// Functoinal API
    /// </summary>
    public class ConversionsController : BaseAPIController
    {

        public ConversionsController(ISourceManager sourceManager) : base(sourceManager)
        {

        }

        // GET: api/Exchange/XeSources/{SourceId}/Conversions/GetConversion
        public ConversionResponseModel GetConversion(Int64 SourceId, ConversionRequestModel req)
        {
            var source = TheSourceManager.GetSourceById(SourceId);
            var conversionService = ServiceLocator.GetServiceByName(source.Name);
            var response = conversionService.Convert(new XeGateWay.Domain.ConversionServiceRequest()
            {
                AdditionalParam = req.AdditionalParam,
                Amount = req.Amount,
                CurrencyCodeFrom = req.CurrencyCodeFrom,
                CurrencyCodeTo = req.CurrencyCodeTo,
                OnDate = req.OnDate
            }
                     );
            return TheModelFacctory.Create(response);
        }

        // GET: api/Exchange/XeSources/{SourceId}/Conversions/GetCountryCodes
        [HttpGet]
        public IEnumerable<string> GetCurrencyCodes()
        {
            return new string[] { "USD", "INR" };
        }
    }
}
