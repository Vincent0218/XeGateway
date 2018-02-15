using System.Collections.Generic;
using System.Web.Http;
using System.Linq;
using XeGateway.Models;
using System.Net.Http;
using XeGateway.Filters;
using XeGateway.ApplicationManager;

namespace XeGateway.Controllers
{

    [XeAuthorizeFilter]
    /// <summary>
    /// Xe ( currency) Source // XE , Yahoo , seed this 
    /// </summary>
    public class XeSourcesController : BaseAPIController
    {

        public XeSourcesController(ISourceManager sourceManager) :base(sourceManager)
        {

        }

        /// <summary>
        /// Get list of all Exchange providers 
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public IEnumerable<XeGatewaySourceModel> Get()
        {
            return TheSourceManager.GetSource().Select(m => TheModelFacctory.Create(m));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Sourceid"></param>
        /// <returns></returns>
        /// 
        [AllowAnonymous]
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
        /// <param name="sourceModel"></param>
        public HttpResponseMessage Put([FromBody]XeGatewaySourceModel sourceModel)
        {
            var source = TheSourceManager.GetSourceById(sourceModel.Id);
            if (source == null)
            {
                Request.CreateResponse(System.Net.HttpStatusCode.BadRequest);
            }
            
            var sourceUpated = TheModelFacctory.Parse(sourceModel);
            TheSourceManager.UpdateSource(sourceUpated);

            return Request.CreateResponse(System.Net.HttpStatusCode.OK);
        }



    }
}
