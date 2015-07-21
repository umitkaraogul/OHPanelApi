using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHPanelApi.Panels.Maestro
{
    public class Limit
    {
        public string Name { get; set; }
         public string ModuleName { get; set; }
         public string FriendlyName { get; set; }
        public int Limitx { get; set; }
        public int Usage { get; set; }
        public bool IsUnlimited { get; set; }
        public bool Pooling { get; set; }
        public string Group { get; set; }
    }

}
