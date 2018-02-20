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
        [HttpPost]
        public HttpResponseMessage GetConversion(ConversionRequestModel request,Int64 sourceid)
        {
            if (request == null)
            {
                return Request.CreateResponse(System.Net.HttpStatusCode.BadRequest);
            }
            var source = TheSourceManager.GetSourceById(sourceid);
            if (source == null)
            {
                return Request.CreateResponse(System.Net.HttpStatusCode.BadRequest);
            }
            if (!source.Active)
            {
                return Request.CreateResponse(System.Net.HttpStatusCode.MethodNotAllowed);
            }
            var conversionService = _serviceLocator.GetServiceByName(source.Name);
            var response = conversionService.Convert(TheModelFacctory.Parse(request));
           

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
