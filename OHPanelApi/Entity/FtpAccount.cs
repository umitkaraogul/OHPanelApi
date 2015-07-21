using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHPanelApi
{
    public class FtpAccount
    {

        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string HomePath { get; set; }
        public bool Ronly { get; set; }

    }
}
