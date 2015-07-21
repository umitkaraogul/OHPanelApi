using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHPanelApi
{

    public class DomainLimit
    {
        public string Name { get; set; }
        public int MaxDiskSpace { get; set; }
        public int MaxMailBox { get; set; }
        public int MaxFtpUser { get; set; }
        public int MaxSubDomain { get; set; }
        public int MaxDomainAlias { get; set; }
        public int TotalWebTraffic { get; set; }
        public int TotalMailSpace { get; set; }
        public int MaxWebTraffic { get; set; }
        public int MaxFtpTraffic { get; set; }
        public int MaxMailTraffic { get; set; }
        public int MaxMySql { get; set; }
        public int MaxMySqlUser { get; set; }
        public int MaxMySqlSpace { get; set; }
        public int MaxMsSql { get; set; }
        public int MaxMsSqlUser { get; set; }
        public int MaxMsSqlSpace { get; set; }

        public DomainLimit()
        {
        }


        public string ResellerName { get; set; }

        public int MaxDomain { get; set; }
    }
}
