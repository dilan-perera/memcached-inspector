using MemcachedInspector.Common;
using MemcachedInspector.Common.Exceptions;
using MemcachedInspector.Services.DataTransferObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.Services.BusinessServices
{
    internal class CacheRegistrationService : ICacheRegistrationService
    {

        private static readonly Collection<ConnectionDto> Connections = new Collection<ConnectionDto>();

        private const string DefaultFileName = "cache.con";

        public void Register(ConnectionDto connection)
        {
            Cache cache = new Cache(connection);

            try
            {
                cache.Connect();
                cache.Disconnect();

                CacheRegistrationService.Connections.Add(connection);
            }
            catch (Exception ex)
            {
                throw new CacheConnectionException(ex.Message, ex);
            }
        }

        public void Unregister(ConnectionDto connection)
        {
            CacheRegistrationService.Connections.Remove(connection);
        }

        public void LoadConnections()
        {
            string filePath = this.GetFilePath();

            CacheRegistrationService.Connections.Clear();

            if (File.Exists(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();

                serializer.NullValueHandling = NullValueHandling.Ignore;

                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    using (JsonReader jsonReader = new JsonTextReader(streamReader))
                    {
                        ConnectionsDto connectionContainer = serializer.Deserialize<ConnectionsDto>(jsonReader);
                        
                        foreach (ConnectionDto connection in connectionContainer.Connections)
                        {
                            CacheRegistrationService.Connections.Add(connection);
                        }
                    }
                }
            }
            else
            {
                // TODO: remove for prod
                ConnectionDto connection = new ConnectionDto(
                    ConnectionSettings.DefaultConnectionName,
                    ConnectionSettings.DefaultHostName, 
                    ConnectionSettings.DefaultPort);

                    CacheRegistrationService.Connections.Add(connection);
            }
        }

        public void SaveConnections()
        {
            string filePath = this.GetFilePath();

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            JsonSerializer serializer = new JsonSerializer();

            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
                {
                    ConnectionsDto connectionContainer = this.GetConnections();

                    serializer.Serialize(jsonWriter, connectionContainer);
                }
            }
        }

        public ConnectionsDto GetConnections()
        {
            return new ConnectionsDto(CacheRegistrationService.Connections);
        }

        private string GetFilePath()
        {
            string filePath = string.Empty;

            filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            filePath = Path.Combine(filePath, CacheRegistrationService.DefaultFileName);

            return filePath;
        }

    }
}
