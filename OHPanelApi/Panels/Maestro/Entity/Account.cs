using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OHPanelApi.Panels.Maestro
{
    public class Account
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public int Quota { get; set; }
        public int Usage { get; set; }
    }
}
