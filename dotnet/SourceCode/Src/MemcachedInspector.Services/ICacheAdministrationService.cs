using MemcachedInspector.Services.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.Services
{
    public interface ICacheAdministrationService
    {

        void FlushAll(ConnectionDto connection);
        SlabStatisticsDto GetMetadata(ConnectionDto connection);
        StatisticsDto GetStatistics(ConnectionDto connection);

    }
}
