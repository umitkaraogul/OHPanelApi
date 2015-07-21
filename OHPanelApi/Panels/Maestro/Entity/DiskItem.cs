using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHPanelApi.Panels.Maestro
{
    public class DiskItem
    {
        public string Name { get; set; }
        public string Typ{ get; set; }
         public bool Read{ get; set; }
        public bool Write{ get; set; }
        public bool IsLock{ get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public int Size { get; set; }
    }
}
