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

    internal class SlabContentParserCommand : StatisticsParserCommand
    {

        public SlabsDto SlabContainer
        {
            get;
            private set;
        }
        
        public SlabContentParserCommand(string content) : base(content)
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
                string dataLine = line.Replace("STAT items:", string.Empty);

                string[] dataLineArray = dataLine.Split(
                    this.ElementDelimiter, StringSplitOptions.RemoveEmptyEntries);

                if (dataLineArray.Length == 2)
                {
                    string key = dataLineArray[0];
                    string value = dataLineArray[1];

                    lineIndex[key] = value;
                }
            }
            
            for (int slabNumber = 1; slabNumber <= int.MaxValue; slabNumber++)
            {
                string key = string.Empty;

                key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "number");

                if (lineIndex.ContainsKey(key))
                {
                    SlabDto slab = new SlabDto();

                    slab.ID = slabNumber;
                    slab.Contents.ID = slabNumber;

                    slab.Contents.ItemCount = int.Parse(lineIndex[key]);

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "age");
                    slab.Contents.OldestItemAge = long.Parse(lineIndex[key]);

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "evicted");
                    slab.Contents.EvictedItemCount = int.Parse(lineIndex[key]);

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "evicted_time");
                    slab.Contents.LastItemEvictedAt = int.Parse(lineIndex[key]);

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "evicted_nonzero");
                    slab.Contents.LastNonZeroItemEvictedAt = int.Parse(lineIndex[key]);

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "outofmemory");

                    if (lineIndex.ContainsKey(key))
                    {
                        slab.Contents.OutOfMemoryTriggeringItemCount = int.Parse(lineIndex[key]);
                        slab.Contents.IsOutOfMemoryTriggerItemCountAvailable = true;
                    }
                    else
                    {
                        slab.Contents.IsOutOfMemoryTriggerItemCountAvailable = false;
                    }

                    key = string.Format(CultureInfo.InvariantCulture, "{0}:{1}", slabNumber, "tailrepairs");
                    slab.Contents.TailRepairItemCount = int.Parse(lineIndex[key]);

                    this.SlabContainer.Slabs.Add(slab);
                }
                else
                {
                    break;
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
