using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.Services.BusinessServices.ParserCommands
{
    internal abstract class StatisticsParserCommand : ParserCommand
    {

        protected StatisticsParserCommand(string content) : base(content)
        {
        }

    }
}
