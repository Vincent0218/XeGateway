using System.Web.Http;
using XeGateway.Models;

namespace XeGateway.Controllers
{
    public class ConversionsController : ApiController
    {
        // GET: api/Conversions
        public ConversionResponse  Post(int SourceId, ConversionRequest req)
        {
            return new ConversionResponse() {
                Amount = 200,
                CurrencyCodeFrom = 1,
                CurrencyCodeTo = 2,
                OnDate = System.DateTime.Now
            };
        }
    }
}
