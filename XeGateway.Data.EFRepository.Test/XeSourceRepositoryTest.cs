using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XeGateway.Data.EFRepository.Test
{
    [TestClass]
    public class XeSourceRepositoryTest
    {
        [TestMethod]
        public void XeSourceRepositoryTestAdd()
        {
            var unitOfWork = new UnitOfWork(new SqlDBContext());

            unitOfWork.XeSourceRepository.Add(new XeGateWay.Domain.XeGatewaySource()
            {
                Active = true,
                AdditionalParms = string.Empty,
                Endpoint = "Localhost",
                Name = "Xe.com"
                
            });
            unitOfWork.Compleate();


        }
    }
}
