using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHPanelApi
{
    public class DnsRecord
    {
        public string Name { get; set; }
        public string RecType { get; set; }
        public string RecName { get; set; }
        public string RecValue { get; set; }
        public int Priority { get; set; }

    }
}
