using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHPanelApi.Panels.Maestro
{
    public class Whoami
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public UserTypes Type { get; set; }
        public int Status { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Organization { get; set; }

    }
}
