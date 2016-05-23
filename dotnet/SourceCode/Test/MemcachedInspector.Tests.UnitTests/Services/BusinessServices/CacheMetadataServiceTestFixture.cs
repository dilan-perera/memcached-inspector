using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MemcachedInspector.Services.BusinessServices;
using MemcachedInspector.Services;

namespace MemcachedInspector.Tests.UnitTests
{
    [TestClass]
    public class CacheMetadataServiceTestFixture
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        private ICacheAdministrationService GetService()
        {
            return ServiceFactory.GetCacheAdministrationService();
        }

    }
}
