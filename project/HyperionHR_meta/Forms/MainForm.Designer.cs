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
            pnlFormBar = new Panel();
            picLogo = new PictureBox();
            lblAppName = new Label();
            btnHide = new Button();
            btnclose = new Button();
            lblSystemName = new Label();
            pnlWelcomeBar = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            icoSystemManage = new PictureBox();
            icoNotifications = new PictureBox();
            pnlScheduleButton = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            picSchedule = new PictureBox();
            lblLichTrinh = new Label();
            picAva2 = new HyperionHR_meta.Scripts.UI.CirclePictureBox();
            lblDateTime = new Label();
            lblWelcome = new Label();
            pnlSideBar_HR = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            roundedPanel1 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pnlLogout = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            picIconLogout = new PictureBox();
            lblLogout = new Label();
            picAva1 = new HyperionHR_meta.Scripts.UI.CirclePictureBox();
            lblUserName1 = new Label();
            lblUserGmail = new Label();
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
            pnlDuAn = new Panel();
            icoDuAn = new PictureBox();
            lblDuAn = new Label();
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
            pnl_Dashboard = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pnl_TopDashboard = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            lbl_Dashboarđ = new Label();
            roundedPanel2 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            pnl_HoSoCaNhan = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pnl_TopHoSo = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            lbl_TitleHoSo = new Label();
            roundedPanel4 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pnlFormBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlWelcomeBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoSystemManage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icoNotifications).BeginInit();
            pnlScheduleButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSchedule).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAva2).BeginInit();
            pnlSideBar_HR.SuspendLayout();
            roundedPanel1.SuspendLayout();
            pnlLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconLogout).BeginInit();
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
            pnlDuAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoDuAn).BeginInit();
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
            pnl_Dashboard.SuspendLayout();
            pnl_TopDashboard.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnl_HoSoCaNhan.SuspendLayout();
            pnl_TopHoSo.SuspendLayout();
            roundedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            picLogo.Location = new Point(3, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(29, 27);
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
            pnlWelcomeBar.Controls.Add(icoSystemManage);
            pnlWelcomeBar.Controls.Add(icoNotifications);
            pnlWelcomeBar.Controls.Add(pnlScheduleButton);
            pnlWelcomeBar.Controls.Add(picAva2);
            pnlWelcomeBar.Controls.Add(lblDateTime);
            pnlWelcomeBar.Controls.Add(lblWelcome);
            pnlWelcomeBar.Location = new Point(289, 41);
            pnlWelcomeBar.Name = "pnlWelcomeBar";
            pnlWelcomeBar.Size = new Size(1054, 90);
            pnlWelcomeBar.TabIndex = 2;
            // 
            // icoSystemManage
            // 
            icoSystemManage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icoSystemManage.Image = (Image)resources.GetObject("icoSystemManage.Image");
            icoSystemManage.Location = new Point(726, 25);
            icoSystemManage.Name = "icoSystemManage";
            icoSystemManage.Size = new Size(43, 43);
            icoSystemManage.SizeMode = PictureBoxSizeMode.StretchImage;
            icoSystemManage.TabIndex = 7;
            icoSystemManage.TabStop = false;
            // 
            // icoNotifications
            // 
            icoNotifications.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icoNotifications.Image = (Image)resources.GetObject("icoNotifications.Image");
            icoNotifications.Location = new Point(790, 25);
            icoNotifications.Name = "icoNotifications";
            icoNotifications.Size = new Size(43, 43);
            icoNotifications.SizeMode = PictureBoxSizeMode.StretchImage;
            icoNotifications.TabIndex = 2;
            icoNotifications.TabStop = false;
            // 
            // pnlScheduleButton
            // 
            pnlScheduleButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlScheduleButton.BackColor = Color.FromArgb(156, 193, 250);
            pnlScheduleButton.BorderRadius = 20;
            pnlScheduleButton.Controls.Add(picSchedule);
            pnlScheduleButton.Controls.Add(lblLichTrinh);
            pnlScheduleButton.Location = new Point(849, 15);
            pnlScheduleButton.Name = "pnlScheduleButton";
            pnlScheduleButton.Size = new Size(179, 62);
            pnlScheduleButton.TabIndex = 6;
            // 
            // picSchedule
            // 
            picSchedule.Image = (Image)resources.GetObject("picSchedule.Image");
            picSchedule.Location = new Point(13, 10);
            picSchedule.Name = "picSchedule";
            picSchedule.Size = new Size(43, 43);
            picSchedule.SizeMode = PictureBoxSizeMode.StretchImage;
            picSchedule.TabIndex = 1;
            picSchedule.TabStop = false;
            // 
            // lblLichTrinh
            // 
            lblLichTrinh.AutoSize = true;
            lblLichTrinh.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLichTrinh.Location = new Point(59, 17);
            lblLichTrinh.Name = "lblLichTrinh";
            lblLichTrinh.Size = new Size(112, 30);
            lblLichTrinh.TabIndex = 0;
            lblLichTrinh.Text = "Lịch Trình";
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
            lblWelcome.Size = new Size(383, 41);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "       , Chào buổi sáng admin";
            lblWelcome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlSideBar_HR
            // 
            pnlSideBar_HR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlSideBar_HR.BackColor = Color.White;
            pnlSideBar_HR.BorderRadius = 20;
            pnlSideBar_HR.Controls.Add(roundedPanel1);
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
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            roundedPanel1.BorderRadius = 20;
            roundedPanel1.Controls.Add(pnlLogout);
            roundedPanel1.Controls.Add(picAva1);
            roundedPanel1.Controls.Add(lblUserName1);
            roundedPanel1.Controls.Add(lblUserGmail);
            roundedPanel1.Location = new Point(0, 672);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(240, 64);
            roundedPanel1.TabIndex = 14;
            // 
            // pnlLogout
            // 
            pnlLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlLogout.BackColor = Color.FromArgb(173, 220, 255);
            pnlLogout.BorderRadius = 20;
            pnlLogout.Controls.Add(picIconLogout);
            pnlLogout.Controls.Add(lblLogout);
            pnlLogout.Location = new Point(139, 12);
            pnlLogout.Name = "pnlLogout";
            pnlLogout.Size = new Size(90, 30);
            pnlLogout.TabIndex = 11;
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
            lblUserName1.Size = new Size(144, 27);
            lblUserName1.TabIndex = 6;
            lblUserName1.Text = "admin";
            lblUserName1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUserGmail
            // 
            lblUserGmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUserGmail.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserGmail.ForeColor = SystemColors.ControlDarkDark;
            lblUserGmail.Location = new Point(60, 29);
            lblUserGmail.Name = "lblUserGmail";
            lblUserGmail.Size = new Size(144, 24);
            lblUserGmail.TabIndex = 7;
            lblUserGmail.Text = "admin";
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
            grbChucNang.Controls.Add(pnlDuAn);
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
            // 
            // pnlLuong
            // 
            pnlLuong.Controls.Add(icoLuong);
            pnlLuong.Controls.Add(lblLuong);
            pnlLuong.Location = new Point(12, 279);
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
            // 
            // pnlDuAn
            // 
            pnlDuAn.Controls.Add(icoDuAn);
            pnlDuAn.Controls.Add(lblDuAn);
            pnlDuAn.Location = new Point(12, 238);
            pnlDuAn.Name = "pnlDuAn";
            pnlDuAn.Size = new Size(190, 35);
            pnlDuAn.TabIndex = 8;
            // 
            // icoDuAn
            // 
            icoDuAn.Image = Properties.Resources.Screenshot_2026_03_16_132316;
            icoDuAn.Location = new Point(10, 5);
            icoDuAn.Name = "icoDuAn";
            icoDuAn.Size = new Size(25, 25);
            icoDuAn.SizeMode = PictureBoxSizeMode.StretchImage;
            icoDuAn.TabIndex = 1;
            icoDuAn.TabStop = false;
            // 
            // lblDuAn
            // 
            lblDuAn.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDuAn.Location = new Point(48, 5);
            lblDuAn.Name = "lblDuAn";
            lblDuAn.Size = new Size(139, 25);
            lblDuAn.TabIndex = 0;
            lblDuAn.Text = "Dự án";
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
            // pnl_Dashboard
            // 
            pnl_Dashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_Dashboard.BackColor = Color.White;
            pnl_Dashboard.BorderRadius = 20;
            pnl_Dashboard.Controls.Add(pnl_TopDashboard);
            pnl_Dashboard.Controls.Add(roundedPanel2);
            pnl_Dashboard.Location = new Point(289, 137);
            pnl_Dashboard.Name = "pnl_Dashboard";
            pnl_Dashboard.Size = new Size(1054, 640);
            pnl_Dashboard.TabIndex = 7;
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
            // pnl_HoSoCaNhan
            // 
            pnl_HoSoCaNhan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_HoSoCaNhan.BackColor = Color.White;
            pnl_HoSoCaNhan.BorderRadius = 20;
            pnl_HoSoCaNhan.Controls.Add(pnl_TopHoSo);
            pnl_HoSoCaNhan.Controls.Add(roundedPanel4);
            pnl_HoSoCaNhan.Location = new Point(289, 137);
            pnl_HoSoCaNhan.Name = "pnl_HoSoCaNhan";
            pnl_HoSoCaNhan.Size = new Size(1054, 640);
            pnl_HoSoCaNhan.TabIndex = 8;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 228, 245);
            ClientSize = new Size(1366, 800);
            Controls.Add(pnlSideBar_HR);
            Controls.Add(pnlWelcomeBar);
            Controls.Add(pnlFormBar);
            Controls.Add(pnl_Dashboard);
            Controls.Add(pnl_HoSoCaNhan);
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
            ((System.ComponentModel.ISupportInitialize)icoSystemManage).EndInit();
            ((System.ComponentModel.ISupportInitialize)icoNotifications).EndInit();
            pnlScheduleButton.ResumeLayout(false);
            pnlScheduleButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSchedule).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAva2).EndInit();
            pnlSideBar_HR.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            pnlLogout.ResumeLayout(false);
            pnlLogout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconLogout).EndInit();
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
            pnlDuAn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoDuAn).EndInit();
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
            pnl_Dashboard.ResumeLayout(false);
            pnl_TopDashboard.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnl_HoSoCaNhan.ResumeLayout(false);
            pnl_TopHoSo.ResumeLayout(false);
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label lblUserGmail;
        private Label lblUserName1;
        private Label lblLogout;
        private Scripts.MakeupScripts.RoundedPanel pnlLogout;
        private PictureBox picIconLogout;
        private GroupBox grbMainMenu;
        private Scripts.MakeupScripts.RoundedPanel pnlScheduleButton;
        private Label lblLichTrinh;
        private PictureBox picSchedule;
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
        private Scripts.MakeupScripts.RoundedPanel pnl_Dashboard;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel2;
        private PictureBox pictureBox3;
        private Label label5;
        private PictureBox icoNotifications;
        private Panel pnlHopDong;
        private PictureBox icoHopDong;
        private Label lblHopDong;
        private Scripts.MakeupScripts.RoundedPanel pnl_TopDashboard;
        private Label lbl_Dashboarđ;
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
        private PictureBox icoSystemManage;
        private Scripts.MakeupScripts.RoundedPanel pnl_HoSoCaNhan;
        private Scripts.MakeupScripts.RoundedPanel pnl_TopHoSo;
        private Label lbl_TitleHoSo;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel4;
        private PictureBox pictureBox1;
        private Label label2;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel1;
    }
}
