using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHPanelApi.Panels.Maestro
{
    public class ResellerOperationResult
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public int ClientId { get; set; }
        public string ClientName { get; set; }
    }
}
