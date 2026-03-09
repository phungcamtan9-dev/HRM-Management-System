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
            label1 = new Label();
            btnHide = new Button();
            btnclose = new Button();
            lblSystemName = new Label();
            pnlWelcomeBar = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            pnlScheduleButton = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            picSchedule = new PictureBox();
            btnSchedule = new Label();
            picAva2 = new HyperionHR_meta.Scripts.UI.CirclePictureBox();
            lblDateTime = new Label();
            lblWelcome = new Label();
            pnlSideBar = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            grbMainMenu = new GroupBox();
            picAva1 = new HyperionHR_meta.Scripts.UI.CirclePictureBox();
            pnlLogout = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            picIconLogout = new PictureBox();
            lblLogout = new Label();
            lblUserName1 = new Label();
            lblUserGmail = new Label();
            picLogo = new PictureBox();
            pnlFormBar.SuspendLayout();
            pnlWelcomeBar.SuspendLayout();
            pnlScheduleButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSchedule).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAva2).BeginInit();
            pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAva1).BeginInit();
            pnlLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
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
            pnlWelcomeBar.Controls.Add(pnlScheduleButton);
            pnlWelcomeBar.Controls.Add(picAva2);
            pnlWelcomeBar.Controls.Add(lblDateTime);
            pnlWelcomeBar.Controls.Add(lblWelcome);
            pnlWelcomeBar.Location = new Point(289, 41);
            pnlWelcomeBar.Name = "pnlWelcomeBar";
            pnlWelcomeBar.Size = new Size(1054, 90);
            pnlWelcomeBar.TabIndex = 2;
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
            btnSchedule.Size = new Size(107, 30);
            btnSchedule.TabIndex = 0;
            btnSchedule.Text = "Schedule";
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
            // pnlSideBar
            // 
            pnlSideBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlSideBar.BackColor = Color.White;
            pnlSideBar.BorderRadius = 20;
            pnlSideBar.Controls.Add(grbMainMenu);
            pnlSideBar.Controls.Add(picAva1);
            pnlSideBar.Controls.Add(pnlLogout);
            pnlSideBar.Controls.Add(lblUserName1);
            pnlSideBar.Controls.Add(lblSystemName);
            pnlSideBar.Controls.Add(lblUserGmail);
            pnlSideBar.Location = new Point(25, 41);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(240, 736);
            pnlSideBar.TabIndex = 3;
            // 
            // grbMainMenu
            // 
            grbMainMenu.Font = new Font("Inter", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbMainMenu.Location = new Point(25, 96);
            grbMainMenu.Name = "grbMainMenu";
            grbMainMenu.Size = new Size(191, 125);
            grbMainMenu.TabIndex = 12;
            grbMainMenu.TabStop = false;
            grbMainMenu.Text = "Main Menu";
            // 
            // picAva1
            // 
            picAva1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            picAva1.Image = Properties.Resources.picAva;
            picAva1.Location = new Point(25, 670);
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
            pnlLogout.Location = new Point(68, 673);
            pnlLogout.Name = "pnlLogout";
            pnlLogout.Size = new Size(103, 30);
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
            lblLogout.Size = new Size(51, 18);
            lblLogout.TabIndex = 10;
            lblLogout.Text = "Logout";
            lblLogout.TextAlign = ContentAlignment.MiddleLeft;
            lblLogout.Click += lblLogout_Click;
            // 
            // lblUserName1
            // 
            lblUserName1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUserName1.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName1.Location = new Point(68, 665);
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
            lblUserGmail.Location = new Point(68, 690);
            lblUserGmail.Name = "lblUserGmail";
            lblUserGmail.Size = new Size(144, 24);
            lblUserGmail.TabIndex = 7;
            lblUserGmail.Text = "admin";
            // 
            // picLogo
            // 
            picLogo.Location = new Point(3, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(29, 27);
            picLogo.TabIndex = 3;
            picLogo.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 228, 245);
            ClientSize = new Size(1366, 800);
            Controls.Add(pnlSideBar);
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
            pnlWelcomeBar.ResumeLayout(false);
            pnlScheduleButton.ResumeLayout(false);
            pnlScheduleButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSchedule).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAva2).EndInit();
            pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAva1).EndInit();
            pnlLogout.ResumeLayout(false);
            pnlLogout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
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
        private Scripts.MakeupScripts.RoundedPanel pnlSideBar;
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
    }
}
