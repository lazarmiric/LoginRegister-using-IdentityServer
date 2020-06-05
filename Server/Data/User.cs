using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Data
{
    public class User
    {
        public int UserID { get; set; }
        public String UserName { get; set; }

        public String Password { get; set; }
        public String Email { get; set; }
    }
}
