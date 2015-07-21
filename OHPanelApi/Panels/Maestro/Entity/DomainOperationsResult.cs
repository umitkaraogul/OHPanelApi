using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OHPanelApi.Panels.Maestro
{
    public class DomainOperationsResult
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool DomainUser { get; set; }
        public string IpString { get; set; }

        public List<DomainOperationModuleResult> ModuleResults { get; set; }

        public DomainOperationsResult()
        {
            ModuleResults = new List<DomainOperationModuleResult>();

        }
    }

}
