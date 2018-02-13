using System.Web.Http;
using XeGateway.Models;
using System;
using System.Collections.Generic;

namespace XeGateway.Controllers
{


    /// <summary>
    /// Functoinal API
    /// </summary>
    public class ConversionsController : ApiController
    {
        // GET: api/Exchange/XeSources/{SourceId}/Conversions/GetConversion
        public ConversionResponse GetConversion(Int64 SourceId, ConversionRequest req)
        {
            return new ConversionResponse()
            {
                Amount = 200,
                CurrencyCodeFrom = "USD",
                CurrencyCodeTo = "INR",
                OnDate = System.DateTime.Now
            };
        }

        // GET: api/Exchange/XeSources/{SourceId}/Conversions/GetCountryCodes
        [HttpGet]
        public IEnumerable<string> GetCurrencyCodes()
        {
            return new string[] { "USD", "INR" };
        }
    }
}
