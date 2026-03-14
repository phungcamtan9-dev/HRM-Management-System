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
            label1 = new Label();
            btnHide = new Button();
            btnclose = new Button();
            lblSystemName = new Label();
            pnlWelcomeBar = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            icoNotifications = new PictureBox();
            pnlScheduleButton = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            picSchedule = new PictureBox();
            btnSchedule = new Label();
            picAva2 = new HyperionHR_meta.Scripts.UI.CirclePictureBox();
            lblDateTime = new Label();
            lblWelcome = new Label();
            pnlSideBar_HR = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pnlHoTro = new Panel();
            icoHoTro = new PictureBox();
            lblHoTro = new Label();
            pnlCaiDat = new Panel();
            icoCaiDat = new PictureBox();
            lblCaiDat = new Label();
            grbChucNang = new GroupBox();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            grbMainMenu = new GroupBox();
            pnlOrganization = new Panel();
            icoOrganization = new PictureBox();
            label3 = new Label();
            pnlDashboard = new Panel();
            icoDashBoard = new PictureBox();
            lblDashboard = new Label();
            picAva1 = new HyperionHR_meta.Scripts.UI.CirclePictureBox();
            pnlLogout = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            picIconLogout = new PictureBox();
            lblLogout = new Label();
            lblUserName1 = new Label();
            lblUserGmail = new Label();
            pnl_Dashboard = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pnl_TopDashboard = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            label7 = new Label();
            roundedPanel2 = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            pnlFormBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlWelcomeBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoNotifications).BeginInit();
            pnlScheduleButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSchedule).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAva2).BeginInit();
            pnlSideBar_HR.SuspendLayout();
            pnlHoTro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoHoTro).BeginInit();
            pnlCaiDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoCaiDat).BeginInit();
            grbChucNang.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            grbMainMenu.SuspendLayout();
            pnlOrganization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoOrganization).BeginInit();
            pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icoDashBoard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAva1).BeginInit();
            pnlLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconLogout).BeginInit();
            pnl_Dashboard.SuspendLayout();
            pnl_TopDashboard.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pnlFormBar
            // 
            pnlFormBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlFormBar.BackColor = Color.FromArgb(173, 220, 255);
            pnlFormBar.Controls.Add(picLogo);
            pnlFormBar.Controls.Add(label1);
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
            // label1
            // 
            label1.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 4);
            label1.Name = "label1";
            label1.Size = new Size(383, 27);
            label1.TabIndex = 2;
            label1.Text = "HyperionHR_meta";
            label1.TextAlign = ContentAlignment.MiddleLeft;
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
            pnlScheduleButton.Controls.Add(btnSchedule);
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
            // btnSchedule
            // 
            btnSchedule.AutoSize = true;
            btnSchedule.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSchedule.Location = new Point(59, 17);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(112, 30);
            btnSchedule.TabIndex = 0;
            btnSchedule.Text = "Lịch Trình";
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
            pnlSideBar_HR.Controls.Add(pnlHoTro);
            pnlSideBar_HR.Controls.Add(pnlCaiDat);
            pnlSideBar_HR.Controls.Add(grbChucNang);
            pnlSideBar_HR.Controls.Add(grbMainMenu);
            pnlSideBar_HR.Controls.Add(picAva1);
            pnlSideBar_HR.Controls.Add(pnlLogout);
            pnlSideBar_HR.Controls.Add(lblUserName1);
            pnlSideBar_HR.Controls.Add(lblSystemName);
            pnlSideBar_HR.Controls.Add(lblUserGmail);
            pnlSideBar_HR.Location = new Point(25, 41);
            pnlSideBar_HR.Name = "pnlSideBar_HR";
            pnlSideBar_HR.Size = new Size(240, 736);
            pnlSideBar_HR.TabIndex = 3;
            // 
            // pnlHoTro
            // 
            pnlHoTro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlHoTro.Controls.Add(icoHoTro);
            pnlHoTro.Controls.Add(lblHoTro);
            pnlHoTro.Location = new Point(30, 597);
            pnlHoTro.Name = "pnlHoTro";
            pnlHoTro.Size = new Size(190, 35);
            pnlHoTro.TabIndex = 7;
            // 
            // icoHoTro
            // 
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
            pnlCaiDat.Location = new Point(30, 638);
            pnlCaiDat.Name = "pnlCaiDat";
            pnlCaiDat.Size = new Size(190, 35);
            pnlCaiDat.TabIndex = 6;
            // 
            // icoCaiDat
            // 
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
            grbChucNang.Controls.Add(panel3);
            grbChucNang.Controls.Add(panel1);
            grbChucNang.Controls.Add(panel2);
            grbChucNang.Font = new Font("Inter", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbChucNang.Location = new Point(18, 225);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(208, 353);
            grbChucNang.TabIndex = 13;
            grbChucNang.TabStop = false;
            grbChucNang.Text = "Chức năng";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(12, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 35);
            panel3.TabIndex = 6;
            // 
            // pictureBox4
            // 
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
            label6.Text = "Hợp đồng";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 35);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(10, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 5);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 0;
            label2.Text = "Tổ chức";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 35);
            panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(10, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 5);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 0;
            label4.Text = "Nhân sự";
            // 
            // grbMainMenu
            // 
            grbMainMenu.Controls.Add(pnlOrganization);
            grbMainMenu.Controls.Add(pnlDashboard);
            grbMainMenu.Font = new Font("Inter", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbMainMenu.Location = new Point(18, 96);
            grbMainMenu.Name = "grbMainMenu";
            grbMainMenu.Size = new Size(208, 123);
            grbMainMenu.TabIndex = 12;
            grbMainMenu.TabStop = false;
            grbMainMenu.Text = "Tổng quan";
            // 
            // pnlOrganization
            // 
            pnlOrganization.Controls.Add(icoOrganization);
            pnlOrganization.Controls.Add(label3);
            pnlOrganization.Location = new Point(12, 74);
            pnlOrganization.Name = "pnlOrganization";
            pnlOrganization.Size = new Size(190, 35);
            pnlOrganization.TabIndex = 5;
            // 
            // icoOrganization
            // 
            icoOrganization.Location = new Point(10, 5);
            icoOrganization.Name = "icoOrganization";
            icoOrganization.Size = new Size(25, 25);
            icoOrganization.SizeMode = PictureBoxSizeMode.StretchImage;
            icoOrganization.TabIndex = 1;
            icoOrganization.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Inter SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 5);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 0;
            label3.Text = "Hồ sơ cá nhân";
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
            // picAva1
            // 
            picAva1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            picAva1.Image = Properties.Resources.picAva;
            picAva1.Location = new Point(25, 681);
            picAva1.Name = "picAva1";
            picAva1.Size = new Size(36, 36);
            picAva1.SizeMode = PictureBoxSizeMode.Zoom;
            picAva1.TabIndex = 4;
            picAva1.TabStop = false;
            picAva1.Click += picAva1_Click;
            // 
            // pnlLogout
            // 
            pnlLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlLogout.BackColor = Color.FromArgb(173, 220, 255);
            pnlLogout.BorderRadius = 20;
            pnlLogout.Controls.Add(picIconLogout);
            pnlLogout.Controls.Add(lblLogout);
            pnlLogout.Location = new Point(147, 684);
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
            // lblUserName1
            // 
            lblUserName1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUserName1.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName1.Location = new Point(68, 676);
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
            lblUserGmail.Location = new Point(68, 701);
            lblUserGmail.Name = "lblUserGmail";
            lblUserGmail.Size = new Size(144, 24);
            lblUserGmail.TabIndex = 7;
            lblUserGmail.Text = "admin";
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
            pnl_TopDashboard.Controls.Add(label7);
            pnl_TopDashboard.Location = new Point(0, 0);
            pnl_TopDashboard.Name = "pnl_TopDashboard";
            pnl_TopDashboard.Size = new Size(1054, 41);
            pnl_TopDashboard.TabIndex = 7;
            // 
            // label7
            // 
            label7.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 9);
            label7.Name = "label7";
            label7.Size = new Size(139, 25);
            label7.TabIndex = 2;
            label7.Text = "Dashboard";
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 228, 245);
            ClientSize = new Size(1366, 800);
            Controls.Add(pnl_Dashboard);
            Controls.Add(pnlSideBar_HR);
            Controls.Add(pnlWelcomeBar);
            Controls.Add(pnlFormBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HyperionHR";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            pnlFormBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlWelcomeBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoNotifications).EndInit();
            pnlScheduleButton.ResumeLayout(false);
            pnlScheduleButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSchedule).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAva2).EndInit();
            pnlSideBar_HR.ResumeLayout(false);
            pnlHoTro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoHoTro).EndInit();
            pnlCaiDat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoCaiDat).EndInit();
            grbChucNang.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            grbMainMenu.ResumeLayout(false);
            pnlOrganization.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoOrganization).EndInit();
            pnlDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icoDashBoard).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAva1).EndInit();
            pnlLogout.ResumeLayout(false);
            pnlLogout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconLogout).EndInit();
            pnl_Dashboard.ResumeLayout(false);
            pnl_TopDashboard.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Label label1;
        private Scripts.UI.CirclePictureBox picAva1;
        private Scripts.UI.CirclePictureBox picAva2;
        private Label lblUserGmail;
        private Label lblUserName1;
        private Label lblLogout;
        private Scripts.MakeupScripts.RoundedPanel pnlLogout;
        private PictureBox picIconLogout;
        private GroupBox grbMainMenu;
        private Scripts.MakeupScripts.RoundedPanel pnlScheduleButton;
        private Label btnSchedule;
        private PictureBox picSchedule;
        private PictureBox picLogo;
        private Label lblDashboard;
        private Panel pnlDashboard;
        private Panel pnlOrganization;
        private PictureBox icoOrganization;
        private Label label3;
        private PictureBox icoDashBoard;
        private GroupBox grbChucNang;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label4;
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
        private Panel panel3;
        private PictureBox pictureBox4;
        private Label label6;
        private Scripts.MakeupScripts.RoundedPanel pnl_TopDashboard;
        private Label label7;
    }
}
