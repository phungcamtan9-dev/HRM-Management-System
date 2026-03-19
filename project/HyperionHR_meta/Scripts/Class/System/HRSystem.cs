using HyperionHR_meta.Scripts.Class.HR_Operations;
using HyperionHR_meta.Scripts.Class.Organizations;
using HyperionHR_meta.Scripts.Class.Person;
using HyperionHR_meta.Scripts.Class.Payrolls;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;


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
        public List<Employee> Employees { get; set; }
        public List<Account> Accounts { get; set; }

        // Nhóm Tổ chức
        public List<Branch> Branches { get; set; }
        public List<Department> Departments { get; set; }
        public List<Position> Positions { get; set; }

        // Nhóm Nghiệp vụ HR
        public List<Contract> Contracts { get; set; }
        public List<LeaveRequest> LeaveRequests { get; set; }
        public List<Notification> Notifications { get; set; }
        public List<Attendance> Attendances { get; set; }     
        public List<ActivityLog> ActivityLogs { get; set; }   

        // Nhóm Tính lương
        public List<Payroll> Payrolls { get; set; } 



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

            options.ReferenceHandler = ReferenceHandler.Preserve;

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

            FileInfo thongTinFile = new FileInfo(fileName);
            if (thongTinFile.Length == 0)
            {
                return; // Nếu file 0 byte thì thoát luôn, không đọc nữa
            }

            JsonSerializerOptions options = new JsonSerializerOptions();
            options.ReferenceHandler = ReferenceHandler.Preserve;

            HRSystem data;

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                data = JsonSerializer.Deserialize<HRSystem>(fs,options);
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


                // Làm sạch danh sách nhân viên trong phòng ban (tránh bị nhân đôi nếu Load nhiều lần)
                foreach (Department dept in Departments)
                {
                    dept.NhanVien.Clear();
                }

                // Duyệt qua toàn bộ nhân viên, ai có phòng ban thì gán lại vào phòng ban đó
                foreach (Employee emp in Employees)
                {
                    if (emp.PhongBan != null)
                    {
                        emp.PhongBan.AddEmployee(emp);
                    }
                }
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


        // ==========================================
        // 9. HÀM TẠO DỮ LIỆU MẪU (DUMMY DATA) - CẬP NHẬT MỚI
        // ==========================================

        public void TaoDuLieuMau()
        {
            // Tránh tạo trùng lặp nếu đã có dữ liệu
            if (Accounts.Count > 0) return;

            Random rnd = new Random();

            // 1. TẠO CÁC CHỨC VỤ TRONG CÔNG TY
            Position posAdmin = new Position("QLIT", "Trưởng phòng IT", "Quản trị hệ thống");
            Position posHR = new Position("QLKT", "Trưởng phòng Kế Toán", "Quản lý nhân sự và lương");
            Position posManager = new Position("QLMKT", "Trưởng phòng Marketing", "Quản lý chiến dịch");
            Position posEmp = new Position("NVPT", "Nhân viên Part-time", "Nhân viên bán thời gian");

            Positions.Add(posAdmin);
            Positions.Add(posHR);
            Positions.Add(posManager);
            Positions.Add(posEmp);

            // 2. TẠO CHI NHÁNH & PHÒNG BAN
            // Chi nhánh 1
            Branch cn1 = new Branch("CN01", "Chi nhánh 1", "279 Nguyễn Tri Phương", null);
            Department mkt1 = new Department("PB_MKT1", "Marketing");
            Department it1 = new Department("PB_IT1", "IT");
            Department kt1 = new Department("PB_KT1", "Kế Toán");

            cn1.AddDepartment(mkt1);
            cn1.AddDepartment(it1);
            cn1.AddDepartment(kt1);
            Branches.Add(cn1);
            Departments.Add(mkt1); Departments.Add(it1); Departments.Add(kt1);

            // Chi nhánh 2
            Branch cn2 = new Branch("CN02", "Chi nhánh 2", "59C Nguyễn Đình Chiểu", null);
            Department it2 = new Department("PB_IT2", "IT");
            Department kt2 = new Department("PB_KT2", "Kế Toán");

            cn2.AddDepartment(it2);
            cn2.AddDepartment(kt2);
            Branches.Add(cn2);
            Departments.Add(it2); Departments.Add(kt2);

            // 3. TẠO NHÂN SỰ VÀ TÀI KHOẢN HÀNG LOẠT
            int idCounter = 1; // Biến đếm để tạo ID tự động (ID001, ID002...)

            // --- CHI NHÁNH 1 ---
            // Sếp Tân và phòng IT 1 (Quyền Admin)
            TaoMotPhongBan(it1, posAdmin, posEmp, Role.Admin,
                "Phùng Cẩm Tân", "phungcamtan", new DateTime(2006, 11, 14), "Nam",
                new string[] { "Vũ Thị Hoa", "Đỗ Văn Khoa", "Ngô Thị Ngọc", "Bùi Văn Tuấn" },
                new string[] { "vuthihoa", "dovankhoa", "ngothingoc", "buivantuan" },
                ref idCounter, rnd);

            // Phòng Marketing 1 (Quyền Manager)
            TaoMotPhongBan(mkt1, posManager, posEmp, Role.Manager,
                "Trần Văn Phong", "tranvanphong", new DateTime(1990, 5, 20), "Nam",
                new string[] { "Nguyễn Thị Lan", "Lê Văn Tâm", "Phạm Thị Mai", "Hoàng Văn Huy" },
                new string[] { "nguyenthilan", "levantam", "phamthimai", "hoangvanhuy" },
                ref idCounter, rnd);

            // Phòng Kế Toán 1 (Quyền HR)
            TaoMotPhongBan(kt1, posHR, posEmp, Role.HR,
                "Lê Thị Nhàn", "lethinhan", new DateTime(1992, 8, 15), "Nữ",
                new string[] { "Phan Văn Đạt", "Trịnh Thị Hà", "Lý Văn Phát", "Đào Thị Cẩm" },
                new string[] { "phanvandat", "trinhthiha", "lyvanphat", "daothicam" },
                ref idCounter, rnd);


            // --- CHI NHÁNH 2 ---
            // Phòng IT 2 (Quyền Admin)
            TaoMotPhongBan(it2, posAdmin, posEmp, Role.Admin,
                "Nguyễn Hải Đăng", "nguyenhaidang", new DateTime(1995, 12, 1), "Nam",
                new string[] { "Trần Thị Thu", "Lê Văn Hải", "Phạm Thị Bình", "Vũ Văn Kiên" },
                new string[] { "tranthithu", "levanhai", "phamthibinh", "vuvankien" },
                ref idCounter, rnd);

            // Phòng Kế Toán 2 (Quyền HR)
            TaoMotPhongBan(kt2, posHR, posEmp, Role.HR,
                "Hoàng Thị Yến", "hoangthiyen", new DateTime(1994, 3, 30), "Nữ",
                new string[] { "Đoàn Văn Tiến", "Nguyễn Thị Quyên", "Lê Văn Long", "Phạm Thị Dung" },
                new string[] { "doanvantien", "nguyenthiquyen", "levanlong", "phamthidung" },
                ref idCounter, rnd);

            // Bổ nhiệm đại 1 quản lý làm Giám đốc chi nhánh
            cn1.NguoiQuanLy = it1.NguoiQuanLy;
            cn2.NguoiQuanLy = kt2.NguoiQuanLy;
        }

        // ==========================================
        // HÀM TIỆN ÍCH: TẠO 1 PHÒNG BAN CÓ 1 QUẢN LÝ VÀ 4 NHÂN VIÊN
        // ==========================================
        public void TaoMotPhongBan(Department phongBan, Position chucVuQuanLy, Position chucVuNhanVien, Role quyenQuanLy,
                                    string tenQL, string userQL, DateTime nsQL, string gtQL,
                                    string[] tenNVs, string[] userNVs, ref int idCounter, Random rnd)
        {
            // 1. TẠO QUẢN LÝ (FULL-TIME)
            // SỬA LỖI: Truyền 'null' vào vị trí thứ 2 (Employee)
            Contract hdQL = new Contract("HD" + idCounter, null, new DateTime(2024, rnd.Next(1, 13), rnd.Next(1, 28)), new DateTime(2027, rnd.Next(1, 13), rnd.Next(1, 28)), "Full-time");
            Contracts.Add(hdQL);

            // Khởi tạo Quản lý
            FullTimeEmployee quanLy = new FullTimeEmployee(
                "ID" + idCounter.ToString("D3"), tenQL, nsQL, gtQL, userQL + "@gmail.com", "09" + rnd.Next(10000000, 99999999),
                "NV" + idCounter.ToString("D3"), phongBan, chucVuQuanLy, hdQL, 15000000, 200000);

            // SỬA LỖI: Gán ngược lại Quản lý vào Hợp đồng
            hdQL.NhanVien = quanLy;

            idCounter++;

            phongBan.AssignManager(quanLy);
            Employees.Add(quanLy);

            // Tài khoản Quản lý
            Account tkQL = new Account(userQL, nsQL.ToString("ddMMyyyy"), quyenQuanLy, quanLy);
            Accounts.Add(tkQL);

            // 2. TẠO 4 NHÂN VIÊN (PART-TIME)
            for (int i = 0; i < 4; i++)
            {
                DateTime nsNV = new DateTime(rnd.Next(1995, 2005), rnd.Next(1, 13), rnd.Next(1, 28));
                string gtNV = (i % 2 == 0) ? "Nữ" : "Nam";

                // SỬA LỖI: Truyền 'null' vào vị trí thứ 2 (Employee)
                Contract hdNV = new Contract("HD" + idCounter, null, new DateTime(2024, rnd.Next(1, 13), rnd.Next(1, 28)), new DateTime(2027, rnd.Next(1, 13), rnd.Next(1, 28)), "Part-time");
                Contracts.Add(hdNV);

                PartTimeEmployee nv = new PartTimeEmployee(
                    "ID" + idCounter.ToString("D3"), tenNVs[i], nsNV, gtNV, userNVs[i] + "@gmail.com", "09" + rnd.Next(10000000, 99999999),
                    "NV" + idCounter.ToString("D3"), phongBan, chucVuNhanVien, hdNV, 120, 25000);

                // SỬA LỖI: Gán ngược lại Nhân viên vào Hợp đồng
                hdNV.NhanVien = nv;

                idCounter++;

                phongBan.AddEmployee(nv);
                Employees.Add(nv);

                // Tài khoản Nhân viên
                Account tkNV = new Account(userNVs[i], nsNV.ToString("ddMMyyyy"), Role.Employee, nv);
                Accounts.Add(tkNV);
            }
        }

    }
}
