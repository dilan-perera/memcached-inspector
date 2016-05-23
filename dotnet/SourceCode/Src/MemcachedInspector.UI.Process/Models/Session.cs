using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.UI.Process.Models
{
    public class Session
    {

        public Guid ID
        {
            get;
            private set;
        }

        public Connection Connection
        {
            get;
            private set;
        }

        public Session(Guid id)
        {
            this.ID = id;
        }

        internal Session(Connection connection)
        {
            this.Connection = connection;
        }

    }
}
