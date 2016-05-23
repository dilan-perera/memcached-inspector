using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MemcachedInspector.Services.BusinessServices;
using MemcachedInspector.Services;

namespace MemcachedInspector.Tests.UnitTests
{
    [TestClass]
    public class CacheServerRegistrationService
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        private ICacheRegistrationService GetService()
        {
            return ServiceFactory.GetCacheRegistrationService();
        }

    }
}
