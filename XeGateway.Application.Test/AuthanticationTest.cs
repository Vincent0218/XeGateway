using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XeGateway.Application.Test
{
    [TestClass]
    public class AuthanticationTest
    {
        [TestMethod]
        public void TestAuthanticate()
        {
            AuthanticationService auth = new AuthanticationService();
            var result = auth.Authanticate("test", "password");
            Assert.AreEqual(result, true);
        }
    }
}
