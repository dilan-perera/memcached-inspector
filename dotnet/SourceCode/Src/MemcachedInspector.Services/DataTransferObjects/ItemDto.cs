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
    public class ItemDto
    {

        [DataMember(Order = 1)]
        public string Key
        {
            get;
            set;
        }

        [DataMember(Order = 2)]
        public bool WasValueRetrieved
        {
            get;
            set;
        }

        [DataMember(Order = 3)]
        public object Value
        {
            get;
            set;
        }

    }
}
