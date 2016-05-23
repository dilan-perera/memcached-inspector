using MemcachedInspector.Services.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.Services.BusinessServices.ParserCommands
{
    internal class SlabsStatisticsParserCommand : StatisticsParserCommand
    {

        public SlabsDto SlabContainer
        {
            get;
            private set;
        }


        public SlabsStatisticsParserCommand(string content) : base(content)
        {
            this.SlabContainer = new SlabsDto();
        }

        protected override void ParseText()
        {
            this.SlabContainer.Slabs.Clear();

            string payload = this.GetPayload();

            string[] lines = payload.Split(
                this.LineDelimiter, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, string> lineIndex = new Dictionary<string, string>();

            foreach (string line in lines)
            {
                string dataLine = line.Replace("STAT ", string.Empty);

                string[] dataLineArray = dataLine.Split(
                    this.ElementDelimiter, StringSplitOptions.RemoveEmptyEntries);

                if (dataLineArray.Length == 2)
                {
                    string key = dataLineArray[0];
                    string value = dataLineArray[1];

                    lineIndex[key] = value;
                }
            }

            this.SlabContainer.ActiveSlabCount = int.Parse(lineIndex["active_slabs"]);
            this.SlabContainer.TotalMemoryAllocated = int.Parse(lineIndex["total_malloced"]);

            if (this.SlabContainer.ActiveSlabCount > 0)
            {
                for (int slabNumber = 1; slabNumber <= this.SlabContainer.ActiveSlabCount; slabNumber++)
                {
                    SlabDto slab = new SlabDto();

                    slab.ID = slabNumber;

                    string key = string.Empty;

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "chunk_size");
                    slab.Statistics.ChunkSize = int.Parse(lineIndex[key]);

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "chunks_per_page");
                    slab.Statistics.ChunksPerPage = int.Parse(lineIndex[key]);

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "total_pages");
                    slab.Statistics.TotalPages = int.Parse(lineIndex[key]);

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "total_chunks");
                    slab.Statistics.TotalChunks = int.Parse(lineIndex[key]);

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "used_chunks");
                    slab.Statistics.UsedChunks = int.Parse(lineIndex[key]);

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "free_chunks");
                    slab.Statistics.FreeChunks = int.Parse(lineIndex[key]);

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "free_chunks_end");
                    slab.Statistics.FreeChunksEnd = int.Parse(lineIndex[key]);

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "mem_requested");
                    slab.Statistics.MemoryRequested = int.Parse(lineIndex[key]);

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "get_hits");
                    slab.Statistics.GetOperationHits = int.Parse(lineIndex[key]);

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "cmd_set");
                    slab.Statistics.SetOperationHits = int.Parse(lineIndex[key]);

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "delete_hits");
                    slab.Statistics.DeleteOperationHits = int.Parse(lineIndex[key]);

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "incr_hits");
                    slab.Statistics.IncrementOperationHits = int.Parse(lineIndex[key]);

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "decr_hits");
                    slab.Statistics.DecrementOperationHits = int.Parse(lineIndex[key]);

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "cas_hits");
                    slab.Statistics.CasOperationHits = int.Parse(lineIndex[key]);

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "cas_badval");
                    slab.Statistics.CasBadValues = int.Parse(lineIndex[key]);

                    this.SlabContainer.Slabs.Add(slab);
                }
            }
        }

        private SlabDto GetSlab(string line)
        {
            SlabDto slab = null;


            return slab;
        }
    }
}
