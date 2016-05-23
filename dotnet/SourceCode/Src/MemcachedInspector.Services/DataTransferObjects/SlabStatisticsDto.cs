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
    public class SlabStatisticsDto
    {
        
        [DataMember(Order = 1)]
        public int ChunkSize
        {
            get;
            set;
        }

        [DataMember(Order = 2)]
        public int ChunksPerPage
        {
            get;
            set;
        }


        [DataMember(Order = 3)]
        public int TotalPages
        {
            get;
            set;
        }

        [DataMember(Order = 4)]
        public int TotalChunks
        {
            get;
            set;
        }

        [DataMember(Order = 5)]
        public int UsedChunks
        {
            get;
            set;
        }

        [DataMember(Order = 6)]
        public int FreeChunks
        {
            get;
            set;
        }

        [DataMember(Order = 7)]
        public int FreeChunksEnd
        {
            get;
            set;
        }

        [DataMember(Order = 8)]
        public int MemoryRequested
        {
            get;
            set;
        }

        [DataMember(Order = 9)]
        public int GetOperationHits
        {
            get;
            set;
        }

        [DataMember(Order = 10)]
        public int SetOperationHits
        {
            get;
            set;
        }

        [DataMember(Order = 11)]
        public int DeleteOperationHits
        {
            get;
            set;
        }

        [DataMember(Order = 12)]
        public int IncrementOperationHits
        {
            get;
            set;
        }

        [DataMember(Order = 13)]
        public int DecrementOperationHits
        {
            get;
            set;
        }

        [DataMember(Order = 14)]
        public int CasOperationHits
        {
            get;
            set;
        }

        [DataMember(Order = 15)]
        public int CasBadValues
        {
            get;
            set;
        }

    }
}
