using MemcachedInspector.UI.Process.Models;

namespace MemcachedInspector.UI.Process.Events
{
    public class SessionEventArgs
    {

        public Session Session
        {
            get;
            internal set;
        }

    }
}