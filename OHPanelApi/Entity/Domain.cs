using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OHPanelApi
{
    public class Domain
    {
        public int Id { get; set; }
        public string Name { get; set; }
       // public string Status { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string OwnerName { get; set; }

        public string PlanAlias { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool ActiveDomainUser { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string ResellerName { get; set; }
    }

}
