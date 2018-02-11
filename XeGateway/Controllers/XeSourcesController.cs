using System.Collections.Generic;
using System.Web.Http;
using XeGateway.ApplicationManager;
using XeGateWay.Domain;

namespace XeGateway.Controllers
{

    /// <summary>
    /// Xe ( currency) Source // XE , Yahoo 
    /// </summary>
    public class XeSourcesController : ApiController
    {
        private readonly ISourceManager _sourceManager;
        public XeSourcesController()
        {
            _sourceManager = new SourceManager();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<XeGatewaySource> Get()
        {
            return _sourceManager.GetSource();
        }


        public XeGatewaySource Get(int id)
        {
            return _sourceManager.GetSourceById(id);
        }

        public void Post([FromBody]string value)
        {
        }


    }
}
