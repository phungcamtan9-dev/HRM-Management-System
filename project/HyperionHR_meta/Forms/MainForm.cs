using HyperionHR_meta.Scripts.Class.Organizations;
using HyperionHR_meta.Scripts.Class.Person;
using HyperionHR_meta.Scripts.Class.System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
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

            //Bom dữ liệu
            TaiDuLieuChucVu();




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
            pnlLogOut2.Visible = false;

        }
        // Hàm check quyền tài khoản
        public void CheckRole()
        {
            switch (system.CurrentUser.Role)
            {
                case Role.Admin:
                    //hiện
                    icoBaoTriHeThong.Visible = true;
                    pnlSideBar_HR.Visible = true;
                    pnlBottomSideMenu.Visible = true;
                    pnl_Dashboard.Visible = true;
                    HienThiDanhSachNhanVien(HRSystem.Instance.Employees);

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

                    //ẩn
                    icoBaoTriHeThong.Visible = false;
                    pnlSideBar_Employee.Visible = false;
                    pnlBottomSideBar_Employee.Visible = false;

                    break;

                case Role.Manager:
                    //hiện                    
                    pnlSideBar_HR.Visible = true;
                    pnlBottomSideMenu.Visible = true;
                    pnlDashboard.Visible = false;

                    //ẩn
                    icoBaoTriHeThong.Visible = false;
                    pnlSideBar_Employee.Visible = false;
                    pnlBottomSideBar_Employee.Visible = false;

                    break;

                case Role.Employee:
                    //hiện
                    pnlSideBar_Employee.Visible = true;
                    pnlBottomSideBar_Employee.Visible = true;
                    pnlHoSoCaNhan.Visible = true;
                    pnlDashboard.Visible = false;

                    //ẩn
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

                // Thêm 1 dòng mới vào lưới
                dgvNhanVien.Rows.Add(emp.Id, emp.MaNhanVien, emp.HoTen, tenPB, tenCV, loaiNhanVien);
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

                // 4. Thêm vào hệ thống
                HRSystem.Instance.Employees.Add(nvMoi);

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

        // ==========================================
        // Vùng Thao Tác DashBoard
        // ==========================================
        //Mở tab
        private void lblDashboard_Click(object sender, EventArgs e)
        {
            CloseAllTab();
            pnlDashboard.BackColor = ColorTranslator.FromHtml("#D9E5FF");
            pnl_Dashboard.Visible = true;
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

            // 1. Tìm cái Chi nhánh đang được chọn để nhét Phòng ban vào
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
                // 2. Tạo phòng ban mới
                Department pbMoi = new Department(maPB, tenPB);

                // 3. Thêm vào hệ thống VÀ thêm vào chi nhánh
                HRSystem.Instance.Departments.Add(pbMoi);
                chiNhanhHienTai.AddDepartment(pbMoi);

                // 4. Load lại lưới bằng cách gọi lại sự kiện đổi Chi Nhánh
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
            
            lbEmail.Text = $"{HRSystem.Instance.CurrentUser.Employee.Email}";
            lbSDT.Text = $"{HRSystem.Instance.CurrentUser.Employee.SoDienThoai}";
            lbHoTen.Text = $"{HRSystem.Instance.CurrentUser.Employee.SoDienThoai}";
            lbMaNV.Text = $"{HRSystem.Instance.CurrentUser.Employee.SoDienThoai}";
            lbGioiTinh.Text = $"{HRSystem.Instance.CurrentUser.Employee.SoDienThoai}";
            lbChucVu.Text = $"{HRSystem.Instance.CurrentUser.Employee.SoDienThoai}";
            lbNgaySinh.Text = $"{HRSystem.Instance.CurrentUser.Employee.SoDienThoai}";
            lbLoaiNhanVien.Text = $"{HRSystem.Instance.CurrentUser.Employee.ChucVu}";


        }

        private void lblHoSoCaNhan_Employee_Click(object sender, EventArgs e)
        {
            CloseAllTab(); // tắt tab khác trước r mới mở
            pnlHoSoCaNhan_Employee.BackColor = ColorTranslator.FromHtml("#D9E5FF");
            pnl_HoSoCaNhan.Visible = true;
        }
    }
}
