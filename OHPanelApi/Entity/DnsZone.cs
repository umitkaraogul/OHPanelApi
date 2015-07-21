using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHPanelApi
{
    public class DnsZone
    {
        public string Name { get; set; }
       
        public int SoaExpire { get; set; }
        public int SoaTtl { get; set; }
        public int SoaRefresh { get; set; }
        public string SoaEmail { get; set; }
        public int SoaRetry { get; set; }
        public int SoaSerial { get; set; }
        public string PrimaryServer { get; set; }
      
        public List<DnsZoneRecord> Records { get; set; }
      

        public DnsZone()
        {
            Records = new List<DnsZoneRecord>();
        }


    }

    public class DnsZoneRecord
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Host { get; set; }
        public int Priority { get; set; }
        public string Value { get; set; }

        public string RecordString
        {
            get
            {
                return String.Format("{0},{1},{2},{3}", this.Name, this.Type, this.Value, this.Priority);
            }
        }
        
    }
}
