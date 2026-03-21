using HyperionHR_meta.Scripts.Class.HR_Operations;
using HyperionHR_meta.Scripts.Class.Organizations;
using HyperionHR_meta.Scripts.Class.Payrolls;
using HyperionHR_meta.Scripts.Class.Person;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


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
            // Khởi tạo máy định dạng Nhị phân
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                formatter.Serialize(fs, this);
            }
        }

        // Load dữ liệu (Deserialize JSON)
        public void Load(string fileName)
        {
            // Kiểm tra file có tồn tại và có dữ liệu không
            if (!File.Exists(fileName)) return;

            FileInfo thongTinFile = new FileInfo(fileName);
            if (thongTinFile.Length == 0) return;

            BinaryFormatter formatter = new BinaryFormatter();

            HRSystem data;

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                // Đọc file nhị phân và ép kiểu (cast) về lại HRSystem
                data = (HRSystem)formatter.Deserialize(fs);
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

            // NỐI LẠI SỰ KIỆN CHO CÁC ĐƠN CŨ
            if (LeaveRequests != null)
            {
                foreach (LeaveRequest req in LeaveRequests)
                {
                    // Đăng ký lại cho hệ thống lắng nghe ( vì kh lưu vào file bin khi tắt )
                    req.OnLeaveRequestCreated += HandleLeaveRequestCreated;
                    req.OnLeaveRequestApproved += HandleLeaveRequestApproved;
                    req.OnLeaveRequestRejected += HandleLeaveRequestRejected;
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
        // HÀM TẠO DỮ LIỆU MẪU (DUMMY DATA) - CẬP NHẬT MỚI
        // ==========================================
        public void TaoDuLieuMau()
        {
            if (Accounts.Count > 0) return;

            Random rnd = new Random();

            // 1. TẠO CÁC CHỨC VỤ CHUẨN MỰC
            Position posGiamDoc = new Position("GD", "Giám đốc", "Điều hành toàn công ty");
            Position posTruongPhong = new Position("TP", "Trưởng Phòng", "Quản lý và điều hành phòng ban");
            Position posNhanVienFT = new Position("NVFT", "Nhân viên Full-time", "Nhân viên làm việc hành chính");
            Position posNhanVienPT = new Position("NVPT", "Nhân viên Part-time", "Nhân viên làm việc theo ca/giờ");

            Positions.Add(posGiamDoc); Positions.Add(posTruongPhong);
            Positions.Add(posNhanVienFT); Positions.Add(posNhanVienPT);

            // 2. TẠO CHI NHÁNH & PHÒNG BAN
            Branch cn1 = new Branch("CN01", "Chi nhánh 1", "279 Nguyễn Tri Phương", null);
            Department pbGiamDoc = new Department("PB_GD", "Phòng Giám Đốc"); // Phòng riêng cho sếp Tân
            Department mkt1 = new Department("PB_MKT1", "Marketing");
            Department it1 = new Department("PB_IT1", "IT");
            Department kt1 = new Department("PB_KT1", "Kế Toán");

            cn1.AddDepartment(pbGiamDoc); cn1.AddDepartment(mkt1); cn1.AddDepartment(it1); cn1.AddDepartment(kt1);
            Branches.Add(cn1);
            Departments.Add(pbGiamDoc); Departments.Add(mkt1); Departments.Add(it1); Departments.Add(kt1);

            Branch cn2 = new Branch("CN02", "Chi nhánh 2", "59C Nguyễn Đình Chiểu", null);
            Department it2 = new Department("PB_IT2", "IT");
            Department kt2 = new Department("PB_KT2", "Kế Toán");

            cn2.AddDepartment(it2); cn2.AddDepartment(kt2);
            Branches.Add(cn2);
            Departments.Add(it2); Departments.Add(kt2);

            int idCounter = 1;

            // ==========================================
            // 3. TẠO SẾP TÂN (VIP - PHÒNG GIÁM ĐỐC)
            // ==========================================
            Contract hdTan = new Contract("HD_VIP01", null, new DateTime(2020, 1, 1), new DateTime(2030, 1, 1), "Full-time");
            hdTan.Approve(); // Sếp thì hợp đồng tự động duyệt
            Contracts.Add(hdTan);

            DateTime nsTan = new DateTime(2006, 11, 14);
            FullTimeEmployee sepTan = new FullTimeEmployee(
                "ID" + idCounter.ToString("D3"), "Phùng Cẩm Tân", nsTan, "Nam", "phungcamtan@gmail.com", "0999999999",
                "NV" + idCounter.ToString("D3"), pbGiamDoc, posGiamDoc, hdTan, 30000000, 5000000);

            hdTan.NhanVien = sepTan;
            pbGiamDoc.AddEmployee(sepTan); // Chỉ là nhân viên thuộc phòng, không cần set Trưởng phòng
            Employees.Add(sepTan);
            cn1.NguoiQuanLy = sepTan; // Set sếp Tân làm sếp tổng chi nhánh 1

            Account tkTan = new Account("phungcamtan", nsTan.ToString("ddMMyyyy"), Role.Admin, sepTan);
            Accounts.Add(tkTan);
            idCounter++;

            // ==========================================
            // 4. TẠO NHÂN SỰ CÁC PHÒNG BAN KHÁC
            // ==========================================
            // Phòng IT 1 (Quyền HR để test)
            TaoMotPhongBan(it1, posTruongPhong, posNhanVienPT, Role.HR,
                "Vũ Thị Hoa", "vuthihoa", new DateTime(1995, 2, 10), "Nữ",
                new string[] { "Đỗ Văn Khoa", "Ngô Thị Ngọc", "Bùi Văn Tuấn", "Lê Hải Anh" },
                new string[] { "dovankhoa", "ngothingoc", "buivantuan", "lehaianh" },
                ref idCounter, rnd);

            // Phòng Marketing 1 (Quyền Manager)
            TaoMotPhongBan(mkt1, posTruongPhong, posNhanVienPT, Role.Manager,
                "Trần Văn Phong", "tranvanphong", new DateTime(1990, 5, 20), "Nam",
                new string[] { "Nguyễn Thị Lan", "Lê Văn Tâm", "Phạm Thị Mai", "Hoàng Văn Huy" },
                new string[] { "nguyenthilan", "levantam", "phamthimai", "hoangvanhuy" },
                ref idCounter, rnd);

            // Phòng Kế Toán 1 (Quyền HR)
            TaoMotPhongBan(kt1, posTruongPhong, posNhanVienPT, Role.HR,
                "Lê Thị Nhàn", "lethinhan", new DateTime(1992, 8, 15), "Nữ",
                new string[] { "Phan Văn Đạt", "Trịnh Thị Hà", "Lý Văn Phát", "Đào Thị Cẩm" },
                new string[] { "phanvandat", "trinhthiha", "lyvanphat", "daothicam" },
                ref idCounter, rnd);

            // Phòng IT 2 (Quyền Manager)
            TaoMotPhongBan(it2, posTruongPhong, posNhanVienPT, Role.Manager,
                "Nguyễn Hải Đăng", "nguyenhaidang", new DateTime(1995, 12, 1), "Nam",
                new string[] { "Trần Thị Thu", "Lê Văn Hải", "Phạm Thị Bình", "Vũ Văn Kiên" },
                new string[] { "tranthithu", "levanhai", "phamthibinh", "vuvankien" },
                ref idCounter, rnd);

            // Set quản lý IT2 làm sếp chi nhánh 2
            cn2.NguoiQuanLy = it2.NguoiQuanLy;

            // ==========================================
            // 5. GỌI HÀM SPAWN DỮ LIỆU CHẤM CÔNG THÁNG 3
            // ==========================================
            TaoDuLieuChamCongThang3(rnd);
        }

        // HÀM TIỆN ÍCH TẠO PHÒNG BAN (ĐÃ NÂNG CẤP APPROVE HỢP ĐỒNG)
        public void TaoMotPhongBan(Department phongBan, Position chucVuQuanLy, Position chucVuNhanVien, Role quyenQuanLy,
                                    string tenQL, string userQL, DateTime nsQL, string gtQL,
                                    string[] tenNVs, string[] userNVs, ref int idCounter, Random rnd)
        {
            // 1. TẠO QUẢN LÝ (FULL-TIME)
            Contract hdQL = new Contract("HD" + idCounter, null, new DateTime(2023, rnd.Next(1, 13), 1), new DateTime(2028, rnd.Next(1, 13), 1), "Full-time");
            hdQL.Approve(); // Duyệt luôn cho nóng
            Contracts.Add(hdQL);

            FullTimeEmployee quanLy = new FullTimeEmployee(
                "ID" + idCounter.ToString("D3"), tenQL, nsQL, gtQL, userQL + "@gmail.com", "09" + rnd.Next(10000000, 99999999),
                "NV" + idCounter.ToString("D3"), phongBan, chucVuQuanLy, hdQL, 15000000, 200000);

            hdQL.NhanVien = quanLy;
            idCounter++;
            phongBan.AssignManager(quanLy);
            Employees.Add(quanLy);

            Account tkQL = new Account(userQL, nsQL.ToString("ddMMyyyy"), quyenQuanLy, quanLy);
            Accounts.Add(tkQL);

            // 2. TẠO 4 NHÂN VIÊN (PART-TIME)
            for (int i = 0; i < 4; i++)
            {
                DateTime nsNV = new DateTime(rnd.Next(1995, 2005), rnd.Next(1, 13), rnd.Next(1, 28));
                string gtNV = (i % 2 == 0) ? "Nữ" : "Nam";

                Contract hdNV = new Contract("HD" + idCounter, null, new DateTime(2024, rnd.Next(1, 13), 1), new DateTime(2027, rnd.Next(1, 13), 1), "Part-time");
                hdNV.Approve();
                Contracts.Add(hdNV);

                PartTimeEmployee nv = new PartTimeEmployee(
                    "ID" + idCounter.ToString("D3"), tenNVs[i], nsNV, gtNV, userNVs[i] + "@gmail.com", "09" + rnd.Next(10000000, 99999999),
                    "NV" + idCounter.ToString("D3"), phongBan, chucVuNhanVien, hdNV, 120, 25000);

                hdNV.NhanVien = nv;
                idCounter++;
                phongBan.AddEmployee(nv);
                Employees.Add(nv);

                Account tkNV = new Account(userNVs[i], nsNV.ToString("ddMMyyyy"), Role.Employee, nv);
                Accounts.Add(tkNV);
            }
        }
        // ==========================================
        // HÀM SPAWN DỮ LIỆU CHẤM CÔNG ẢO (THÁNG 3)
        // ==========================================
        public void TaoDuLieuChamCongThang3(Random rnd)
        {
            int thangCC = 3;
            int namCC = DateTime.Now.Year;

            foreach (Employee emp in Employees)
            {
                // Tạo bảng chấm công tháng 3 cho từng người
                Attendance bangCC = new Attendance();
                bangCC.NhanVien = emp;
                bangCC.Thang = thangCC;
                bangCC.Nam = namCC;

                int soNgayTrongThang = DateTime.DaysInMonth(namCC, thangCC);

                for (int day = 1; day <= soNgayTrongThang; day++)
                {
                    DateTime date = new DateTime(namCC, thangCC, day);

                    // Chỉ chấm công từ Thứ 2 đến Thứ 6 (Bỏ qua T7, CN)
                    if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                        continue;

                    // Random 5% cơ hội nhân viên xin nghỉ (không có record ngày đó)
                    if (rnd.Next(1, 100) <= 5) continue;

                    // Random giờ Check-in: từ 08:00 đến 08:45
                    int phutVao = rnd.Next(0, 46);
                    TimeSpan gioVao = new TimeSpan(8, phutVao, 0);

                    // Random giờ Check-out: từ 17:00 đến 18:30
                    int gioRaHour = rnd.Next(17, 19);
                    int phutRa = rnd.Next(0, 60);
                    TimeSpan gioRa = new TimeSpan(gioRaHour, phutRa, 0);

                    // Tính trạng thái (8h30 là trễ, 17h30 là về sớm)
                    string trangThai = (gioVao.Hours == 8 && gioVao.Minutes > 30) ? "Đi trễ" : "Đúng giờ";
                    if (gioRa.Hours == 17 && gioRa.Minutes < 30)
                        trangThai += ", Về sớm";
                    else
                        trangThai += ", Hoàn thành";

                    // Ghi nhận vào record
                    AttendanceRecord record = new AttendanceRecord(date, gioVao, gioRa, trangThai);
                    bangCC.Records.Add(record);
                }

                // Nhét bảng của người này vào hệ thống
                Attendances.Add(bangCC);
            }
        }



        // ==========================================
        // NGHIỆP VỤ XỬ LÝ ĐƠN TỪ & THÔNG BÁO (EVENTS)
        // ==========================================

        // Hàm này dùng để Nhân viên nộp đơn mới vào hệ thống
        public void NopDonXinNghi(LeaveRequest request)
        {
            if (request != null)
            {
                LeaveRequests.Add(request);

                // 1. Đăng ký cho HRSystem "lắng nghe" các sự kiện của cái đơn này
                request.OnLeaveRequestCreated += HandleLeaveRequestCreated;
                request.OnLeaveRequestApproved += HandleLeaveRequestApproved;
                request.OnLeaveRequestRejected += HandleLeaveRequestRejected;

                // 2. Kích hoạt sự kiện tạo đơn (Nó sẽ tự động nhảy xuống cái hàm Handle bên dưới)
                request.Submit();
            }
        }

        // --- CÁC HÀM "NGƯỜI NGHE" (EVENT HANDLERS) ---

        // Khi đơn vừa tạo -> Gửi thông báo cho Sếp (Trưởng phòng)
        private void HandleLeaveRequestCreated(LeaveRequest sender)
        {
            // Kiểm tra xem nhân viên có phòng không, và phòng đó có sếp không
            if (sender.NhanVien.PhongBan != null && sender.NhanVien.PhongBan.NguoiQuanLy != null)
            {
                Employee sep = sender.NhanVien.PhongBan.NguoiQuanLy;
                string maTB = "TB_" + DateTime.Now.ToString("HHmmss") + new Random().Next(10, 99);

                // Logic phân loại text hiển thị
                string tenLoaiDon = sender.LoaiNghiPhep == "Nghỉ việc" ? "ĐƠN XIN THÔI VIỆC" : $"ĐƠN XIN NGHỈ PHÉP ({sender.SoNgayNghi} ngày)";
                string noiDung = $"[CẦN DUYỆT] Nhân viên {sender.NhanVien.HoTen} vừa nộp {tenLoaiDon}. Lý do: {sender.LyDo}";

                Notification thongBaoMoi = new Notification(maTB, noiDung, sep);
                Notifications.Add(thongBaoMoi);
            }
        }

        // Khi sếp DUYỆT -> Báo cho Nhân viên
        private void HandleLeaveRequestApproved(LeaveRequest sender)
        {
            string maTB = "TB_" + DateTime.Now.ToString("HHmmss") + new Random().Next(10, 99);
            string tenLoaiDon = sender.LoaiNghiPhep == "Nghỉ việc" ? "xin thôi việc" : $"xin nghỉ phép";
            string noiDung = $"[TIN VUI] Đơn {tenLoaiDon} của bạn đã được quản lý PHÊ DUYỆT!";

            Notification thongBaoMoi = new Notification(maTB, noiDung, sender.NhanVien);
            Notifications.Add(thongBaoMoi);

        }

        // Khi sếp TỪ CHỐI -> Báo cho Nhân viên
        private void HandleLeaveRequestRejected(LeaveRequest sender)
        {
            string maTB = "TB_" + DateTime.Now.ToString("HHmmss") + new Random().Next(10, 99);
            string tenLoaiDon = sender.LoaiNghiPhep == "Nghỉ việc" ? "xin thôi việc" : $"xin nghỉ phép";
            string noiDung = $"[THÔNG BÁO] Đơn {tenLoaiDon} của bạn đã bị TỪ CHỐI. Vui lòng liên hệ quản lý để biết thêm chi tiết!";

            Notification thongBaoMoi = new Notification(maTB, noiDung, sender.NhanVien);
            Notifications.Add(thongBaoMoi);
        }




        // ==========================================
        // NGHIỆP VỤ XỬ LÝ CHẤM CÔNG
        // ==========================================
        // Lấy Bảng chấm công của tháng hiện tại cho Nhân viên
        public Attendance LayBangChamCongThanhNay(Employee emp)
        {
            int thangHienTai = DateTime.Now.Month;
            int namHienTai = DateTime.Now.Year;

            // Tìm xem đã có bảng của tháng này chưa
            foreach (Attendance att in Attendances)
            {
                if (att.NhanVien.Id == emp.Id && att.Thang == thangHienTai && att.Nam == namHienTai)
                {
                    return att;
                }
            }

            // Nếu chưa có (ngày 1 đầu tháng) -> Tạo bảng mới
            Attendance bangMoi = new Attendance();
            bangMoi.NhanVien = emp;
            bangMoi.Thang = thangHienTai;
            bangMoi.Nam = namHienTai;

            Attendances.Add(bangMoi);
            return bangMoi;
        }


        // ==========================================
        // LƯƠNG BỔNG 
        // ==========================================
        //Chốt lương hàng tháng
        public void ChotLuongThang(int thang, int nam)
        {
            foreach (Employee emp in Employees)
            {
                // 1. Kiểm tra xem tháng này đã chốt lương cho người này chưa (tránh chốt đúp)
                bool daChot = false;
                foreach (Payroll p in Payrolls)
                {
                    if (p.NhanVien.Id == emp.Id && p.Thang == thang && p.Nam == nam)
                    {
                        daChot = true; break;
                    }
                }
                if (daChot) continue;

                // 2. Tìm Bảng chấm công tháng này để lấy Số giờ làm việc
                double tongGioLam = 0;
                foreach (Attendance att in Attendances)
                {
                    if (att.NhanVien.Id == emp.Id && att.Thang == thang && att.Nam == nam)
                    {
                        tongGioLam = att.CalculateWorkingHours();
                        break;
                    }
                }

                // 3. Nếu là Part-time thì bơm số giờ làm vào để nó tự tính tiền
                if (emp is PartTimeEmployee pt)
                {
                    pt.SoGioLamTrongThang = tongGioLam;
                }

                // 4. Khởi tạo Phiếu Lương
                Payroll bangLuong = new Payroll();
                bangLuong.MaBangLuong = "PR_" + nam + thang.ToString("00") + "_" + emp.MaNhanVien;
                bangLuong.Thang = thang;
                bangLuong.Nam = nam;
                bangLuong.NhanVien = emp;

                // 5. Gọi hàm thiết lập Phụ cấp, Thuế, Bảo hiểm (Hàm bro đã viết rất chuẩn)
                bangLuong.ThietLapLuatTinhLuong();

                Payrolls.Add(bangLuong);
            }
        }



    }
}
