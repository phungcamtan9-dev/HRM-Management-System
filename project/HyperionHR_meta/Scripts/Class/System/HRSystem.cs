using HyperionHR_meta.Scripts.Class.HR_Operations;
using HyperionHR_meta.Scripts.Class.Organizations;
using HyperionHR_meta.Scripts.Class.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HyperionHR_meta.Scripts.Class.System
{
    [Serializable]
    public class HRSystem
    {
        //Các list dữ liệu của hệ thống
        public List<Employee> Employees { get; set; } //Danh sách nhân viên
        public List<Department> Departments { get; set; } //Danh sách phòng ban
        public List<Account> Accounts { get; set; } // Danh sách tài khoản
        public List<Attendance> Attendances { get; set; } // Danh sách hợp đồng


        //Singleton
        private static HRSystem _instance;
        public static HRSystem Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HRSystem();

                return _instance;
            }
        }

        //Constructor
        public HRSystem()
        {
            Employees = new List<Employee>();
            Departments = new List<Department>();
            Accounts = new List<Account>();
            Attendances = new List<Attendance>();
        }

        // Save dữ liệu (Serialize JSON)
        public void Save(string fileName)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                JsonSerializer.Serialize<HRSystem>(fs, this, options);
            }
        }

        // Load dữ liệu (Deserialize JSON)
        public void Load(string fileName)
        {
            if (!File.Exists(fileName))
                return;

            HRSystem data;

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                data = JsonSerializer.Deserialize<HRSystem>(fs);
            }

            if (data != null)
            {
                Employees = data.Employees;
                Departments = data.Departments;
                Accounts = data.Accounts;
                Attendances = data.Attendances;
            }
        }






        /// <summary>
        /// Vùng các methods
        /// </summary>
        /// Vùng quản lý tài khoản:
        public Account CurrentUser { get; private set; } //Tài khoản đang đăng nhập

        //Hàm login
        public bool Login(string username, string password)
        {
            foreach (Account acc in Accounts)
            {
                if (acc.Username == username && acc.Password == password)
                {                   
                    CurrentUser = acc;
                    return true;
                }    
            }
            return false;
        }

        //Hàm logout
        public void Logout()
        {
            CurrentUser = null;
        }

        //Hàm tạo tk
        public void CreateAccount(string username, string password, Role role)
        {
            Account acc = new Account(username, password, role);
            Accounts.Add(acc);
        }

        
        //==============================================================================

    }
}
