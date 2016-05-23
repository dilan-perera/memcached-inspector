using MemcachedInspector.Services.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.Services
{
    public interface ICacheService
    {

        SlabsDto GetSlabs(ConnectionDto connection);
        void Add(ConnectionDto connection, string key, object value);
        object Get(ConnectionDto connection, string key);
        void Remove(ConnectionDto connection, string key);
        void Replace(ConnectionDto connection, string key, object value);
        void Set(ConnectionDto connection, string key, object value);

    }
}
