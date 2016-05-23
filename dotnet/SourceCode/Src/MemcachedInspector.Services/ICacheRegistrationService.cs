using MemcachedInspector.Services.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.Services
{
    public interface ICacheRegistrationService
    {

        void Register(ConnectionDto connection);

        void Unregister(ConnectionDto connection);

        void LoadConnections();

        void SaveConnections();

        ConnectionsDto GetConnections();


    }
}
