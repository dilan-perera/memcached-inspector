using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.Services.BusinessServices
{
    public static class ServiceFactory
    {

        public static ICacheRegistrationService GetCacheRegistrationService()
        {
            return new CacheRegistrationService();
        }

        public static ICacheAdministrationService GetCacheAdministrationService()
        {
            return new CacheAdministrationService();
        }

        public static ICacheService GetCacheService()
        {
            return new CacheService();
        }

    }
}
