using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.System
{
    
    public class Account
    {
        //thuộc tính
        public string Username { get; set; }
        public string Password { get; private set; }
        public Role Role { get; set; } //biến để phân quyền

        //Constructor
        public Account(string userName, string password, Role role)
        {
            this.Username = userName;
            this.Password = password;
            this.Role = role;
        }

        //Methods:
        public bool checkPassword(string passInput)
        {
            if ( passInput == Password ) return true;
            return false;
        }
    }
}
