using Enyim.Caching;
using Enyim.Caching.Configuration;
using Enyim.Caching.Memcached;
using MemcachedInspector.Common;
using MemcachedInspector.Common.Exceptions;
using MemcachedInspector.Services.BusinessServices.ParserCommands;
using MemcachedInspector.Services.DataTransferObjects;
using MemcachedInspector.Services.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.Services.BusinessServices
{
    internal class Cache
    {

        private static class Commands
        {

            public const string Statistics = "stats";

            public const string SlabsStatistics = Cache.Commands.Statistics + " slabs";

            public const string ItemsStatistics = Cache.Commands.Statistics + " items";

        }

        private const int BufferSize = 1024;

        private Socket socket = null;

        private IMemcachedClient memcacheClient = null;

        public string HostName
        {
            get;
            private set;
        }

        public int Port
        {
            get;
            private set;
        }
        
        public bool IsConnected
        {
            get;
            private set;
        }

        /// <summary>
        /// Reads data from a stream until the end is reached. The
        /// data is returned as a byte array. An IOException is
        /// thrown if any of the underlying IO calls fail.
        /// </summary>
        /// <param name="stream">The stream to read data from</param>
        /// <remarks>
        /// http://www.yoda.arachsys.com/csharp/readbinary.html
        /// </remarks>
        private static byte[] Read(Stream stream)
        {
            byte[] result = null;

            byte[] buffer = new byte[Cache.BufferSize];

            using (MemoryStream memoryStream = new MemoryStream())
            {
                while (true)
                {
                    int read = stream.Read(buffer, 0, buffer.Length);

                    if (read < Cache.BufferSize)
                    {
                        if (read > 0)
                        {
                            memoryStream.Write(buffer, 0, read);
                        }

                        result = memoryStream.ToArray();

                        break;
                    }
                    else
                    {
                        memoryStream.Write(buffer, 0, read);
                    }
                }
            }

            return result;
        }

        public Cache() : this(ConnectionSettings.DefaultHostName)
        {

        }

        public Cache(string hostName) : this(hostName, ConnectionSettings.DefaultPort)
        {
        }

        public Cache(ConnectionDto connection) : this(connection.HostName, connection.Port)
        {

        }

        public Cache(string hostName, int port)
        {
            this.HostName = hostName;
            this.Port = port;
        }

        public void Connect()
        {
            if (!(this.IsConnected))
            {
                IPEndPoint remoteEndpoint = this.GetRemoteEndPoint();
                
                this.socket = new Socket(remoteEndpoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                this.socket.Connect(remoteEndpoint);

                this.IsConnected = true;
            }
        }

        public void Disconnect()
        {
            if (this.IsConnected)
            {
                if (this.socket.Connected)
                {
                    this.socket.Close();
                }
            }

            this.IsConnected = false;
            this.socket = null;
        }

        public void FlushAll()
        {
            IMemcachedClient client = this.GetMemcachedClient();

            client.FlushAll();
        }

        public void Add(string key, object value)
        {
            IMemcachedClient client = this.GetMemcachedClient();

            client.Store(StoreMode.Add, key, value);
        }

        public void Replace(string key, object value)
        {
            IMemcachedClient client = this.GetMemcachedClient();

            client.Store(StoreMode.Replace, key, value);
        }

        public void Set(string key, object value)
        {
            IMemcachedClient client = this.GetMemcachedClient();

            client.Store(StoreMode.Set, key, value);
        }

        public object Get(string key)
        {
            object value = null;

            IMemcachedClient client = this.GetMemcachedClient();

            value = client.Get(key);

            return value;
        }

        public void Remove(string key)
        {
            IMemcachedClient client = this.GetMemcachedClient();

            client.Remove(key);
        }

        public SlabStatisticsDto GetMetadata()
        {
            SlabStatisticsDto resultMetadata = new SlabStatisticsDto();

            IMemcachedClient client = this.GetMemcachedClient();

            ServerStats stats = client.Stats();

            return resultMetadata;
        }

        public StatisticsDto GetStatistics()
        {
            StatisticsDto resultStats = new StatisticsDto();

            IMemcachedClient client = this.GetMemcachedClient();

            ServerStats stats = client.Stats();
            
            return resultStats;
        }

        private IMemcachedClient GetMemcachedClient()
        {
            if (this.memcacheClient == null)
            {
                IMemcachedClientConfiguration configuration = new MemcachedClientConfiguration();

                IPEndPoint remoteEndpoint = this.GetRemoteEndPoint();

                configuration.Servers.Add(remoteEndpoint);

                this.memcacheClient = new MemcachedClient(configuration);
            }

            return this.memcacheClient;
        }

        private IPEndPoint GetRemoteEndPoint()
        {
            IPEndPoint remoteEndpoint = null;

            IPHostEntry ipHostInfo = Dns.GetHostEntry(this.HostName);
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            remoteEndpoint = new IPEndPoint(ipAddress, this.Port);

            return remoteEndpoint;
        }

        public SlabsDto GetSlabs()
        {
            SlabsDto slabsContainer = null;

            this.EnsureConnected();

            string response = string.Empty;

            response = this.ExecuteCommand(Cache.Commands.SlabsStatistics);
            SlabsStatisticsParserCommand statsCommand = new SlabsStatisticsParserCommand(response);
            statsCommand.Parse();
            SlabsDto slabsStatsContainer = statsCommand.SlabContainer;

            response = this.ExecuteCommand(Cache.Commands.ItemsStatistics);
            SlabContentParserCommand contentCommand = new SlabContentParserCommand(response);
            contentCommand.Parse();
            SlabsDto slabsContentContainer = contentCommand.SlabContainer;

            slabsContainer = new SlabsDto();
            slabsContainer.ActiveSlabCount = slabsStatsContainer.ActiveSlabCount;
            slabsContainer.TotalMemoryAllocated = slabsStatsContainer.TotalMemoryAllocated;

            foreach (SlabDto statSlab in slabsStatsContainer.Slabs)
            {
                foreach (SlabDto contentSlab in slabsContentContainer.Slabs)
                {
                    if (statSlab.ID == contentSlab.ID)
                    {
                        SlabDto slab = new SlabDto();

                        slab.ID = statSlab.ID;
                        slab.Statistics = statSlab.Statistics;
                        slab.Contents = contentSlab.Contents;

                        slabsContainer.Slabs.Add(slab);

                        break;
                    }
                }
            }

            return slabsContainer;
        }

        public Collection<ItemDto> GetItems(SlabDto slab)
        {
            Collection<ItemDto> items = null;
            
            items = new Collection<ItemDto>();

            return items;
        }

        private void EnsureConnected()
        {
            if (!(this.IsConnected))
            {
                this.Connect();
            }
        }

        private string ExecuteCommand(string command)
        {
            string response = string.Empty;

            try
            {
                this.EnsureConnected();

                string delimitedCommand = command + OperatingEnvironment.NewLine;
                byte[] data = null;

                using (NetworkStream stream = new NetworkStream(this.socket))
                {
                    data = Encoding.ASCII.GetBytes(delimitedCommand);
                    stream.Write(data, 0, data.Length);

                    data = Cache.Read(stream);
                    response = Encoding.ASCII.GetString(data);
                }
            }
            catch (SocketException ex)
            {
                throw new CacheConnectionException(ex.Message, ex);
            }

            return response;
        }

    }
}
