using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.Common
{
    public static class OperatingEnvironment
    {

        public static readonly string NewLine = string.Empty;

        static OperatingEnvironment()
        {
            OperatingEnvironment.NewLine = Environment.NewLine;
        }

    }
}
