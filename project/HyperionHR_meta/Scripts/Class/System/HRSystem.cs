using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.System
{
    public class HRSystem
    {
        //Singleton
        private static HRSystem instance;
        private HRSystem() { }
        public static HRSystem Instance
        {
            get {
                if (instance == null)
                    instance = new HRSystem();
                return instance;
            }

        }


        /// <summary>
        /// Các dánh sách và biến toàn cục của hệ thống 
        /// </summary>
        /// Vùng quản lý tài khoản:
        public List<Account> Accounts { get; set; } = new List<Account>(); // Danh sách tài khoản

        public Account CurrentUser { get; private set; } //Tài khoản đang đăng nhập

        //Hàm login
        public bool Login(string username, string password)
        {
            foreach (Account acc in Accounts)
            {
                if (acc.Username == username && acc.Password == password)
                    return true;
                CurrentUser = acc;
            }
            return false;
        }

        //Hàm logout
        public void Logout()
        {
            CurrentUser = null;
        }
        //==============================================================================
        
    }
}
