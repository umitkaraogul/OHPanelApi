using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OHPanelApi.Panels.Maestro
{
    public class DomainListItem
    {
        public int Code { get; set; }
        public string Message { get; set; }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public DomainStatuses Status { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string OwnerName { get; set; }
        public string Email { get; set; }
        public string Disk { get; set; }
        public List<string> IpList { get; set; }

    }

    public enum DomainStatuses
    {
        Start,
        Stop,
        inProcess
    }
}
