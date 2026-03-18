using HyperionHR_meta.Scripts.Class.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.System
{
    [Serializable]
    public class Account
    {
        // Thuộc tính
        public string Username { get; set; }
        public string Password { get; set; } 
        public Role Role { get; set; }

        // Liên kết với Employee
        public Employee Employee { get; set; }

        //Constructor
        public Account()
        {
        }

        // Constructor 
        public Account(string userName, string password, Role role, Employee employee)
        {
            Username = userName;
            Password = password;
            Role = role;
            Employee = employee; // Gắn liên kết nhân viên ngay khi tạo tài khoản
        }
    }
}