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
    /// Xe ( currency) Source // XE , Yahoo  
    /// </summary>
    public class XeSourcesController : BaseAPIController
    {

        public XeSourcesController(ISourceManager sourceManager) :base(sourceManager)
        {

        }

        /// <summary>
        /// Get list of all Exchange providers ,currently getting all the sources could have restricted to just the active ones
        /// but this feels more flexible in design as the user can see source status ,  
        /// We are not showing the function that user could preform on those sources if the are inactive 
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
        /// Not Allowed on resource
        /// </summary>
        /// <param name="value"></param>
        public HttpResponseMessage Post([FromBody]string value)
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.MethodNotAllowed);
        }

        /// <summary>
        /// 

        /// </summary>
        /// <param name="sourceModel"></param>
        [RequireHttpsFilter]
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
