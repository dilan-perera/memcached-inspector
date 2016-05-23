using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MemcachedInspector.Services.BusinessServices;
using MemcachedInspector.Services;
using MemcachedInspector.Services.DataTransferObjects;

namespace MemcachedInspector.Tests.UnitTests
{
    [TestClass]
    public class CacheTestFixture
    {
        [TestMethod]
        public void TestStoreRetrieve()
        {
            ICacheService service = this.GetService();
            ConnectionDto connection = new ConnectionDto(".", "localhost", 11211);

            const string Key = "test";
            const string Value = "data";

            service.Set(connection, Key, Value);
            string resultValue = service.Get(connection, Key) as string;

            Assert.AreEqual(Value, resultValue);
        }

        private ICacheService GetService()
        {
            return ServiceFactory.GetCacheService();
        }

    }
}
