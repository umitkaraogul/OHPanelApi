using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHPanelApi
{
    public class Database
    {
        public int Id { get; set; }
        /// <summary>
        /// Domain Name
        /// </summary>
        public string Name { get; set; }
        public string DbType { get; set; }
        public string Database_{ get; set; }
        public int? Quota { get; set; }
        public string Host { get; set; }

        public List<DatabaseUser> Users { get; set; }

        public Database() 
        {
            this.Users = new List<DatabaseUser>();
        }
     
    }

    public class DatabaseUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    
}
