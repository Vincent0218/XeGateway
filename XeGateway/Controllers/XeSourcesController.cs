using System.Collections.Generic;
using System.Web.Http;
using System.Linq;
using XeGateway.Models;
using System.Net.Http;

namespace XeGateway.Controllers
{

    /// <summary>
    /// Xe ( currency) Source // XE , Yahoo , seed this 
    /// </summary>
    public class XeSourcesController : BaseAPIController
    {

        public XeSourcesController()
        {

        }

        /// <summary>
        /// Get list of all Exchange providers 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<XeGatewaySourceModel> Get()
        {
            return TheSourceManager.GetSource().Select(m => TheModelFacctory.Create(m));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Sourceid"></param>
        /// <returns></returns>
        public XeGatewaySourceModel Get(int Sourceid)
        {
            return TheModelFacctory.Create(TheSourceManager.GetSourceById(Sourceid));
        }


        
        /// <summary>
        /// TODO
        /// Create Should have Authantication  or could be done through script seed new data  , Create a new Source , Service provider for currency exchange rate , 
        /// for now this in not allowed returning 405 
        /// </summary>
        /// <param name="value"></param>
        public HttpResponseMessage Post([FromBody]string value)
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.MethodNotAllowed);

        }

        /// <summary>
        /// TODO
        /// Create Should have Authantication  or could be done through script seed new data  , Create a new Source , Service provider for currency exchange rate , 
        /// for now this in not allowed returning 405 
        /// </summary>
        /// <param name="value"></param>
        public HttpResponseMessage Put([FromBody]string value)
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.MethodNotAllowed);
        }



    }
}
