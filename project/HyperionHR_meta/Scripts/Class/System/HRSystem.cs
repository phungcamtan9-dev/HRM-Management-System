using HyperionHR_meta.Scripts.Class.HR_Operations;
using HyperionHR_meta.Scripts.Class.Organizations;
using HyperionHR_meta.Scripts.Class.Person;
using HyperionHR_meta.Scripts.Class.Payrolls;
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
        // ==========================================
        // TRIỂN KHAI SINGLETON 
        // ==========================================
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



        // ==========================================
        // KHAI BÁO CÁC DANH SÁCH QUẢN LÝ
        // ==========================================

        // Nhóm Con người & Hệ thống
        public List<Employee> Employees { get; private set; }
        public List<Account> Accounts { get; private set; }

        // Nhóm Tổ chức
        public List<Branch> Branches { get; private set; }
        public List<Department> Departments { get; private set; }
        public List<Position> Positions { get; private set; }

        // Nhóm Nghiệp vụ HR
        public List<Contract> Contracts { get; private set; }
        public List<LeaveRequest> LeaveRequests { get; private set; }
        public List<Notification> Notifications { get; private set; }
        public List<Attendance> Attendances { get; private set; }     
        public List<ActivityLog> ActivityLogs { get; private set; }   

        // Nhóm Tính lương
        public List<Payroll> Payrolls { get; private set; } 



        // Constructor
        public HRSystem()
        {
            Employees = new List<Employee>();
            Accounts = new List<Account>();

            Branches = new List<Branch>();
            Departments = new List<Department>();
            Positions = new List<Position>();

            Contracts = new List<Contract>();
            LeaveRequests = new List<LeaveRequest>();
            Notifications = new List<Notification>();
            Attendances = new List<Attendance>();
            ActivityLogs = new List<ActivityLog>();
            Payrolls = new List<Payroll>();
        }



        // ==========================================
        // NGHIỆP VỤ HỆ THỐNG (METHODS SYSTEM)
        // ==========================================

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
            {
                return;
            }

            HRSystem data;

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                data = JsonSerializer.Deserialize<HRSystem>(fs);
            }

            if (data != null)
            {
                // Gán lại dữ liệu từ file JSON vào các danh sách hiện tại
                Employees = data.Employees;
                Accounts = data.Accounts;

                Branches = data.Branches;
                Departments = data.Departments;
                Positions = data.Positions;

                Contracts = data.Contracts;
                LeaveRequests = data.LeaveRequests;
                Attendances = data.Attendances;
                ActivityLogs = data.ActivityLogs;
                Payrolls = data.Payrolls;
            }
        }



        // ==========================================
        // Quản lý tài khoản và đăng nhập
        // ==========================================
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
        public void CreateAccount(string username, string password, Role role, Employee emp)
        {
            Account acc = new Account(username, password, role, emp);
            Accounts.Add(acc);
        }

        // ==========================================
        // TRIỂN KHAI DELEGATE (LỌC NHÂN VIÊN)
        // ==========================================

        // Khai báo Delegate. 
        // Bất kỳ hàm nào nhận vào 1 Employee và trả về bool đều có thể "gắn" vào đây.
        public delegate bool EmployeeFilter(Employee emp);

        // Viết hàm lọc dùng Delegate
        public List<Employee> GetEmployeesByCondition(EmployeeFilter conditionMethod)
        {
            List<Employee> resultList = new List<Employee>();

            foreach (Employee emp in Employees)
            {
                // Gọi hàm đã được truyền vào qua Delegate
                if (conditionMethod(emp) == true)
                {
                    resultList.Add(emp);
                }
            }

            return resultList;
        }


        // ==========================================
        // NGHIỆP VỤ DUYỆT ĐƠN & NHẬN SỰ KIỆN
        // ==========================================

        // Hàm thêm đơn xin phép mới vào hệ thống
        public void AddLeaveRequest(LeaveRequest request)
        {
            if (request != null && !LeaveRequests.Contains(request))
            {
                LeaveRequests.Add(request);

                request.OnLeaveRequestApproved += HandleLeaveRequestApproved;
            }
        }

        // Hàm xử lý khi sự kiện Duyệt đơn xảy ra
        private void HandleLeaveRequestApproved(LeaveRequest sender)
        {
            // Lấy thông tin từ cái đơn vừa được duyệt
            string tenNhanVien = sender.NhanVien.HoTen;
            string noiDungThongBao = "Xin chào " + tenNhanVien + ", đơn xin nghỉ [" + sender.LoaiNghiPhep + "] của bạn đã được quản lý phê duyệt!";

            // Tạo một cái Notification mới
            string maTB = "TB_" + DateTime.Now.ToString("HHmmss"); // Tạo mã ngẫu nhiên theo giờ
            Notification thongBaoMoi = new Notification(maTB, noiDungThongBao, sender.NhanVien);

            // Thêm vào danh sách thông báo của hệ thống
            Notifications.Add(thongBaoMoi);
        }
    }
}
