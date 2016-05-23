using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.Common.Exceptions
{
    public class CacheConnectionException : CacheException
    {
        
        public CacheConnectionException() : base()
        {

        }

        public CacheConnectionException(string message) : base(message)
        {

        }

        public CacheConnectionException(string message, Exception innerException) : base(message, innerException)
        {

        }

        [SecuritySafeCritical]
        protected CacheConnectionException(SerializationInfo info, StreamingContext context)
        {

        }

    }
}
