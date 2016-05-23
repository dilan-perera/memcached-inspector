using MemcachedInspector.Services.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.UI.Process.Models
{
    public class Connection
    {

        public string Name
        {
            get;
            set;
        }

        public string HostName
        {
            get;
            set;
        }

        public int Port
        {
            get;
            set;
        }

        public Connection(string name, string hostName, int port)
        {
            this.Name = name;
            this.HostName = hostName;
            this.Port = port;
        }

        internal Connection(ConnectionDto connection) : this(connection.Name, connection.HostName, connection.Port)
        {
        }

    }
}
