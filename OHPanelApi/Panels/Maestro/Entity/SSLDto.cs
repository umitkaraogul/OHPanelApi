using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHPanelApi.Panels.Maestro
{
    public class SSLDto
    {
        public string Name { get; set; }
        public string ExpirationDate { get; set; }
        public string CertificateHash { get; set; }
        public string PublicKey { get; set; }
        public string RequestKey { get; set; }
        public string PrivateKey { get; set; }
        public string RawCertData { get; set; }
        public string ResponseCAkey { get; set; }
        public string Organization { get; set; }
        public string OrganizationUnit { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public bool hasPrivateKey { get; set; }
        public int Status { get; set; }
        public string IpAddr { get; set; }

    }
}
