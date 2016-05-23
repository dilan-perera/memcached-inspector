using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.Common.Exceptions
{
    public class CacheException : Exception
    {
        
        public CacheException() : base()
        {

        }

        public CacheException(string message) : base(message)
        {

        }

        public CacheException(string message, Exception innerException) : base(message, innerException)
        {

        }

        [SecuritySafeCritical]
        protected CacheException(SerializationInfo info, StreamingContext context)
        {

        }

    }
}
