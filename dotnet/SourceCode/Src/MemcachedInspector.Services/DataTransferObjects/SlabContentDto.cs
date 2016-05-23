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
    public class SlabContentDto
    {

        [DataMember(Order = 1)]
        public int ItemCount
        {
            get;
            set;
        }

        [DataMember(Order = 2)]
        public int OldestItemAge
        {
            get;
            set;
        }

        [DataMember(Order = 3)]
        public int EvictedItemCount
        {
            get;
            set;
        }

        [DataMember(Order = 4)]
        public int LastItemEvictedAt
        {
            get;
            set;
        }

    }
}
