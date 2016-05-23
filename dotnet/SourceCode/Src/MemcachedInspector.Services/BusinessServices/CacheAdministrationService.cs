using MemcachedInspector.Services.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.Services.BusinessServices
{
    internal class CacheAdministrationService : ICacheAdministrationService
    {

        public void FlushAll(ConnectionDto connection)
        {
            Cache cache = new Cache(connection);

            cache.FlushAll();
        }

        public SlabStatisticsDto GetMetadata(ConnectionDto connection)
        {
            Cache cache = new Cache(connection);

            return cache.GetMetadata();
        }

        public StatisticsDto GetStatistics(ConnectionDto connection)
        {
            Cache cache = new Cache(connection);

            return cache.GetStatistics();
        }

    }
}
