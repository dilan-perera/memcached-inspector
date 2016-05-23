using MemcachedInspector.Services.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.Services.BusinessServices
{
    internal class CacheService : ICacheService
    {

        private const bool MustRetrieveValuesByDefault = true;

        public SlabsDto GetSlabs(ConnectionDto connection)
        {
            SlabsDto slabs = null;

            Cache cache = new Cache(connection);

            cache.Connect();
            slabs = cache.GetSlabs();
            cache.Disconnect();

            return slabs;
        }

        public Collection<ItemDto> GetItems(ConnectionDto connection, SlabDto slab)
        {
            return this.GetItems(connection, slab, CacheService.MustRetrieveValuesByDefault);
        }

        public Collection<ItemDto> GetItems(ConnectionDto connection, SlabDto slab, bool mustRetrieveValues)
        {
            Collection<ItemDto> items = null;

            Cache cache = new Cache(connection);

            cache.Connect();
            items = cache.GetItems(slab);
            cache.Disconnect();

            return items;
        }

        public void Add(ConnectionDto connection, string key, object value)
        {
            Cache cache = new Cache(connection);

            cache.Add(key, value);
        }

        public void Replace(ConnectionDto connection, string key, object value)
        {
            Cache cache = new Cache(connection);

            cache.Replace(key, value);
        }

        public void Set(ConnectionDto connection, string key, object value)
        {
            Cache cache = new Cache(connection);

            cache.Set(key, value);
        }

        public object Get(ConnectionDto connection, string key)
        {
            Cache cache = new Cache(connection);

            return cache.Get(key);
        }

        public void Remove(ConnectionDto connection, string key)
        {
            Cache cache = new Cache(connection);

            cache.Remove(key);
        }

    }
}
