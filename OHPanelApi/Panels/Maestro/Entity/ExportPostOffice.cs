using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHPanelApi.Panels.Maestro
{
    public class ExportPostOffice
    {
        public string Name { get; set; }
        public int Quota { get; set; }
        List<Account> Accounts { get; set; }
    }
}
