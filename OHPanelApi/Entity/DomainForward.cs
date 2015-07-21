using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHPanelApi
{
    public class DomainForward
    {
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public string Destination { get; set; }
        public bool ExacDestination { get; set; }
        public bool ChildOnly { get; set; }
        public string StatusCode { get; set; }
    }
}
