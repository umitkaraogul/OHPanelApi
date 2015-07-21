using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHPanelApi
{
    public class CreateSSLRequest
    {
        public string DomainName { get; set; }
        public string CommonName { get; set; }
        public string Organization { get; set; }
        public string OrganizationUnit { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CountryCode { get; set; }
    }
}
