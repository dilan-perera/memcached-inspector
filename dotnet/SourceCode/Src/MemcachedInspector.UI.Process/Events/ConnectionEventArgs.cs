using MemcachedInspector.UI.Process.Models;

namespace MemcachedInspector.UI.Process.Events
{
    public class ConnectionEventArgs
    {

        public Connection Connection
        {
            get;
            internal set;
        }

    }
}