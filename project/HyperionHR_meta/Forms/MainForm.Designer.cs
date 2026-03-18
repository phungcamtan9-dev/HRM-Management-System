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
            icoBaoTriHeThong = new PictureBox();
            icoNotifications = new PictureBox();
            pnlScheduleButton = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            picSchedule = new PictureBox();
            lblLichTrinh = new Label();
            picAva2 = new HyperionHR_meta.Scripts.UI.CirclePictureBox();
            lblDateTime = new Label();
            lblWelcome = new Label();
            pnlSideBar_HR = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pnlBottomSideMenu = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pnlLogout = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            picIconLogout = new PictureBox();
            lblLogout = new Label();
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
            pnlSideBar_Employee = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pnlHoTro2 = new Panel();
            icoHoTro2 = new PictureBox();
            lblHoTro2 = new Label();
            pnlCaiDat2 = new Panel();
            icoCaiDat2 = new PictureBox();
            lblCaiDat2 = new Label();
            pnlBottomSideBar_Employee = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pnlLogOut2 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            lblLogOut2 = new Label();
            picLogOut2 = new PictureBox();
            label13 = new Label();
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
            pnlDuAn_Employee = new Panel();
            icoDuAn_Employee = new PictureBox();
            lblDuAn_Employee = new Label();
            pnlChamCong_Employee = new Panel();
            icoChamCong_2 = new PictureBox();
            lblChamCong_Employee = new Label();
            pnlHopDong_Employee = new Panel();
            icoHopDong2 = new PictureBox();
            lblHopDong_Employee = new Label();
            pnl_QuanLyNhanSu = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pnl_TopQLNhanSu = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            lbl_TittleQLNhanSu = new Label();
            roundedPanel7 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pictureBox6 = new PictureBox();
            label9 = new Label();
            pnlFormBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlWelcomeBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoBaoTriHeThong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icoNotifications).BeginInit();
            pnlScheduleButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSchedule).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAva2).BeginInit();
            pnlSideBar_HR.SuspendLayout();
            pnlBottomSideMenu.SuspendLayout();
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
            pnlSideBar_Employee.SuspendLayout();
            pnlHoTro2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoHoTro2).BeginInit();
            pnlCaiDat2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoCaiDat2).BeginInit();
            pnlBottomSideBar_Employee.SuspendLayout();
            pnlLogOut2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogOut2).BeginInit();
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
            pnlDuAn_Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoDuAn_Employee).BeginInit();
            pnlChamCong_Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoChamCong_2).BeginInit();
            pnlHopDong_Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoHopDong2).BeginInit();
            pnl_QuanLyNhanSu.SuspendLayout();
            pnl_TopQLNhanSu.SuspendLayout();
            roundedPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
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
            pnlWelcomeBar.Controls.Add(icoBaoTriHeThong);
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
            // icoBaoTriHeThong
            // 
            icoBaoTriHeThong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icoBaoTriHeThong.Image = (Image)resources.GetObject("icoBaoTriHeThong.Image");
            icoBaoTriHeThong.Location = new Point(726, 25);
            icoBaoTriHeThong.Name = "icoBaoTriHeThong";
            icoBaoTriHeThong.Size = new Size(43, 43);
            icoBaoTriHeThong.SizeMode = PictureBoxSizeMode.StretchImage;
            icoBaoTriHeThong.TabIndex = 7;
            icoBaoTriHeThong.TabStop = false;
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
            pnlBottomSideMenu.Controls.Add(pnlLogout);
            pnlBottomSideMenu.Controls.Add(picAva1);
            pnlBottomSideMenu.Controls.Add(lblUserName1);
            pnlBottomSideMenu.Controls.Add(lblUserGmail1);
            pnlBottomSideMenu.Location = new Point(0, 672);
            pnlBottomSideMenu.Name = "pnlBottomSideMenu";
            pnlBottomSideMenu.Size = new Size(240, 64);
            pnlBottomSideMenu.TabIndex = 14;
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
            // lblUserGmail1
            // 
            lblUserGmail1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUserGmail1.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserGmail1.ForeColor = SystemColors.ControlDarkDark;
            lblUserGmail1.Location = new Point(60, 29);
            lblUserGmail1.Name = "lblUserGmail1";
            lblUserGmail1.Size = new Size(144, 24);
            lblUserGmail1.TabIndex = 7;
            lblUserGmail1.Text = "admin";
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
            pnlBottomSideBar_Employee.Controls.Add(pnlLogOut2);
            pnlBottomSideBar_Employee.Controls.Add(picAva3);
            pnlBottomSideBar_Employee.Controls.Add(lblUserName2);
            pnlBottomSideBar_Employee.Controls.Add(lblUserGmail2);
            pnlBottomSideBar_Employee.Location = new Point(0, 672);
            pnlBottomSideBar_Employee.Name = "pnlBottomSideBar_Employee";
            pnlBottomSideBar_Employee.Size = new Size(240, 64);
            pnlBottomSideBar_Employee.TabIndex = 15;
            // 
            // pnlLogOut2
            // 
            pnlLogOut2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlLogOut2.BackColor = Color.FromArgb(173, 220, 255);
            pnlLogOut2.BorderRadius = 20;
            pnlLogOut2.Controls.Add(lblLogOut2);
            pnlLogOut2.Controls.Add(picLogOut2);
            pnlLogOut2.Controls.Add(label13);
            pnlLogOut2.Location = new Point(139, 17);
            pnlLogOut2.Name = "pnlLogOut2";
            pnlLogOut2.Size = new Size(90, 30);
            pnlLogOut2.TabIndex = 11;
            // 
            // lblLogOut2
            // 
            lblLogOut2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblLogOut2.AutoSize = true;
            lblLogOut2.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogOut2.Location = new Point(38, 7);
            lblLogOut2.Name = "lblLogOut2";
            lblLogOut2.Size = new Size(43, 18);
            lblLogOut2.TabIndex = 12;
            lblLogOut2.Text = "Thoát";
            lblLogOut2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picLogOut2
            // 
            picLogOut2.Image = Properties.Resources.picIconLogout;
            picLogOut2.Location = new Point(9, 7);
            picLogOut2.Name = "picLogOut2";
            picLogOut2.Size = new Size(25, 18);
            picLogOut2.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogOut2.TabIndex = 11;
            picLogOut2.TabStop = false;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(40, -64);
            label13.Name = "label13";
            label13.Size = new Size(43, 18);
            label13.TabIndex = 10;
            label13.Text = "Thoát";
            label13.TextAlign = ContentAlignment.MiddleLeft;
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
            lblUserGmail2.Text = "admin";
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
            grbChucNang_Employee.Controls.Add(pnlDuAn_Employee);
            grbChucNang_Employee.Controls.Add(pnlChamCong_Employee);
            grbChucNang_Employee.Controls.Add(pnlHopDong_Employee);
            grbChucNang_Employee.Font = new Font("Inter", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbChucNang_Employee.Location = new Point(18, 96);
            grbChucNang_Employee.Name = "grbChucNang_Employee";
            grbChucNang_Employee.Size = new Size(208, 298);
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
            // 
            // pnlDonXin_Employee
            // 
            pnlDonXin_Employee.Controls.Add(icoDonXin);
            pnlDonXin_Employee.Controls.Add(lblDonXin_Employee);
            pnlDonXin_Employee.Location = new Point(12, 123);
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
            // 
            // pnlLuong_Employee
            // 
            pnlLuong_Employee.Controls.Add(icoLuong2);
            pnlLuong_Employee.Controls.Add(lblLuong_Employee);
            pnlLuong_Employee.Location = new Point(12, 246);
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
            // 
            // pnlDuAn_Employee
            // 
            pnlDuAn_Employee.Controls.Add(icoDuAn_Employee);
            pnlDuAn_Employee.Controls.Add(lblDuAn_Employee);
            pnlDuAn_Employee.Location = new Point(12, 205);
            pnlDuAn_Employee.Name = "pnlDuAn_Employee";
            pnlDuAn_Employee.Size = new Size(190, 35);
            pnlDuAn_Employee.TabIndex = 8;
            // 
            // icoDuAn_Employee
            // 
            icoDuAn_Employee.Image = Properties.Resources.Screenshot_2026_03_16_132316;
            icoDuAn_Employee.Location = new Point(10, 5);
            icoDuAn_Employee.Name = "icoDuAn_Employee";
            icoDuAn_Employee.Size = new Size(25, 25);
            icoDuAn_Employee.SizeMode = PictureBoxSizeMode.StretchImage;
            icoDuAn_Employee.TabIndex = 1;
            icoDuAn_Employee.TabStop = false;
            // 
            // lblDuAn_Employee
            // 
            lblDuAn_Employee.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDuAn_Employee.Location = new Point(48, 5);
            lblDuAn_Employee.Name = "lblDuAn_Employee";
            lblDuAn_Employee.Size = new Size(139, 25);
            lblDuAn_Employee.TabIndex = 0;
            lblDuAn_Employee.Text = "Dự án";
            // 
            // pnlChamCong_Employee
            // 
            pnlChamCong_Employee.Controls.Add(icoChamCong_2);
            pnlChamCong_Employee.Controls.Add(lblChamCong_Employee);
            pnlChamCong_Employee.Location = new Point(12, 164);
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
            // 
            // pnlHopDong_Employee
            // 
            pnlHopDong_Employee.Controls.Add(icoHopDong2);
            pnlHopDong_Employee.Controls.Add(lblHopDong_Employee);
            pnlHopDong_Employee.Location = new Point(12, 82);
            pnlHopDong_Employee.Name = "pnlHopDong_Employee";
            pnlHopDong_Employee.Size = new Size(190, 35);
            pnlHopDong_Employee.TabIndex = 6;
            // 
            // icoHopDong2
            // 
            icoHopDong2.Image = Properties.Resources.Screenshot_2026_03_16_125040;
            icoHopDong2.Location = new Point(10, 5);
            icoHopDong2.Name = "icoHopDong2";
            icoHopDong2.Size = new Size(25, 25);
            icoHopDong2.SizeMode = PictureBoxSizeMode.StretchImage;
            icoHopDong2.TabIndex = 1;
            icoHopDong2.TabStop = false;
            // 
            // lblHopDong_Employee
            // 
            lblHopDong_Employee.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHopDong_Employee.Location = new Point(48, 5);
            lblHopDong_Employee.Name = "lblHopDong_Employee";
            lblHopDong_Employee.Size = new Size(139, 25);
            lblHopDong_Employee.TabIndex = 0;
            lblHopDong_Employee.Text = "Hợp đồng";
            // 
            // pnl_QuanLyNhanSu
            // 
            pnl_QuanLyNhanSu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_QuanLyNhanSu.BackColor = Color.White;
            pnl_QuanLyNhanSu.BorderRadius = 20;
            pnl_QuanLyNhanSu.Controls.Add(pnl_TopQLNhanSu);
            pnl_QuanLyNhanSu.Controls.Add(roundedPanel7);
            pnl_QuanLyNhanSu.Location = new Point(289, 137);
            pnl_QuanLyNhanSu.Name = "pnl_QuanLyNhanSu";
            pnl_QuanLyNhanSu.Size = new Size(1054, 640);
            pnl_QuanLyNhanSu.TabIndex = 9;
            // 
            // pnl_TopQLNhanSu
            // 
            pnl_TopQLNhanSu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnl_TopQLNhanSu.BackColor = Color.FromArgb(217, 229, 255);
            pnl_TopQLNhanSu.BorderRadius = 20;
            pnl_TopQLNhanSu.Controls.Add(lbl_TittleQLNhanSu);
            pnl_TopQLNhanSu.Location = new Point(0, 0);
            pnl_TopQLNhanSu.Name = "pnl_TopQLNhanSu";
            pnl_TopQLNhanSu.Size = new Size(2762, 41);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 228, 245);
            ClientSize = new Size(1366, 800);
            Controls.Add(pnlWelcomeBar);
            Controls.Add(pnlFormBar);
            Controls.Add(pnlSideBar_HR);
            Controls.Add(pnlSideBar_Employee);
            Controls.Add(pnl_QuanLyNhanSu);
            Controls.Add(pnl_HoSoCaNhan);
            Controls.Add(pnl_Dashboard);
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
            ((System.ComponentModel.ISupportInitialize)icoBaoTriHeThong).EndInit();
            ((System.ComponentModel.ISupportInitialize)icoNotifications).EndInit();
            pnlScheduleButton.ResumeLayout(false);
            pnlScheduleButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSchedule).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAva2).EndInit();
            pnlSideBar_HR.ResumeLayout(false);
            pnlBottomSideMenu.ResumeLayout(false);
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
            pnlSideBar_Employee.ResumeLayout(false);
            pnlHoTro2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoHoTro2).EndInit();
            pnlCaiDat2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoCaiDat2).EndInit();
            pnlBottomSideBar_Employee.ResumeLayout(false);
            pnlLogOut2.ResumeLayout(false);
            pnlLogOut2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogOut2).EndInit();
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
            pnlDuAn_Employee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoDuAn_Employee).EndInit();
            pnlChamCong_Employee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoChamCong_2).EndInit();
            pnlHopDong_Employee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoHopDong2).EndInit();
            pnl_QuanLyNhanSu.ResumeLayout(false);
            pnl_TopQLNhanSu.ResumeLayout(false);
            roundedPanel7.ResumeLayout(false);
            roundedPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
        private Panel pnlHopDong_Employee;
        private PictureBox icoHopDong2;
        private Label lblHopDong_Employee;
        private Panel pnlHoSoCaNhan_Employee;
        private PictureBox icoHoSoCaNhan2;
        private Label lblHoSoCaNhan_Employee;
        private Label lblSystemName2;
        private Scripts.MakeupScripts.RoundedPanel pnlBottomSideBar_Employee;
        private Scripts.MakeupScripts.RoundedPanel pnlLogOut2;
        private PictureBox picLogOut2;
        private Label label13;
        private Scripts.UI.CirclePictureBox picAva3;
        private Label lblUserName2;
        private Label lblUserGmail2;
        private Panel pnlHoTro2;
        private PictureBox icoHoTro2;
        private Label lblHoTro2;
        private Panel pnlCaiDat2;
        private PictureBox icoCaiDat2;
        private Label lblCaiDat2;
        private Label lblLogOut2;
        private Scripts.MakeupScripts.RoundedPanel pnl_QuanLyNhanSu;
        private Scripts.MakeupScripts.RoundedPanel pnl_TopQLNhanSu;
        private Label lbl_TittleQLNhanSu;
        private Scripts.MakeupScripts.RoundedPanel roundedPanel7;
        private PictureBox pictureBox6;
        private Label label9;
    }
}
