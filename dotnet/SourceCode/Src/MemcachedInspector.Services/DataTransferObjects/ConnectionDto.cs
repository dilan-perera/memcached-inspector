using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.Services.DataTransferObjects
{

    [Serializable]
    [DataContract]
    public class ConnectionDto
    {

        [DataMember(Order = 1)]
        public string Name
        {
            get;
            private set;
        }

        [DataMember(Order = 2)]
        public string HostName
        {
            get;
            private set;
        }

        [DataMember(Order = 3)]
        public int Port
        {
            get;
            private set;
        }

        public ConnectionDto(string name, string hostName, int port)
        {
            this.Name = name;
            this.HostName = hostName;
            this.Port = port;
        }

    }
}
