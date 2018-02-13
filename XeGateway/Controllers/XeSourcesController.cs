using System.Collections.Generic;
using System.Web.Http;
using XeGateway.ApplicationManager;
using XeGateWay.Domain;
using System.Linq;
using XeGateway.Models;

namespace XeGateway.Controllers
{

    /// <summary>
    /// Xe ( currency) Source // XE , Yahoo 
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
        /// Create Should have Authantication  , Create a new Source , Service provider for currency exchange rate , 
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody]string value)
        {


        }

        /// <summary>
        ///  Update  
        /// </summary>
        /// <param name="value"></param>
        public void Put([FromBody]string value)
        {
        }



    }
}
