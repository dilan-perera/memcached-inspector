using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.Services.DataTransferObjects
{

    [Serializable]
    [DataContract]
    public class ConnectionsDto
    {

        [DataMember]
        public Collection<ConnectionDto> Connections
        {
            get;
            private set;
        }

        public ConnectionsDto() : this(new Collection<ConnectionDto>())
        {
        }

        public ConnectionsDto(Collection<ConnectionDto> connections)
        {
            this.Connections = connections;
        }

    }
}
