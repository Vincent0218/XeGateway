using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using XeGateway.ApplicationManager;
using XeGateway.Controllers;
using System.Net.Http;
using System.Web.Http;

namespace XeGateway.Web.Test
{
    [TestClass]
    public class ConversionsControllerTest
    {
        [TestMethod]
        public void GetConversionTestBadRequest()
        {
            var serviceManager = MockRepository.Mock<ISourceManager>();
            var serviceLocator = MockRepository.Mock<IServiceLocator>();

            ConversionsController controller = new ConversionsController(serviceManager, serviceLocator)
            {
                Request = new HttpRequestMessage()
            };
            var result1 = controller.GetConversion(null);
            Assert.AreEqual(result1.StatusCode, System.Net.HttpStatusCode.BadRequest);

            var result2 = controller.GetConversion(new Models.ConversionRequestModel());
            serviceManager.AssertWasCalled(x => x.GetSourceById(0));
        }
  
    }
}
