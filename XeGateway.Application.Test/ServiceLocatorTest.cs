using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XeGateway.ApplicationManager;
using Rhino.Mocks;
using XeGateway.Data.Services;

namespace XeGateway.Application.Test
{
    [TestClass]
    public class ServiceLocatorTest
    {
        [TestMethod]
        public void TestServiceLocator()
        {
            var _exchangeService = MockRepository.Mock<IXeService>();
            var vv=    _exchangeService.GetType().FullName;
            ServiceLocator.Instance.AddService(_exchangeService);
            var service =  ServiceLocator.Instance.GetServiceByName(vv);
            Assert.AreEqual(_exchangeService, service);
        }
    }
}
