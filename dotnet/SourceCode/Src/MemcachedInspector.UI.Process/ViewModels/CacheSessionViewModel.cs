using MemcachedInspector.Services;
using MemcachedInspector.Services.BusinessServices;
using MemcachedInspector.Services.DataTransferObjects;
using MemcachedInspector.UI.Process.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.UI.Process.ViewModels
{
    public class CacheSessionViewModel
    {

        public Session Session
        {
            get;
            private set;
        }

        private ICacheAdministrationService cacheAdministrationService = null;
        private ICacheService cacheService = null;

        public CacheSessionViewModel(Session session)
        {
            this.Session = session;
            this.cacheAdministrationService = ServiceFactory.GetCacheAdministrationService();
            this.cacheService = ServiceFactory.GetCacheService();
        }

        public void Initialize()
        {
            ConnectionDto connectionDto = new ConnectionDto(
                this.Session.Connection.Name,
                this.Session.Connection.HostName,
                this.Session.Connection.Port);

            SlabsDto slabContainer = this.cacheService.GetSlabs(connectionDto);


        }

    }
}
