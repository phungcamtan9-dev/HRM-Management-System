using HyperionHR_meta.Scripts.Class.HR_Operations;
using HyperionHR_meta.Scripts.Class.Organizations;
using HyperionHR_meta.Scripts.Class.Payrolls;
using HyperionHR_meta.Scripts.Class.Person;
using HyperionHR_meta.Scripts.Class.System;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace HyperionHR_meta
{
    public partial class MainForm : Form
    {
        // ==========================================
        // Singleton
        // ==========================================
        HRSystem system = HRSystem.Instance;
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // chống giật


        }
        //FormLoad
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Load giao diện ban đầu
            CloseAllTab();
            LoadGiaoDien();
            BoGocAvatar();
            TaoCotChoLuoiChamCong();
            TaoCotChoLuoiTinhLuong();
            CapNhatDashboard();

            //Bom dữ liệu
            TaiDuLieuChucVu();
            CapNhatChuongThongBao();
            HienThiDanhSachChamCong();
            nudThang.Value = DateTime.Now.Month;
            nudNam.Value = DateTime.Now.Year;

        }
        // ==========================================
        // LÀM ĐẸP FORM
        // ==========================================
        //Bo gốc avatar
        public void BoGocAvatar()
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, picAva1.Width, picAva1.Height);
            picAva1.Region = new Region(gp);
            picAva1.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawEllipse(new Pen(Color.White, 2), 1, 1, picAva1.Width - 3, picAva1.Height - 3);
            };
        }
        //Gradient
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                ColorTranslator.FromHtml("#B9D3FF"),
                ColorTranslator.FromHtml("#9BC1FF"),
                LinearGradientMode.BackwardDiagonal))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
        // check buổi
        public string GetGreeting()
        {
            int hour = DateTime.Now.Hour;

            if (hour >= 5 && hour < 11)
                return "☀️ Chào buổi sáng";
            else if (hour >= 11 && hour < 14)
                return "🌤 Chào buổi trưa";
            else if (hour >= 14 && hour < 18)
                return "🌇 Chào buổi chiều";
            else
                return "🌙 Chào buổi tối";
        }

        // ==========================================
        // PANEL CONTROL
        // ==========================================
        public void LoadGiaoDien()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25)); //Bo gốc
            lblWelcome.Text = $"{GetGreeting()}, {system.CurrentUser.Employee.HoTen}"; //Chào người dùng
            lblDateTime.Text = $"Hôm nay là {DateTime.Now.ToString("dddd, MMMM dd, yyyy")}"; //Hiện ngày tháng trên welcomebar
            lblUserName1.Text = $"{system.CurrentUser.Employee.HoTen}";
            lblUserGmail1.Text = $"{system.CurrentUser.Employee.Email}";
            lblUserName2.Text = $"{system.CurrentUser.Employee.HoTen}";
            lblUserGmail2.Text = $"{system.CurrentUser.Employee.Email}";

            CheckRole(); // Hiển thị UI theo cấp độ tài khoản

            pnlLogout.Visible = false;


        }
        // Hàm check quyền tài khoản
        public void CheckRole()
        {
            switch (system.CurrentUser.Role)
            {
                case Role.Admin: //GD
                    //hiện
                    icoBaoTriHeThong.Visible = true;
                    pnlSideBar_HR.Visible = true;
                    pnlBottomSideMenu.Visible = true;
                    pnl_Dashboard.Visible = true;
                    HienThiDanhSachNhanVien(HRSystem.Instance.Employees);
                    btnDuyetHD.Visible = true;
                    btnDuyet.Visible = true;
                    btnTuChoi.Visible = true;
                    btnChotLuong.Visible = true;
                    button8.Visible = true;
                    button8.BringToFront();

                    //ẩn
                    pnlSideBar_Employee.Visible = false;
                    pnlBottomSideBar_Employee.Visible = false;

                    break;

                case Role.HR:
                    //hiện                    
                    pnlSideBar_HR.Visible = true;
                    pnlBottomSideMenu.Visible = true;
                    pnl_Dashboard.Visible = true;
                    HienThiDanhSachNhanVien(HRSystem.Instance.Employees);
                    btnChotLuong.Visible = true;

                    //ẩn
                    icoBaoTriHeThong.Visible = false;
                    pnlSideBar_Employee.Visible = false;
                    pnlBottomSideBar_Employee.Visible = false;

                    break;

                case Role.Manager:
                    //hiện                    
                    pnlDashboard.Visible = true;
                    pnlSideBar_HR.Visible = true;
                    pnlBottomSideMenu.Visible = true;
                    btnDuyet.Visible = true;
                    btnTuChoi.Visible = true;

                    //ẩn
                    icoBaoTriHeThong.Visible = false;
                    pnlSideBar_Employee.Visible = false;
                    pnlBottomSideBar_Employee.Visible = false;


                    break;

                case Role.Employee:
                    //hiện
                    pnl_HoSoCaNhan.Visible = true;
                    pnlSideBar_Employee.Visible = true;
                    pnlBottomSideBar_Employee.Visible = true;
                    pnlHoSoCaNhan.Visible = true;


                    //ẩn
                    pnlDashboard.Visible = false;
                    icoBaoTriHeThong.Visible = false;
                    pnlSideBar_HR.Visible = false;
                    pnlBottomSideMenu.Visible = false;

                    break;
            }
        }

        // Tắt tất cả các tab khác
        public void CloseAllTab()
        {
            pnl_Dashboard.Visible = false;
            pnlDashboard.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            pnl_QuanLyNhanSu.Visible = false;
            pnlNhanSu.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            pnl_HoSoCaNhan.Visible = false;
            pnlHoSoCaNhan.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            pnl_ToChuc.Visible = false; ;
            pnlChucNang.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            pnl_HoSoCaNhan.Visible = false;
            pnlHoSoCaNhan.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            pnlHoSoCaNhan_Employee.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            pnlHopDong.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            pnl_QuanLyHopDong.Visible = false;

            pnlDonXin.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            pnlDonXin_Employee.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            pnl_DonXin.Visible = false;

            pnlChamCong.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            pnlChamCong_Employee.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            pnl_ChamCong.Visible = false;

            pnlLuong.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            pnlLuong_Employee.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            pnl_Luong.Visible = false;
        }

        //Đổi màu box tìm kiếm
        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            pnlBoxTimKiem.BackColor = Color.FromArgb(216, 228, 245);
            txtTimKiem.BackColor = Color.FromArgb(216, 228, 245);
            cbbTieuChi.BackColor = Color.FromArgb(216, 228, 245);
        }
        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            pnlBoxTimKiem.BackColor = ColorTranslator.FromHtml("#B9D3FF");
            txtTimKiem.BackColor = ColorTranslator.FromHtml("#B9D3FF");
            cbbTieuChi.BackColor = ColorTranslator.FromHtml("#B9D3FF");
        }



        // ==========================================
        // TƯƠNG TÁC CƠ BẢN
        // ==========================================
        private void picAva3_Click(object sender, EventArgs e)
        {
            if (!pnlLogout.Visible) pnlLogout.Visible = true;
            else pnlLogout.Visible = false;
        }
        private void btnTatBangThongTin_Click(object sender, EventArgs e)
        {
            pnlDienThongTin.Visible = false;
        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            btnThem.Visible = true;
            btnSua.Visible = false;
            pnlDienThongTin.Visible = true;
        }

        private void btnclose_Click(object sender, EventArgs e) // tắt
        {
            Application.Exit();
        }

        private void btnHide_Click(object sender, EventArgs e) // thu nhỏ
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picAva1_Click(object sender, EventArgs e)
        {
            if (!pnlLogout.Visible) pnlLogout.Visible = true;
            else pnlLogout.Visible = false;
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }



        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) //Upadte dữ liệu khi đóng file và xác nhận thoát 
        {
            HRSystem.Instance.Save("hrsystem.bin");

            DialogResult result = MessageBox.Show("Dữ liệu của bạn đã được cập nhật, xác nhận thoát ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) e.Cancel = false;
            else e.Cancel = true;
        }



        // ==========================================
        // Vùng Thao Tác Quản Lý Nhân Viên
        // ==========================================
        //Lấy dữ liệu chức vụ
        private void TaiDuLieuChucVu()
        {
            cbbChucVu.Items.Clear();
            foreach (Position pos in HRSystem.Instance.Positions)
            {
                cbbChucVu.Items.Add(pos.TenChucVu);
            }
        }

        //Tạo cột cho bảng
        private void TaoCotChoLuoi()
        {
            dgvNhanVien.Columns.Clear();

            // Khai báo các cột (Tên cột trong code, Tên cột hiển thị lên UI)
            dgvNhanVien.Columns.Add("colID", "ID");
            dgvNhanVien.Columns.Add("colMaNV", "Mã NV");
            dgvNhanVien.Columns.Add("colHoTen", "Họ Tên");
            dgvNhanVien.Columns.Add("colNgaySinh", "Ngày Sinh");
            dgvNhanVien.Columns.Add("colPhongBan", "Phòng Ban");
            dgvNhanVien.Columns.Add("colChucVu", "Chức Vụ");
            dgvNhanVien.Columns.Add("colLoaiNV", "Loại Nhân Viên");

            // Tùy chỉnh các thuộc tính thêm:
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự động giãn cột vừa khung
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;    // Click vào là chọn nguyên 1 dòng
            dgvNhanVien.AllowUserToAddRows = false;                                 // Ẩn cái dòng trống cuối cùng đi
            dgvNhanVien.ReadOnly = true;                                            // Chỉ cho xem, không cho gõ trực tiếp vào ô
        }

        // Bom dữ liệu lên bảng
        private void HienThiDanhSachNhanVien(List<Employee> danhSach)
        {
            TaoCotChoLuoi();
            dgvNhanVien.Rows.Clear(); // Xóa sạch các dòng cũ trước khi nạp mới

            // Duyệt danh sách
            foreach (Employee emp in danhSach)
            {
                // Kiểm tra phòng ban để tránh lỗi văng app nếu nhân viên chưa có phòng
                string tenPB = "Chưa có";
                if (emp.PhongBan != null)
                {
                    tenPB = emp.PhongBan.TenPB;
                }

                // Kiểm tra chức vụ tương tự
                string tenCV = "Chưa có";
                if (emp.ChucVu != null)
                {
                    tenCV = emp.ChucVu.TenChucVu;
                }

                // Phương thức của ĐA HÌNH (Polymorphism):
                string loaiNhanVien = emp.HienThiThongTin();

                string ngaySinhDep = emp.NgaySinh.ToString("dd/MM/yyyy");

                // Thêm 1 dòng mới vào lưới
                dgvNhanVien.Rows.Add(emp.Id, emp.MaNhanVien, emp.HoTen, ngaySinhDep, tenPB, tenCV, loaiNhanVien);
            }
        }

        //Mở tab
        private void lblNhanSu_Click(object sender, EventArgs e)
        {
            CloseAllTab(); // tắt tab khác trước r mới mở
            pnlNhanSu.BackColor = ColorTranslator.FromHtml("#D9E5FF");
            pnl_QuanLyNhanSu.Visible = true;
        }

        // Chức năng tìm kiếm dùng DELEGATE
        private string tuKhoaTimKiem = "";

        // Kiểm tra Tên nhân viên có chứa từ khóa không
        private bool DieuKienTimTheoTen(Employee emp)
        {
            if (emp.HoTen != null && emp.HoTen.ToLower().Contains(tuKhoaTimKiem.ToLower()))
            {
                return true;
            }
            return false;
        }

        // Kiểm tra Tên phòng ban có chứa từ khóa không
        private bool DieuKienTimTheoPhongBan(Employee emp)
        {
            if (emp.PhongBan != null && emp.PhongBan.TenPB != null && emp.PhongBan.TenPB.ToLower().Contains(tuKhoaTimKiem.ToLower()))
            {
                return true;
            }
            return false;
        }

        // nút tìm
        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            // Lấy từ khóa và tiêu chí từ giao diện
            tuKhoaTimKiem = txtTimKiem.Text.Trim();
            string tieuChi = cbbTieuChi.Text;

            // Khai báo khuôn mẫu Delegate
            HRSystem.EmployeeFilter boLoc = null;

            // Xét xem người dùng muốn tìm theo cái gì để nhét vào Delegate
            if (tieuChi == "Theo Tên")
            {
                boLoc = new HRSystem.EmployeeFilter(DieuKienTimTheoTen);
            }
            else if (tieuChi == "Theo Phòng Ban")
            {
                boLoc = new HRSystem.EmployeeFilter(DieuKienTimTheoPhongBan);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm (Theo Tên / Theo Phòng Ban)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi hệ thống lọc dữ liệu
            if (boLoc != null)
            {
                List<Employee> danhSachKetQua = HRSystem.Instance.GetEmployeesByCondition(boLoc);

                // Đổ kết quả tìm được lên DataGridView
                HienThiDanhSachNhanVien(danhSachKetQua);
            }
        }


        // nút làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            cbbTieuChi.SelectedIndex = -1; // Xóa chọn ComboBox

            // Lấy lại danh sách gốc hiển thị lên
            HienThiDanhSachNhanVien(HRSystem.Instance.Employees);
        }
        private void btnLamMoiInput_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtSoDienThoai.Text = "";
            cbbGioiTinh.Text = "";
            cbbLoaiNV.Text = "";
        }

        //Thêm nv
        private void btnThem_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu từ giao diện
            string maNV = txtMaNV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string gioiTinh = cbbGioiTinh.Text;
            string email = txtEmail.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            DateTime ngaySinh = dtpNgaySinh.Value;
            string loaiNV = cbbLoaiNV.Text; // "FullTime" hoặc "PartTime"
            string tenChucVu = cbbChucVu.Text;

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(loaiNV))
            {
                MessageBox.Show("Vui lòng nhập đủ Họ tên và Loại nhân viên!");
                return;
            }

            // 2. Tạo ID ngẫu nhiên (hoặc tự tăng)
            string idMoi = "ID_" + DateTime.Now.ToString("HHmmss");

            // 3. Dùng Factory đẻ ra nhân viên (Chuẩn Design Pattern)
            try
            {
                Employee nvMoi = EmployeeFactory.CreateEmployee(loaiNV, idMoi, hoTen, ngaySinh, gioiTinh, email, sdt, maNV);

                // --- TÌM VÀ GÁN CHỨC VỤ CHO NHÂN VIÊN MỚI ---
                foreach (Position pos in HRSystem.Instance.Positions)
                {
                    if (pos.TenChucVu == tenChucVu)
                    {
                        nvMoi.ChucVu = pos;
                        break;
                    }
                }

                // 4. Thêm vào hệ thống + tạo hợp đồng
                HRSystem.Instance.Employees.Add(nvMoi);
                if (chkTaoHopDong.Checked == true)
                {
                    string maHD = "HD_" + DateTime.Now.ToString("HHmmss");
                    DateTime ngayBD = DateTime.Now;               // Bắt đầu từ hôm nay
                    DateTime ngayKT = ngayBD.AddYears(1);         // Mặc định cộng thêm 1 năm

                    // Tạo đối tượng hợp đồng mới
                    Contract hdMoi = new Contract(maHD, nvMoi, ngayBD, ngayKT, loaiNV);

                    // Gắn hợp đồng vào hồ sơ nhân viên luôn cho đồng bộ
                    nvMoi.HopDong = hdMoi;

                    // Lưu hợp đồng vào danh sách quản lý hợp đồng của công ty
                    HRSystem.Instance.Contracts.Add(hdMoi);
                }

                // 5. Cập nhật bảng và thông báo
                HienThiDanhSachNhanVien(HRSystem.Instance.Employees);
                MessageBox.Show("Thêm nhân viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo nhân viên: " + ex.Message);
            }
        }

        //Sửa thông tin
        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Visible = false;
            btnSua.Visible = true;
            pnlDienThongTin.Visible = true;
            if (e.RowIndex >= 0) // Tránh click vào tiêu đề cột
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                // Lấy ID để tìm nhân viên gốc trong hệ thống
                string idChon = row.Cells["colID"].Value.ToString();

                foreach (Employee emp in HRSystem.Instance.Employees)
                {
                    if (emp.Id == idChon)
                    {
                        // Đổ dữ liệu lên UI
                        txtMaNV.Text = emp.MaNhanVien;
                        txtHoTen.Text = emp.HoTen;
                        txtEmail.Text = emp.Email;
                        txtSoDienThoai.Text = emp.SoDienThoai;
                        dtpNgaySinh.Value = emp.NgaySinh;

                        // Xét loại để hiển thị lên ComboBox
                        if (emp is FullTimeEmployee) cbbLoaiNV.Text = "FullTime";
                        else if (emp is PartTimeEmployee) cbbLoaiNV.Text = "PartTime";

                        break;
                    }
                }
            }
        }

        //XoaNV
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem có đang chọn dòng nào không
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                // Lấy ID từ cột đầu tiên (colID) của dòng đang chọn
                string idCanXoa = dgvNhanVien.SelectedRows[0].Cells["colID"].Value.ToString();
                string tenNV = dgvNhanVien.SelectedRows[0].Cells["colHoTen"].Value.ToString();

                // Hỏi lại cho chắc
                DialogResult hoi = MessageBox.Show($"Bạn có chắc muốn xóa {tenNV} không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (hoi == DialogResult.Yes)
                {
                    // Lặp qua danh sách để tìm và xóa
                    Employee empXoa = null;
                    foreach (Employee emp in HRSystem.Instance.Employees)
                    {
                        if (emp.Id == idCanXoa)
                        {
                            empXoa = emp;
                            break;
                        }
                    }

                    if (empXoa != null)
                    {
                        HRSystem.Instance.Employees.Remove(empXoa);

                        // Cập nhật lại lưới
                        HienThiDanhSachNhanVien(HRSystem.Instance.Employees);
                        MessageBox.Show("Đã xóa thành công!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn nhân viên cần xóa !");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                string idCanSua = dgvNhanVien.SelectedRows[0].Cells["colID"].Value.ToString();

                foreach (Employee emp in HRSystem.Instance.Employees)
                {
                    if (emp.Id == idCanSua)
                    {
                        // Cập nhật thuộc tính mới từ TextBox
                        emp.MaNhanVien = txtMaNV.Text.Trim();
                        emp.HoTen = txtHoTen.Text.Trim();
                        emp.Email = txtEmail.Text.Trim();
                        emp.SoDienThoai = txtSoDienThoai.Text.Trim();
                        emp.NgaySinh = dtpNgaySinh.Value;

                        HienThiDanhSachNhanVien(HRSystem.Instance.Employees);
                        MessageBox.Show("Cập nhật thành công!");
                        break;
                    }
                }
            }
        }

        // ==========================================
        // Vùng Thao Tác DashBoard
        // ==========================================
        //Mở tab
        private void lblDashboard_Click(object sender, EventArgs e)
        {
            CloseAllTab();
            pnlDashboard.BackColor = ColorTranslator.FromHtml("#D9E5FF");
            pnl_Dashboard.Visible = true;
            CapNhatDashboard();
        }

        private void CapNhatDashboard()
        {
            // 1. Thống kê cơ bản (Nhân viên & Phòng ban)
            int tongNhanVien = HRSystem.Instance.Employees.Count;
            int tongPhongBan = HRSystem.Instance.Departments.Count;

            // 2. Thống kê Hợp đồng
            int hdConHan = 0;
            int hdHetHan = 0;
            foreach (var hd in HRSystem.Instance.Contracts)
            {
                if (DateTime.Now > hd.NgayKetThuc)
                    hdHetHan++;
                else
                    hdConHan++;
            }

            // 3. Thống kê Đơn từ chờ duyệt
            int donChoDuyet = 0;
            foreach (var don in HRSystem.Instance.LeaveRequests)
            {
                if (don.GetStatus() == "Pending")
                    donChoDuyet++;
            }

            // 4. Thống kê số người đã Check-in hôm nay
            int soNguoiCheckInHomNay = 0;
            DateTime homNay = DateTime.Now.Date;

            foreach (var bangCC in HRSystem.Instance.Attendances)
            {
                // Lướt qua các record điểm danh của từng người
                foreach (var record in bangCC.Records)
                {
                    // Nếu đúng ngày hôm nay và đã có Giờ Vào (HasValue = true)
                    if (record.Ngay == homNay && record.GioVao.HasValue)
                    {
                        soNguoiCheckInHomNay++;
                        break; // Đếm người này rồi thì ngưng lướt record của họ, chuyển sang người tiếp theo
                    }
                }
            }

            // --- GÁN DỮ LIỆU LÊN GIAO DIỆN (Lên các Label đã tạo) ---
            lblTongNhanVien.Text = tongNhanVien.ToString();
            lblTongPhongBan.Text = tongPhongBan.ToString(); // Nhớ thêm Label này lên UI nha bro
            lblHopDongConHan.Text = hdConHan.ToString();
            lblHopDongHetHan.Text = hdHetHan.ToString();
            lblDonChoDuyet.Text = donChoDuyet.ToString();
            lblNhanVienCheckIn.Text = soNguoiCheckInHomNay.ToString(); // Và cả Label này nữa
        }







        // ==========================================
        // Vùng Thao Tác Tổ Chức
        // ==========================================
        // Chuyển tab
        private void lblToChuc_Click(object sender, EventArgs e)
        {
            CloseAllTab(); // tắt tab khác trước r mới mở
            pnlChucNang.BackColor = ColorTranslator.FromHtml("#D9E5FF");
            pnl_ToChuc.Visible = true;
            TaiDuLieuChiNhanh();

        }

        private void TaiDuLieuChiNhanh()
        {
            cbbChiNhanh.Items.Clear();

            // Lặp qua danh sách chi nhánh trong hệ thống và đưa tên vào ComboBox
            foreach (Branch cn in HRSystem.Instance.Branches)
            {
                cbbChiNhanh.Items.Add(cn.TenCN);
            }
        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xóa lưới phòng ban cũ
            dgvPhongBan.Rows.Clear();
            dgvPhongBan.Columns.Clear();

            // Tạo cột cho lưới phòng ban
            dgvPhongBan.Columns.Add("colMaPB", "Mã Phòng");
            dgvPhongBan.Columns.Add("colTenPB", "Tên Phòng Ban");
            dgvPhongBan.Columns.Add("colQuanLy", "Trưởng Phòng");
            dgvPhongBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhongBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhongBan.ReadOnly = true; // Chỉ cho xem

            string tenChiNhanhDuocChon = cbbChiNhanh.Text;

            // Tìm chi nhánh tương ứng trong hệ thống
            foreach (Branch cn in HRSystem.Instance.Branches)
            {
                if (cn.TenCN == tenChiNhanhDuocChon)
                {
                    // Lấy danh sách phòng ban CỦA RIÊNG CHI NHÁNH NÀY để hiển thị
                    foreach (Department pb in cn.DanhSachPB)
                    {
                        string tenTruongPhong = "Chưa bổ nhiệm";
                        if (pb.NguoiQuanLy != null)
                        {
                            tenTruongPhong = pb.NguoiQuanLy.HoTen;
                        }

                        // Đổ dữ liệu 1 phòng ban lên lưới
                        dgvPhongBan.Rows.Add(pb.MaPB, pb.TenPB, tenTruongPhong);
                    }
                    break;
                }
            }
        }

        private void btnBoxThemChiNhanh_Click(object sender, EventArgs e)
        {
            pnlThemChiNhanh.Visible = !pnlThemChiNhanh.Visible;
            pnlThemChiNhanh.BringToFront();
        }

        private void btnThemCN_Click(object sender, EventArgs e)
        {
            string maCN = txtMaCN.Text.Trim();
            string tenCN = txtTenCN.Text.Trim();
            string diaChi = txtDiaChiCN.Text.Trim();

            // 1. Kiểm tra nhập liệu cơ bản
            if (string.IsNullOrEmpty(maCN) || string.IsNullOrEmpty(tenCN))
            {
                MessageBox.Show("Sếp ơi, vui lòng nhập ít nhất Mã và Tên chi nhánh nhé!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra xem Mã chi nhánh này đã tồn tại chưa (Chống trùng lặp)
            foreach (Branch cn in HRSystem.Instance.Branches)
            {
                if (cn.MaCN == maCN)
                {
                    MessageBox.Show("Mã chi nhánh này đã tồn tại rồi! Vui lòng nhập mã khác.", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // 3. Khởi tạo Chi nhánh mới (Người quản lý ban đầu để null, sẽ bổ nhiệm sau)
            Branch chiNhanhMoi = new Branch(maCN, tenCN, diaChi, null);

            // 4. Thêm vào hệ thống tổng
            HRSystem.Instance.Branches.Add(chiNhanhMoi);

            // 5. Cập nhật lại cái ComboBox Chi nhánh
            TaiDuLieuChiNhanh(); // Gọi lại hàm nạp ComboBox hồi trước mình viết

            // đẩy vào combobox
            cbbChiNhanh.SelectedItem = tenCN;

            MessageBox.Show($"Chúc mừng! Đã khai trương {tenCN} thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa trắng form nhập liệu
            txtMaCN.Text = "";
            txtTenCN.Text = "";
            txtDiaChiCN.Text = "";
        }

        private void btnThemPB_Click(object sender, EventArgs e)
        {
            string maPB = txtMaPB.Text.Trim();
            string tenPB = txtTenPB.Text.Trim();
            string tenChiNhanh = cbbChiNhanh.Text; // Lấy chi nhánh đang chọn

            if (string.IsNullOrEmpty(maPB) || string.IsNullOrEmpty(tenPB) || string.IsNullOrEmpty(tenChiNhanh))
            {
                MessageBox.Show("Vui lòng nhập đủ Mã, Tên phòng ban và chọn Chi nhánh!");
                return;
            }

            // Tìm cái Chi nhánh đang được chọn để tải Phòng ban vào
            Branch chiNhanhHienTai = null;
            foreach (Branch cn in HRSystem.Instance.Branches)
            {
                if (cn.TenCN == tenChiNhanh)
                {
                    chiNhanhHienTai = cn;
                    break;
                }
            }

            if (chiNhanhHienTai != null)
            {
                // Tạo phòng ban mới
                Department pbMoi = new Department(maPB, tenPB);

                // Thêm vào hệ thống VÀ thêm vào chi nhánh
                HRSystem.Instance.Departments.Add(pbMoi);
                chiNhanhHienTai.AddDepartment(pbMoi);

                // Load lại lưới bằng cách gọi lại sự kiện đổi Chi Nhánh
                cbbChiNhanh_SelectedIndexChanged(null, null);
                MessageBox.Show("Thêm phòng ban thành công!");
            }
        }

        private void btnXoaPB_Click(object sender, EventArgs e)
        {
            if (dgvPhongBan.SelectedRows.Count > 0)
            {
                string maPB = dgvPhongBan.SelectedRows[0].Cells["colMaPB"].Value.ToString();

                DialogResult hoi = MessageBox.Show("Bạn có chắc muốn xóa phòng ban này? Các nhân viên bên trong sẽ bị mất phòng!", "Xác nhận", MessageBoxButtons.YesNo);
                if (hoi == DialogResult.Yes)
                {
                    // Tìm và xóa trong hệ thống
                    Department pbCanXoa = null;
                    foreach (Department pb in HRSystem.Instance.Departments)
                    {
                        if (pb.MaPB == maPB)
                        {
                            pbCanXoa = pb;
                            break;
                        }
                    }

                    if (pbCanXoa != null)
                    {
                        // Gỡ phòng ban cho các nhân viên đang ở trong phòng này
                        foreach (Employee emp in HRSystem.Instance.Employees)
                        {
                            if (emp.PhongBan != null && emp.PhongBan.MaPB == pbCanXoa.MaPB)
                            {
                                emp.PhongBan = null;
                            }
                        }

                        // Xóa khỏi danh sách tổng
                        HRSystem.Instance.Departments.Remove(pbCanXoa);

                        // Xóa khỏi Chi nhánh hiện tại
                        foreach (Branch cn in HRSystem.Instance.Branches)
                        {
                            if (cn.TenCN == cbbChiNhanh.Text)
                            {
                                cn.DanhSachPB.Remove(pbCanXoa);
                                break;
                            }
                        }

                        cbbChiNhanh_SelectedIndexChanged(null, null); // Load lại lưới
                        MessageBox.Show("Xóa thành công!");
                    }
                }
            }
        }

        private void btnSuaPB_Click(object sender, EventArgs e)
        {
            string maPB = txtMaPB.Text.Trim();
            foreach (Department pb in HRSystem.Instance.Departments)
            {
                if (pb.MaPB == maPB)
                {
                    pb.TenPB = txtTenPB.Text.Trim();
                    cbbChiNhanh_SelectedIndexChanged(null, null);
                    MessageBox.Show("Cập nhật thành công!");
                    break;
                }
            }
        }

        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Lấy dữ liệu lên TextBox
            txtMaPB.Text = dgvPhongBan.Rows[e.RowIndex].Cells["colMaPB"].Value.ToString();
            txtTenPB.Text = dgvPhongBan.Rows[e.RowIndex].Cells["colTenPB"].Value.ToString();

            // 2. LẤY MÃ PHÒNG BAN ĐỂ LỌC DANH SÁCH NHÂN VIÊN
            maPBDangChonDeLoc = dgvPhongBan.Rows[e.RowIndex].Cells["colMaPB"].Value.ToString();

            // 3. Dùng Delegate lọc
            HRSystem.EmployeeFilter boLoc = new HRSystem.EmployeeFilter(DieuKienTimTheoMaPB);
            List<Employee> dsNhanVienTrongPhong = HRSystem.Instance.GetEmployeesByCondition(boLoc);

            // 4. Hiển thị lên lưới con
            HienThiNhanVienTheoPhong(dsNhanVienTrongPhong);
        }
        // Biến lưu mã phòng ban đang được click để truyền vào Delegate
        private string maPBDangChonDeLoc = "";

        // Hàm điều kiện cho Delegate: Kiểm tra nhân viên có thuộc phòng này không
        private bool DieuKienTimTheoMaPB(Employee emp)
        {
            if (emp.PhongBan != null && emp.PhongBan.MaPB == maPBDangChonDeLoc)
            {
                return true;
            }
            return false;
        }

        private void HienThiNhanVienTheoPhong(List<Employee> danhSach)
        {
            dgvDanhSachTheoPhong.Rows.Clear();
            if (dgvDanhSachTheoPhong.Columns.Count == 0)
            {
                dgvDanhSachTheoPhong.Columns.Add("colMaNV_PB", "Mã NV");
                dgvDanhSachTheoPhong.Columns.Add("colHoTen_PB", "Họ Tên");
                dgvDanhSachTheoPhong.Columns.Add("colLoai_PB", "Loại");
                dgvDanhSachTheoPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDanhSachTheoPhong.ReadOnly = true;
            }

            foreach (Employee emp in danhSach)
            {
                dgvDanhSachTheoPhong.Rows.Add(emp.MaNhanVien, emp.HoTen, emp.HienThiThongTin());
            }
        }

        private Department phongBanHienTai = null;
        // double click mở thêm nv
        private void dgvPhongBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maPB = dgvPhongBan.Rows[e.RowIndex].Cells["colMaPB"].Value.ToString();

                // Tìm phòng ban
                phongBanHienTai = null;
                foreach (Department pb in HRSystem.Instance.Departments)
                {
                    if (pb.MaPB == maPB)
                    {
                        phongBanHienTai = pb;
                        break;
                    }
                }

                if (phongBanHienTai != null)
                {
                    lblTenPhong.Text = "Đang thêm nhân sự cho: " + phongBanHienTai.TenPB;

                    // Nạp danh sách "vô gia cư"
                    cbbNhanVienRanh.Items.Clear();
                    foreach (Employee emp in HRSystem.Instance.Employees)
                    {
                        if (emp.PhongBan == null)
                        {
                            cbbNhanVienRanh.Items.Add(emp.MaNhanVien + " - " + emp.HoTen);
                        }
                    }

                    // Reset checkbox và HIỆN PANEL
                    chkTruongPhong.Checked = false;
                    pnlThemNVvaoPB.Visible = true;
                    pnlThemNVvaoPB.BringToFront();
                }
            }
        }
        //Chốt thêm vào phòng
        private void btnXacNhanThem_Click(object sender, EventArgs e)
        {
            if (phongBanHienTai == null) return;
            string luaChon = cbbNhanVienRanh.Text;
            if (string.IsNullOrEmpty(luaChon)) return;

            string[] mangChuoi = luaChon.Split('-');
            string maNV = mangChuoi[0].Trim();

            foreach (Employee emp in HRSystem.Instance.Employees)
            {
                if (emp.MaNhanVien == maNV)
                {
                    // NẾU TICK CHỌN LÀM TRƯỞNG PHÒNG
                    if (chkTruongPhong.Checked == true)
                    {
                        // Kiểm tra xem có phải FullTime không 
                        if (emp is FullTimeEmployee)
                        {
                            FullTimeEmployee sdtFull = (FullTimeEmployee)emp;
                            phongBanHienTai.AssignManager(sdtFull);
                            emp.PhongBan = phongBanHienTai;

                            // --- TỰ ĐỘNG THĂNG CHỨC THÀNH TRƯỞNG PHÒNG ---
                            foreach (Position pos in HRSystem.Instance.Positions)
                            {
                                if (pos.TenChucVu == "Trưởng Phòng")
                                {
                                    emp.ChucVu = pos; // Đổi chức vụ của người này
                                    break;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cảnh báo: Chỉ nhân viên Full-Time mới được bổ nhiệm làm Trưởng phòng!", "Lỗi bổ nhiệm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Dừng luôn, không cho thêm
                        }
                    }
                    else // CHỈ LÀ NHÂN VIÊN BÌNH THƯỜNG
                    {
                        phongBanHienTai.AddEmployee(emp);
                        emp.PhongBan = phongBanHienTai;
                    }

                    MessageBox.Show("Thêm nhân sự thành công!");
                    pnlThemNVvaoPB.Visible = false; // Ẩn Panel đi

                    // --- CẬP NHẬT LẠI GIAO DIỆN ---
                    // 1. Cập nhật lại bảng phòng ban 
                    cbbChiNhanh_SelectedIndexChanged(null, null);

                    // 2. Cập nhật lại bảng danh sách nhân viên của phòng
                    HRSystem.EmployeeFilter boLoc = new HRSystem.EmployeeFilter(DieuKienTimTheoMaPB);
                    HienThiNhanVienTheoPhong(HRSystem.Instance.GetEmployeesByCondition(boLoc));

                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlThemNVvaoPB.Visible = false;
            phongBanHienTai = null;
        }


        // ==========================================
        // Vùng Thao Tác Hồ sơ cá nhân
        // ==========================================
        private void lblHoSoCaNhan_Click(object sender, EventArgs e)
        {
            CloseAllTab(); // tắt tab khác trước r mới mở
            pnlHoSoCaNhan.BackColor = ColorTranslator.FromHtml("#D9E5FF");
            pnl_HoSoCaNhan.Visible = true;

            BomThongTin();
        }
        private void lblHoSoCaNhan_Employee_Click(object sender, EventArgs e)
        {
            CloseAllTab(); // tắt tab khác trước r mới mở
            pnlHoSoCaNhan_Employee.BackColor = ColorTranslator.FromHtml("#D9E5FF");
            pnl_HoSoCaNhan.Visible = true;

            BomThongTin();
        }
        public void BomThongTin()
        {

            lbEmail.Text = $"{HRSystem.Instance.CurrentUser.Employee.Email}";
            lbSDT.Text = $"{HRSystem.Instance.CurrentUser.Employee.SoDienThoai}";
            lbHoTen.Text = $"{HRSystem.Instance.CurrentUser.Employee.HoTen}";
            lbMaNV.Text = $"{HRSystem.Instance.CurrentUser.Employee.MaNhanVien}";
            lbGioiTinh.Text = $"{HRSystem.Instance.CurrentUser.Employee.GioiTinh}";
            lbChucVu.Text = $"{HRSystem.Instance.CurrentUser.Employee.ChucVu.TenChucVu}";
            lbNgaySinh.Text = $"{HRSystem.Instance.CurrentUser.Employee.NgaySinh:dd/MM/yyyy}";
            lbLoaiNhanVien.Text = $"{HRSystem.Instance.CurrentUser.Employee.ChucVu.MoTa}";
            lbPhongban.Text = $"{HRSystem.Instance.CurrentUser.Employee.PhongBan.TenPB}";

            lbMaHD.Text = $"{HRSystem.Instance.CurrentUser.Employee.HopDong.MaHopDong}";
            lbLoaiHD.Text = $"{HRSystem.Instance.CurrentUser.Employee.HopDong.LoaiHopDong}";
            lbNgayBatDauHD.Text = $"{HRSystem.Instance.CurrentUser.Employee.HopDong.NgayBatDau:dd/MM/yyyy}";
            lbNgayKetThuc.Text = $"{HRSystem.Instance.CurrentUser.Employee.HopDong.NgayKetThuc:dd/MM/yyyy}";
        }



        // ==========================================
        // Vùng Thao Tác Hợp Đồng
        // ==========================================
        private void TaoCotChoLuoiHopDong()
        {
            dgvHopDong.Columns.Clear();

            dgvHopDong.Columns.Add("colMaHD", "Mã HĐ");
            dgvHopDong.Columns.Add("colTenNV", "Nhân Viên");
            dgvHopDong.Columns.Add("colLoaiHD", "Loại Hợp Đồng");
            dgvHopDong.Columns.Add("colNgayBD", "Ngày Bắt Đầu");
            dgvHopDong.Columns.Add("colNgayKT", "Ngày Kết Thúc");
            dgvHopDong.Columns.Add("colThoiHan", "Thời Hạn"); // Còn hạn / Hết hạn
            dgvHopDong.Columns.Add("colTrangThai", "Trạng Thái Duyệt"); // Pending / Approved

            dgvHopDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHopDong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHopDong.AllowUserToAddRows = false;
            dgvHopDong.ReadOnly = true;
        }
        private void HienThiDanhSachHopDong(List<Contract> danhSach)
        {
            dgvHopDong.Rows.Clear();

            // Duyệt danh sách hợp đồng trong hệ thống
            foreach (Contract hd in danhSach)
            {
                // Kiểm tra xem hợp đồng đã được gán cho nhân viên nào chưa
                string tenNV = "Chưa gán";
                if (hd.NhanVien != null)
                {
                    tenNV = hd.NhanVien.HoTen;
                }

                // Format ngày tháng
                string ngayBD = hd.NgayBatDau.ToString("dd/MM/yyyy");
                string ngayKT = hd.NgayKetThuc.ToString("dd/MM/yyyy");

                // Tính toán thời hạn hợp đồng
                string thoiHan = "Còn hạn";
                if (DateTime.Now > hd.NgayKetThuc)
                {
                    thoiHan = "Đã hết hạn";
                }
                else if ((hd.NgayKetThuc - DateTime.Now).TotalDays <= 30)
                {
                    thoiHan = "Sắp hết hạn"; // Highlight
                }

                // Lấy trạng thái duyệt từ interface IApprovable
                string trangThaiDuyet = hd.GetStatus();

                // Ném dữ liệu lên bảng
                dgvHopDong.Rows.Add(hd.MaHopDong, tenNV, hd.LoaiHopDong, ngayBD, ngayKT, thoiHan, trangThaiDuyet);
            }
        }

        private void lblHopDong_Click(object sender, EventArgs e)
        {
            CloseAllTab();
            pnlHopDong.BackColor = ColorTranslator.FromHtml("#D9E5FF");
            pnl_QuanLyHopDong.Visible = true;
            TaoCotChoLuoiHopDong();
            HienThiDanhSachHopDong(HRSystem.Instance.Contracts);
        }

        private void btnTimHopDong_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimHopDong.Text.Trim().ToLower();

            // Tạo 1 danh sách rỗng để chứa kết quả
            List<Contract> ketQuaTimKiem = new List<Contract>();

            // Lướt qua toàn bộ hợp đồng trong hệ thống
            foreach (Contract hd in HRSystem.Instance.Contracts)
            {
                // Nếu tên nhân viên có chứa từ khóa (không phân biệt hoa thường)
                if (hd.NhanVien != null && hd.NhanVien.HoTen.ToLower().Contains(tuKhoa))
                {
                    ketQuaTimKiem.Add(hd); // Ném vào danh sách kết quả
                }
            }

            // Gọi hàm hiển thị và truyền cái danh sách kết quả vào
            HienThiDanhSachHopDong(ketQuaTimKiem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTimHopDong.Text = "";
            HienThiDanhSachHopDong(HRSystem.Instance.Contracts);
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem HR có đang chọn dòng nào trên lưới không
            if (dgvHopDong.SelectedRows.Count > 0)
            {
                // Lấy Mã Hợp Đồng từ cột đang chọn
                string maHD = dgvHopDong.SelectedRows[0].Cells["colMaHD"].Value.ToString();

                // Lặp để tìm cái hợp đồng đó trong hệ thống
                foreach (Contract hd in HRSystem.Instance.Contracts)
                {
                    if (hd.MaHopDong == maHD)
                    {
                        // Kiểm tra xem hợp đồng còn hiệu lực duyệt không
                        if (hd.GetStatus() == "Approved")
                        {
                            // THỰC HIỆN GIA HẠN: Cộng thêm 1 năm vào ngày kết thúc
                            hd.NgayKetThuc = hd.NgayKetThuc.AddYears(1);

                            // Load lại lưới để thấy sự thay đổi
                            HienThiDanhSachHopDong(HRSystem.Instance.Contracts);
                            MessageBox.Show("Đã gia hạn hợp đồng thêm 1 năm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Hợp đồng này chưa được Giám đốc duyệt, không thể gia hạn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn hợp đồng nào để gia hạn!");
            }
        }

        private void btnChamDut_Click(object sender, EventArgs e)
        {
            if (dgvHopDong.SelectedRows.Count > 0)
            {
                string maHD = dgvHopDong.SelectedRows[0].Cells["colMaHD"].Value.ToString();
                string tenNV = dgvHopDong.SelectedRows[0].Cells["colTenNV"].Value.ToString();

                // Hỏi lại HR cho chắc cốp trước khi "đuổi việc" người ta
                DialogResult hoi = MessageBox.Show($"Bạn có chắc chắn muốn chấm dứt hợp đồng với nhân viên {tenNV} không?", "Xác nhận chấm dứt", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (hoi == DialogResult.Yes)
                {
                    foreach (Contract hd in HRSystem.Instance.Contracts)
                    {
                        if (hd.MaHopDong == maHD)
                        {
                            // THỰC HIỆN CHẤM DỨT: Cắt hợp đồng ngay ngày hôm nay
                            hd.NgayKetThuc = DateTime.Now;

                            // Ccắt luôn phòng ban của người này thì có thể gọi:
                            if (hd.NhanVien != null && hd.NhanVien.PhongBan != null)
                            {
                                hd.NhanVien.PhongBan.RemoveEmployee(hd.NhanVien);
                                hd.NhanVien.PhongBan = null;
                            }

                            HienThiDanhSachHopDong(HRSystem.Instance.Contracts);
                            MessageBox.Show("Đã chấm dứt hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần chấm dứt!");
            }
        }

        private void btnDuyetHD_Click(object sender, EventArgs e)
        {
            if (HRSystem.Instance.CurrentUser.Role != Role.Admin)
            {
                MessageBox.Show("Cảnh báo: Chỉ có Giám đốc (quyền Admin) mới được phép duyệt hợp đồng!", "Từ chối truy cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // THỰC HIỆN DUYỆT
            if (dgvHopDong.SelectedRows.Count > 0)
            {
                string maHD = dgvHopDong.SelectedRows[0].Cells["colMaHD"].Value.ToString();

                foreach (Contract hd in HRSystem.Instance.Contracts)
                {
                    if (hd.MaHopDong == maHD)
                    {
                        // Kiểm tra xem đã duyệt chưa
                        if (hd.GetStatus() == "Approved")
                        {
                            MessageBox.Show("Hợp đồng này đã được duyệt từ trước rồi sếp ơi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        // Kích hoạt hàm Duyệt (Từ interface IApprovable)
                        hd.Approve();

                        // Load lại lưới
                        HienThiDanhSachHopDong(HRSystem.Instance.Contracts);
                        MessageBox.Show("Đã phê duyệt hợp đồng thành công! Hợp đồng đã có hiệu lực pháp lý.", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Sếp vui lòng chọn một hợp đồng trên bảng để duyệt nhé!");
            }
        }





        // ==========================================
        // Vùng Thao Tác Đơn xin
        // ==========================================
        private void lblDonXin_Click(object sender, EventArgs e)
        {
            CloseAllTab();
            pnlDonXin.BackColor = ColorTranslator.FromHtml("#D9E5FF");
            pnl_DonXin.Visible = true;

            TaoCotChoLuoiNghiPhep();
            PhanQuyenVaHienThiNghiPhep();
        }

        private void lblDonXin_Employee_Click(object sender, EventArgs e)
        {
            CloseAllTab();
            pnlDonXin_Employee.BackColor = ColorTranslator.FromHtml("#D9E5FF");
            pnl_DonXin.Visible = true;

            TaoCotChoLuoiNghiPhep();
            PhanQuyenVaHienThiNghiPhep();
        }

        private void TaoCotChoLuoiNghiPhep()
        {
            dgvNghiPhep.Columns.Clear();
            dgvNghiPhep.Columns.Add("colMaDon", "Mã Đơn");
            dgvNghiPhep.Columns.Add("colNguoiNop", "Người Nộp");
            dgvNghiPhep.Columns.Add("colLoaiDon", "Loại Đơn");
            dgvNghiPhep.Columns.Add("colSoNgay", "Số Ngày");
            dgvNghiPhep.Columns.Add("colLyDo", "Lý Do");
            dgvNghiPhep.Columns.Add("colTrangThai", "Trạng Thái");

            dgvNghiPhep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNghiPhep.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNghiPhep.ReadOnly = true;
        }

        private void PhanQuyenVaHienThiNghiPhep()
        {
            dgvNghiPhep.Rows.Clear();

            Account accHienTai = HRSystem.Instance.CurrentUser;
            if (accHienTai == null) return;

            Role quyen = accHienTai.Role;
            Employee userHienTai = accHienTai.Employee;

            // --- LỌC DANH SÁCH THEO QUYỀN ---
            foreach (LeaveRequest req in HRSystem.Instance.LeaveRequests)
            {
                bool duocPhepXem = false;

                if (quyen == Role.Admin || quyen == Role.HR)
                {
                    duocPhepXem = true; // Admin và HR soi hết cả công ty
                }
                else if (quyen == Role.Manager)
                {
                    // Manager chỉ xem đơn của người trong phòng (và của chính sếp)
                    if (req.NhanVien.PhongBan != null && userHienTai.PhongBan != null &&
                        req.NhanVien.PhongBan.MaPB == userHienTai.PhongBan.MaPB)
                    {
                        duocPhepXem = true;
                    }
                }
                else if (quyen == Role.Employee)
                {
                    // Nhân viên chỉ được xem đơn của bản thân
                    if (req.NhanVien.Id == userHienTai.Id)
                    {
                        duocPhepXem = true;
                    }
                }

                // Nếu thỏa mãn điều kiện thì ném lên lưới
                if (duocPhepXem)
                {
                    dgvNghiPhep.Rows.Add(req.MaDon, req.NhanVien.HoTen, req.LoaiNghiPhep, req.SoNgayNghi, req.LyDo, req.GetStatus());
                }
            }
        }

        private void btnGuiDon_Click(object sender, EventArgs e)
        {
            string loaiDon = cbbLoaiDon.Text;
            string lyDo = txtLyDo.Text.Trim();
            int soNgay = 0;

            // Bắt lỗi nhập bậy bạ
            if (string.IsNullOrEmpty(loaiDon) || string.IsNullOrEmpty(lyDo) || !int.TryParse(txtSoNgayNghi.Text, out soNgay))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin! Lưu ý: Số ngày nghỉ phải là số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Employee userHienTai = HRSystem.Instance.CurrentUser.Employee;
            string maDon = "LR_" + DateTime.Now.ToString("HHmmss");

            // Tạo đơn mới
            LeaveRequest donMoi = new LeaveRequest(maDon, userHienTai, loaiDon, soNgay, lyDo);

            // Đẩy vào hệ thống (Event tự động chạy báo cho Sếp)
            HRSystem.Instance.NopDonXinNghi(donMoi);

            MessageBox.Show("Đã gửi đơn thành công! Vui lòng chờ quản lý xét duyệt.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa trắng form và load lại lưới
            cbbLoaiDon.SelectedIndex = -1;
            txtSoNgayNghi.Text = "";
            txtLyDo.Text = "";
            PhanQuyenVaHienThiNghiPhep();
        }
        // Hàm phụ trợ xử lý chung cho cả 2 nút Duyệt/Từ chối
        private void XuLyDon(string hanhDong)
        {
            if (dgvNghiPhep.SelectedRows.Count > 0)
            {
                string maDon = dgvNghiPhep.SelectedRows[0].Cells["colMaDon"].Value.ToString();

                foreach (LeaveRequest req in HRSystem.Instance.LeaveRequests)
                {
                    if (req.MaDon == maDon)
                    {
                        if (req.GetStatus() != "Pending")
                        {
                            MessageBox.Show("Đơn này đã được xử lý rồi sếp ơi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        // Gọi hàm kích hoạt Event
                        if (hanhDong == "Duyệt")
                            req.Approve();
                        else
                            req.Reject();

                        PhanQuyenVaHienThiNghiPhep();
                        MessageBox.Show($"Đã {hanhDong.ToLower()} đơn thành công! Hệ thống đã gửi thông báo đến nhân viên.", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Sếp vui lòng chọn một đơn trên lưới để xử lý nhé!");
            }
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            XuLyDon("Duyệt");
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            XuLyDon("Từ chối");
        }



        // ==========================================
        // VÙNG CHUÔNG THÔNG BÁO
        // ==========================================
        private void CapNhatChuongThongBao()
        {
            if (HRSystem.Instance.CurrentUser == null) return;

            string idNguoiDung = HRSystem.Instance.CurrentUser.Employee.Id;
            int soThongBaoChuaDoc = 0;

            // Đếm số thông báo của riêng người này và chưa đọc
            foreach (Notification tb in HRSystem.Instance.Notifications)
            {
                if (tb.NguoiNhan.Id == idNguoiDung && tb.DaDoc == false)
                {
                    soThongBaoChuaDoc++;
                }
            }

            // Hiện số đỏ nếu > 0, ngược lại thì giấu cái số đỏ đi
            if (soThongBaoChuaDoc > 0)
            {
                lblSoThongBao.Text = soThongBaoChuaDoc.ToString();
                lblSoThongBao.Visible = true;
            }
            else
            {
                lblSoThongBao.Visible = false;
            }
        }

        private void btnChuong_Click(object sender, EventArgs e)
        {
            pnlThongBao.Visible = !pnlThongBao.Visible;
            pnlThongBao.BringToFront();

            if (pnlThongBao.Visible == true)
            {
                pnlThongBao.BringToFront(); // Nổi lên trên cùng
                HienThiDanhSachThongBao();  // Gọi hàm đổ dữ liệu
            }
        }

        private void HienThiDanhSachThongBao()
        {
            pnlThongBao.Controls.Clear(); // Xóa sạch các thông báo cũ trên giao diện

            string idNguoiDung = HRSystem.Instance.CurrentUser.Employee.Id;
            int toaDoY = 10; // Tọa độ từ trên xuống

            // Duyệt danh sách thông báo ngược từ dưới lên (để thông báo MỚI NHẤT hiện lên đầu)
            for (int i = HRSystem.Instance.Notifications.Count - 1; i >= 0; i--)
            {
                Notification tb = HRSystem.Instance.Notifications[i];

                // Chỉ lấy thông báo của mình
                if (tb.NguoiNhan.Id == idNguoiDung)
                {
                    // Tự động tạo 1 cái Label bằng Code
                    Label lblTB = new Label();
                    lblTB.Text = tb.NoiDung;
                    lblTB.AutoSize = false;
                    lblTB.Width = pnlThongBao.Width - 25; // Chiều ngang nhét vừa Panel
                    lblTB.Height = 50;                    // Chiều cao
                    lblTB.Location = new Point(5, toaDoY);
                    lblTB.Cursor = Cursors.Hand;          // Trỏ chuột hình bàn tay

                    // Style giống Facebook: Chưa đọc -> In đậm nền trắng | Đã đọc -> In thường nền xám
                    if (tb.DaDoc == false)
                    {
                        lblTB.BackColor = Color.LightCyan; // Nền hơi xanh nhẹ cho nổi bật
                        lblTB.Font = new Font(lblTB.Font, FontStyle.Bold);
                    }
                    else
                    {
                        lblTB.BackColor = Color.WhiteSmoke; // Nền xám nhạt
                        lblTB.Font = new Font(lblTB.Font, FontStyle.Regular);
                    }

                    // --- SỰ KIỆN CLICK VÀO THÔNG BÁO ĐỂ ĐÁNH DẤU ĐÃ ĐỌC ---
                    lblTB.Click += (s, e) =>
                    {
                        tb.DaDoc = true; // Chuyển trạng thái
                        lblTB.BackColor = Color.WhiteSmoke;
                        lblTB.Font = new Font(lblTB.Font, FontStyle.Regular);

                        CapNhatChuongThongBao(); // Cập nhật lại cái số đỏ ngay lập tức
                    };

                    // Nhét cái Label vừa tạo vào Panel
                    pnlThongBao.Controls.Add(lblTB);

                    // Tăng tọa độ Y lên để cái Label tiếp theo nằm bên dưới
                    toaDoY += 55;
                }
            }

            // Nếu không có thông báo nào thì báo cho người ta biết
            if (pnlThongBao.Controls.Count == 0)
            {
                Label lblTrong = new Label();
                lblTrong.Text = "Bạn không có thông báo nào.";
                lblTrong.AutoSize = true;
                lblTrong.Location = new Point(10, 10);
                pnlThongBao.Controls.Add(lblTrong);
            }
        }


        // ==========================================
        // VÙNG QUẢN LÝ HỆ THỐNG
        // ==========================================
        private void icoBaoTriHeThong_Click(object sender, EventArgs e)
        {
            pnl_HeThong.Visible = !pnl_HeThong.Visible;
            pnl_HeThong.BringToFront();

            TaoCotChoLuoiTaiKhoan();
            HienThiDanhSachTaiKhoan(HRSystem.Instance.Accounts);
            TaoCotChoLuoiLichSu();
            HienThiLichSu();
        }

        private void TaoCotChoLuoiTaiKhoan()
        {
            dgvTaiKhoan.Columns.Clear();
            dgvTaiKhoan.Columns.Add("colUser", "Tên Đăng Nhập");
            dgvTaiKhoan.Columns.Add("colNhanVien", "Chủ Tài Khoản");
            dgvTaiKhoan.Columns.Add("colQuyen", "Quyền Hạn");
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.ReadOnly = true;
        }

        private void HienThiDanhSachTaiKhoan(List<Account> danhSach)
        {
            dgvTaiKhoan.Rows.Clear();
            foreach (Account acc in danhSach)
            {
                string tenNV = acc.Employee != null ? acc.Employee.HoTen : "Chưa gắn NV";
                dgvTaiKhoan.Rows.Add(acc.Username, tenNV, acc.Role.ToString());
            }

            // Cập nhật luôn cái ComboBox những người "vô gia cư" (chưa có acc)
            LoadNhanVienChuaCoTaiKhoan();
        }

        private void LoadNhanVienChuaCoTaiKhoan()
        {
            cbbNhanVienRanh.Items.Clear();
            foreach (Employee emp in HRSystem.Instance.Employees)
            {
                // Kiểm tra xem ID của ông này đã nằm trong danh sách Account chưa
                bool daCoTaiKhoan = false;
                foreach (Account acc in HRSystem.Instance.Accounts)
                {
                    if (acc.Employee != null && acc.Employee.Id == emp.Id)
                    {
                        daCoTaiKhoan = true; break;
                    }
                }

                if (daCoTaiKhoan == false) // Nếu chưa có thì đưa vào danh sách chọn
                {
                    cbbNhanVienRanh2.Items.Add(emp.MaNhanVien + " - " + emp.HoTen);
                }
            }
        }

        private void btnTimTaiKhoan_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimTaiKhoan.Text.Trim().ToLower();
            List<Account> ketQua = new List<Account>();

            foreach (Account acc in HRSystem.Instance.Accounts)
            {
                if (acc.Username.ToLower().Contains(tuKhoa) ||
                   (acc.Employee != null && acc.Employee.HoTen.ToLower().Contains(tuKhoa)))
                {
                    ketQua.Add(acc);
                }
            }
            HienThiDanhSachTaiKhoan(ketQua);
        }

        //THÊM VÀ XÓA TÀI KHOẢN
        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string roleString = cbbQuyen.Text;
            string luaChonNV = cbbNhanVienRanh2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(roleString) || string.IsNullOrEmpty(luaChonNV))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin và chọn Nhân viên!"); return;
            }

            // Kiểm tra trùng Username
            foreach (Account acc in HRSystem.Instance.Accounts)
            {
                if (acc.Username == username)
                {
                    MessageBox.Show("Tên đăng nhập này đã có người xài! Chọn tên khác nhé."); return;
                }
            }

            // Tách chuỗi lấy Mã NV
            string maNV = luaChonNV.Split('-')[0].Trim();
            Employee chuTaiKhoan = null;
            foreach (Employee emp in HRSystem.Instance.Employees)
            {
                if (emp.MaNhanVien == maNV) { chuTaiKhoan = emp; break; }
            }

            // Ép kiểu chuỗi sang Enum Role 
            Role quyen = (Role)Enum.Parse(typeof(Role), roleString);

            // Tạo Account mới
            Account accMoi = new Account(username, password, quyen, chuTaiKhoan);
            HRSystem.Instance.Accounts.Add(accMoi);

            HienThiDanhSachTaiKhoan(HRSystem.Instance.Accounts);
            MessageBox.Show("Cấp tài khoản thành công!");
            txtUsername.Text = ""; txtPassword.Text = "";
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count > 0)
            {
                string username = dgvTaiKhoan.SelectedRows[0].Cells["colUser"].Value.ToString();

                // BẢO MẬT: Không cho admin tự xóa acc của chính mình
                if (username == HRSystem.Instance.CurrentUser.Username)
                {
                    MessageBox.Show("Không thể tự xóa tài khoản đang đăng nhập của chính mình được!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult hoi = MessageBox.Show($"Chắc chắn muốn xóa tài khoản {username}?", "Xác nhận", MessageBoxButtons.YesNo);
                if (hoi == DialogResult.Yes)
                {
                    foreach (Account acc in HRSystem.Instance.Accounts)
                    {
                        if (acc.Username == username)
                        {
                            HRSystem.Instance.Accounts.Remove(acc);
                            HienThiDanhSachTaiKhoan(HRSystem.Instance.Accounts);
                            MessageBox.Show("Đã xóa tài khoản!");
                            break;
                        }
                    }
                }
            }
        }

        //hiển thị lịch sử hoạt động:
        private void TaoCotChoLuoiLichSu()
        {
            dgvLichSu.Columns.Clear();
            dgvLichSu.Columns.Add("colThoiGian", "Thời Gian");
            dgvLichSu.Columns.Add("colUser", "Tài Khoản");
            dgvLichSu.Columns.Add("colHanhDong", "Hành Động");
            dgvLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichSu.ReadOnly = true;
        }

        private void HienThiLichSu()
        {
            dgvLichSu.Rows.Clear();
            // Lặp ngược để hiển thị log mới nhất lên trên cùng
            for (int i = HRSystem.Instance.ActivityLogs.Count - 1; i >= 0; i--)
            {
                ActivityLog log = HRSystem.Instance.ActivityLogs[i];
                string thoiGian = log.ThoiGian.ToString("dd/MM/yyyy HH:mm:ss");
                dgvLichSu.Rows.Add(thoiGian, log.TenTaiKhoan, log.HanhDong);
            }
        }





        // ==========================================
        // VÙNG THAO TÁC CHẤM CÔNG
        // ==========================================

        private void TaoCotChoLuoiChamCong()
        {
            dgvChamCong.Columns.Clear();
            dgvChamCong.Columns.Add("colNhanVien", "Nhân Viên");
            dgvChamCong.Columns.Add("colNgay", "Ngày");
            dgvChamCong.Columns.Add("colGioVao", "Giờ Vào");
            dgvChamCong.Columns.Add("colGioRa", "Giờ Ra");
            dgvChamCong.Columns.Add("colTrangThai", "Trạng Thái");
            dgvChamCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChamCong.ReadOnly = true;
        }

        private void HienThiDanhSachChamCong()
        {
            dgvChamCong.Rows.Clear();

            Account accHienTai = HRSystem.Instance.CurrentUser;
            if (accHienTai == null) return;

            Role quyen = accHienTai.Role;
            Employee userHienTai = accHienTai.Employee;

            // Duyệt qua tất cả các Bảng chấm công trong hệ thống
            foreach (Attendance bangCC in HRSystem.Instance.Attendances)
            {
                bool duocXem = false;

                // --- LOGIC PHÂN QUYỀN ---
                if (quyen == Role.Admin || quyen == Role.HR) duocXem = true; // Admin/HR xem hết
                else if (quyen == Role.Manager)
                {
                    // Manager xem phòng mình
                    if (bangCC.NhanVien.PhongBan != null && userHienTai.PhongBan != null &&
                        bangCC.NhanVien.PhongBan.MaPB == userHienTai.PhongBan.MaPB)
                        duocXem = true;
                }
                else if (quyen == Role.Employee)
                {
                    // Nhân viên chỉ xem của mình
                    if (bangCC.NhanVien.Id == userHienTai.Id) duocXem = true;
                }

                // Nếu được xem, thì lôi từng dòng (Record) ra nhét vào Grid
                if (duocXem)
                {
                    foreach (AttendanceRecord record in bangCC.Records)
                    {
                        string gioVao = record.GioVao.HasValue ? record.GioVao.Value.ToString(@"hh\:mm\:ss") : "--:--:--";
                        string gioRa = record.GioRa.HasValue ? record.GioRa.Value.ToString(@"hh\:mm\:ss") : "--:--:--";
                        string ngay = record.Ngay.ToString("dd/MM/yyyy");

                        dgvChamCong.Rows.Add(bangCC.NhanVien.HoTen, ngay, gioVao, gioRa, record.TrangThai);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)// checkin
        {
            Employee me = HRSystem.Instance.CurrentUser.Employee;
            Attendance bangCC = HRSystem.Instance.LayBangChamCongThanhNay(me);

            string ketQua = bangCC.CheckIn(DateTime.Now);

            MessageBox.Show(ketQua, "Thông báo Chấm Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThiDanhSachChamCong();
        }

        private void button7_Click(object sender, EventArgs e)// checkout
        {
            Employee me = HRSystem.Instance.CurrentUser.Employee;
            Attendance bangCC = HRSystem.Instance.LayBangChamCongThanhNay(me);

            string ketQua = bangCC.CheckOut(DateTime.Now);

            MessageBox.Show(ketQua, "Thông báo Chấm Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThiDanhSachChamCong();
        }

        private void lblChamCong_Click(object sender, EventArgs e)
        {
            CloseAllTab();
            pnlChamCong.BackColor = ColorTranslator.FromHtml("#D9E5FF");
            pnl_ChamCong.Visible = true;

        }

        private void lblChamCong_Employee_Click(object sender, EventArgs e)
        {
            CloseAllTab();
            pnlChamCong_Employee.BackColor = ColorTranslator.FromHtml("#D9E5FF");
            pnl_ChamCong.Visible = true;
        }


        // ==========================================
        // VÙNG THAO TÁC CHẤM CÔNG
        // ==========================================
        private void lblLuong_Employee_Click(object sender, EventArgs e)
        {
            CloseAllTab();
            pnlLuong_Employee.BackColor = ColorTranslator.FromHtml("#D9E5FF");
            pnl_Luong.Visible = true;
        }

        private void lblLuong_Click(object sender, EventArgs e)
        {
            CloseAllTab();
            pnlLuong.BackColor = ColorTranslator.FromHtml("#D9E5FF");
            pnl_Luong.Visible = true;
        }



        // GIAO DIỆN BẢNG LƯƠNG & PHÂN QUYỀN
        private void TaoCotChoLuoiTinhLuong()
        {
            dgvTinhLuong.Columns.Clear();
            dgvTinhLuong.Columns.Add("colNhanVien", "Nhân Viên");
            dgvTinhLuong.Columns.Add("colLuongGoc", "Lương Gốc");
            dgvTinhLuong.Columns.Add("colPhuCap", "Phụ Cấp (+)");
            dgvTinhLuong.Columns.Add("colBaoHiem", "Bảo Hiểm (-)");
            dgvTinhLuong.Columns.Add("colThue", "Thuế (-)");
            dgvTinhLuong.Columns.Add("colKhauTru", "Khấu Trừ (-)");
            dgvTinhLuong.Columns.Add("colThucLinh", "THỰC LĨNH");
            dgvTinhLuong.Columns.Add("colTrangThai", "Trạng Thái");

            dgvTinhLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTinhLuong.ReadOnly = true;
        }

        private void HienThiDanhSachBangLuong()
        {
            dgvTinhLuong.Rows.Clear();
            Account accHienTai = HRSystem.Instance.CurrentUser;
            if (accHienTai == null) return;

            Role quyen = accHienTai.Role;
            Employee userHienTai = accHienTai.Employee;



            foreach (Payroll pr in HRSystem.Instance.Payrolls)
            {
                bool duocXem = false;

                // --- PHÂN QUYỀN HIỂN THỊ CHUẨN MỰC ---
                if (quyen == Role.Admin || quyen == Role.HR) duocXem = true;
                else if (quyen == Role.Manager)
                {
                    if (pr.NhanVien.PhongBan != null && userHienTai.PhongBan != null && pr.NhanVien.PhongBan.MaPB == userHienTai.PhongBan.MaPB)
                        duocXem = true;
                }
                else if (quyen == Role.Employee && pr.NhanVien.Id == userHienTai.Id)
                {
                    duocXem = true;
                }

                if (duocXem)
                {
                    // Lấy Lương Gross để tính toán các khoản phụ thuộc %
                    double gross = pr.CalculateGrossSalary();

                    // 1. Lương Gốc (Cơ bản hoặc Giờ)
                    double luongGoc = pr.NhanVien.TinhLuong();

                    // 2. Phụ cấp + Thưởng
                    double tongPhuCap = 0;
                    foreach (var pc in pr.DanhSachPhuCap) tongPhuCap += pc.SoTien;
                    foreach (var t in pr.DanhSachThuong) tongPhuCap += t.SoTien;

                    // 3. Tiền Bảo Hiểm (Cố định + % dựa trên Gross)
                    double tongBaoHiem = 0;
                    foreach (var bh in pr.DanhSachBaoHiem) tongBaoHiem += bh.SoTienCoDinh + (gross * bh.TyLe);

                    // 4. Tiền Thuế
                    double tienThue = pr.ThueApDung != null ? gross * pr.ThueApDung.TyLeThue : 0;

                    // 5. Khấu trừ khác (Đi trễ, phạt...)
                    double khauTruKhac = 0;
                    foreach (var kt in pr.DanhSachKhauTru) khauTruKhac += kt.SoTien;

                    // 6. TRÙM CUỐI: Thực Lĩnh
                    double thucLinh = pr.CalculateNetSalary();

                    // Hiển thị lên lưới với định dạng N0 (Thêm dấu phẩy cho hàng ngàn, ví dụ: 15,000,000)
                    dgvTinhLuong.Rows.Add(
                        pr.NhanVien.HoTen,
                        luongGoc.ToString("N0") + " đ",
                        tongPhuCap.ToString("N0") + " đ",
                        tongBaoHiem.ToString("N0") + " đ",
                        tienThue.ToString("N0") + " đ",
                        khauTruKhac.ToString("N0") + " đ",
                        thucLinh.ToString("N0") + " đ",
                        pr.GetStatus()
                    );
                }
            }
        }

        private void btnChotLuong_Click(object sender, EventArgs e)
        {
            // Lấy tháng/năm từ giao diện
            int thangChot = (int)nudThang.Value;
            int namChot = (int)nudNam.Value;

            // 1. Chốt lương
            HRSystem.Instance.ChotLuongThang(thangChot, namChot);

            // 2. Bắn thông báo cho Giám đốc (Mã chức vụ = "GD")
            foreach (Employee emp in HRSystem.Instance.Employees)
            {
                if (emp.ChucVu != null && emp.ChucVu.MaChucVu == "GD")
                {
                    string maTB = "TB_LUONG_" + DateTime.Now.ToString("HHmmss");
                    string noiDung = $"[CHỜ DUYỆT LƯƠNG] HR vừa chốt bảng lương tháng {thangChot}/{namChot}. Sếp vui lòng vào kiểm tra và phê duyệt nhé!";

                    Notification thongBao = new Notification(maTB, noiDung, emp);
                    HRSystem.Instance.Notifications.Add(thongBao);
                }
            }

            // 3. Load lại lưới
            HienThiDanhSachBangLuong();
            MessageBox.Show($"Đã chốt lương tháng {thangChot}/{namChot} thành công! Hệ thống đã gửi thông báo đến Giám đốc.", "Thành công",
                                                                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // 1. KIỂM TRA QUYỀN: Bắt buộc phải là Giám đốc (Mã "GD")
            Employee userHienTai = HRSystem.Instance.CurrentUser.Employee;
            if (userHienTai.ChucVu == null || userHienTai.ChucVu.MaChucVu != "GD")
            {
                MessageBox.Show("Báo động: Chỉ có Giám đốc công ty mới có thẩm quyền duyệt bảng lương!", "Từ chối truy cập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. HỎI XÁC NHẬN DUYỆT HÀNG LOẠT
            DialogResult hoi = MessageBox.Show("Sếp có muốn duyệt TOÀN BỘ bảng lương đang chờ trong hệ thống không?", "Xác nhận duyệt tổng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (hoi == DialogResult.Yes)
            {
                int soLuongDaDuyet = 0;

                // Lướt trong hệ thống tìm tất cả các bảng lương Pending
                foreach (Payroll pr in HRSystem.Instance.Payrolls)
                {
                    if (pr.GetStatus() == "Pending")
                    {
                        pr.Approve(); // Đổi trạng thái thành Approved
                        soLuongDaDuyet++;
                    }
                }

                // 3. THÔNG BÁO KẾT QUẢ
                if (soLuongDaDuyet > 0)
                {
                    HienThiDanhSachBangLuong(); // Load lại lưới
                    MessageBox.Show($"Quá đã! Sếp vừa vung tay phê duyệt thành công {soLuongDaDuyet} bảng lương!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hiện tại không có bảng lương nào đang chờ duyệt sếp ơi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
