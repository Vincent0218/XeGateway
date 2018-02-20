using System.Web.Http;
using XeGateway.Models;
using System;
using System.Collections.Generic;
using XeGateway.ApplicationManager;
using System.Net.Http;

namespace XeGateway.Controllers
{


    /// <summary>
    /// Functoinal API
    /// </summary>
    public class ConversionsController : BaseAPIController
    {
       private IServiceLocator _serviceLocator;

        public ConversionsController(ISourceManager sourceManager, IServiceLocator servicelocator) : base(sourceManager)
        {
            _serviceLocator = servicelocator;
        }

        // GET: api/Exchange/XeSources/{SourceId}/Conversions/GetConversion
        public HttpResponseMessage GetConversion(ConversionRequestModel req)
        {
            if (req == null)
            {
                return Request.CreateResponse(System.Net.HttpStatusCode.BadRequest);
            }
            var source = TheSourceManager.GetSourceById(req.SourceId);
            if (source == null)
            {
                return Request.CreateResponse(System.Net.HttpStatusCode.BadRequest);
            }

            var conversionService = _serviceLocator.GetServiceByName(source.Name);
            var response = conversionService.Convert(new XeGateWay.Domain.ConversionServiceRequest()
            {
                AdditionalParam = req.AdditionalParam,
                Amount = req.Amount,
                CurrencyCodeFrom = req.CurrencyCodeFrom,
                CurrencyCodeTo = req.CurrencyCodeTo,
                OnDate = req.OnDate
            }
           );

            return Request.CreateResponse(System.Net.HttpStatusCode.OK, TheModelFacctory.Create(response));
        }

        // GET: api/Exchange/XeSources/{SourceId}/Conversions/GetCountryCodes
        [HttpGet]
        public IEnumerable<string> GetCurrencyCodes()
        {
            return new string[] { "USD", "INR" };
        }
    }
}
