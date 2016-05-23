using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.Services.DataTransferObjects
{

    [Serializable]
    [DataContract]
    public class SlabsDto
    {

        [DataMember(Order = 1)]
        public Collection<SlabDto> Slabs
        {
            get;
            set;
        }

        [DataMember(Order = 2)]
        public int ActiveSlabCount
        {
            get;
            set;
        }

        [DataMember(Order = 3)]
        public int TotalMemoryAllocated
        {
            get;
            set;
        }

        public SlabsDto()
        {
            this.Slabs = new Collection<SlabDto>();
        }

    }
}
