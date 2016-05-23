using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.Common.Exceptions
{
    public class CacheServerException : CacheException
    {
        
        public CacheServerException() : base()
        {

        }

        public CacheServerException(string message) : base(message)
        {

        }

        public CacheServerException(string message, Exception innerException) : base(message, innerException)
        {

        }

        [SecuritySafeCritical]
        protected CacheServerException(SerializationInfo info, StreamingContext context)
        {

        }

    }
}
