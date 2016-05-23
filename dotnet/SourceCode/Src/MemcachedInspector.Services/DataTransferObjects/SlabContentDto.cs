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
        public int ID
        {
            get;
            set;
        }

        [DataMember(Order = 2)]
        public int ItemCount
        {
            get;
            set;
        }

        [DataMember(Order = 3)]
        public long OldestItemAge
        {
            get;
            set;
        }

        [DataMember(Order = 4)]
        public int EvictedItemCount
        {
            get;
            set;
        }

        [DataMember(Order = 5)]
        public int LastItemEvictedAt
        {
            get;
            set;
        }

        [DataMember(Order = 6)]
        public int LastNonZeroItemEvictedAt
        {
            get;
            set;
        }

        [DataMember(Order = 7)]
        public int OutOfMemoryTriggeringItemCount
        {
            get;
            set;
        }

        [DataMember(Order = 8)]
        public bool IsOutOfMemoryTriggerItemCountAvailable
        {
            get;
            set;
        }

        [DataMember(Order = 9)]
        public int TailRepairItemCount
        {
            get;
            set;
        }
    }
}
