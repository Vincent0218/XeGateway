using System.Web.Http;
using XeGateway.ApplicationManager;
using XeGateway.Models;

namespace XeGateway.Controllers
{
    public abstract class BaseAPIController : ApiController
    {
         ISourceManager _sourceManager;
         ModelFactory _modelFactory;
        public BaseAPIController(ISourceManager sourceManager)
        {
            _sourceManager = sourceManager;
        }
        protected ISourceManager TheSourceManager
        {
            get
            {
                return _sourceManager;
            }
        }

        protected ModelFactory TheModelFacctory
        {
            get
            {
                if (_modelFactory == null)
                {
                    _modelFactory = new ModelFactory(this.Request);
                }
                return _modelFactory;
            }
        }

    }
}
