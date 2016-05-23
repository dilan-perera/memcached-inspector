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
    public class SlabDto
    {

        [DataMember(Order = 1)]
        public int ID
        {
            get;
            set;
        }

        [DataMember(Order = 2)]
        public SlabStatisticsDto Statistics
        {
            get;
            set;
        }

        [DataMember(Order = 2)]
        public SlabContentDto Contents
        {
            get;
            set;
        }

        public SlabDto()
        {
            this.Statistics = new SlabStatisticsDto();
            this.Contents = new SlabContentDto();
        }

    }
}
