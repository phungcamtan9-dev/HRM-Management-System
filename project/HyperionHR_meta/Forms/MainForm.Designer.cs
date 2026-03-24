using System.Runtime.InteropServices;

namespace HyperionHR_meta
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse);

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            pnlFormBar = new Panel();
            picLogo = new PictureBox();
            lblAppName = new Label();
            btnHide = new Button();
            btnclose = new Button();
            lblSystemName = new Label();
            pnlWelcomeBar = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            lblSoThongBao = new Label();
            icoBaoTriHeThong = new PictureBox();
            btnChuong = new PictureBox();
            picAva2 = new HyperionHR_meta.Scripts.UI.CirclePictureBox();
            lblDateTime = new Label();
            lblWelcome = new Label();
            pnlSideBar_HR = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pnlBottomSideMenu = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            picAva1 = new HyperionHR_meta.Scripts.UI.CirclePictureBox();
            lblUserName1 = new Label();
            lblUserGmail1 = new Label();
            pnlHoTro = new Panel();
            icoHoTro = new PictureBox();
            lblHoTro = new Label();
            pnlCaiDat = new Panel();
            icoCaiDat = new PictureBox();
            lblCaiDat = new Label();
            grbChucNang = new GroupBox();
            pnlDonXin = new Panel();
            icoDon = new PictureBox();
            lblDonXin = new Label();
            pnlLuong = new Panel();
            icoLuong = new PictureBox();
            lblLuong = new Label();
            pnlChamCong = new Panel();
            icoChamCong = new PictureBox();
            lblChamCong = new Label();
            pnlHopDong = new Panel();
            icoHopDong = new PictureBox();
            lblHopDong = new Label();
            pnlChucNang = new Panel();
            icoToChuc = new PictureBox();
            lblToChuc = new Label();
            pnlNhanSu = new Panel();
            icoNhanSu = new PictureBox();
            lblNhanSu = new Label();
            grbMainMenu = new GroupBox();
            pnlHoSoCaNhan = new Panel();
            icoHoSoCaNhan = new PictureBox();
            lblHoSoCaNhan = new Label();
            pnlDashboard = new Panel();
            icoDashBoard = new PictureBox();
            lblDashboard = new Label();
            pnlLogout = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            picIconLogout = new PictureBox();
            lblLogout = new Label();
            pnl_HoSoCaNhan = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            lbPhongban = new Label();
            label50 = new Label();
            lbNgayKetThuc = new Label();
            label36 = new Label();
            lbNgayBatDauHD = new Label();
            label37 = new Label();
            lbLoaiHD = new Label();
            label35 = new Label();
            lbMaHD = new Label();
            label34 = new Label();
            label31 = new Label();
            label32 = new Label();
            label30 = new Label();
            lbChucVu = new Label();
            lbLoaiNhanVien = new Label();
            lbNgaySinh = new Label();
            lbGioiTinh = new Label();
            lbHoTen = new Label();
            lbMaNV = new Label();
            roundedPanel10 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            lbSDT = new Label();
            lbEmail = new Label();
            circlePictureBox2 = new HyperionHR_meta.Scripts.UI.CirclePictureBox();
            label25 = new Label();
            label27 = new Label();
            label23 = new Label();
            label28 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label24 = new Label();
            label26 = new Label();
            pnl_TopHoSo = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            lbl_TitleHoSo = new Label();
            roundedPanel4 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pnlSideBar_Employee = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pnlHoTro2 = new Panel();
            icoHoTro2 = new PictureBox();
            lblHoTro2 = new Label();
            pnlCaiDat2 = new Panel();
            icoCaiDat2 = new PictureBox();
            lblCaiDat2 = new Label();
            pnlBottomSideBar_Employee = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            picAva3 = new HyperionHR_meta.Scripts.UI.CirclePictureBox();
            lblUserName2 = new Label();
            lblUserGmail2 = new Label();
            lblSystemName2 = new Label();
            roundedPanel3 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            roundedPanel5 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            circlePictureBox1 = new HyperionHR_meta.Scripts.UI.CirclePictureBox();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            label7 = new Label();
            grbChucNang_Employee = new GroupBox();
            pnlHoSoCaNhan_Employee = new Panel();
            icoHoSoCaNhan2 = new PictureBox();
            lblHoSoCaNhan_Employee = new Label();
            pnlDonXin_Employee = new Panel();
            icoDonXin = new PictureBox();
            lblDonXin_Employee = new Label();
            pnlLuong_Employee = new Panel();
            icoLuong2 = new PictureBox();
            lblLuong_Employee = new Label();
            pnlChamCong_Employee = new Panel();
            icoChamCong_2 = new PictureBox();
            lblChamCong_Employee = new Label();
            pnl_QuanLyNhanSu = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pnlDienThongTin = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            chkTaoHopDong = new CheckBox();
            label38 = new Label();
            cbbChucVu = new ComboBox();
            label16 = new Label();
            btnTatBangThongTin = new Button();
            btnLamMoiInput = new Button();
            btnThem = new Button();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            cbbLoaiNV = new ComboBox();
            cbbGioiTinh = new ComboBox();
            lblLoaiNhanVien = new Label();
            lblGioiTInh = new Label();
            lblBangDieuChinh = new Label();
            lblDienSDT = new Label();
            txtMaNV = new TextBox();
            txtSoDienThoai = new TextBox();
            lblDienMaNV = new Label();
            lblDienEmail = new Label();
            txtHoTen = new TextBox();
            txtEmail = new TextBox();
            lblDienHoTen = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnThemNV = new Button();
            pnlBoxTimKiem = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            btnTimKiem = new PictureBox();
            txtTimKiem = new TextBox();
            cbbTieuChi = new ComboBox();
            btnLamMoi = new Button();
            pnl_TopQLNhanSu = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            lbl_TittleQLNhanSu = new Label();
            roundedPanel7 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pictureBox6 = new PictureBox();
            label9 = new Label();
            lblTimKiem = new Label();
            pnl_DGVEmployee = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            dgvNhanVien = new DataGridView();
            pnl_ToChuc = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            btnBoxThemChiNhanh = new Button();
            btnSuaPB = new Button();
            btnXoaPB = new Button();
            btnThemPB = new Button();
            label11 = new Label();
            label8 = new Label();
            roundedPanel9 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            dgvDanhSachTheoPhong = new DataGridView();
            roundedPanel1 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            dgvPhongBan = new DataGridView();
            cbbChiNhanh = new ComboBox();
            lblChonChiNhanh = new Label();
            roundedPanel6 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            lblTieuDeToChuc = new Label();
            roundedPanel8 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pictureBox7 = new PictureBox();
            label10 = new Label();
            pnlBangDieuChinhPB = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            label15 = new Label();
            txtMaPB = new TextBox();
            txtTenPB = new TextBox();
            label14 = new Label();
            label12 = new Label();
            pnlThemNVvaoPB = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            button1 = new Button();
            chkTruongPhong = new CheckBox();
            btnXacNhanThem = new Button();
            cbbNhanVienRanh = new ComboBox();
            lblTenPhong = new Label();
            label17 = new Label();
            label18 = new Label();
            pnlThemChiNhanh = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            label49 = new Label();
            txtDiaChiCN = new TextBox();
            txtTenCN = new TextBox();
            txtMaCN = new TextBox();
            button5 = new Button();
            btnThemCN = new Button();
            label42 = new Label();
            label46 = new Label();
            label48 = new Label();
            pnl_QuanLyHopDong = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            btnDuyetHD = new Button();
            btnChamDut = new Button();
            btnGiaHan = new Button();
            button2 = new Button();
            roundedPanel11 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            txtTimHopDong = new TextBox();
            btnTimHopDong = new PictureBox();
            label33 = new Label();
            dgcHopDong = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            dgvHopDong = new DataGridView();
            roundedPanel12 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            label13 = new Label();
            roundedPanel13 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pictureBox8 = new PictureBox();
            label29 = new Label();
            roundedPanel2 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            pnl_TopDashboard = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            lbl_Dashboarđ = new Label();
            pnl_Dashboard = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pictureBox13 = new PictureBox();
            roundedPanel34 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            lblNhanVienCheckIn = new Label();
            label70 = new Label();
            roundedPanel33 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            lblDonChoDuyet = new Label();
            label69 = new Label();
            roundedPanel32 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            lblHopDongHetHan = new Label();
            label68 = new Label();
            roundedPanel31 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            lblHopDongConHan = new Label();
            label67 = new Label();
            roundedPanel30 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            lblTongPhongBan = new Label();
            label66 = new Label();
            roundedPanel29 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            lblTongNhanVien = new Label();
            label65 = new Label();
            pnl_DonXin = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            label43 = new Label();
            roundedPanel14 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            btnGuiDon = new Button();
            cbbLoaiDon = new ComboBox();
            txtLyDo = new TextBox();
            txtSoNgayNghi = new TextBox();
            label47 = new Label();
            label45 = new Label();
            label44 = new Label();
            btnTuChoi = new Button();
            btnDuyet = new Button();
            roundedPanel17 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            dgvNghiPhep = new DataGridView();
            roundedPanel15 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            label39 = new Label();
            roundedPanel16 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pictureBox9 = new PictureBox();
            label40 = new Label();
            pnlThongBao = new Panel();
            label41 = new Label();
            button3 = new Button();
            button4 = new Button();
            roundedPanel18 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            label51 = new Label();
            pnl_HeThong = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            label58 = new Label();
            roundedPanel22 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            dgvLichSu = new DataGridView();
            pnlBoxTimTaiKhoan = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            txtTimTaiKhoan = new TextBox();
            btnTimTaiKhoan = new PictureBox();
            roundedPanel21 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            btnThemTaiKhoan = new Button();
            btnXoaTaiKhoan = new Button();
            cbbNhanVienRanh2 = new ComboBox();
            label57 = new Label();
            cbbQuyen = new ComboBox();
            label56 = new Label();
            txtPassword = new TextBox();
            label55 = new Label();
            txtUsername = new TextBox();
            label54 = new Label();
            label53 = new Label();
            roundedPanel19 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            dgvTaiKhoan = new DataGridView();
            roundedPanel20 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pictureBox10 = new PictureBox();
            label52 = new Label();
            pnl_ChamCong = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            button7 = new Button();
            button6 = new Button();
            label61 = new Label();
            roundedPanel26 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            dgvChamCong = new DataGridView();
            roundedPanel24 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            label59 = new Label();
            roundedPanel25 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pictureBox11 = new PictureBox();
            label60 = new Label();
            pnl_Luong = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            label72 = new Label();
            nudNam = new NumericUpDown();
            label71 = new Label();
            nudThang = new NumericUpDown();
            label64 = new Label();
            button8 = new Button();
            btnChotLuong = new Button();
            roundedPanel23 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            dgvTinhLuong = new DataGridView();
            roundedPanel27 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            label62 = new Label();
            roundedPanel28 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pictureBox12 = new PictureBox();
            label63 = new Label();
            pnlFormBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlWelcomeBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoBaoTriHeThong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnChuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAva2).BeginInit();
            pnlSideBar_HR.SuspendLayout();
            pnlBottomSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAva1).BeginInit();
            pnlHoTro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoHoTro).BeginInit();
            pnlCaiDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoCaiDat).BeginInit();
            grbChucNang.SuspendLayout();
            pnlDonXin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoDon).BeginInit();
            pnlLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoLuong).BeginInit();
            pnlChamCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoChamCong).BeginInit();
            pnlHopDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoHopDong).BeginInit();
            pnlChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoToChuc).BeginInit();
            pnlNhanSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoNhanSu).BeginInit();
            grbMainMenu.SuspendLayout();
            pnlHoSoCaNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoHoSoCaNhan).BeginInit();
            pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoDashBoard).BeginInit();
            pnlLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconLogout).BeginInit();
            pnl_HoSoCaNhan.SuspendLayout();
            roundedPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)circlePictureBox2).BeginInit();
            pnl_TopHoSo.SuspendLayout();
            roundedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlSideBar_Employee.SuspendLayout();
            pnlHoTro2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoHoTro2).BeginInit();
            pnlCaiDat2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoCaiDat2).BeginInit();
            pnlBottomSideBar_Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAva3).BeginInit();
            roundedPanel3.SuspendLayout();
            roundedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)circlePictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            grbChucNang_Employee.SuspendLayout();
            pnlHoSoCaNhan_Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoHoSoCaNhan2).BeginInit();
            pnlDonXin_Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoDonXin).BeginInit();
            pnlLuong_Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoLuong2).BeginInit();
            pnlChamCong_Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoChamCong_2).BeginInit();
            pnl_QuanLyNhanSu.SuspendLayout();
            pnlDienThongTin.SuspendLayout();
            pnlBoxTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnTimKiem).BeginInit();
            pnl_TopQLNhanSu.SuspendLayout();
            roundedPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            pnl_DGVEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            pnl_ToChuc.SuspendLayout();
            roundedPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachTheoPhong).BeginInit();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhongBan).BeginInit();
            roundedPanel6.SuspendLayout();
            roundedPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            pnlBangDieuChinhPB.SuspendLayout();
            pnlThemNVvaoPB.SuspendLayout();
            pnlThemChiNhanh.SuspendLayout();
            pnl_QuanLyHopDong.SuspendLayout();
            roundedPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnTimHopDong).BeginInit();
            dgcHopDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHopDong).BeginInit();
            roundedPanel12.SuspendLayout();
            roundedPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnl_TopDashboard.SuspendLayout();
            pnl_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            roundedPanel34.SuspendLayout();
            roundedPanel33.SuspendLayout();
            roundedPanel32.SuspendLayout();
            roundedPanel31.SuspendLayout();
            roundedPanel30.SuspendLayout();
            roundedPanel29.SuspendLayout();
            pnl_DonXin.SuspendLayout();
            roundedPanel14.SuspendLayout();
            roundedPanel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNghiPhep).BeginInit();
            roundedPanel15.SuspendLayout();
            roundedPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            pnlThongBao.SuspendLayout();
            roundedPanel18.SuspendLayout();
            pnl_HeThong.SuspendLayout();
            roundedPanel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).BeginInit();
            pnlBoxTimTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnTimTaiKhoan).BeginInit();
            roundedPanel21.SuspendLayout();
            roundedPanel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            roundedPanel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            pnl_ChamCong.SuspendLayout();
            roundedPanel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).BeginInit();
            roundedPanel24.SuspendLayout();
            roundedPanel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            pnl_Luong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudThang).BeginInit();
            roundedPanel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTinhLuong).BeginInit();
            roundedPanel27.SuspendLayout();
            roundedPanel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            SuspendLayout();
            // 
            // pnlFormBar
            // 
            pnlFormBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlFormBar.BackColor = Color.FromArgb(173, 220, 255);
            pnlFormBar.Controls.Add(picLogo);
            pnlFormBar.Controls.Add(lblAppName);
            pnlFormBar.Controls.Add(btnHide);
            pnlFormBar.Controls.Add(btnclose);
            pnlFormBar.Location = new Point(0, 0);
            pnlFormBar.Name = "pnlFormBar";
            pnlFormBar.Size = new Size(1366, 35);
            pnlFormBar.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(3, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(29, 27);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 3;
            picLogo.TabStop = false;
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.Location = new Point(33, 4);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(383, 27);
            lblAppName.TabIndex = 2;
            lblAppName.Text = "HyperionHR_meta";
            lblAppName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnHide
            // 
            btnHide.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHide.BackColor = Color.Transparent;
            btnHide.FlatAppearance.BorderSize = 0;
            btnHide.FlatStyle = FlatStyle.Flat;
            btnHide.Font = new Font("Inter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHide.Location = new Point(1263, 5);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(40, 25);
            btnHide.TabIndex = 2;
            btnHide.Text = "-";
            btnHide.TextAlign = ContentAlignment.TopCenter;
            btnHide.UseVisualStyleBackColor = false;
            btnHide.Click += btnHide_Click;
            // 
            // btnclose
            // 
            btnclose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnclose.BackColor = Color.Transparent;
            btnclose.FlatAppearance.BorderSize = 0;
            btnclose.FlatStyle = FlatStyle.Flat;
            btnclose.Font = new Font("Inter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose.Location = new Point(1306, 5);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(40, 25);
            btnclose.TabIndex = 1;
            btnclose.Text = "x";
            btnclose.TextAlign = ContentAlignment.TopCenter;
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // lblSystemName
            // 
            lblSystemName.Font = new Font("Inter ExtraBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSystemName.Location = new Point(1, 3);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(238, 90);
            lblSystemName.TabIndex = 1;
            lblSystemName.Text = "HyperionHR";
            lblSystemName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlWelcomeBar
            // 
            pnlWelcomeBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlWelcomeBar.BackColor = Color.White;
            pnlWelcomeBar.BorderRadius = 20;
            pnlWelcomeBar.Controls.Add(lblSoThongBao);
            pnlWelcomeBar.Controls.Add(icoBaoTriHeThong);
            pnlWelcomeBar.Controls.Add(btnChuong);
            pnlWelcomeBar.Controls.Add(picAva2);
            pnlWelcomeBar.Controls.Add(lblDateTime);
            pnlWelcomeBar.Controls.Add(lblWelcome);
            pnlWelcomeBar.Location = new Point(289, 41);
            pnlWelcomeBar.Name = "pnlWelcomeBar";
            pnlWelcomeBar.Size = new Size(1054, 90);
            pnlWelcomeBar.TabIndex = 2;
            // 
            // lblSoThongBao
            // 
            lblSoThongBao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSoThongBao.AutoSize = true;
            lblSoThongBao.BackColor = Color.Red;
            lblSoThongBao.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoThongBao.ForeColor = Color.White;
            lblSoThongBao.Location = new Point(1026, 18);
            lblSoThongBao.Name = "lblSoThongBao";
            lblSoThongBao.Size = new Size(16, 17);
            lblSoThongBao.TabIndex = 8;
            lblSoThongBao.Text = "0";
            // 
            // icoBaoTriHeThong
            // 
            icoBaoTriHeThong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icoBaoTriHeThong.Image = (Image)resources.GetObject("icoBaoTriHeThong.Image");
            icoBaoTriHeThong.Location = new Point(929, 25);
            icoBaoTriHeThong.Name = "icoBaoTriHeThong";
            icoBaoTriHeThong.Size = new Size(43, 43);
            icoBaoTriHeThong.SizeMode = PictureBoxSizeMode.StretchImage;
            icoBaoTriHeThong.TabIndex = 7;
            icoBaoTriHeThong.TabStop = false;
            icoBaoTriHeThong.Click += icoBaoTriHeThong_Click;
            // 
            // btnChuong
            // 
            btnChuong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChuong.Image = (Image)resources.GetObject("btnChuong.Image");
            btnChuong.Location = new Point(993, 25);
            btnChuong.Name = "btnChuong";
            btnChuong.Size = new Size(43, 43);
            btnChuong.SizeMode = PictureBoxSizeMode.StretchImage;
            btnChuong.TabIndex = 2;
            btnChuong.TabStop = false;
            btnChuong.Click += btnChuong_Click;
            // 
            // picAva2
            // 
            picAva2.Image = Properties.Resources.picAva;
            picAva2.Location = new Point(25, 15);
            picAva2.Name = "picAva2";
            picAva2.Size = new Size(62, 62);
            picAva2.SizeMode = PictureBoxSizeMode.Zoom;
            picAva2.TabIndex = 5;
            picAva2.TabStop = false;
            // 
            // lblDateTime
            // 
            lblDateTime.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateTime.Location = new Point(100, 50);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(383, 27);
            lblDateTime.TabIndex = 1;
            lblDateTime.Text = "Thứ hai, ngày 02 tháng 02 năm 2026";
            lblDateTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Inter Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(100, 15);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(557, 41);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "       , Chào buổi sáng admin";
            lblWelcome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlSideBar_HR
            // 
            pnlSideBar_HR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlSideBar_HR.BackColor = Color.White;
            pnlSideBar_HR.BorderRadius = 20;
            pnlSideBar_HR.Controls.Add(pnlBottomSideMenu);
            pnlSideBar_HR.Controls.Add(pnlHoTro);
            pnlSideBar_HR.Controls.Add(pnlCaiDat);
            pnlSideBar_HR.Controls.Add(grbChucNang);
            pnlSideBar_HR.Controls.Add(grbMainMenu);
            pnlSideBar_HR.Controls.Add(lblSystemName);
            pnlSideBar_HR.Location = new Point(25, 41);
            pnlSideBar_HR.Name = "pnlSideBar_HR";
            pnlSideBar_HR.Size = new Size(240, 736);
            pnlSideBar_HR.TabIndex = 3;
            // 
            // pnlBottomSideMenu
            // 
            pnlBottomSideMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlBottomSideMenu.BackColor = Color.FromArgb(217, 229, 255);
            pnlBottomSideMenu.BorderRadius = 20;
            pnlBottomSideMenu.Controls.Add(picAva1);
            pnlBottomSideMenu.Controls.Add(lblUserName1);
            pnlBottomSideMenu.Controls.Add(lblUserGmail1);
            pnlBottomSideMenu.Location = new Point(0, 672);
            pnlBottomSideMenu.Name = "pnlBottomSideMenu";
            pnlBottomSideMenu.Size = new Size(240, 64);
            pnlBottomSideMenu.TabIndex = 14;
            // 
            // picAva1
            // 
            picAva1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            picAva1.Image = Properties.Resources.picAva;
            picAva1.Location = new Point(17, 9);
            picAva1.Name = "picAva1";
            picAva1.Size = new Size(36, 36);
            picAva1.SizeMode = PictureBoxSizeMode.Zoom;
            picAva1.TabIndex = 4;
            picAva1.TabStop = false;
            picAva1.Click += picAva1_Click;
            // 
            // lblUserName1
            // 
            lblUserName1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUserName1.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName1.Location = new Point(60, 4);
            lblUserName1.Name = "lblUserName1";
            lblUserName1.Size = new Size(170, 27);
            lblUserName1.TabIndex = 6;
            lblUserName1.Text = "admin/HR";
            lblUserName1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUserGmail1
            // 
            lblUserGmail1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUserGmail1.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserGmail1.ForeColor = SystemColors.ControlDarkDark;
            lblUserGmail1.Location = new Point(60, 29);
            lblUserGmail1.Name = "lblUserGmail1";
            lblUserGmail1.Size = new Size(170, 24);
            lblUserGmail1.TabIndex = 7;
            lblUserGmail1.Text = "admin/HR";
            // 
            // pnlHoTro
            // 
            pnlHoTro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlHoTro.Controls.Add(icoHoTro);
            pnlHoTro.Controls.Add(lblHoTro);
            pnlHoTro.Location = new Point(30, 590);
            pnlHoTro.Name = "pnlHoTro";
            pnlHoTro.Size = new Size(190, 35);
            pnlHoTro.TabIndex = 7;
            // 
            // icoHoTro
            // 
            icoHoTro.Image = Properties.Resources.Screenshot_2026_03_16_125445;
            icoHoTro.Location = new Point(10, 5);
            icoHoTro.Name = "icoHoTro";
            icoHoTro.Size = new Size(25, 25);
            icoHoTro.SizeMode = PictureBoxSizeMode.StretchImage;
            icoHoTro.TabIndex = 1;
            icoHoTro.TabStop = false;
            // 
            // lblHoTro
            // 
            lblHoTro.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoTro.Location = new Point(48, 5);
            lblHoTro.Name = "lblHoTro";
            lblHoTro.Size = new Size(139, 25);
            lblHoTro.TabIndex = 0;
            lblHoTro.Text = "Hỗ trợ";
            // 
            // pnlCaiDat
            // 
            pnlCaiDat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlCaiDat.Controls.Add(icoCaiDat);
            pnlCaiDat.Controls.Add(lblCaiDat);
            pnlCaiDat.Location = new Point(30, 631);
            pnlCaiDat.Name = "pnlCaiDat";
            pnlCaiDat.Size = new Size(190, 35);
            pnlCaiDat.TabIndex = 6;
            // 
            // icoCaiDat
            // 
            icoCaiDat.Image = Properties.Resources.Screenshot_2026_03_16_125354;
            icoCaiDat.Location = new Point(10, 5);
            icoCaiDat.Name = "icoCaiDat";
            icoCaiDat.Size = new Size(25, 25);
            icoCaiDat.SizeMode = PictureBoxSizeMode.StretchImage;
            icoCaiDat.TabIndex = 1;
            icoCaiDat.TabStop = false;
            // 
            // lblCaiDat
            // 
            lblCaiDat.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCaiDat.Location = new Point(48, 5);
            lblCaiDat.Name = "lblCaiDat";
            lblCaiDat.Size = new Size(139, 25);
            lblCaiDat.TabIndex = 0;
            lblCaiDat.Text = "Cài đặt";
            // 
            // grbChucNang
            // 
            grbChucNang.Controls.Add(pnlDonXin);
            grbChucNang.Controls.Add(pnlLuong);
            grbChucNang.Controls.Add(pnlChamCong);
            grbChucNang.Controls.Add(pnlHopDong);
            grbChucNang.Controls.Add(pnlChucNang);
            grbChucNang.Controls.Add(pnlNhanSu);
            grbChucNang.Font = new Font("Inter", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbChucNang.Location = new Point(18, 225);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(208, 325);
            grbChucNang.TabIndex = 13;
            grbChucNang.TabStop = false;
            grbChucNang.Text = "Chức năng";
            // 
            // pnlDonXin
            // 
            pnlDonXin.Controls.Add(icoDon);
            pnlDonXin.Controls.Add(lblDonXin);
            pnlDonXin.Location = new Point(12, 156);
            pnlDonXin.Name = "pnlDonXin";
            pnlDonXin.Size = new Size(190, 35);
            pnlDonXin.TabIndex = 7;
            // 
            // icoDon
            // 
            icoDon.Image = Properties.Resources.Screenshot_2026_03_16_132124;
            icoDon.Location = new Point(10, 5);
            icoDon.Name = "icoDon";
            icoDon.Size = new Size(25, 25);
            icoDon.SizeMode = PictureBoxSizeMode.StretchImage;
            icoDon.TabIndex = 1;
            icoDon.TabStop = false;
            // 
            // lblDonXin
            // 
            lblDonXin.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDonXin.Location = new Point(48, 5);
            lblDonXin.Name = "lblDonXin";
            lblDonXin.Size = new Size(139, 25);
            lblDonXin.TabIndex = 0;
            lblDonXin.Text = "Đơn xin";
            lblDonXin.Click += lblDonXin_Click;
            // 
            // pnlLuong
            // 
            pnlLuong.Controls.Add(icoLuong);
            pnlLuong.Controls.Add(lblLuong);
            pnlLuong.Location = new Point(12, 238);
            pnlLuong.Name = "pnlLuong";
            pnlLuong.Size = new Size(190, 35);
            pnlLuong.TabIndex = 9;
            // 
            // icoLuong
            // 
            icoLuong.Image = Properties.Resources.Screenshot_2026_03_16_132348;
            icoLuong.Location = new Point(10, 5);
            icoLuong.Name = "icoLuong";
            icoLuong.Size = new Size(25, 25);
            icoLuong.SizeMode = PictureBoxSizeMode.StretchImage;
            icoLuong.TabIndex = 1;
            icoLuong.TabStop = false;
            // 
            // lblLuong
            // 
            lblLuong.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLuong.Location = new Point(48, 5);
            lblLuong.Name = "lblLuong";
            lblLuong.Size = new Size(139, 25);
            lblLuong.TabIndex = 0;
            lblLuong.Text = "Lương";
            lblLuong.Click += lblLuong_Click;
            // 
            // pnlChamCong
            // 
            pnlChamCong.Controls.Add(icoChamCong);
            pnlChamCong.Controls.Add(lblChamCong);
            pnlChamCong.Location = new Point(12, 197);
            pnlChamCong.Name = "pnlChamCong";
            pnlChamCong.Size = new Size(190, 35);
            pnlChamCong.TabIndex = 7;
            // 
            // icoChamCong
            // 
            icoChamCong.Image = Properties.Resources.Screenshot_2026_03_16_132203;
            icoChamCong.Location = new Point(10, 5);
            icoChamCong.Name = "icoChamCong";
            icoChamCong.Size = new Size(25, 25);
            icoChamCong.SizeMode = PictureBoxSizeMode.StretchImage;
            icoChamCong.TabIndex = 1;
            icoChamCong.TabStop = false;
            // 
            // lblChamCong
            // 
            lblChamCong.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChamCong.Location = new Point(48, 5);
            lblChamCong.Name = "lblChamCong";
            lblChamCong.Size = new Size(139, 25);
            lblChamCong.TabIndex = 0;
            lblChamCong.Text = "Chấm công";
            lblChamCong.Click += lblChamCong_Click;
            // 
            // pnlHopDong
            // 
            pnlHopDong.Controls.Add(icoHopDong);
            pnlHopDong.Controls.Add(lblHopDong);
            pnlHopDong.Location = new Point(12, 115);
            pnlHopDong.Name = "pnlHopDong";
            pnlHopDong.Size = new Size(190, 35);
            pnlHopDong.TabIndex = 6;
            // 
            // icoHopDong
            // 
            icoHopDong.Image = Properties.Resources.Screenshot_2026_03_16_125040;
            icoHopDong.Location = new Point(10, 5);
            icoHopDong.Name = "icoHopDong";
            icoHopDong.Size = new Size(25, 25);
            icoHopDong.SizeMode = PictureBoxSizeMode.StretchImage;
            icoHopDong.TabIndex = 1;
            icoHopDong.TabStop = false;
            // 
            // lblHopDong
            // 
            lblHopDong.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHopDong.Location = new Point(48, 5);
            lblHopDong.Name = "lblHopDong";
            lblHopDong.Size = new Size(139, 25);
            lblHopDong.TabIndex = 0;
            lblHopDong.Text = "Hợp đồng";
            lblHopDong.Click += lblHopDong_Click;
            // 
            // pnlChucNang
            // 
            pnlChucNang.Controls.Add(icoToChuc);
            pnlChucNang.Controls.Add(lblToChuc);
            pnlChucNang.Location = new Point(12, 74);
            pnlChucNang.Name = "pnlChucNang";
            pnlChucNang.Size = new Size(190, 35);
            pnlChucNang.TabIndex = 5;
            // 
            // icoToChuc
            // 
            icoToChuc.Image = Properties.Resources.Screenshot_2026_03_16_132024;
            icoToChuc.Location = new Point(10, 5);
            icoToChuc.Name = "icoToChuc";
            icoToChuc.Size = new Size(25, 25);
            icoToChuc.SizeMode = PictureBoxSizeMode.StretchImage;
            icoToChuc.TabIndex = 1;
            icoToChuc.TabStop = false;
            // 
            // lblToChuc
            // 
            lblToChuc.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToChuc.Location = new Point(48, 5);
            lblToChuc.Name = "lblToChuc";
            lblToChuc.Size = new Size(139, 25);
            lblToChuc.TabIndex = 0;
            lblToChuc.Text = "Tổ chức";
            lblToChuc.Click += lblToChuc_Click;
            // 
            // pnlNhanSu
            // 
            pnlNhanSu.Controls.Add(icoNhanSu);
            pnlNhanSu.Controls.Add(lblNhanSu);
            pnlNhanSu.Location = new Point(12, 33);
            pnlNhanSu.Name = "pnlNhanSu";
            pnlNhanSu.Size = new Size(190, 35);
            pnlNhanSu.TabIndex = 4;
            // 
            // icoNhanSu
            // 
            icoNhanSu.Image = Properties.Resources.Screenshot_2026_03_16_131943;
            icoNhanSu.Location = new Point(10, 5);
            icoNhanSu.Name = "icoNhanSu";
            icoNhanSu.Size = new Size(25, 25);
            icoNhanSu.SizeMode = PictureBoxSizeMode.StretchImage;
            icoNhanSu.TabIndex = 1;
            icoNhanSu.TabStop = false;
            // 
            // lblNhanSu
            // 
            lblNhanSu.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhanSu.Location = new Point(48, 5);
            lblNhanSu.Name = "lblNhanSu";
            lblNhanSu.Size = new Size(139, 25);
            lblNhanSu.TabIndex = 0;
            lblNhanSu.Text = "Nhân sự";
            lblNhanSu.Click += lblNhanSu_Click;
            // 
            // grbMainMenu
            // 
            grbMainMenu.Controls.Add(pnlHoSoCaNhan);
            grbMainMenu.Controls.Add(pnlDashboard);
            grbMainMenu.Font = new Font("Inter", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbMainMenu.Location = new Point(18, 96);
            grbMainMenu.Name = "grbMainMenu";
            grbMainMenu.Size = new Size(208, 123);
            grbMainMenu.TabIndex = 12;
            grbMainMenu.TabStop = false;
            grbMainMenu.Text = "Tổng quan";
            // 
            // pnlHoSoCaNhan
            // 
            pnlHoSoCaNhan.Controls.Add(icoHoSoCaNhan);
            pnlHoSoCaNhan.Controls.Add(lblHoSoCaNhan);
            pnlHoSoCaNhan.Location = new Point(12, 74);
            pnlHoSoCaNhan.Name = "pnlHoSoCaNhan";
            pnlHoSoCaNhan.Size = new Size(190, 35);
            pnlHoSoCaNhan.TabIndex = 5;
            // 
            // icoHoSoCaNhan
            // 
            icoHoSoCaNhan.Image = Properties.Resources.Screenshot_2026_03_16_125129;
            icoHoSoCaNhan.Location = new Point(10, 5);
            icoHoSoCaNhan.Name = "icoHoSoCaNhan";
            icoHoSoCaNhan.Size = new Size(25, 25);
            icoHoSoCaNhan.SizeMode = PictureBoxSizeMode.StretchImage;
            icoHoSoCaNhan.TabIndex = 1;
            icoHoSoCaNhan.TabStop = false;
            // 
            // lblHoSoCaNhan
            // 
            lblHoSoCaNhan.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoSoCaNhan.Location = new Point(48, 5);
            lblHoSoCaNhan.Name = "lblHoSoCaNhan";
            lblHoSoCaNhan.Size = new Size(139, 25);
            lblHoSoCaNhan.TabIndex = 0;
            lblHoSoCaNhan.Text = "Hồ sơ cá nhân";
            lblHoSoCaNhan.Click += lblHoSoCaNhan_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(icoDashBoard);
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new Point(12, 33);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(190, 35);
            pnlDashboard.TabIndex = 4;
            // 
            // icoDashBoard
            // 
            icoDashBoard.Image = Properties.Resources.Screenshot_2026_03_16_130224;
            icoDashBoard.Location = new Point(10, 5);
            icoDashBoard.Name = "icoDashBoard";
            icoDashBoard.Size = new Size(25, 25);
            icoDashBoard.SizeMode = PictureBoxSizeMode.StretchImage;
            icoDashBoard.TabIndex = 1;
            icoDashBoard.TabStop = false;
            // 
            // lblDashboard
            // 
            lblDashboard.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(48, 5);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(139, 25);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Dashboard";
            lblDashboard.Click += lblDashboard_Click;
            // 
            // pnlLogout
            // 
            pnlLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlLogout.BackColor = Color.FromArgb(173, 220, 255);
            pnlLogout.BorderRadius = 20;
            pnlLogout.Controls.Add(picIconLogout);
            pnlLogout.Controls.Add(lblLogout);
            pnlLogout.Location = new Point(271, 727);
            pnlLogout.Name = "pnlLogout";
            pnlLogout.Size = new Size(90, 30);
            pnlLogout.TabIndex = 11;
            pnlLogout.Visible = false;
            // 
            // picIconLogout
            // 
            picIconLogout.Image = Properties.Resources.picIconLogout;
            picIconLogout.Location = new Point(9, 7);
            picIconLogout.Name = "picIconLogout";
            picIconLogout.Size = new Size(25, 18);
            picIconLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            picIconLogout.TabIndex = 11;
            picIconLogout.TabStop = false;
            // 
            // lblLogout
            // 
            lblLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblLogout.AutoSize = true;
            lblLogout.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogout.Location = new Point(40, 6);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(43, 18);
            lblLogout.TabIndex = 10;
            lblLogout.Text = "Thoát";
            lblLogout.TextAlign = ContentAlignment.MiddleLeft;
            lblLogout.Click += lblLogout_Click;
            // 
            // pnl_HoSoCaNhan
            // 
            pnl_HoSoCaNhan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_HoSoCaNhan.BackColor = Color.White;
            pnl_HoSoCaNhan.BorderRadius = 20;
            pnl_HoSoCaNhan.Controls.Add(lbPhongban);
            pnl_HoSoCaNhan.Controls.Add(label50);
            pnl_HoSoCaNhan.Controls.Add(lbNgayKetThuc);
            pnl_HoSoCaNhan.Controls.Add(label36);
            pnl_HoSoCaNhan.Controls.Add(lbNgayBatDauHD);
            pnl_HoSoCaNhan.Controls.Add(label37);
            pnl_HoSoCaNhan.Controls.Add(lbLoaiHD);
            pnl_HoSoCaNhan.Controls.Add(label35);
            pnl_HoSoCaNhan.Controls.Add(lbMaHD);
            pnl_HoSoCaNhan.Controls.Add(label34);
            pnl_HoSoCaNhan.Controls.Add(label31);
            pnl_HoSoCaNhan.Controls.Add(label32);
            pnl_HoSoCaNhan.Controls.Add(label30);
            pnl_HoSoCaNhan.Controls.Add(lbChucVu);
            pnl_HoSoCaNhan.Controls.Add(lbLoaiNhanVien);
            pnl_HoSoCaNhan.Controls.Add(lbNgaySinh);
            pnl_HoSoCaNhan.Controls.Add(lbGioiTinh);
            pnl_HoSoCaNhan.Controls.Add(lbHoTen);
            pnl_HoSoCaNhan.Controls.Add(lbMaNV);
            pnl_HoSoCaNhan.Controls.Add(roundedPanel10);
            pnl_HoSoCaNhan.Controls.Add(label28);
            pnl_HoSoCaNhan.Controls.Add(label19);
            pnl_HoSoCaNhan.Controls.Add(label20);
            pnl_HoSoCaNhan.Controls.Add(label21);
            pnl_HoSoCaNhan.Controls.Add(label22);
            pnl_HoSoCaNhan.Controls.Add(label24);
            pnl_HoSoCaNhan.Controls.Add(label26);
            pnl_HoSoCaNhan.Controls.Add(pnl_TopHoSo);
            pnl_HoSoCaNhan.Controls.Add(roundedPanel4);
            pnl_HoSoCaNhan.Location = new Point(289, 137);
            pnl_HoSoCaNhan.Name = "pnl_HoSoCaNhan";
            pnl_HoSoCaNhan.Size = new Size(1054, 640);
            pnl_HoSoCaNhan.TabIndex = 8;
            pnl_HoSoCaNhan.Visible = false;
            // 
            // lbPhongban
            // 
            lbPhongban.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPhongban.Location = new Point(457, 339);
            lbPhongban.Name = "lbPhongban";
            lbPhongban.Size = new Size(213, 30);
            lbPhongban.TabIndex = 54;
            lbPhongban.Text = "m";
            lbPhongban.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label50
            // 
            label50.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label50.Location = new Point(315, 339);
            label50.Name = "label50";
            label50.Size = new Size(138, 30);
            label50.TabIndex = 53;
            label50.Text = "Phòng ban:";
            label50.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbNgayKetThuc
            // 
            lbNgayKetThuc.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNgayKetThuc.Location = new Point(455, 523);
            lbNgayKetThuc.Name = "lbNgayKetThuc";
            lbNgayKetThuc.Size = new Size(213, 30);
            lbNgayKetThuc.TabIndex = 52;
            lbNgayKetThuc.Text = "m";
            lbNgayKetThuc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label36
            // 
            label36.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.Location = new Point(311, 523);
            label36.Name = "label36";
            label36.Size = new Size(138, 30);
            label36.TabIndex = 51;
            label36.Text = "Ngày kết thúc:";
            label36.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbNgayBatDauHD
            // 
            lbNgayBatDauHD.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNgayBatDauHD.Location = new Point(455, 493);
            lbNgayBatDauHD.Name = "lbNgayBatDauHD";
            lbNgayBatDauHD.Size = new Size(213, 30);
            lbNgayBatDauHD.TabIndex = 50;
            lbNgayBatDauHD.Text = "m";
            lbNgayBatDauHD.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label37
            // 
            label37.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label37.Location = new Point(311, 493);
            label37.Name = "label37";
            label37.Size = new Size(138, 30);
            label37.TabIndex = 49;
            label37.Text = "Ngày Bắt Đầu:";
            label37.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbLoaiHD
            // 
            lbLoaiHD.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLoaiHD.Location = new Point(455, 463);
            lbLoaiHD.Name = "lbLoaiHD";
            lbLoaiHD.Size = new Size(213, 30);
            lbLoaiHD.TabIndex = 48;
            lbLoaiHD.Text = "m";
            lbLoaiHD.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label35
            // 
            label35.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label35.Location = new Point(311, 463);
            label35.Name = "label35";
            label35.Size = new Size(138, 30);
            label35.TabIndex = 47;
            label35.Text = "Loại Hợp Đồng:";
            label35.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbMaHD
            // 
            lbMaHD.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMaHD.Location = new Point(455, 429);
            lbMaHD.Name = "lbMaHD";
            lbMaHD.Size = new Size(213, 30);
            lbMaHD.TabIndex = 46;
            lbMaHD.Text = "m";
            lbMaHD.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label34
            // 
            label34.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label34.Location = new Point(311, 429);
            label34.Name = "label34";
            label34.Size = new Size(138, 30);
            label34.TabIndex = 45;
            label34.Text = "Mã Hợp Đồng:";
            label34.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label31
            // 
            label31.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(457, 309);
            label31.Name = "label31";
            label31.Size = new Size(213, 30);
            label31.TabIndex = 44;
            label31.Text = "Tốt";
            label31.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label32
            // 
            label32.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(315, 309);
            label32.Name = "label32";
            label32.Size = new Size(138, 30);
            label32.TabIndex = 43;
            label32.Text = "Sức khỏe:";
            label32.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label30
            // 
            label30.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.Location = new Point(311, 378);
            label30.Name = "label30";
            label30.Size = new Size(333, 30);
            label30.TabIndex = 42;
            label30.Text = "Thông tin hợp đồng";
            label30.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbChucVu
            // 
            lbChucVu.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbChucVu.Location = new Point(457, 246);
            lbChucVu.Name = "lbChucVu";
            lbChucVu.Size = new Size(213, 30);
            lbChucVu.TabIndex = 41;
            lbChucVu.Text = "m";
            lbChucVu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbLoaiNhanVien
            // 
            lbLoaiNhanVien.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLoaiNhanVien.Location = new Point(457, 276);
            lbLoaiNhanVien.Name = "lbLoaiNhanVien";
            lbLoaiNhanVien.Size = new Size(364, 30);
            lbLoaiNhanVien.TabIndex = 40;
            lbLoaiNhanVien.Text = "m";
            lbLoaiNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbNgaySinh
            // 
            lbNgaySinh.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNgaySinh.Location = new Point(457, 217);
            lbNgaySinh.Name = "lbNgaySinh";
            lbNgaySinh.Size = new Size(213, 30);
            lbNgaySinh.TabIndex = 39;
            lbNgaySinh.Text = "m";
            lbNgaySinh.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbGioiTinh
            // 
            lbGioiTinh.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGioiTinh.Location = new Point(457, 189);
            lbGioiTinh.Name = "lbGioiTinh";
            lbGioiTinh.Size = new Size(213, 30);
            lbGioiTinh.TabIndex = 38;
            lbGioiTinh.Text = "m";
            lbGioiTinh.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbHoTen
            // 
            lbHoTen.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHoTen.Location = new Point(457, 159);
            lbHoTen.Name = "lbHoTen";
            lbHoTen.Size = new Size(213, 30);
            lbHoTen.TabIndex = 37;
            lbHoTen.Text = "m";
            lbHoTen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbMaNV
            // 
            lbMaNV.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMaNV.Location = new Point(457, 129);
            lbMaNV.Name = "lbMaNV";
            lbMaNV.Size = new Size(213, 30);
            lbMaNV.TabIndex = 36;
            lbMaNV.Text = "m";
            lbMaNV.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roundedPanel10
            // 
            roundedPanel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            roundedPanel10.BackColor = Color.FromArgb(173, 220, 255);
            roundedPanel10.BorderRadius = 20;
            roundedPanel10.Controls.Add(lbSDT);
            roundedPanel10.Controls.Add(lbEmail);
            roundedPanel10.Controls.Add(circlePictureBox2);
            roundedPanel10.Controls.Add(label25);
            roundedPanel10.Controls.Add(label27);
            roundedPanel10.Controls.Add(label23);
            roundedPanel10.Location = new Point(25, 74);
            roundedPanel10.Name = "roundedPanel10";
            roundedPanel10.Size = new Size(255, 533);
            roundedPanel10.TabIndex = 35;
            // 
            // lbSDT
            // 
            lbSDT.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSDT.Location = new Point(19, 364);
            lbSDT.Name = "lbSDT";
            lbSDT.Size = new Size(233, 30);
            lbSDT.TabIndex = 43;
            lbSDT.Text = "m";
            lbSDT.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbEmail
            // 
            lbEmail.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(19, 304);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(233, 30);
            lbEmail.TabIndex = 42;
            lbEmail.Text = "m";
            lbEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // circlePictureBox2
            // 
            circlePictureBox2.Image = Properties.Resources.picAva;
            circlePictureBox2.Location = new Point(19, 22);
            circlePictureBox2.Name = "circlePictureBox2";
            circlePictureBox2.Size = new Size(210, 210);
            circlePictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            circlePictureBox2.TabIndex = 8;
            circlePictureBox2.TabStop = false;
            // 
            // label25
            // 
            label25.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(19, 274);
            label25.Name = "label25";
            label25.Size = new Size(120, 30);
            label25.TabIndex = 27;
            label25.Text = "Email:";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            label27.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.Location = new Point(19, 241);
            label27.Name = "label27";
            label27.Size = new Size(210, 30);
            label27.TabIndex = 33;
            label27.Text = "Thông tin liên hệ";
            label27.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(19, 334);
            label23.Name = "label23";
            label23.Size = new Size(120, 30);
            label23.TabIndex = 28;
            label23.Text = "Số điện thoại:";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label28
            // 
            label28.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.Location = new Point(313, 74);
            label28.Name = "label28";
            label28.Size = new Size(344, 30);
            label28.TabIndex = 34;
            label28.Text = "Thông tin chung";
            label28.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(315, 249);
            label19.Name = "label19";
            label19.Size = new Size(138, 30);
            label19.TabIndex = 32;
            label19.Text = "Chức vụ:";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(313, 219);
            label20.Name = "label20";
            label20.Size = new Size(138, 30);
            label20.TabIndex = 31;
            label20.Text = "Ngày Sinh:";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            label21.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(315, 279);
            label21.Name = "label21";
            label21.Size = new Size(138, 30);
            label21.TabIndex = 30;
            label21.Text = "Loại nhân viên:";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            label22.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(313, 189);
            label22.Name = "label22";
            label22.Size = new Size(138, 30);
            label22.TabIndex = 29;
            label22.Text = "Giới Tính:";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            label24.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(313, 129);
            label24.Name = "label24";
            label24.Size = new Size(138, 30);
            label24.TabIndex = 25;
            label24.Text = "Mã Nhân Viên:";
            label24.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            label26.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(313, 159);
            label26.Name = "label26";
            label26.Size = new Size(138, 30);
            label26.TabIndex = 26;
            label26.Text = "Họ và tên:";
            label26.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnl_TopHoSo
            // 
            pnl_TopHoSo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnl_TopHoSo.BackColor = Color.FromArgb(217, 229, 255);
            pnl_TopHoSo.BorderRadius = 20;
            pnl_TopHoSo.Controls.Add(lbl_TitleHoSo);
            pnl_TopHoSo.Location = new Point(0, 0);
            pnl_TopHoSo.Name = "pnl_TopHoSo";
            pnl_TopHoSo.Size = new Size(1908, 41);
            pnl_TopHoSo.TabIndex = 7;
            // 
            // lbl_TitleHoSo
            // 
            lbl_TitleHoSo.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_TitleHoSo.Location = new Point(25, 9);
            lbl_TitleHoSo.Name = "lbl_TitleHoSo";
            lbl_TitleHoSo.Size = new Size(166, 25);
            lbl_TitleHoSo.TabIndex = 2;
            lbl_TitleHoSo.Text = "Hồ Sơ Cá Nhân";
            // 
            // roundedPanel4
            // 
            roundedPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedPanel4.BackColor = Color.FromArgb(156, 193, 250);
            roundedPanel4.BorderRadius = 20;
            roundedPanel4.Controls.Add(pictureBox1);
            roundedPanel4.Controls.Add(label2);
            roundedPanel4.Location = new Point(2557, 15);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(179, 62);
            roundedPanel4.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 17);
            label2.Name = "label2";
            label2.Size = new Size(112, 30);
            label2.TabIndex = 0;
            label2.Text = "Lịch Trình";
            // 
            // pnlSideBar_Employee
            // 
            pnlSideBar_Employee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlSideBar_Employee.BackColor = Color.White;
            pnlSideBar_Employee.BorderRadius = 20;
            pnlSideBar_Employee.Controls.Add(pnlHoTro2);
            pnlSideBar_Employee.Controls.Add(pnlCaiDat2);
            pnlSideBar_Employee.Controls.Add(pnlBottomSideBar_Employee);
            pnlSideBar_Employee.Controls.Add(lblSystemName2);
            pnlSideBar_Employee.Controls.Add(roundedPanel3);
            pnlSideBar_Employee.Controls.Add(panel1);
            pnlSideBar_Employee.Controls.Add(panel2);
            pnlSideBar_Employee.Controls.Add(grbChucNang_Employee);
            pnlSideBar_Employee.Location = new Point(26, 41);
            pnlSideBar_Employee.Name = "pnlSideBar_Employee";
            pnlSideBar_Employee.Size = new Size(240, 736);
            pnlSideBar_Employee.TabIndex = 15;
            // 
            // pnlHoTro2
            // 
            pnlHoTro2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlHoTro2.Controls.Add(icoHoTro2);
            pnlHoTro2.Controls.Add(lblHoTro2);
            pnlHoTro2.Location = new Point(19, 590);
            pnlHoTro2.Name = "pnlHoTro2";
            pnlHoTro2.Size = new Size(190, 35);
            pnlHoTro2.TabIndex = 9;
            // 
            // icoHoTro2
            // 
            icoHoTro2.Image = Properties.Resources.Screenshot_2026_03_16_125445;
            icoHoTro2.Location = new Point(10, 5);
            icoHoTro2.Name = "icoHoTro2";
            icoHoTro2.Size = new Size(25, 25);
            icoHoTro2.SizeMode = PictureBoxSizeMode.StretchImage;
            icoHoTro2.TabIndex = 1;
            icoHoTro2.TabStop = false;
            // 
            // lblHoTro2
            // 
            lblHoTro2.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoTro2.Location = new Point(48, 5);
            lblHoTro2.Name = "lblHoTro2";
            lblHoTro2.Size = new Size(139, 25);
            lblHoTro2.TabIndex = 0;
            lblHoTro2.Text = "Hỗ trợ";
            // 
            // pnlCaiDat2
            // 
            pnlCaiDat2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlCaiDat2.Controls.Add(icoCaiDat2);
            pnlCaiDat2.Controls.Add(lblCaiDat2);
            pnlCaiDat2.Location = new Point(19, 631);
            pnlCaiDat2.Name = "pnlCaiDat2";
            pnlCaiDat2.Size = new Size(190, 35);
            pnlCaiDat2.TabIndex = 8;
            // 
            // icoCaiDat2
            // 
            icoCaiDat2.Image = Properties.Resources.Screenshot_2026_03_16_125354;
            icoCaiDat2.Location = new Point(10, 5);
            icoCaiDat2.Name = "icoCaiDat2";
            icoCaiDat2.Size = new Size(25, 25);
            icoCaiDat2.SizeMode = PictureBoxSizeMode.StretchImage;
            icoCaiDat2.TabIndex = 1;
            icoCaiDat2.TabStop = false;
            // 
            // lblCaiDat2
            // 
            lblCaiDat2.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCaiDat2.Location = new Point(48, 5);
            lblCaiDat2.Name = "lblCaiDat2";
            lblCaiDat2.Size = new Size(139, 25);
            lblCaiDat2.TabIndex = 0;
            lblCaiDat2.Text = "Cài đặt";
            // 
            // pnlBottomSideBar_Employee
            // 
            pnlBottomSideBar_Employee.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlBottomSideBar_Employee.BackColor = Color.FromArgb(217, 229, 255);
            pnlBottomSideBar_Employee.BorderRadius = 20;
            pnlBottomSideBar_Employee.Controls.Add(picAva3);
            pnlBottomSideBar_Employee.Controls.Add(lblUserName2);
            pnlBottomSideBar_Employee.Controls.Add(lblUserGmail2);
            pnlBottomSideBar_Employee.Location = new Point(0, 672);
            pnlBottomSideBar_Employee.Name = "pnlBottomSideBar_Employee";
            pnlBottomSideBar_Employee.Size = new Size(240, 64);
            pnlBottomSideBar_Employee.TabIndex = 15;
            // 
            // picAva3
            // 
            picAva3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            picAva3.Image = Properties.Resources.picAva;
            picAva3.Location = new Point(17, 14);
            picAva3.Name = "picAva3";
            picAva3.Size = new Size(36, 36);
            picAva3.SizeMode = PictureBoxSizeMode.Zoom;
            picAva3.TabIndex = 4;
            picAva3.TabStop = false;
            picAva3.Click += picAva3_Click;
            // 
            // lblUserName2
            // 
            lblUserName2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUserName2.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName2.Location = new Point(60, 9);
            lblUserName2.Name = "lblUserName2";
            lblUserName2.Size = new Size(144, 27);
            lblUserName2.TabIndex = 6;
            lblUserName2.Text = "emp";
            lblUserName2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUserGmail2
            // 
            lblUserGmail2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUserGmail2.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserGmail2.ForeColor = SystemColors.ControlDarkDark;
            lblUserGmail2.Location = new Point(60, 34);
            lblUserGmail2.Name = "lblUserGmail2";
            lblUserGmail2.Size = new Size(144, 24);
            lblUserGmail2.TabIndex = 7;
            lblUserGmail2.Text = "emp";
            // 
            // lblSystemName2
            // 
            lblSystemName2.Font = new Font("Inter ExtraBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSystemName2.Location = new Point(1, 3);
            lblSystemName2.Name = "lblSystemName2";
            lblSystemName2.Size = new Size(238, 90);
            lblSystemName2.TabIndex = 1;
            lblSystemName2.Text = "HyperionHR";
            lblSystemName2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedPanel3
            // 
            roundedPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            roundedPanel3.BackColor = Color.FromArgb(217, 229, 255);
            roundedPanel3.BorderRadius = 20;
            roundedPanel3.Controls.Add(roundedPanel5);
            roundedPanel3.Controls.Add(circlePictureBox1);
            roundedPanel3.Controls.Add(label3);
            roundedPanel3.Controls.Add(label4);
            roundedPanel3.Location = new Point(0, 1308);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(240, 64);
            roundedPanel3.TabIndex = 14;
            // 
            // roundedPanel5
            // 
            roundedPanel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            roundedPanel5.BackColor = Color.FromArgb(173, 220, 255);
            roundedPanel5.BorderRadius = 20;
            roundedPanel5.Controls.Add(pictureBox2);
            roundedPanel5.Controls.Add(label1);
            roundedPanel5.Location = new Point(139, -24);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(90, 30);
            roundedPanel5.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.picIconLogout;
            pictureBox2.Location = new Point(9, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 18);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, -64);
            label1.Name = "label1";
            label1.Size = new Size(43, 18);
            label1.TabIndex = 10;
            label1.Text = "Thoát";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // circlePictureBox1
            // 
            circlePictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            circlePictureBox1.Image = Properties.Resources.picAva;
            circlePictureBox1.Location = new Point(17, -27);
            circlePictureBox1.Name = "circlePictureBox1";
            circlePictureBox1.Size = new Size(36, 36);
            circlePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            circlePictureBox1.TabIndex = 4;
            circlePictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, -32);
            label3.Name = "label3";
            label3.Size = new Size(144, 27);
            label3.TabIndex = 6;
            label3.Text = "admin";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(60, -7);
            label4.Name = "label4";
            label4.Size = new Size(144, 24);
            label4.TabIndex = 7;
            label4.Text = "admin";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(30, 1226);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 35);
            panel1.TabIndex = 7;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Screenshot_2026_03_16_125445;
            pictureBox4.Location = new Point(10, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(48, 5);
            label6.Name = "label6";
            label6.Size = new Size(139, 25);
            label6.TabIndex = 0;
            label6.Text = "Hỗ trợ";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(30, 1267);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 35);
            panel2.TabIndex = 6;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Screenshot_2026_03_16_125354;
            pictureBox5.Location = new Point(10, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // label7
            // 
            label7.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(48, 5);
            label7.Name = "label7";
            label7.Size = new Size(139, 25);
            label7.TabIndex = 0;
            label7.Text = "Cài đặt";
            // 
            // grbChucNang_Employee
            // 
            grbChucNang_Employee.Controls.Add(pnlHoSoCaNhan_Employee);
            grbChucNang_Employee.Controls.Add(pnlDonXin_Employee);
            grbChucNang_Employee.Controls.Add(pnlLuong_Employee);
            grbChucNang_Employee.Controls.Add(pnlChamCong_Employee);
            grbChucNang_Employee.Font = new Font("Inter", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbChucNang_Employee.Location = new Point(18, 96);
            grbChucNang_Employee.Name = "grbChucNang_Employee";
            grbChucNang_Employee.Size = new Size(208, 213);
            grbChucNang_Employee.TabIndex = 13;
            grbChucNang_Employee.TabStop = false;
            grbChucNang_Employee.Text = "Chức năng";
            // 
            // pnlHoSoCaNhan_Employee
            // 
            pnlHoSoCaNhan_Employee.Controls.Add(icoHoSoCaNhan2);
            pnlHoSoCaNhan_Employee.Controls.Add(lblHoSoCaNhan_Employee);
            pnlHoSoCaNhan_Employee.Location = new Point(12, 41);
            pnlHoSoCaNhan_Employee.Name = "pnlHoSoCaNhan_Employee";
            pnlHoSoCaNhan_Employee.Size = new Size(190, 35);
            pnlHoSoCaNhan_Employee.TabIndex = 5;
            // 
            // icoHoSoCaNhan2
            // 
            icoHoSoCaNhan2.Image = Properties.Resources.Screenshot_2026_03_16_125129;
            icoHoSoCaNhan2.Location = new Point(10, 5);
            icoHoSoCaNhan2.Name = "icoHoSoCaNhan2";
            icoHoSoCaNhan2.Size = new Size(25, 25);
            icoHoSoCaNhan2.SizeMode = PictureBoxSizeMode.StretchImage;
            icoHoSoCaNhan2.TabIndex = 1;
            icoHoSoCaNhan2.TabStop = false;
            // 
            // lblHoSoCaNhan_Employee
            // 
            lblHoSoCaNhan_Employee.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoSoCaNhan_Employee.Location = new Point(48, 5);
            lblHoSoCaNhan_Employee.Name = "lblHoSoCaNhan_Employee";
            lblHoSoCaNhan_Employee.Size = new Size(139, 25);
            lblHoSoCaNhan_Employee.TabIndex = 0;
            lblHoSoCaNhan_Employee.Text = "Hồ sơ cá nhân";
            lblHoSoCaNhan_Employee.Click += lblHoSoCaNhan_Employee_Click;
            // 
            // pnlDonXin_Employee
            // 
            pnlDonXin_Employee.Controls.Add(icoDonXin);
            pnlDonXin_Employee.Controls.Add(lblDonXin_Employee);
            pnlDonXin_Employee.Location = new Point(12, 82);
            pnlDonXin_Employee.Name = "pnlDonXin_Employee";
            pnlDonXin_Employee.Size = new Size(190, 35);
            pnlDonXin_Employee.TabIndex = 7;
            // 
            // icoDonXin
            // 
            icoDonXin.Image = Properties.Resources.Screenshot_2026_03_16_132124;
            icoDonXin.Location = new Point(10, 5);
            icoDonXin.Name = "icoDonXin";
            icoDonXin.Size = new Size(25, 25);
            icoDonXin.SizeMode = PictureBoxSizeMode.StretchImage;
            icoDonXin.TabIndex = 1;
            icoDonXin.TabStop = false;
            // 
            // lblDonXin_Employee
            // 
            lblDonXin_Employee.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDonXin_Employee.Location = new Point(48, 5);
            lblDonXin_Employee.Name = "lblDonXin_Employee";
            lblDonXin_Employee.Size = new Size(139, 25);
            lblDonXin_Employee.TabIndex = 0;
            lblDonXin_Employee.Text = "Đơn xin";
            lblDonXin_Employee.Click += lblDonXin_Employee_Click;
            // 
            // pnlLuong_Employee
            // 
            pnlLuong_Employee.Controls.Add(icoLuong2);
            pnlLuong_Employee.Controls.Add(lblLuong_Employee);
            pnlLuong_Employee.Location = new Point(12, 165);
            pnlLuong_Employee.Name = "pnlLuong_Employee";
            pnlLuong_Employee.Size = new Size(190, 35);
            pnlLuong_Employee.TabIndex = 9;
            // 
            // icoLuong2
            // 
            icoLuong2.Image = Properties.Resources.Screenshot_2026_03_16_132348;
            icoLuong2.Location = new Point(10, 5);
            icoLuong2.Name = "icoLuong2";
            icoLuong2.Size = new Size(25, 25);
            icoLuong2.SizeMode = PictureBoxSizeMode.StretchImage;
            icoLuong2.TabIndex = 1;
            icoLuong2.TabStop = false;
            // 
            // lblLuong_Employee
            // 
            lblLuong_Employee.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLuong_Employee.Location = new Point(48, 5);
            lblLuong_Employee.Name = "lblLuong_Employee";
            lblLuong_Employee.Size = new Size(139, 25);
            lblLuong_Employee.TabIndex = 0;
            lblLuong_Employee.Text = "Lương";
            lblLuong_Employee.Click += lblLuong_Employee_Click;
            // 
            // pnlChamCong_Employee
            // 
            pnlChamCong_Employee.Controls.Add(icoChamCong_2);
            pnlChamCong_Employee.Controls.Add(lblChamCong_Employee);
            pnlChamCong_Employee.Location = new Point(12, 123);
            pnlChamCong_Employee.Name = "pnlChamCong_Employee";
            pnlChamCong_Employee.Size = new Size(190, 35);
            pnlChamCong_Employee.TabIndex = 7;
            // 
            // icoChamCong_2
            // 
            icoChamCong_2.Image = Properties.Resources.Screenshot_2026_03_16_132203;
            icoChamCong_2.Location = new Point(10, 5);
            icoChamCong_2.Name = "icoChamCong_2";
            icoChamCong_2.Size = new Size(25, 25);
            icoChamCong_2.SizeMode = PictureBoxSizeMode.StretchImage;
            icoChamCong_2.TabIndex = 1;
            icoChamCong_2.TabStop = false;
            // 
            // lblChamCong_Employee
            // 
            lblChamCong_Employee.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChamCong_Employee.Location = new Point(48, 5);
            lblChamCong_Employee.Name = "lblChamCong_Employee";
            lblChamCong_Employee.Size = new Size(139, 25);
            lblChamCong_Employee.TabIndex = 0;
            lblChamCong_Employee.Text = "Chấm công";
            lblChamCong_Employee.Click += lblChamCong_Employee_Click;
            // 
            // pnl_QuanLyNhanSu
            // 
            pnl_QuanLyNhanSu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_QuanLyNhanSu.BackColor = Color.White;
            pnl_QuanLyNhanSu.BorderRadius = 20;
            pnl_QuanLyNhanSu.Controls.Add(pnlDienThongTin);
            pnl_QuanLyNhanSu.Controls.Add(btnXoa);
            pnl_QuanLyNhanSu.Controls.Add(btnThemNV);
            pnl_QuanLyNhanSu.Controls.Add(pnlBoxTimKiem);
            pnl_QuanLyNhanSu.Controls.Add(btnLamMoi);
            pnl_QuanLyNhanSu.Controls.Add(pnl_TopQLNhanSu);
            pnl_QuanLyNhanSu.Controls.Add(roundedPanel7);
            pnl_QuanLyNhanSu.Controls.Add(lblTimKiem);
            pnl_QuanLyNhanSu.Controls.Add(pnl_DGVEmployee);
            pnl_QuanLyNhanSu.Location = new Point(289, 137);
            pnl_QuanLyNhanSu.Name = "pnl_QuanLyNhanSu";
            pnl_QuanLyNhanSu.Size = new Size(1054, 640);
            pnl_QuanLyNhanSu.TabIndex = 9;
            // 
            // pnlDienThongTin
            // 
            pnlDienThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlDienThongTin.BackColor = Color.White;
            pnlDienThongTin.BorderRadius = 20;
            pnlDienThongTin.Controls.Add(chkTaoHopDong);
            pnlDienThongTin.Controls.Add(label38);
            pnlDienThongTin.Controls.Add(cbbChucVu);
            pnlDienThongTin.Controls.Add(label16);
            pnlDienThongTin.Controls.Add(btnTatBangThongTin);
            pnlDienThongTin.Controls.Add(btnLamMoiInput);
            pnlDienThongTin.Controls.Add(btnThem);
            pnlDienThongTin.Controls.Add(lblNgaySinh);
            pnlDienThongTin.Controls.Add(dtpNgaySinh);
            pnlDienThongTin.Controls.Add(cbbLoaiNV);
            pnlDienThongTin.Controls.Add(cbbGioiTinh);
            pnlDienThongTin.Controls.Add(lblLoaiNhanVien);
            pnlDienThongTin.Controls.Add(lblGioiTInh);
            pnlDienThongTin.Controls.Add(lblBangDieuChinh);
            pnlDienThongTin.Controls.Add(lblDienSDT);
            pnlDienThongTin.Controls.Add(txtMaNV);
            pnlDienThongTin.Controls.Add(txtSoDienThoai);
            pnlDienThongTin.Controls.Add(lblDienMaNV);
            pnlDienThongTin.Controls.Add(lblDienEmail);
            pnlDienThongTin.Controls.Add(txtHoTen);
            pnlDienThongTin.Controls.Add(txtEmail);
            pnlDienThongTin.Controls.Add(lblDienHoTen);
            pnlDienThongTin.Controls.Add(btnSua);
            pnlDienThongTin.Location = new Point(442, 147);
            pnlDienThongTin.Name = "pnlDienThongTin";
            pnlDienThongTin.Size = new Size(463, 465);
            pnlDienThongTin.TabIndex = 1;
            pnlDienThongTin.Visible = false;
            // 
            // chkTaoHopDong
            // 
            chkTaoHopDong.AutoSize = true;
            chkTaoHopDong.Checked = true;
            chkTaoHopDong.CheckState = CheckState.Checked;
            chkTaoHopDong.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkTaoHopDong.Location = new Point(208, 364);
            chkTaoHopDong.Name = "chkTaoHopDong";
            chkTaoHopDong.Size = new Size(224, 27);
            chkTaoHopDong.TabIndex = 27;
            chkTaoHopDong.Text = "Tạo kèm Hợp đồng 1 năm";
            chkTaoHopDong.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            label38.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label38.Location = new Point(17, 364);
            label38.Name = "label38";
            label38.Size = new Size(176, 30);
            label38.TabIndex = 26;
            label38.Text = "Tạo hợp đồng:";
            label38.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbbChucVu
            // 
            cbbChucVu.BackColor = Color.FromArgb(216, 228, 245);
            cbbChucVu.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbbChucVu.FormattingEnabled = true;
            cbbChucVu.Items.AddRange(new object[] { "FullTime", "PartTime" });
            cbbChucVu.Location = new Point(208, 323);
            cbbChucVu.Name = "cbbChucVu";
            cbbChucVu.Size = new Size(232, 31);
            cbbChucVu.TabIndex = 25;
            // 
            // label16
            // 
            label16.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(17, 324);
            label16.Name = "label16";
            label16.Size = new Size(176, 30);
            label16.TabIndex = 24;
            label16.Text = "Chức vụ:";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnTatBangThongTin
            // 
            btnTatBangThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTatBangThongTin.BackColor = Color.Transparent;
            btnTatBangThongTin.FlatAppearance.BorderSize = 0;
            btnTatBangThongTin.FlatStyle = FlatStyle.Flat;
            btnTatBangThongTin.Font = new Font("Inter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTatBangThongTin.Location = new Point(420, 4);
            btnTatBangThongTin.Name = "btnTatBangThongTin";
            btnTatBangThongTin.Size = new Size(40, 25);
            btnTatBangThongTin.TabIndex = 4;
            btnTatBangThongTin.Text = "x";
            btnTatBangThongTin.TextAlign = ContentAlignment.TopCenter;
            btnTatBangThongTin.UseVisualStyleBackColor = false;
            btnTatBangThongTin.Click += btnTatBangThongTin_Click;
            // 
            // btnLamMoiInput
            // 
            btnLamMoiInput.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoiInput.BackColor = Color.FromArgb(155, 193, 255);
            btnLamMoiInput.FlatStyle = FlatStyle.Flat;
            btnLamMoiInput.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoiInput.Location = new Point(331, 410);
            btnLamMoiInput.Name = "btnLamMoiInput";
            btnLamMoiInput.Size = new Size(109, 40);
            btnLamMoiInput.TabIndex = 23;
            btnLamMoiInput.Text = "Đặt lại";
            btnLamMoiInput.UseVisualStyleBackColor = false;
            btnLamMoiInput.Click += btnLamMoiInput_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.BackColor = Color.FromArgb(155, 193, 255);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(208, 410);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 40);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNgaySinh.Location = new Point(17, 214);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(176, 30);
            lblNgaySinh.TabIndex = 22;
            lblNgaySinh.Text = "Ngày Sinh:";
            lblNgaySinh.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CalendarFont = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgaySinh.CalendarMonthBackground = Color.White;
            dtpNgaySinh.Font = new Font("Inter", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(208, 214);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(232, 28);
            dtpNgaySinh.TabIndex = 21;
            // 
            // cbbLoaiNV
            // 
            cbbLoaiNV.BackColor = Color.FromArgb(216, 228, 245);
            cbbLoaiNV.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbbLoaiNV.FormattingEnabled = true;
            cbbLoaiNV.Items.AddRange(new object[] { "FullTime", "PartTime" });
            cbbLoaiNV.Location = new Point(208, 286);
            cbbLoaiNV.Name = "cbbLoaiNV";
            cbbLoaiNV.Size = new Size(232, 31);
            cbbLoaiNV.TabIndex = 20;
            // 
            // cbbGioiTinh
            // 
            cbbGioiTinh.BackColor = Color.FromArgb(216, 228, 245);
            cbbGioiTinh.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbbGioiTinh.FormattingEnabled = true;
            cbbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbbGioiTinh.Location = new Point(208, 141);
            cbbGioiTinh.Name = "cbbGioiTinh";
            cbbGioiTinh.Size = new Size(232, 31);
            cbbGioiTinh.TabIndex = 11;
            // 
            // lblLoaiNhanVien
            // 
            lblLoaiNhanVien.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoaiNhanVien.Location = new Point(17, 286);
            lblLoaiNhanVien.Name = "lblLoaiNhanVien";
            lblLoaiNhanVien.Size = new Size(176, 30);
            lblLoaiNhanVien.TabIndex = 19;
            lblLoaiNhanVien.Text = "Loại nhân viên:";
            lblLoaiNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGioiTInh
            // 
            lblGioiTInh.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGioiTInh.Location = new Point(17, 142);
            lblGioiTInh.Name = "lblGioiTInh";
            lblGioiTInh.Size = new Size(176, 30);
            lblGioiTInh.TabIndex = 18;
            lblGioiTInh.Text = "Giới Tính:";
            lblGioiTInh.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBangDieuChinh
            // 
            lblBangDieuChinh.Font = new Font("Inter", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBangDieuChinh.Location = new Point(3, 10);
            lblBangDieuChinh.Name = "lblBangDieuChinh";
            lblBangDieuChinh.Size = new Size(457, 56);
            lblBangDieuChinh.TabIndex = 17;
            lblBangDieuChinh.Text = "Bảng Điều Chỉnh";
            lblBangDieuChinh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDienSDT
            // 
            lblDienSDT.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDienSDT.Location = new Point(17, 178);
            lblDienSDT.Name = "lblDienSDT";
            lblDienSDT.Size = new Size(176, 30);
            lblDienSDT.TabIndex = 16;
            lblDienSDT.Text = "Số điện thoại:";
            lblDienSDT.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMaNV
            // 
            txtMaNV.BackColor = Color.FromArgb(216, 228, 245);
            txtMaNV.BorderStyle = BorderStyle.FixedSingle;
            txtMaNV.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaNV.Location = new Point(208, 69);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(232, 30);
            txtMaNV.TabIndex = 9;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BackColor = Color.FromArgb(216, 228, 245);
            txtSoDienThoai.BorderStyle = BorderStyle.FixedSingle;
            txtSoDienThoai.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoDienThoai.Location = new Point(208, 178);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(232, 30);
            txtSoDienThoai.TabIndex = 15;
            // 
            // lblDienMaNV
            // 
            lblDienMaNV.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDienMaNV.Location = new Point(17, 70);
            lblDienMaNV.Name = "lblDienMaNV";
            lblDienMaNV.Size = new Size(176, 30);
            lblDienMaNV.TabIndex = 10;
            lblDienMaNV.Text = "Mã Nhân Viên:";
            lblDienMaNV.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDienEmail
            // 
            lblDienEmail.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDienEmail.Location = new Point(17, 250);
            lblDienEmail.Name = "lblDienEmail";
            lblDienEmail.Size = new Size(176, 30);
            lblDienEmail.TabIndex = 14;
            lblDienEmail.Text = "Email:";
            lblDienEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = Color.FromArgb(216, 228, 245);
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoTen.Location = new Point(208, 105);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(232, 30);
            txtHoTen.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(216, 228, 245);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(208, 250);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 30);
            txtEmail.TabIndex = 13;
            // 
            // lblDienHoTen
            // 
            lblDienHoTen.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDienHoTen.Location = new Point(17, 105);
            lblDienHoTen.Name = "lblDienHoTen";
            lblDienHoTen.Size = new Size(176, 30);
            lblDienHoTen.TabIndex = 12;
            lblDienHoTen.Text = "Họ và tên:";
            lblDienHoTen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.BackColor = Color.FromArgb(155, 193, 255);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(208, 410);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(109, 40);
            btnSua.TabIndex = 12;
            btnSua.Text = "Cập Nhật";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.BackColor = Color.FromArgb(155, 193, 255);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(919, 220);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(109, 40);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnThemNV
            // 
            btnThemNV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemNV.BackColor = Color.FromArgb(155, 193, 255);
            btnThemNV.FlatStyle = FlatStyle.Flat;
            btnThemNV.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemNV.Location = new Point(919, 162);
            btnThemNV.Name = "btnThemNV";
            btnThemNV.Size = new Size(109, 40);
            btnThemNV.TabIndex = 10;
            btnThemNV.Text = "Thêm";
            btnThemNV.UseVisualStyleBackColor = false;
            btnThemNV.Click += btnThemNV_Click;
            // 
            // pnlBoxTimKiem
            // 
            pnlBoxTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlBoxTimKiem.BackColor = Color.FromArgb(217, 229, 255);
            pnlBoxTimKiem.BorderRadius = 20;
            pnlBoxTimKiem.Controls.Add(btnTimKiem);
            pnlBoxTimKiem.Controls.Add(txtTimKiem);
            pnlBoxTimKiem.Controls.Add(cbbTieuChi);
            pnlBoxTimKiem.Location = new Point(25, 96);
            pnlBoxTimKiem.Name = "pnlBoxTimKiem";
            pnlBoxTimKiem.Size = new Size(880, 45);
            pnlBoxTimKiem.TabIndex = 9;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.Image = Properties.Resources.Screenshot_2026_03_20_174457;
            btnTimKiem.Location = new Point(836, 5);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(35, 35);
            btnTimKiem.SizeMode = PictureBoxSizeMode.StretchImage;
            btnTimKiem.TabIndex = 10;
            btnTimKiem.TabStop = false;
            btnTimKiem.Click += btnTimKiem_Click_1;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.BackColor = Color.FromArgb(216, 228, 245);
            txtTimKiem.BorderStyle = BorderStyle.None;
            txtTimKiem.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(9, 11);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(636, 23);
            txtTimKiem.TabIndex = 3;
            txtTimKiem.Enter += txtTimKiem_Enter;
            txtTimKiem.Leave += txtTimKiem_Leave;
            // 
            // cbbTieuChi
            // 
            cbbTieuChi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbTieuChi.BackColor = Color.FromArgb(216, 228, 245);
            cbbTieuChi.FlatStyle = FlatStyle.Popup;
            cbbTieuChi.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbbTieuChi.FormattingEnabled = true;
            cbbTieuChi.Items.AddRange(new object[] { "Theo Tên", "Theo Phòng Ban" });
            cbbTieuChi.Location = new Point(651, 7);
            cbbTieuChi.Name = "cbbTieuChi";
            cbbTieuChi.Size = new Size(179, 31);
            cbbTieuChi.TabIndex = 5;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoi.BackColor = Color.FromArgb(155, 193, 255);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.Location = new Point(919, 101);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(109, 40);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // pnl_TopQLNhanSu
            // 
            pnl_TopQLNhanSu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnl_TopQLNhanSu.BackColor = Color.FromArgb(217, 229, 255);
            pnl_TopQLNhanSu.BorderRadius = 20;
            pnl_TopQLNhanSu.Controls.Add(lbl_TittleQLNhanSu);
            pnl_TopQLNhanSu.Location = new Point(0, 0);
            pnl_TopQLNhanSu.Name = "pnl_TopQLNhanSu";
            pnl_TopQLNhanSu.Size = new Size(1054, 41);
            pnl_TopQLNhanSu.TabIndex = 7;
            // 
            // lbl_TittleQLNhanSu
            // 
            lbl_TittleQLNhanSu.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_TittleQLNhanSu.Location = new Point(25, 4);
            lbl_TittleQLNhanSu.Name = "lbl_TittleQLNhanSu";
            lbl_TittleQLNhanSu.Size = new Size(280, 34);
            lbl_TittleQLNhanSu.TabIndex = 2;
            lbl_TittleQLNhanSu.Text = "Quản lý nhân sự";
            lbl_TittleQLNhanSu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roundedPanel7
            // 
            roundedPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedPanel7.BackColor = Color.FromArgb(156, 193, 250);
            roundedPanel7.BorderRadius = 20;
            roundedPanel7.Controls.Add(pictureBox6);
            roundedPanel7.Controls.Add(label9);
            roundedPanel7.Location = new Point(3411, 15);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(179, 62);
            roundedPanel7.TabIndex = 6;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(13, 10);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(43, 43);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(59, 17);
            label9.Name = "label9";
            label9.Size = new Size(112, 30);
            label9.TabIndex = 0;
            label9.Text = "Lịch Trình";
            // 
            // lblTimKiem
            // 
            lblTimKiem.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimKiem.Location = new Point(25, 65);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(232, 25);
            lblTimKiem.TabIndex = 2;
            lblTimKiem.Text = "Tìm kiếm nhân viên";
            lblTimKiem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnl_DGVEmployee
            // 
            pnl_DGVEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_DGVEmployee.BackColor = Color.FromArgb(217, 229, 255);
            pnl_DGVEmployee.BorderRadius = 20;
            pnl_DGVEmployee.Controls.Add(dgvNhanVien);
            pnl_DGVEmployee.Location = new Point(25, 162);
            pnl_DGVEmployee.Name = "pnl_DGVEmployee";
            pnl_DGVEmployee.Size = new Size(880, 416);
            pnl_DGVEmployee.TabIndex = 8;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.BackgroundColor = Color.FromArgb(217, 229, 255);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(217, 229, 255);
            dataGridViewCellStyle1.Font = new Font("Inter Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 0);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.Size = new Size(880, 416);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.CellDoubleClick += dgvNhanVien_CellDoubleClick;
            // 
            // pnl_ToChuc
            // 
            pnl_ToChuc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_ToChuc.BackColor = Color.White;
            pnl_ToChuc.BorderRadius = 20;
            pnl_ToChuc.Controls.Add(btnBoxThemChiNhanh);
            pnl_ToChuc.Controls.Add(btnSuaPB);
            pnl_ToChuc.Controls.Add(btnXoaPB);
            pnl_ToChuc.Controls.Add(btnThemPB);
            pnl_ToChuc.Controls.Add(label11);
            pnl_ToChuc.Controls.Add(label8);
            pnl_ToChuc.Controls.Add(roundedPanel9);
            pnl_ToChuc.Controls.Add(roundedPanel1);
            pnl_ToChuc.Controls.Add(cbbChiNhanh);
            pnl_ToChuc.Controls.Add(lblChonChiNhanh);
            pnl_ToChuc.Controls.Add(roundedPanel6);
            pnl_ToChuc.Controls.Add(roundedPanel8);
            pnl_ToChuc.Controls.Add(pnlBangDieuChinhPB);
            pnl_ToChuc.Controls.Add(pnlThemNVvaoPB);
            pnl_ToChuc.Controls.Add(pnlThemChiNhanh);
            pnl_ToChuc.Location = new Point(289, 137);
            pnl_ToChuc.Name = "pnl_ToChuc";
            pnl_ToChuc.Size = new Size(1054, 640);
            pnl_ToChuc.TabIndex = 9;
            pnl_ToChuc.Visible = false;
            // 
            // btnBoxThemChiNhanh
            // 
            btnBoxThemChiNhanh.BackColor = Color.Transparent;
            btnBoxThemChiNhanh.FlatAppearance.BorderSize = 0;
            btnBoxThemChiNhanh.FlatStyle = FlatStyle.Flat;
            btnBoxThemChiNhanh.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBoxThemChiNhanh.Location = new Point(354, 69);
            btnBoxThemChiNhanh.Name = "btnBoxThemChiNhanh";
            btnBoxThemChiNhanh.Size = new Size(40, 31);
            btnBoxThemChiNhanh.TabIndex = 4;
            btnBoxThemChiNhanh.Text = "+";
            btnBoxThemChiNhanh.UseVisualStyleBackColor = false;
            btnBoxThemChiNhanh.Click += btnBoxThemChiNhanh_Click;
            // 
            // btnSuaPB
            // 
            btnSuaPB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSuaPB.BackColor = Color.FromArgb(155, 193, 255);
            btnSuaPB.FlatStyle = FlatStyle.Flat;
            btnSuaPB.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuaPB.Location = new Point(919, 236);
            btnSuaPB.Name = "btnSuaPB";
            btnSuaPB.Size = new Size(109, 40);
            btnSuaPB.TabIndex = 17;
            btnSuaPB.Text = "Sửa";
            btnSuaPB.UseVisualStyleBackColor = false;
            btnSuaPB.Click += btnSuaPB_Click;
            // 
            // btnXoaPB
            // 
            btnXoaPB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoaPB.BackColor = Color.FromArgb(155, 193, 255);
            btnXoaPB.FlatStyle = FlatStyle.Flat;
            btnXoaPB.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaPB.Location = new Point(919, 179);
            btnXoaPB.Name = "btnXoaPB";
            btnXoaPB.Size = new Size(109, 40);
            btnXoaPB.TabIndex = 16;
            btnXoaPB.Text = "Xóa";
            btnXoaPB.UseVisualStyleBackColor = false;
            btnXoaPB.Click += btnXoaPB_Click;
            // 
            // btnThemPB
            // 
            btnThemPB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemPB.BackColor = Color.FromArgb(155, 193, 255);
            btnThemPB.FlatStyle = FlatStyle.Flat;
            btnThemPB.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemPB.Location = new Point(919, 123);
            btnThemPB.Name = "btnThemPB";
            btnThemPB.Size = new Size(109, 40);
            btnThemPB.TabIndex = 15;
            btnThemPB.Text = "Thêm";
            btnThemPB.UseVisualStyleBackColor = false;
            btnThemPB.Click += btnThemPB_Click;
            // 
            // label11
            // 
            label11.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(538, 288);
            label11.Name = "label11";
            label11.Size = new Size(185, 25);
            label11.TabIndex = 14;
            label11.Text = "Bảng điều khiển";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(25, 288);
            label8.Name = "label8";
            label8.Size = new Size(185, 25);
            label8.TabIndex = 12;
            label8.Text = "Danh sách nhân viên:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roundedPanel9
            // 
            roundedPanel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            roundedPanel9.BackColor = Color.FromArgb(217, 229, 255);
            roundedPanel9.BorderRadius = 20;
            roundedPanel9.Controls.Add(dgvDanhSachTheoPhong);
            roundedPanel9.Location = new Point(25, 326);
            roundedPanel9.Name = "roundedPanel9";
            roundedPanel9.Size = new Size(490, 244);
            roundedPanel9.TabIndex = 11;
            // 
            // dgvDanhSachTheoPhong
            // 
            dgvDanhSachTheoPhong.BackgroundColor = Color.FromArgb(217, 229, 255);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(217, 229, 255);
            dataGridViewCellStyle2.Font = new Font("Inter Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDanhSachTheoPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDanhSachTheoPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachTheoPhong.Dock = DockStyle.Fill;
            dgvDanhSachTheoPhong.Location = new Point(0, 0);
            dgvDanhSachTheoPhong.Name = "dgvDanhSachTheoPhong";
            dgvDanhSachTheoPhong.Size = new Size(490, 244);
            dgvDanhSachTheoPhong.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel1.BackColor = Color.FromArgb(217, 229, 255);
            roundedPanel1.BorderRadius = 20;
            roundedPanel1.Controls.Add(dgvPhongBan);
            roundedPanel1.Location = new Point(25, 123);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(880, 151);
            roundedPanel1.TabIndex = 10;
            // 
            // dgvPhongBan
            // 
            dgvPhongBan.BackgroundColor = Color.FromArgb(217, 229, 255);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(217, 229, 255);
            dataGridViewCellStyle3.Font = new Font("Inter Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPhongBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPhongBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhongBan.Dock = DockStyle.Fill;
            dgvPhongBan.Location = new Point(0, 0);
            dgvPhongBan.Name = "dgvPhongBan";
            dgvPhongBan.Size = new Size(880, 151);
            dgvPhongBan.TabIndex = 0;
            dgvPhongBan.CellClick += dgvPhongBan_CellClick;
            dgvPhongBan.CellDoubleClick += dgvPhongBan_CellDoubleClick;
            // 
            // cbbChiNhanh
            // 
            cbbChiNhanh.BackColor = Color.FromArgb(216, 228, 245);
            cbbChiNhanh.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbbChiNhanh.FormattingEnabled = true;
            cbbChiNhanh.Items.AddRange(new object[] { "Theo Tên", "Theo Phòng Ban" });
            cbbChiNhanh.Location = new Point(169, 69);
            cbbChiNhanh.Name = "cbbChiNhanh";
            cbbChiNhanh.Size = new Size(179, 31);
            cbbChiNhanh.TabIndex = 9;
            cbbChiNhanh.SelectedIndexChanged += cbbChiNhanh_SelectedIndexChanged;
            // 
            // lblChonChiNhanh
            // 
            lblChonChiNhanh.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChonChiNhanh.Location = new Point(25, 72);
            lblChonChiNhanh.Name = "lblChonChiNhanh";
            lblChonChiNhanh.Size = new Size(146, 25);
            lblChonChiNhanh.TabIndex = 8;
            lblChonChiNhanh.Text = "Chọn chi nhánh:";
            lblChonChiNhanh.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roundedPanel6
            // 
            roundedPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel6.BackColor = Color.FromArgb(217, 229, 255);
            roundedPanel6.BorderRadius = 20;
            roundedPanel6.Controls.Add(lblTieuDeToChuc);
            roundedPanel6.Location = new Point(0, 0);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(1054, 41);
            roundedPanel6.TabIndex = 7;
            // 
            // lblTieuDeToChuc
            // 
            lblTieuDeToChuc.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDeToChuc.Location = new Point(25, 9);
            lblTieuDeToChuc.Name = "lblTieuDeToChuc";
            lblTieuDeToChuc.Size = new Size(166, 25);
            lblTieuDeToChuc.TabIndex = 2;
            lblTieuDeToChuc.Text = "Tổ chức";
            // 
            // roundedPanel8
            // 
            roundedPanel8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedPanel8.BackColor = Color.FromArgb(156, 193, 250);
            roundedPanel8.BorderRadius = 20;
            roundedPanel8.Controls.Add(pictureBox7);
            roundedPanel8.Controls.Add(label10);
            roundedPanel8.Location = new Point(3411, 15);
            roundedPanel8.Name = "roundedPanel8";
            roundedPanel8.Size = new Size(179, 62);
            roundedPanel8.TabIndex = 6;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(13, 10);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(43, 43);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(59, 17);
            label10.Name = "label10";
            label10.Size = new Size(112, 30);
            label10.TabIndex = 0;
            label10.Text = "Lịch Trình";
            // 
            // pnlBangDieuChinhPB
            // 
            pnlBangDieuChinhPB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBangDieuChinhPB.BackColor = Color.FromArgb(217, 229, 255);
            pnlBangDieuChinhPB.BorderRadius = 20;
            pnlBangDieuChinhPB.Controls.Add(label15);
            pnlBangDieuChinhPB.Controls.Add(txtMaPB);
            pnlBangDieuChinhPB.Controls.Add(txtTenPB);
            pnlBangDieuChinhPB.Controls.Add(label14);
            pnlBangDieuChinhPB.Controls.Add(label12);
            pnlBangDieuChinhPB.Location = new Point(538, 326);
            pnlBangDieuChinhPB.Name = "pnlBangDieuChinhPB";
            pnlBangDieuChinhPB.Size = new Size(490, 244);
            pnlBangDieuChinhPB.TabIndex = 13;
            // 
            // label15
            // 
            label15.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(3, 20);
            label15.Name = "label15";
            label15.Size = new Size(484, 25);
            label15.TabIndex = 18;
            label15.Text = "Thông tin phòng ban";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMaPB
            // 
            txtMaPB.BackColor = Color.White;
            txtMaPB.BorderStyle = BorderStyle.FixedSingle;
            txtMaPB.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaPB.Location = new Point(162, 113);
            txtMaPB.Name = "txtMaPB";
            txtMaPB.Size = new Size(295, 30);
            txtMaPB.TabIndex = 21;
            // 
            // txtTenPB
            // 
            txtTenPB.BackColor = Color.White;
            txtTenPB.BorderStyle = BorderStyle.FixedSingle;
            txtTenPB.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenPB.Location = new Point(162, 72);
            txtTenPB.Name = "txtTenPB";
            txtTenPB.Size = new Size(295, 30);
            txtTenPB.TabIndex = 20;
            // 
            // label14
            // 
            label14.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(19, 113);
            label14.Name = "label14";
            label14.Size = new Size(137, 30);
            label14.TabIndex = 19;
            label14.Text = "Mã phòng ban:";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(19, 72);
            label12.Name = "label12";
            label12.Size = new Size(137, 30);
            label12.TabIndex = 18;
            label12.Text = "Tên phòng ban:";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlThemNVvaoPB
            // 
            pnlThemNVvaoPB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlThemNVvaoPB.BackColor = Color.FromArgb(217, 229, 255);
            pnlThemNVvaoPB.BorderRadius = 20;
            pnlThemNVvaoPB.Controls.Add(button1);
            pnlThemNVvaoPB.Controls.Add(chkTruongPhong);
            pnlThemNVvaoPB.Controls.Add(btnXacNhanThem);
            pnlThemNVvaoPB.Controls.Add(cbbNhanVienRanh);
            pnlThemNVvaoPB.Controls.Add(lblTenPhong);
            pnlThemNVvaoPB.Controls.Add(label17);
            pnlThemNVvaoPB.Controls.Add(label18);
            pnlThemNVvaoPB.Location = new Point(538, 326);
            pnlThemNVvaoPB.Name = "pnlThemNVvaoPB";
            pnlThemNVvaoPB.Size = new Size(490, 244);
            pnlThemNVvaoPB.TabIndex = 22;
            pnlThemNVvaoPB.Visible = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(155, 193, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(258, 185);
            button1.Name = "button1";
            button1.Size = new Size(109, 40);
            button1.TabIndex = 25;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // chkTruongPhong
            // 
            chkTruongPhong.AutoSize = true;
            chkTruongPhong.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkTruongPhong.Location = new Point(162, 118);
            chkTruongPhong.Name = "chkTruongPhong";
            chkTruongPhong.Size = new Size(51, 27);
            chkTruongPhong.TabIndex = 24;
            chkTruongPhong.Text = "Có";
            chkTruongPhong.UseVisualStyleBackColor = true;
            // 
            // btnXacNhanThem
            // 
            btnXacNhanThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXacNhanThem.BackColor = Color.FromArgb(155, 193, 255);
            btnXacNhanThem.FlatStyle = FlatStyle.Flat;
            btnXacNhanThem.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXacNhanThem.Location = new Point(143, 185);
            btnXacNhanThem.Name = "btnXacNhanThem";
            btnXacNhanThem.Size = new Size(109, 40);
            btnXacNhanThem.TabIndex = 23;
            btnXacNhanThem.Text = "Xác nhận";
            btnXacNhanThem.UseVisualStyleBackColor = false;
            btnXacNhanThem.Click += btnXacNhanThem_Click;
            // 
            // cbbNhanVienRanh
            // 
            cbbNhanVienRanh.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbNhanVienRanh.FormattingEnabled = true;
            cbbNhanVienRanh.Location = new Point(162, 71);
            cbbNhanVienRanh.Name = "cbbNhanVienRanh";
            cbbNhanVienRanh.Size = new Size(295, 31);
            cbbNhanVienRanh.TabIndex = 22;
            // 
            // lblTenPhong
            // 
            lblTenPhong.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenPhong.Location = new Point(3, 20);
            lblTenPhong.Name = "lblTenPhong";
            lblTenPhong.Size = new Size(484, 25);
            lblTenPhong.TabIndex = 18;
            lblTenPhong.Text = "Đang thêm nv vào...";
            lblTenPhong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(19, 113);
            label17.Name = "label17";
            label17.Size = new Size(137, 30);
            label17.TabIndex = 19;
            label17.Text = "Trưởng phòng:";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            label18.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(19, 72);
            label18.Name = "label18";
            label18.Size = new Size(147, 30);
            label18.TabIndex = 18;
            label18.Text = "Chọn nhân viên:";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlThemChiNhanh
            // 
            pnlThemChiNhanh.BackColor = Color.FromArgb(217, 229, 255);
            pnlThemChiNhanh.BorderRadius = 20;
            pnlThemChiNhanh.Controls.Add(label49);
            pnlThemChiNhanh.Controls.Add(txtDiaChiCN);
            pnlThemChiNhanh.Controls.Add(txtTenCN);
            pnlThemChiNhanh.Controls.Add(txtMaCN);
            pnlThemChiNhanh.Controls.Add(button5);
            pnlThemChiNhanh.Controls.Add(btnThemCN);
            pnlThemChiNhanh.Controls.Add(label42);
            pnlThemChiNhanh.Controls.Add(label46);
            pnlThemChiNhanh.Controls.Add(label48);
            pnlThemChiNhanh.Location = new Point(354, 102);
            pnlThemChiNhanh.Name = "pnlThemChiNhanh";
            pnlThemChiNhanh.Size = new Size(490, 244);
            pnlThemChiNhanh.TabIndex = 26;
            pnlThemChiNhanh.Visible = false;
            // 
            // label49
            // 
            label49.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label49.Location = new Point(19, 144);
            label49.Name = "label49";
            label49.Size = new Size(137, 30);
            label49.TabIndex = 28;
            label49.Text = "Địa chỉ:";
            label49.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiaChiCN
            // 
            txtDiaChiCN.BackColor = Color.White;
            txtDiaChiCN.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChiCN.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaChiCN.Location = new Point(172, 143);
            txtDiaChiCN.Name = "txtDiaChiCN";
            txtDiaChiCN.Size = new Size(295, 30);
            txtDiaChiCN.TabIndex = 27;
            // 
            // txtTenCN
            // 
            txtTenCN.BackColor = Color.White;
            txtTenCN.BorderStyle = BorderStyle.FixedSingle;
            txtTenCN.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenCN.Location = new Point(172, 107);
            txtTenCN.Name = "txtTenCN";
            txtTenCN.Size = new Size(295, 30);
            txtTenCN.TabIndex = 26;
            // 
            // txtMaCN
            // 
            txtMaCN.BackColor = Color.White;
            txtMaCN.BorderStyle = BorderStyle.FixedSingle;
            txtMaCN.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaCN.Location = new Point(172, 71);
            txtMaCN.Name = "txtMaCN";
            txtMaCN.Size = new Size(295, 30);
            txtMaCN.TabIndex = 22;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(155, 193, 255);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(548, 185);
            button5.Name = "button5";
            button5.Size = new Size(109, 40);
            button5.TabIndex = 25;
            button5.Text = "Hủy";
            button5.UseVisualStyleBackColor = false;
            // 
            // btnThemCN
            // 
            btnThemCN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemCN.BackColor = Color.FromArgb(155, 193, 255);
            btnThemCN.FlatStyle = FlatStyle.Flat;
            btnThemCN.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemCN.Location = new Point(194, 188);
            btnThemCN.Name = "btnThemCN";
            btnThemCN.Size = new Size(109, 40);
            btnThemCN.TabIndex = 23;
            btnThemCN.Text = "Xác nhận";
            btnThemCN.UseVisualStyleBackColor = false;
            btnThemCN.Click += btnThemCN_Click;
            // 
            // label42
            // 
            label42.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label42.Location = new Point(3, 20);
            label42.Name = "label42";
            label42.Size = new Size(484, 25);
            label42.TabIndex = 18;
            label42.Text = "Thêm chi nhánh";
            label42.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label46
            // 
            label46.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label46.Location = new Point(19, 108);
            label46.Name = "label46";
            label46.Size = new Size(137, 30);
            label46.TabIndex = 19;
            label46.Text = "Tên chi nhánh:";
            label46.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label48
            // 
            label48.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label48.Location = new Point(19, 71);
            label48.Name = "label48";
            label48.Size = new Size(147, 30);
            label48.TabIndex = 18;
            label48.Text = "Mã chi nhánh:";
            label48.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnl_QuanLyHopDong
            // 
            pnl_QuanLyHopDong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_QuanLyHopDong.BackColor = Color.White;
            pnl_QuanLyHopDong.BorderRadius = 20;
            pnl_QuanLyHopDong.Controls.Add(btnDuyetHD);
            pnl_QuanLyHopDong.Controls.Add(btnChamDut);
            pnl_QuanLyHopDong.Controls.Add(btnGiaHan);
            pnl_QuanLyHopDong.Controls.Add(button2);
            pnl_QuanLyHopDong.Controls.Add(roundedPanel11);
            pnl_QuanLyHopDong.Controls.Add(label33);
            pnl_QuanLyHopDong.Controls.Add(dgcHopDong);
            pnl_QuanLyHopDong.Controls.Add(roundedPanel12);
            pnl_QuanLyHopDong.Controls.Add(roundedPanel13);
            pnl_QuanLyHopDong.Location = new Point(289, 137);
            pnl_QuanLyHopDong.Name = "pnl_QuanLyHopDong";
            pnl_QuanLyHopDong.Size = new Size(1054, 640);
            pnl_QuanLyHopDong.TabIndex = 8;
            pnl_QuanLyHopDong.Visible = false;
            // 
            // btnDuyetHD
            // 
            btnDuyetHD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDuyetHD.BackColor = Color.FromArgb(155, 193, 255);
            btnDuyetHD.FlatStyle = FlatStyle.Flat;
            btnDuyetHD.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDuyetHD.Location = new Point(919, 266);
            btnDuyetHD.Name = "btnDuyetHD";
            btnDuyetHD.Size = new Size(109, 40);
            btnDuyetHD.TabIndex = 16;
            btnDuyetHD.Text = "Duyệt";
            btnDuyetHD.UseVisualStyleBackColor = false;
            btnDuyetHD.Visible = false;
            btnDuyetHD.Click += btnDuyetHD_Click;
            // 
            // btnChamDut
            // 
            btnChamDut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChamDut.BackColor = Color.FromArgb(155, 193, 255);
            btnChamDut.FlatStyle = FlatStyle.Flat;
            btnChamDut.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChamDut.Location = new Point(919, 216);
            btnChamDut.Name = "btnChamDut";
            btnChamDut.Size = new Size(109, 40);
            btnChamDut.TabIndex = 15;
            btnChamDut.Text = "Hủy";
            btnChamDut.UseVisualStyleBackColor = false;
            btnChamDut.Click += btnChamDut_Click;
            // 
            // btnGiaHan
            // 
            btnGiaHan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGiaHan.BackColor = Color.FromArgb(155, 193, 255);
            btnGiaHan.FlatStyle = FlatStyle.Flat;
            btnGiaHan.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGiaHan.Location = new Point(919, 167);
            btnGiaHan.Name = "btnGiaHan";
            btnGiaHan.Size = new Size(109, 40);
            btnGiaHan.TabIndex = 14;
            btnGiaHan.Text = "Gia hạn";
            btnGiaHan.UseVisualStyleBackColor = false;
            btnGiaHan.Click += btnGiaHan_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(155, 193, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(919, 112);
            button2.Name = "button2";
            button2.Size = new Size(109, 40);
            button2.TabIndex = 13;
            button2.Text = "Làm mới";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // roundedPanel11
            // 
            roundedPanel11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel11.BackColor = Color.FromArgb(217, 229, 255);
            roundedPanel11.BorderRadius = 20;
            roundedPanel11.Controls.Add(txtTimHopDong);
            roundedPanel11.Controls.Add(btnTimHopDong);
            roundedPanel11.Location = new Point(25, 112);
            roundedPanel11.Name = "roundedPanel11";
            roundedPanel11.Size = new Size(888, 41);
            roundedPanel11.TabIndex = 8;
            // 
            // txtTimHopDong
            // 
            txtTimHopDong.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimHopDong.BackColor = Color.FromArgb(216, 228, 245);
            txtTimHopDong.BorderStyle = BorderStyle.None;
            txtTimHopDong.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimHopDong.Location = new Point(10, 10);
            txtTimHopDong.Name = "txtTimHopDong";
            txtTimHopDong.Size = new Size(829, 23);
            txtTimHopDong.TabIndex = 13;
            // 
            // btnTimHopDong
            // 
            btnTimHopDong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimHopDong.Image = Properties.Resources.Screenshot_2026_03_20_174457;
            btnTimHopDong.Location = new Point(845, 3);
            btnTimHopDong.Name = "btnTimHopDong";
            btnTimHopDong.Size = new Size(35, 35);
            btnTimHopDong.SizeMode = PictureBoxSizeMode.StretchImage;
            btnTimHopDong.TabIndex = 14;
            btnTimHopDong.TabStop = false;
            btnTimHopDong.Click += btnTimHopDong_Click;
            // 
            // label33
            // 
            label33.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label33.Location = new Point(26, 79);
            label33.Name = "label33";
            label33.Size = new Size(232, 25);
            label33.TabIndex = 12;
            label33.Text = "Tìm kiếm hợp đồng";
            label33.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgcHopDong
            // 
            dgcHopDong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgcHopDong.BackColor = Color.FromArgb(217, 229, 255);
            dgcHopDong.BorderRadius = 20;
            dgcHopDong.Controls.Add(dgvHopDong);
            dgcHopDong.Location = new Point(25, 162);
            dgcHopDong.Name = "dgcHopDong";
            dgcHopDong.Size = new Size(888, 408);
            dgcHopDong.TabIndex = 11;
            // 
            // dgvHopDong
            // 
            dgvHopDong.BackgroundColor = Color.FromArgb(217, 229, 255);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(217, 229, 255);
            dataGridViewCellStyle4.Font = new Font("Inter Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvHopDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvHopDong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHopDong.Dock = DockStyle.Fill;
            dgvHopDong.Location = new Point(0, 0);
            dgvHopDong.Name = "dgvHopDong";
            dgvHopDong.Size = new Size(888, 408);
            dgvHopDong.TabIndex = 0;
            // 
            // roundedPanel12
            // 
            roundedPanel12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel12.BackColor = Color.FromArgb(217, 229, 255);
            roundedPanel12.BorderRadius = 20;
            roundedPanel12.Controls.Add(label13);
            roundedPanel12.Location = new Point(0, 0);
            roundedPanel12.Name = "roundedPanel12";
            roundedPanel12.Size = new Size(1054, 41);
            roundedPanel12.TabIndex = 7;
            // 
            // label13
            // 
            label13.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(26, 4);
            label13.Name = "label13";
            label13.Size = new Size(279, 34);
            label13.TabIndex = 2;
            label13.Text = "Quản lý hợp đồng";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roundedPanel13
            // 
            roundedPanel13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedPanel13.BackColor = Color.FromArgb(156, 193, 250);
            roundedPanel13.BorderRadius = 20;
            roundedPanel13.Controls.Add(pictureBox8);
            roundedPanel13.Controls.Add(label29);
            roundedPanel13.Location = new Point(2557, 15);
            roundedPanel13.Name = "roundedPanel13";
            roundedPanel13.Size = new Size(179, 62);
            roundedPanel13.TabIndex = 6;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(13, 10);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(43, 43);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 1;
            pictureBox8.TabStop = false;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.Location = new Point(59, 17);
            label29.Name = "label29";
            label29.Size = new Size(112, 30);
            label29.TabIndex = 0;
            label29.Text = "Lịch Trình";
            // 
            // roundedPanel2
            // 
            roundedPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedPanel2.BackColor = Color.FromArgb(156, 193, 250);
            roundedPanel2.BorderRadius = 20;
            roundedPanel2.Controls.Add(pictureBox3);
            roundedPanel2.Controls.Add(label5);
            roundedPanel2.Location = new Point(1703, 15);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(179, 62);
            roundedPanel2.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(13, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(59, 17);
            label5.Name = "label5";
            label5.Size = new Size(112, 30);
            label5.TabIndex = 0;
            label5.Text = "Lịch Trình";
            // 
            // pnl_TopDashboard
            // 
            pnl_TopDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnl_TopDashboard.BackColor = Color.FromArgb(217, 229, 255);
            pnl_TopDashboard.BorderRadius = 20;
            pnl_TopDashboard.Controls.Add(lbl_Dashboarđ);
            pnl_TopDashboard.Location = new Point(0, 0);
            pnl_TopDashboard.Name = "pnl_TopDashboard";
            pnl_TopDashboard.Size = new Size(1054, 41);
            pnl_TopDashboard.TabIndex = 7;
            // 
            // lbl_Dashboarđ
            // 
            lbl_Dashboarđ.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Dashboarđ.Location = new Point(25, 9);
            lbl_Dashboarđ.Name = "lbl_Dashboarđ";
            lbl_Dashboarđ.Size = new Size(139, 25);
            lbl_Dashboarđ.TabIndex = 2;
            lbl_Dashboarđ.Text = "Dashboard";
            // 
            // pnl_Dashboard
            // 
            pnl_Dashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_Dashboard.BackColor = Color.White;
            pnl_Dashboard.BorderRadius = 20;
            pnl_Dashboard.Controls.Add(pictureBox13);
            pnl_Dashboard.Controls.Add(roundedPanel34);
            pnl_Dashboard.Controls.Add(roundedPanel33);
            pnl_Dashboard.Controls.Add(roundedPanel32);
            pnl_Dashboard.Controls.Add(roundedPanel31);
            pnl_Dashboard.Controls.Add(roundedPanel30);
            pnl_Dashboard.Controls.Add(roundedPanel29);
            pnl_Dashboard.Controls.Add(pnl_TopDashboard);
            pnl_Dashboard.Controls.Add(roundedPanel2);
            pnl_Dashboard.Location = new Point(289, 137);
            pnl_Dashboard.Name = "pnl_Dashboard";
            pnl_Dashboard.Size = new Size(1054, 640);
            pnl_Dashboard.TabIndex = 7;
            // 
            // pictureBox13
            // 
            pictureBox13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox13.Image = Properties.Resources.Screenshot_2026_03_22_000658;
            pictureBox13.Location = new Point(557, 94);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(479, 450);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 13;
            pictureBox13.TabStop = false;
            // 
            // roundedPanel34
            // 
            roundedPanel34.BackColor = Color.FromArgb(173, 220, 255);
            roundedPanel34.BorderRadius = 20;
            roundedPanel34.Controls.Add(lblNhanVienCheckIn);
            roundedPanel34.Controls.Add(label70);
            roundedPanel34.Location = new Point(284, 94);
            roundedPanel34.Name = "roundedPanel34";
            roundedPanel34.Size = new Size(220, 125);
            roundedPanel34.TabIndex = 12;
            // 
            // lblNhanVienCheckIn
            // 
            lblNhanVienCheckIn.Font = new Font("Inter", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhanVienCheckIn.Location = new Point(3, 47);
            lblNhanVienCheckIn.Name = "lblNhanVienCheckIn";
            lblNhanVienCheckIn.Size = new Size(214, 67);
            lblNhanVienCheckIn.TabIndex = 10;
            lblNhanVienCheckIn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label70
            // 
            label70.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label70.Location = new Point(3, 13);
            label70.Name = "label70";
            label70.Size = new Size(214, 27);
            label70.TabIndex = 5;
            label70.Text = "Nhân viên đang làm";
            label70.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedPanel33
            // 
            roundedPanel33.BackColor = Color.FromArgb(173, 220, 255);
            roundedPanel33.BorderRadius = 20;
            roundedPanel33.Controls.Add(lblDonChoDuyet);
            roundedPanel33.Controls.Add(label69);
            roundedPanel33.Location = new Point(284, 419);
            roundedPanel33.Name = "roundedPanel33";
            roundedPanel33.Size = new Size(220, 125);
            roundedPanel33.TabIndex = 11;
            // 
            // lblDonChoDuyet
            // 
            lblDonChoDuyet.Font = new Font("Inter", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDonChoDuyet.Location = new Point(3, 47);
            lblDonChoDuyet.Name = "lblDonChoDuyet";
            lblDonChoDuyet.Size = new Size(214, 67);
            lblDonChoDuyet.TabIndex = 9;
            lblDonChoDuyet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label69
            // 
            label69.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label69.Location = new Point(3, 13);
            label69.Name = "label69";
            label69.Size = new Size(214, 27);
            label69.TabIndex = 5;
            label69.Text = "Đơn chờ duyệt";
            label69.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedPanel32
            // 
            roundedPanel32.BackColor = Color.FromArgb(255, 192, 192);
            roundedPanel32.BorderRadius = 20;
            roundedPanel32.Controls.Add(lblHopDongHetHan);
            roundedPanel32.Controls.Add(label68);
            roundedPanel32.Location = new Point(284, 258);
            roundedPanel32.Name = "roundedPanel32";
            roundedPanel32.Size = new Size(220, 125);
            roundedPanel32.TabIndex = 11;
            // 
            // lblHopDongHetHan
            // 
            lblHopDongHetHan.Font = new Font("Inter", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHopDongHetHan.Location = new Point(3, 46);
            lblHopDongHetHan.Name = "lblHopDongHetHan";
            lblHopDongHetHan.Size = new Size(214, 67);
            lblHopDongHetHan.TabIndex = 7;
            lblHopDongHetHan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label68
            // 
            label68.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label68.Location = new Point(3, 13);
            label68.Name = "label68";
            label68.Size = new Size(214, 27);
            label68.TabIndex = 6;
            label68.Text = "Hợp đồng hết hạn";
            label68.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedPanel31
            // 
            roundedPanel31.BackColor = Color.FromArgb(192, 255, 192);
            roundedPanel31.BorderRadius = 20;
            roundedPanel31.Controls.Add(lblHopDongConHan);
            roundedPanel31.Controls.Add(label67);
            roundedPanel31.Location = new Point(25, 258);
            roundedPanel31.Name = "roundedPanel31";
            roundedPanel31.Size = new Size(220, 125);
            roundedPanel31.TabIndex = 10;
            // 
            // lblHopDongConHan
            // 
            lblHopDongConHan.Font = new Font("Inter", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHopDongConHan.Location = new Point(3, 51);
            lblHopDongConHan.Name = "lblHopDongConHan";
            lblHopDongConHan.Size = new Size(214, 67);
            lblHopDongConHan.TabIndex = 8;
            lblHopDongConHan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label67
            // 
            label67.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label67.Location = new Point(3, 13);
            label67.Name = "label67";
            label67.Size = new Size(214, 27);
            label67.TabIndex = 5;
            label67.Text = "Hợp đồng còn hạn";
            label67.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedPanel30
            // 
            roundedPanel30.BackColor = Color.FromArgb(173, 220, 255);
            roundedPanel30.BorderRadius = 20;
            roundedPanel30.Controls.Add(lblTongPhongBan);
            roundedPanel30.Controls.Add(label66);
            roundedPanel30.Location = new Point(25, 419);
            roundedPanel30.Name = "roundedPanel30";
            roundedPanel30.Size = new Size(220, 125);
            roundedPanel30.TabIndex = 9;
            // 
            // lblTongPhongBan
            // 
            lblTongPhongBan.Font = new Font("Inter", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongPhongBan.Location = new Point(3, 49);
            lblTongPhongBan.Name = "lblTongPhongBan";
            lblTongPhongBan.Size = new Size(214, 67);
            lblTongPhongBan.TabIndex = 6;
            lblTongPhongBan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label66
            // 
            label66.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label66.Location = new Point(3, 16);
            label66.Name = "label66";
            label66.Size = new Size(214, 27);
            label66.TabIndex = 5;
            label66.Text = "Tổng phòng ban";
            label66.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedPanel29
            // 
            roundedPanel29.BackColor = Color.FromArgb(173, 220, 255);
            roundedPanel29.BorderRadius = 20;
            roundedPanel29.Controls.Add(lblTongNhanVien);
            roundedPanel29.Controls.Add(label65);
            roundedPanel29.Location = new Point(25, 96);
            roundedPanel29.Name = "roundedPanel29";
            roundedPanel29.Size = new Size(220, 125);
            roundedPanel29.TabIndex = 8;
            // 
            // lblTongNhanVien
            // 
            lblTongNhanVien.Font = new Font("Inter", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongNhanVien.Location = new Point(3, 49);
            lblTongNhanVien.Name = "lblTongNhanVien";
            lblTongNhanVien.Size = new Size(214, 67);
            lblTongNhanVien.TabIndex = 5;
            lblTongNhanVien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label65
            // 
            label65.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label65.Location = new Point(3, 16);
            label65.Name = "label65";
            label65.Size = new Size(214, 27);
            label65.TabIndex = 4;
            label65.Text = "Tổng nhân viên";
            label65.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl_DonXin
            // 
            pnl_DonXin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_DonXin.BackColor = Color.White;
            pnl_DonXin.BorderRadius = 20;
            pnl_DonXin.Controls.Add(label43);
            pnl_DonXin.Controls.Add(roundedPanel14);
            pnl_DonXin.Controls.Add(btnTuChoi);
            pnl_DonXin.Controls.Add(btnDuyet);
            pnl_DonXin.Controls.Add(roundedPanel17);
            pnl_DonXin.Controls.Add(roundedPanel15);
            pnl_DonXin.Controls.Add(roundedPanel16);
            pnl_DonXin.Location = new Point(289, 137);
            pnl_DonXin.Name = "pnl_DonXin";
            pnl_DonXin.Size = new Size(1054, 640);
            pnl_DonXin.TabIndex = 8;
            // 
            // label43
            // 
            label43.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label43.Location = new Point(34, 54);
            label43.Name = "label43";
            label43.Size = new Size(199, 31);
            label43.TabIndex = 2;
            label43.Text = "Tạo đơn nghĩ";
            label43.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roundedPanel14
            // 
            roundedPanel14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel14.BackColor = Color.FromArgb(217, 229, 255);
            roundedPanel14.BorderRadius = 20;
            roundedPanel14.Controls.Add(btnGuiDon);
            roundedPanel14.Controls.Add(cbbLoaiDon);
            roundedPanel14.Controls.Add(txtLyDo);
            roundedPanel14.Controls.Add(txtSoNgayNghi);
            roundedPanel14.Controls.Add(label47);
            roundedPanel14.Controls.Add(label45);
            roundedPanel14.Controls.Add(label44);
            roundedPanel14.Location = new Point(19, 88);
            roundedPanel14.Name = "roundedPanel14";
            roundedPanel14.Size = new Size(891, 112);
            roundedPanel14.TabIndex = 18;
            // 
            // btnGuiDon
            // 
            btnGuiDon.BackColor = Color.FromArgb(155, 193, 255);
            btnGuiDon.FlatStyle = FlatStyle.Flat;
            btnGuiDon.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuiDon.Location = new Point(768, 35);
            btnGuiDon.Name = "btnGuiDon";
            btnGuiDon.Size = new Size(109, 40);
            btnGuiDon.TabIndex = 19;
            btnGuiDon.Text = "Gửi Đơn";
            btnGuiDon.UseVisualStyleBackColor = false;
            btnGuiDon.Click += btnGuiDon_Click;
            // 
            // cbbLoaiDon
            // 
            cbbLoaiDon.Font = new Font("Inter", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbLoaiDon.FormattingEnabled = true;
            cbbLoaiDon.Items.AddRange(new object[] { "Nghỉ phép", "Thôi việc" });
            cbbLoaiDon.Location = new Point(151, 14);
            cbbLoaiDon.Name = "cbbLoaiDon";
            cbbLoaiDon.Size = new Size(159, 32);
            cbbLoaiDon.TabIndex = 19;
            // 
            // txtLyDo
            // 
            txtLyDo.Font = new Font("Inter", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLyDo.Location = new Point(423, 17);
            txtLyDo.Multiline = true;
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(333, 76);
            txtLyDo.TabIndex = 18;
            // 
            // txtSoNgayNghi
            // 
            txtSoNgayNghi.Font = new Font("Inter", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoNgayNghi.Location = new Point(150, 65);
            txtSoNgayNghi.Name = "txtSoNgayNghi";
            txtSoNgayNghi.Size = new Size(158, 28);
            txtSoNgayNghi.TabIndex = 17;
            // 
            // label47
            // 
            label47.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label47.Location = new Point(348, 17);
            label47.Name = "label47";
            label47.Size = new Size(72, 25);
            label47.TabIndex = 16;
            label47.Text = "Lý do:";
            label47.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label45
            // 
            label45.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label45.Location = new Point(16, 68);
            label45.Name = "label45";
            label45.Size = new Size(129, 25);
            label45.TabIndex = 14;
            label45.Text = "Số ngày nghỉ:";
            label45.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label44
            // 
            label44.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label44.Location = new Point(15, 17);
            label44.Name = "label44";
            label44.Size = new Size(130, 25);
            label44.TabIndex = 13;
            label44.Text = "Loại đơn:";
            label44.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnTuChoi
            // 
            btnTuChoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTuChoi.BackColor = Color.FromArgb(155, 193, 255);
            btnTuChoi.FlatStyle = FlatStyle.Flat;
            btnTuChoi.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTuChoi.Location = new Point(919, 260);
            btnTuChoi.Name = "btnTuChoi";
            btnTuChoi.Size = new Size(109, 40);
            btnTuChoi.TabIndex = 17;
            btnTuChoi.Text = "Từ chối";
            btnTuChoi.UseVisualStyleBackColor = false;
            btnTuChoi.Visible = false;
            btnTuChoi.Click += btnTuChoi_Click;
            // 
            // btnDuyet
            // 
            btnDuyet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDuyet.BackColor = Color.FromArgb(155, 193, 255);
            btnDuyet.FlatStyle = FlatStyle.Flat;
            btnDuyet.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDuyet.Location = new Point(919, 209);
            btnDuyet.Name = "btnDuyet";
            btnDuyet.Size = new Size(109, 40);
            btnDuyet.TabIndex = 16;
            btnDuyet.Text = "Duyệt";
            btnDuyet.UseVisualStyleBackColor = false;
            btnDuyet.Visible = false;
            btnDuyet.Click += btnDuyet_Click;
            // 
            // roundedPanel17
            // 
            roundedPanel17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel17.BackColor = Color.FromArgb(217, 229, 255);
            roundedPanel17.BorderRadius = 20;
            roundedPanel17.Controls.Add(dgvNghiPhep);
            roundedPanel17.Location = new Point(22, 211);
            roundedPanel17.Name = "roundedPanel17";
            roundedPanel17.Size = new Size(888, 367);
            roundedPanel17.TabIndex = 12;
            // 
            // dgvNghiPhep
            // 
            dgvNghiPhep.BackgroundColor = Color.FromArgb(217, 229, 255);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(217, 229, 255);
            dataGridViewCellStyle5.Font = new Font("Inter Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvNghiPhep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvNghiPhep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNghiPhep.Dock = DockStyle.Fill;
            dgvNghiPhep.Location = new Point(0, 0);
            dgvNghiPhep.Name = "dgvNghiPhep";
            dgvNghiPhep.Size = new Size(888, 367);
            dgvNghiPhep.TabIndex = 0;
            // 
            // roundedPanel15
            // 
            roundedPanel15.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel15.BackColor = Color.FromArgb(217, 229, 255);
            roundedPanel15.BorderRadius = 20;
            roundedPanel15.Controls.Add(label39);
            roundedPanel15.Location = new Point(0, 0);
            roundedPanel15.Name = "roundedPanel15";
            roundedPanel15.Size = new Size(1054, 41);
            roundedPanel15.TabIndex = 7;
            // 
            // label39
            // 
            label39.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label39.Location = new Point(25, 4);
            label39.Name = "label39";
            label39.Size = new Size(199, 34);
            label39.TabIndex = 2;
            label39.Text = "Quản lý đơn xin";
            label39.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roundedPanel16
            // 
            roundedPanel16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedPanel16.BackColor = Color.FromArgb(156, 193, 250);
            roundedPanel16.BorderRadius = 20;
            roundedPanel16.Controls.Add(pictureBox9);
            roundedPanel16.Controls.Add(label40);
            roundedPanel16.Location = new Point(2557, 15);
            roundedPanel16.Name = "roundedPanel16";
            roundedPanel16.Size = new Size(179, 62);
            roundedPanel16.TabIndex = 6;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(13, 10);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(43, 43);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 1;
            pictureBox9.TabStop = false;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label40.Location = new Point(59, 17);
            label40.Name = "label40";
            label40.Size = new Size(112, 30);
            label40.TabIndex = 0;
            label40.Text = "Lịch Trình";
            // 
            // pnlThongBao
            // 
            pnlThongBao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlThongBao.AutoScroll = true;
            pnlThongBao.BackColor = Color.FromArgb(173, 220, 255);
            pnlThongBao.Controls.Add(label41);
            pnlThongBao.Controls.Add(button3);
            pnlThongBao.Controls.Add(button4);
            pnlThongBao.Location = new Point(1015, 134);
            pnlThongBao.Name = "pnlThongBao";
            pnlThongBao.Size = new Size(328, 255);
            pnlThongBao.TabIndex = 4;
            pnlThongBao.Visible = false;
            // 
            // label41
            // 
            label41.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label41.Location = new Point(3, 8);
            label41.Name = "label41";
            label41.Size = new Size(322, 31);
            label41.TabIndex = 19;
            label41.Text = "Thông báo";
            label41.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Inter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(1391, 5);
            button3.Name = "button3";
            button3.Size = new Size(40, 25);
            button3.TabIndex = 2;
            button3.Text = "-";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Inter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(1434, 5);
            button4.Name = "button4";
            button4.Size = new Size(40, 25);
            button4.TabIndex = 1;
            button4.Text = "x";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = false;
            // 
            // roundedPanel18
            // 
            roundedPanel18.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel18.BackColor = Color.FromArgb(217, 229, 255);
            roundedPanel18.BorderRadius = 20;
            roundedPanel18.Controls.Add(label51);
            roundedPanel18.Location = new Point(0, 0);
            roundedPanel18.Name = "roundedPanel18";
            roundedPanel18.Size = new Size(1054, 41);
            roundedPanel18.TabIndex = 7;
            // 
            // label51
            // 
            label51.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label51.Location = new Point(25, 5);
            label51.Name = "label51";
            label51.Size = new Size(139, 29);
            label51.TabIndex = 2;
            label51.Text = "Hệ thống";
            label51.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnl_HeThong
            // 
            pnl_HeThong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_HeThong.BackColor = Color.White;
            pnl_HeThong.BorderRadius = 20;
            pnl_HeThong.Controls.Add(label58);
            pnl_HeThong.Controls.Add(roundedPanel22);
            pnl_HeThong.Controls.Add(pnlBoxTimTaiKhoan);
            pnl_HeThong.Controls.Add(roundedPanel21);
            pnl_HeThong.Controls.Add(roundedPanel19);
            pnl_HeThong.Controls.Add(roundedPanel18);
            pnl_HeThong.Controls.Add(roundedPanel20);
            pnl_HeThong.Location = new Point(289, 137);
            pnl_HeThong.Name = "pnl_HeThong";
            pnl_HeThong.Size = new Size(1054, 640);
            pnl_HeThong.TabIndex = 8;
            pnl_HeThong.Visible = false;
            // 
            // label58
            // 
            label58.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label58.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label58.Location = new Point(623, 66);
            label58.Name = "label58";
            label58.Size = new Size(402, 27);
            label58.TabIndex = 30;
            label58.Text = "Lịch sử đăng nhập hệ thống";
            label58.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedPanel22
            // 
            roundedPanel22.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            roundedPanel22.BackColor = Color.FromArgb(217, 229, 255);
            roundedPanel22.BorderRadius = 20;
            roundedPanel22.Controls.Add(dgvLichSu);
            roundedPanel22.Location = new Point(623, 99);
            roundedPanel22.Name = "roundedPanel22";
            roundedPanel22.Size = new Size(402, 527);
            roundedPanel22.TabIndex = 14;
            // 
            // dgvLichSu
            // 
            dgvLichSu.BackgroundColor = Color.FromArgb(217, 229, 255);
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(217, 229, 255);
            dataGridViewCellStyle6.Font = new Font("Inter Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvLichSu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvLichSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichSu.Dock = DockStyle.Fill;
            dgvLichSu.Location = new Point(0, 0);
            dgvLichSu.Name = "dgvLichSu";
            dgvLichSu.Size = new Size(402, 527);
            dgvLichSu.TabIndex = 0;
            // 
            // pnlBoxTimTaiKhoan
            // 
            pnlBoxTimTaiKhoan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlBoxTimTaiKhoan.BackColor = Color.FromArgb(217, 229, 255);
            pnlBoxTimTaiKhoan.BorderRadius = 20;
            pnlBoxTimTaiKhoan.Controls.Add(txtTimTaiKhoan);
            pnlBoxTimTaiKhoan.Controls.Add(btnTimTaiKhoan);
            pnlBoxTimTaiKhoan.Location = new Point(28, 220);
            pnlBoxTimTaiKhoan.Name = "pnlBoxTimTaiKhoan";
            pnlBoxTimTaiKhoan.Size = new Size(578, 40);
            pnlBoxTimTaiKhoan.TabIndex = 8;
            // 
            // txtTimTaiKhoan
            // 
            txtTimTaiKhoan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimTaiKhoan.BackColor = Color.FromArgb(216, 228, 245);
            txtTimTaiKhoan.BorderStyle = BorderStyle.None;
            txtTimTaiKhoan.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimTaiKhoan.Location = new Point(7, 9);
            txtTimTaiKhoan.Name = "txtTimTaiKhoan";
            txtTimTaiKhoan.Size = new Size(521, 23);
            txtTimTaiKhoan.TabIndex = 15;
            // 
            // btnTimTaiKhoan
            // 
            btnTimTaiKhoan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimTaiKhoan.Image = Properties.Resources.Screenshot_2026_03_20_174457;
            btnTimTaiKhoan.Location = new Point(534, 2);
            btnTimTaiKhoan.Name = "btnTimTaiKhoan";
            btnTimTaiKhoan.Size = new Size(35, 35);
            btnTimTaiKhoan.SizeMode = PictureBoxSizeMode.StretchImage;
            btnTimTaiKhoan.TabIndex = 16;
            btnTimTaiKhoan.TabStop = false;
            btnTimTaiKhoan.Click += btnTimTaiKhoan_Click;
            // 
            // roundedPanel21
            // 
            roundedPanel21.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel21.BackColor = Color.FromArgb(173, 220, 255);
            roundedPanel21.BorderRadius = 20;
            roundedPanel21.Controls.Add(btnThemTaiKhoan);
            roundedPanel21.Controls.Add(btnXoaTaiKhoan);
            roundedPanel21.Controls.Add(cbbNhanVienRanh2);
            roundedPanel21.Controls.Add(label57);
            roundedPanel21.Controls.Add(cbbQuyen);
            roundedPanel21.Controls.Add(label56);
            roundedPanel21.Controls.Add(txtPassword);
            roundedPanel21.Controls.Add(label55);
            roundedPanel21.Controls.Add(txtUsername);
            roundedPanel21.Controls.Add(label54);
            roundedPanel21.Controls.Add(label53);
            roundedPanel21.Location = new Point(25, 59);
            roundedPanel21.Name = "roundedPanel21";
            roundedPanel21.Size = new Size(578, 146);
            roundedPanel21.TabIndex = 14;
            // 
            // btnThemTaiKhoan
            // 
            btnThemTaiKhoan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemTaiKhoan.BackColor = Color.FromArgb(155, 193, 255);
            btnThemTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnThemTaiKhoan.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemTaiKhoan.Location = new Point(409, 105);
            btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            btnThemTaiKhoan.Size = new Size(67, 31);
            btnThemTaiKhoan.TabIndex = 29;
            btnThemTaiKhoan.Text = "Tạo";
            btnThemTaiKhoan.UseVisualStyleBackColor = false;
            btnThemTaiKhoan.Click += btnThemTaiKhoan_Click;
            // 
            // btnXoaTaiKhoan
            // 
            btnXoaTaiKhoan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoaTaiKhoan.BackColor = Color.FromArgb(155, 193, 255);
            btnXoaTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnXoaTaiKhoan.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaTaiKhoan.Location = new Point(482, 105);
            btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            btnXoaTaiKhoan.Size = new Size(67, 31);
            btnXoaTaiKhoan.TabIndex = 18;
            btnXoaTaiKhoan.Text = "Xóa";
            btnXoaTaiKhoan.UseVisualStyleBackColor = false;
            btnXoaTaiKhoan.Click += btnXoaTaiKhoan_Click;
            // 
            // cbbNhanVienRanh2
            // 
            cbbNhanVienRanh2.Font = new Font("Inter", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbNhanVienRanh2.FormattingEnabled = true;
            cbbNhanVienRanh2.Location = new Point(402, 38);
            cbbNhanVienRanh2.Name = "cbbNhanVienRanh2";
            cbbNhanVienRanh2.Size = new Size(164, 32);
            cbbNhanVienRanh2.TabIndex = 28;
            // 
            // label57
            // 
            label57.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label57.Location = new Point(297, 38);
            label57.Name = "label57";
            label57.Size = new Size(99, 30);
            label57.TabIndex = 27;
            label57.Text = "Đối tượng:";
            label57.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbbQuyen
            // 
            cbbQuyen.Font = new Font("Inter", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbQuyen.FormattingEnabled = true;
            cbbQuyen.Items.AddRange(new object[] { "HR", "Employee", "Manager", "Admin" });
            cbbQuyen.Location = new Point(127, 106);
            cbbQuyen.Name = "cbbQuyen";
            cbbQuyen.Size = new Size(164, 32);
            cbbQuyen.TabIndex = 26;
            // 
            // label56
            // 
            label56.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label56.Location = new Point(19, 108);
            label56.Name = "label56";
            label56.Size = new Size(102, 30);
            label56.TabIndex = 25;
            label56.Text = "Quyền:";
            label56.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(127, 71);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(164, 30);
            txtPassword.TabIndex = 24;
            // 
            // label55
            // 
            label55.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label55.Location = new Point(19, 72);
            label55.Name = "label55";
            label55.Size = new Size(102, 30);
            label55.TabIndex = 23;
            label55.Text = "Password:";
            label55.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(127, 38);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(164, 30);
            txtUsername.TabIndex = 22;
            // 
            // label54
            // 
            label54.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label54.Location = new Point(19, 38);
            label54.Name = "label54";
            label54.Size = new Size(102, 30);
            label54.TabIndex = 22;
            label54.Text = "Username:";
            label54.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label53
            // 
            label53.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label53.Location = new Point(19, 9);
            label53.Name = "label53";
            label53.Size = new Size(547, 27);
            label53.TabIndex = 3;
            label53.Text = "Bảng điều chỉnh tài khoản";
            label53.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedPanel19
            // 
            roundedPanel19.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel19.BackColor = Color.FromArgb(217, 229, 255);
            roundedPanel19.BorderRadius = 20;
            roundedPanel19.Controls.Add(dgvTaiKhoan);
            roundedPanel19.Location = new Point(25, 276);
            roundedPanel19.Name = "roundedPanel19";
            roundedPanel19.Size = new Size(581, 350);
            roundedPanel19.TabIndex = 13;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.BackgroundColor = Color.FromArgb(217, 229, 255);
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(217, 229, 255);
            dataGridViewCellStyle7.Font = new Font("Inter Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Dock = DockStyle.Fill;
            dgvTaiKhoan.Location = new Point(0, 0);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.Size = new Size(581, 350);
            dgvTaiKhoan.TabIndex = 0;
            // 
            // roundedPanel20
            // 
            roundedPanel20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedPanel20.BackColor = Color.FromArgb(156, 193, 250);
            roundedPanel20.BorderRadius = 20;
            roundedPanel20.Controls.Add(pictureBox10);
            roundedPanel20.Controls.Add(label52);
            roundedPanel20.Location = new Point(2557, 15);
            roundedPanel20.Name = "roundedPanel20";
            roundedPanel20.Size = new Size(179, 62);
            roundedPanel20.TabIndex = 6;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(13, 10);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(43, 43);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 1;
            pictureBox10.TabStop = false;
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label52.Location = new Point(59, 17);
            label52.Name = "label52";
            label52.Size = new Size(112, 30);
            label52.TabIndex = 0;
            label52.Text = "Lịch Trình";
            // 
            // pnl_ChamCong
            // 
            pnl_ChamCong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_ChamCong.BackColor = Color.White;
            pnl_ChamCong.BorderRadius = 20;
            pnl_ChamCong.Controls.Add(button7);
            pnl_ChamCong.Controls.Add(button6);
            pnl_ChamCong.Controls.Add(label61);
            pnl_ChamCong.Controls.Add(roundedPanel26);
            pnl_ChamCong.Controls.Add(roundedPanel24);
            pnl_ChamCong.Controls.Add(roundedPanel25);
            pnl_ChamCong.Location = new Point(289, 137);
            pnl_ChamCong.Name = "pnl_ChamCong";
            pnl_ChamCong.Size = new Size(1054, 640);
            pnl_ChamCong.TabIndex = 8;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button7.BackColor = Color.FromArgb(155, 193, 255);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(919, 200);
            button7.Name = "button7";
            button7.Size = new Size(117, 40);
            button7.TabIndex = 18;
            button7.Text = "CheckOut";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.BackColor = Color.FromArgb(155, 193, 255);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(919, 146);
            button6.Name = "button6";
            button6.Size = new Size(117, 40);
            button6.TabIndex = 17;
            button6.Text = "CheckIn";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label61
            // 
            label61.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label61.Location = new Point(25, 108);
            label61.Name = "label61";
            label61.Size = new Size(185, 27);
            label61.TabIndex = 9;
            label61.Text = "Lịch sử chấm công";
            label61.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roundedPanel26
            // 
            roundedPanel26.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel26.BackColor = Color.FromArgb(217, 229, 255);
            roundedPanel26.BorderRadius = 20;
            roundedPanel26.Controls.Add(dgvChamCong);
            roundedPanel26.Location = new Point(25, 146);
            roundedPanel26.Name = "roundedPanel26";
            roundedPanel26.Size = new Size(880, 432);
            roundedPanel26.TabIndex = 8;
            // 
            // dgvChamCong
            // 
            dgvChamCong.BackgroundColor = Color.FromArgb(217, 229, 255);
            dgvChamCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamCong.Dock = DockStyle.Fill;
            dgvChamCong.Location = new Point(0, 0);
            dgvChamCong.Name = "dgvChamCong";
            dgvChamCong.Size = new Size(880, 432);
            dgvChamCong.TabIndex = 0;
            // 
            // roundedPanel24
            // 
            roundedPanel24.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel24.BackColor = Color.FromArgb(217, 229, 255);
            roundedPanel24.BorderRadius = 20;
            roundedPanel24.Controls.Add(label59);
            roundedPanel24.Location = new Point(0, 0);
            roundedPanel24.Name = "roundedPanel24";
            roundedPanel24.Size = new Size(1054, 41);
            roundedPanel24.TabIndex = 7;
            // 
            // label59
            // 
            label59.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label59.Location = new Point(25, 6);
            label59.Name = "label59";
            label59.Size = new Size(139, 29);
            label59.TabIndex = 2;
            label59.Text = "Chấm công";
            label59.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roundedPanel25
            // 
            roundedPanel25.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedPanel25.BackColor = Color.FromArgb(156, 193, 250);
            roundedPanel25.BorderRadius = 20;
            roundedPanel25.Controls.Add(pictureBox11);
            roundedPanel25.Controls.Add(label60);
            roundedPanel25.Location = new Point(2557, 15);
            roundedPanel25.Name = "roundedPanel25";
            roundedPanel25.Size = new Size(179, 62);
            roundedPanel25.TabIndex = 6;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(13, 10);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(43, 43);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 1;
            pictureBox11.TabStop = false;
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label60.Location = new Point(59, 17);
            label60.Name = "label60";
            label60.Size = new Size(112, 30);
            label60.TabIndex = 0;
            label60.Text = "Lịch Trình";
            // 
            // pnl_Luong
            // 
            pnl_Luong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_Luong.BackColor = Color.White;
            pnl_Luong.BorderRadius = 20;
            pnl_Luong.Controls.Add(label72);
            pnl_Luong.Controls.Add(nudNam);
            pnl_Luong.Controls.Add(label71);
            pnl_Luong.Controls.Add(nudThang);
            pnl_Luong.Controls.Add(label64);
            pnl_Luong.Controls.Add(button8);
            pnl_Luong.Controls.Add(btnChotLuong);
            pnl_Luong.Controls.Add(roundedPanel23);
            pnl_Luong.Controls.Add(roundedPanel27);
            pnl_Luong.Controls.Add(roundedPanel28);
            pnl_Luong.Location = new Point(289, 137);
            pnl_Luong.Name = "pnl_Luong";
            pnl_Luong.Size = new Size(1054, 640);
            pnl_Luong.TabIndex = 8;
            // 
            // label72
            // 
            label72.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label72.Location = new Point(342, 100);
            label72.Name = "label72";
            label72.Size = new Size(59, 27);
            label72.TabIndex = 23;
            label72.Text = "Năm:";
            label72.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudNam
            // 
            nudNam.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudNam.Location = new Point(407, 101);
            nudNam.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudNam.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudNam.Name = "nudNam";
            nudNam.Size = new Size(120, 27);
            nudNam.TabIndex = 22;
            nudNam.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // label71
            // 
            label71.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label71.Location = new Point(25, 101);
            label71.Name = "label71";
            label71.Size = new Size(185, 27);
            label71.TabIndex = 21;
            label71.Text = "Chọn tháng cần chốt:";
            label71.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudThang
            // 
            nudThang.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudThang.Location = new Point(216, 100);
            nudThang.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nudThang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudThang.Name = "nudThang";
            nudThang.Size = new Size(120, 27);
            nudThang.TabIndex = 20;
            nudThang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label64
            // 
            label64.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label64.Location = new Point(25, 69);
            label64.Name = "label64";
            label64.Size = new Size(185, 27);
            label64.TabIndex = 19;
            label64.Text = "Bảng lương công ty:";
            label64.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button8.BackColor = Color.FromArgb(192, 255, 192);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(847, 45);
            button8.Name = "button8";
            button8.Size = new Size(178, 40);
            button8.TabIndex = 18;
            button8.Text = "Duyệt lương =>";
            button8.UseVisualStyleBackColor = false;
            button8.Visible = false;
            button8.Click += button8_Click;
            // 
            // btnChotLuong
            // 
            btnChotLuong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChotLuong.BackColor = Color.FromArgb(192, 255, 192);
            btnChotLuong.FlatStyle = FlatStyle.Flat;
            btnChotLuong.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChotLuong.Location = new Point(847, 91);
            btnChotLuong.Name = "btnChotLuong";
            btnChotLuong.Size = new Size(178, 40);
            btnChotLuong.TabIndex = 17;
            btnChotLuong.Text = "Chốt bảng lương";
            btnChotLuong.UseVisualStyleBackColor = false;
            btnChotLuong.Visible = false;
            btnChotLuong.Click += btnChotLuong_Click;
            // 
            // roundedPanel23
            // 
            roundedPanel23.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel23.BorderRadius = 20;
            roundedPanel23.Controls.Add(dgvTinhLuong);
            roundedPanel23.Location = new Point(26, 140);
            roundedPanel23.Name = "roundedPanel23";
            roundedPanel23.Size = new Size(999, 438);
            roundedPanel23.TabIndex = 8;
            // 
            // dgvTinhLuong
            // 
            dgvTinhLuong.BackgroundColor = Color.FromArgb(217, 229, 255);
            dgvTinhLuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTinhLuong.Dock = DockStyle.Fill;
            dgvTinhLuong.Location = new Point(0, 0);
            dgvTinhLuong.Name = "dgvTinhLuong";
            dgvTinhLuong.Size = new Size(999, 438);
            dgvTinhLuong.TabIndex = 0;
            // 
            // roundedPanel27
            // 
            roundedPanel27.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel27.BackColor = Color.FromArgb(217, 229, 255);
            roundedPanel27.BorderRadius = 20;
            roundedPanel27.Controls.Add(label62);
            roundedPanel27.Location = new Point(0, 0);
            roundedPanel27.Name = "roundedPanel27";
            roundedPanel27.Size = new Size(1054, 41);
            roundedPanel27.TabIndex = 7;
            // 
            // label62
            // 
            label62.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label62.Location = new Point(25, 5);
            label62.Name = "label62";
            label62.Size = new Size(139, 30);
            label62.TabIndex = 2;
            label62.Text = "Lương";
            label62.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roundedPanel28
            // 
            roundedPanel28.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedPanel28.BackColor = Color.FromArgb(156, 193, 250);
            roundedPanel28.BorderRadius = 20;
            roundedPanel28.Controls.Add(pictureBox12);
            roundedPanel28.Controls.Add(label63);
            roundedPanel28.Location = new Point(2557, 15);
            roundedPanel28.Name = "roundedPanel28";
            roundedPanel28.Size = new Size(179, 62);
            roundedPanel28.TabIndex = 6;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(13, 10);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(43, 43);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 1;
            pictureBox12.TabStop = false;
            // 
            // label63
            // 
            label63.AutoSize = true;
            label63.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label63.Location = new Point(59, 17);
            label63.Name = "label63";
            label63.Size = new Size(112, 30);
            label63.TabIndex = 0;
            label63.Text = "Lịch Trình";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 228, 245);
            ClientSize = new Size(1366, 800);
            Controls.Add(pnlWelcomeBar);
            Controls.Add(pnlLogout);
            Controls.Add(pnlFormBar);
            Controls.Add(pnlSideBar_HR);
            Controls.Add(pnlSideBar_Employee);
            Controls.Add(pnl_HeThong);
            Controls.Add(pnl_ToChuc);
            Controls.Add(pnl_HoSoCaNhan);
            Controls.Add(pnl_QuanLyNhanSu);
            Controls.Add(pnl_ChamCong);
            Controls.Add(pnl_Dashboard);
            Controls.Add(pnlThongBao);
            Controls.Add(pnl_Luong);
            Controls.Add(pnl_DonXin);
            Controls.Add(pnl_QuanLyHopDong);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HyperionHR";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            pnlFormBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlWelcomeBar.ResumeLayout(false);
            pnlWelcomeBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icoBaoTriHeThong).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnChuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAva2).EndInit();
            pnlSideBar_HR.ResumeLayout(false);
            pnlBottomSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAva1).EndInit();
            pnlHoTro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoHoTro).EndInit();
            pnlCaiDat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoCaiDat).EndInit();
            grbChucNang.ResumeLayout(false);
            pnlDonXin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoDon).EndInit();
            pnlLuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoLuong).EndInit();
            pnlChamCong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoChamCong).EndInit();
            pnlHopDong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoHopDong).EndInit();
            pnlChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoToChuc).EndInit();
            pnlNhanSu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoNhanSu).EndInit();
            grbMainMenu.ResumeLayout(false);
            pnlHoSoCaNhan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoHoSoCaNhan).EndInit();
            pnlDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoDashBoard).EndInit();
            pnlLogout.ResumeLayout(false);
            pnlLogout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconLogout).EndInit();
            pnl_HoSoCaNhan.ResumeLayout(false);
            roundedPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)circlePictureBox2).EndInit();
            pnl_TopHoSo.ResumeLayout(false);
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlSideBar_Employee.ResumeLayout(false);
            pnlHoTro2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoHoTro2).EndInit();
            pnlCaiDat2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoCaiDat2).EndInit();
            pnlBottomSideBar_Employee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAva3).EndInit();
            roundedPanel3.ResumeLayout(false);
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)circlePictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            grbChucNang_Employee.ResumeLayout(false);
            pnlHoSoCaNhan_Employee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoHoSoCaNhan2).EndInit();
            pnlDonXin_Employee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoDonXin).EndInit();
            pnlLuong_Employee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoLuong2).EndInit();
            pnlChamCong_Employee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoChamCong_2).EndInit();
            pnl_QuanLyNhanSu.ResumeLayout(false);
            pnlDienThongTin.ResumeLayout(false);
            pnlDienThongTin.PerformLayout();
            pnlBoxTimKiem.ResumeLayout(false);
            pnlBoxTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnTimKiem).EndInit();
            pnl_TopQLNhanSu.ResumeLayout(false);
            roundedPanel7.ResumeLayout(false);
            roundedPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            pnl_DGVEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            pnl_ToChuc.ResumeLayout(false);
            roundedPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachTheoPhong).EndInit();
            roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhongBan).EndInit();
            roundedPanel6.ResumeLayout(false);
            roundedPanel8.ResumeLayout(false);
            roundedPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            pnlBangDieuChinhPB.ResumeLayout(false);
            pnlBangDieuChinhPB.PerformLayout();
            pnlThemNVvaoPB.ResumeLayout(false);
            pnlThemNVvaoPB.PerformLayout();
            pnlThemChiNhanh.ResumeLayout(false);
            pnlThemChiNhanh.PerformLayout();
            pnl_QuanLyHopDong.ResumeLayout(false);
            roundedPanel11.ResumeLayout(false);
            roundedPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnTimHopDong).EndInit();
            dgcHopDong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHopDong).EndInit();
            roundedPanel12.ResumeLayout(false);
            roundedPanel13.ResumeLayout(false);
            roundedPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnl_TopDashboard.ResumeLayout(false);
            pnl_Dashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            roundedPanel34.ResumeLayout(false);
            roundedPanel33.ResumeLayout(false);
            roundedPanel32.ResumeLayout(false);
            roundedPanel31.ResumeLayout(false);
            roundedPanel30.ResumeLayout(false);
            roundedPanel29.ResumeLayout(false);
            pnl_DonXin.ResumeLayout(false);
            roundedPanel14.ResumeLayout(false);
            roundedPanel14.PerformLayout();
            roundedPanel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNghiPhep).EndInit();
            roundedPanel15.ResumeLayout(false);
            roundedPanel16.ResumeLayout(false);
            roundedPanel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            pnlThongBao.ResumeLayout(false);
            roundedPanel18.ResumeLayout(false);
            pnl_HeThong.ResumeLayout(false);
            roundedPanel22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).EndInit();
            pnlBoxTimTaiKhoan.ResumeLayout(false);
            pnlBoxTimTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnTimTaiKhoan).EndInit();
            roundedPanel21.ResumeLayout(false);
            roundedPanel21.PerformLayout();
            roundedPanel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            roundedPanel20.ResumeLayout(false);
            roundedPanel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            pnl_ChamCong.ResumeLayout(false);
            roundedPanel26.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).EndInit();
            roundedPanel24.ResumeLayout(false);
            roundedPanel25.ResumeLayout(false);
            roundedPanel25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            pnl_Luong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudNam).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudThang).EndInit();
            roundedPanel23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTinhLuong).EndInit();
            roundedPanel27.ResumeLayout(false);
            roundedPanel28.ResumeLayout(false);
            roundedPanel28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFormBar;
        private Button btnclose;
        private Button btnHide;
        private Scripts.MakeupScripts.RoundedPanel pnlWelcomeBar;
        private Label lblDateTime;
        private Label lblWelcome;
        private Label lblSystemName;
        private Scripts.MakeupScripts.RoundedPanel pnlSideBar_HR;
        private Label lblAppName;
        private Scripts.UI.CirclePictureBox picAva1;
        private Scripts.UI.CirclePictureBox picAva2;
        private Label lblUserGmail1;
        private Label lblUserName1;
        private Label lblLogout;
        private Scripts.MakeupScripts.RoundedPanel pnlLogout;
        private PictureBox picIconLogout;
        private GroupBox grbMainMenu;
        private PictureBox picLogo;
        private Label lblDashboard;
        private Panel pnlDashboard;
        private Panel pnlHoSoCaNhan;
        private PictureBox icoHoSoCaNhan;
        private Label lblHoSoCaNhan;
        private PictureBox icoDashBoard;
        private GroupBox grbChucNang;
        private Panel pnlChucNang;
        private PictureBox icoToChuc;
        private Label lblToChuc;
        private Panel pnlNhanSu;
        private PictureBox icoNhanSu;
        private Label lblNhanSu;
        private Panel pnlHoTro;
        private PictureBox icoHoTro;
        private Label lblHoTro;
        private Panel pnlCaiDat;
        private PictureBox icoCaiDat;
        private Label lblCaiDat;
        private PictureBox btnChuong;
        private Panel pnlHopDong;
        private PictureBox icoHopDong;
        private Label lblHopDong;
        private Panel pnlChamCong;
        private PictureBox icoChamCong;
        private Label lblChamCong;
        private Panel pnlDuAn;
        private PictureBox icoDuAn;
        private Label lblDuAn;
        private Panel pnlDonXin;
        private PictureBox icoDon;
        private Label lblDonXin;
        private Panel pnlLuong;
        private PictureBox icoLuong;
        private Label lblLuong;
        private PictureBox icoBaoTriHeThong;
        private Scripts.MakeupScripts.RoundedPanel pnl_HoSoCaNhan;
        private Scripts.MakeupScripts.RoundedPanel pnl_TopHoSo;
        private Label lbl_TitleHoSo;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel4;
        private PictureBox pictureBox1;
        private Label label2;
        private Scripts.MakeupScripts.RoundedPanel pnlBottomSideMenu;
        private Scripts.MakeupScripts.RoundedPanel pnlSideBar_Employee;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel3;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel5;
        private PictureBox pictureBox2;
        private Label label1;
        private Scripts.UI.CirclePictureBox circlePictureBox1;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Label label6;
        private Panel panel2;
        private PictureBox pictureBox5;
        private Label label7;
        private GroupBox grbChucNang_Employee;
        private Panel pnlDonXin_Employee;
        private PictureBox icoDonXin;
        private Label lblDonXin_Employee;
        private Panel pnlLuong_Employee;
        private PictureBox icoLuong2;
        private Label lblLuong_Employee;
        private Panel pnlDuAn_Employee;
        private PictureBox icoDuAn_Employee;
        private Label lblDuAn_Employee;
        private Panel pnlChamCong_Employee;
        private PictureBox icoChamCong_2;
        private Label lblChamCong_Employee;
        private Panel pnlHoSoCaNhan_Employee;
        private PictureBox icoHoSoCaNhan2;
        private Label lblHoSoCaNhan_Employee;
        private Label lblSystemName2;
        private Scripts.MakeupScripts.RoundedPanel pnlBottomSideBar_Employee;
        private Scripts.UI.CirclePictureBox picAva3;
        private Label lblUserName2;
        private Label lblUserGmail2;
        private Panel pnlHoTro2;
        private PictureBox icoHoTro2;
        private Label lblHoTro2;
        private Panel pnlCaiDat2;
        private PictureBox icoCaiDat2;
        private Label lblCaiDat2;
        private Scripts.MakeupScripts.RoundedPanel pnl_QuanLyNhanSu;
        private Scripts.MakeupScripts.RoundedPanel pnl_TopQLNhanSu;
        private Label lbl_TittleQLNhanSu;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel7;
        private PictureBox pictureBox6;
        private Label label9;
        private Scripts.MakeupScripts.RoundedPanel pnl_DGVEmployee;
        private DataGridView dgvNhanVien;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private Button btnLamMoi;
        private ComboBox cbbTieuChi;
        private Label lblDienMaNV;
        private TextBox txtMaNV;
        private Label lblDienSDT;
        private TextBox txtSoDienThoai;
        private Label lblDienEmail;
        private TextBox txtEmail;
        private Label lblDienHoTen;
        private TextBox txtHoTen;
        private Scripts.MakeupScripts.RoundedPanel pnlDienThongTin;
        private Scripts.MakeupScripts.RoundedPanel pnlBoxTimKiem;
        private PictureBox btnTimKiem;
        private Button btnThemNV;
        private Label lblLoaiNhanVien;
        private Label lblGioiTInh;
        private Label lblBangDieuChinh;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cbbLoaiNV;
        private ComboBox cbbGioiTinh;
        private Label lblNgaySinh;
        private Button btnThem;
        private Button btnLamMoiInput;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTatBangThongTin;
        private Scripts.MakeupScripts.RoundedPanel pnl_ToChuc;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel6;
        private Label lblTieuDeToChuc;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel8;
        private PictureBox pictureBox7;
        private Label label10;
        private ComboBox cbbChiNhanh;
        private Label lblChonChiNhanh;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel1;
        private DataGridView dgvPhongBan;
        private Label label8;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel9;
        private DataGridView dgvDanhSachTheoPhong;
        private Button btnSuaPB;
        private Button btnXoaPB;
        private Button btnThemPB;
        private Label label11;
        private Scripts.MakeupScripts.RoundedPanel pnlBangDieuChinhPB;
        private TextBox txtMaPB;
        private TextBox txtTenPB;
        private Label label14;
        private Label label12;
        private Label label15;
        private Scripts.MakeupScripts.RoundedPanel pnlThemNVvaoPB;
        private ComboBox cbbNhanVienRanh;
        private Label lblTenPhong;
        private Label label17;
        private Label label18;
        private Button btnXacNhanThem;
        private CheckBox chkTruongPhong;
        private Button button1;
        private ComboBox cbbChucVu;
        private Label label16;
        private Scripts.UI.CirclePictureBox circlePictureBox2;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel10;
        private Label label25;
        private Label label27;
        private Label label23;
        private Label label28;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label24;
        private Label label26;
        private Label lbChucVu;
        private Label lbLoaiNhanVien;
        private Label lbNgaySinh;
        private Label lbGioiTinh;
        private Label lbHoTen;
        private Label lbMaNV;
        private Label lbSDT;
        private Label lbEmail;
        private Scripts.MakeupScripts.RoundedPanel pnl_QuanLyHopDong;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel12;
        private Label label13;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel13;
        private PictureBox pictureBox8;
        private Label label29;
        private Scripts.MakeupScripts.RoundedPanel dgcHopDong;
        private DataGridView dgvHopDong;
        private Label lbLoaiHD;
        private Label label35;
        private Label lbMaHD;
        private Label label34;
        private Label label31;
        private Label label32;
        private Label label30;
        private Label lbNgayBatDauHD;
        private Label label37;
        private Label lbNgayKetThuc;
        private Label label36;
        private Label label33;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel11;
        private TextBox txtTimHopDong;
        private PictureBox btnTimHopDong;
        private Button button2;
        private Button btnGiaHan;
        private Button btnChamDut;
        private Button btnDuyetHD;
        private Label label38;
        private CheckBox chkTaoHopDong;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel2;
        private PictureBox pictureBox3;
        private Label label5;
        private Scripts.MakeupScripts.RoundedPanel pnl_TopDashboard;
        private Label lbl_Dashboarđ;
        private Scripts.MakeupScripts.RoundedPanel pnl_Dashboard;
        private Scripts.MakeupScripts.RoundedPanel pnl_DonXin;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel15;
        private Label label39;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel16;
        private PictureBox pictureBox9;
        private Label label40;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel17;
        private DataGridView dgvNghiPhep;
        private Button btnTuChoi;
        private Button btnDuyet;
        private Label label43;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel14;
        private Label label45;
        private Label label44;
        private TextBox txtLyDo;
        private TextBox txtSoNgayNghi;
        private Label label47;
        private Button btnGuiDon;
        private ComboBox cbbLoaiDon;
        private Label lblSoThongBao;
        private Panel pnlThongBao;
        private Label label41;
        private Button button3;
        private Button button4;
        private Button btnBoxThemChiNhanh;
        private Scripts.MakeupScripts.RoundedPanel pnlThemChiNhanh;
        private Button button5;
        private Button btnThemCN;
        private Label label42;
        private Label label46;
        private Label label48;
        private TextBox txtDiaChiCN;
        private TextBox txtTenCN;
        private TextBox txtMaCN;
        private Label label49;
        private Label lbPhongban;
        private Label label50;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel18;
        private Label label51;
        private Scripts.MakeupScripts.RoundedPanel pnl_HeThong;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel20;
        private PictureBox pictureBox10;
        private Label label52;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel21;
        private Label label53;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel19;
        private DataGridView dgvTaiKhoan;
        private Scripts.MakeupScripts.RoundedPanel pnlBoxTimTaiKhoan;
        private TextBox txtTimTaiKhoan;
        private PictureBox btnTimTaiKhoan;
        private TextBox txtUsername;
        private Label label54;
        private Button btnXoaTaiKhoan;
        private ComboBox cbbNhanVienRanh2;
        private Label label57;
        private ComboBox cbbQuyen;
        private Label label56;
        private TextBox txtPassword;
        private Label label55;
        private Button btnThemTaiKhoan;
        private Label label58;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel22;
        private DataGridView dgvLichSu;
        private Scripts.MakeupScripts.RoundedPanel pnl_ChamCong;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel26;
        private DataGridView dgvChamCong;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel24;
        private Label label59;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel25;
        private PictureBox pictureBox11;
        private Label label60;
        private Button button7;
        private Button button6;
        private Label label61;
        private Scripts.MakeupScripts.RoundedPanel pnl_Luong;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel27;
        private Label label62;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel28;
        private PictureBox pictureBox12;
        private Label label63;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel23;
        private Button btnChotLuong;
        private DataGridView dgvTinhLuong;
        private Button button8;
        private Label label64;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel32;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel31;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel30;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel29;
        private Label label68;
        private Label label67;
        private Label label66;
        private Label label65;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel34;
        private Label lblNhanVienCheckIn;
        private Label label70;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel33;
        private Label lblDonChoDuyet;
        private Label label69;
        private Label lblHopDongHetHan;
        private Label lblHopDongConHan;
        private Label lblTongPhongBan;
        private Label lblTongNhanVien;
        private PictureBox pictureBox13;
        private Label label71;
        private NumericUpDown nudThang;
        private Label label72;
        private NumericUpDown nudNam;
    }
}
