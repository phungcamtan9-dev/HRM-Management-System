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
            pnlMenuBar = new Panel();
            lblSupport = new Label();
            lblSetting = new Label();
            iConSupport = new PictureBox();
            iConSetting = new PictureBox();
            grbPayroll_Fiance = new GroupBox();
            iConSalaryStructure = new PictureBox();
            iConPayroll = new PictureBox();
            lblSalaryStructure = new Label();
            lblPayroll = new Label();
            grbManagement = new GroupBox();
            iConContracts = new PictureBox();
            iconDepartments = new PictureBox();
            lblContracts = new Label();
            iConEmployees = new PictureBox();
            lblDepartments = new Label();
            lblEmployees = new Label();
            grbOverviewMenu = new GroupBox();
            iConReport = new PictureBox();
            iConDashBoard = new PictureBox();
            lblReport = new Label();
            lblDashboard = new Label();
            lblMenuTittle = new Label();
            pnlTopBar = new Panel();
            picUserAvatar = new PictureBox();
            lblWelcome = new Label();
            cardTotalEmployees = new Panel();
            cardDepartments = new Panel();
            pnlMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iConSupport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iConSetting).BeginInit();
            grbPayroll_Fiance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iConSalaryStructure).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iConPayroll).BeginInit();
            grbManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iConContracts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconDepartments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iConEmployees).BeginInit();
            grbOverviewMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iConReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iConDashBoard).BeginInit();
            pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUserAvatar).BeginInit();
            SuspendLayout();
            // 
            // pnlMenuBar
            // 
            pnlMenuBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlMenuBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlMenuBar.BackColor = Color.FromArgb(121, 152, 81);
            pnlMenuBar.Controls.Add(lblSupport);
            pnlMenuBar.Controls.Add(lblSetting);
            pnlMenuBar.Controls.Add(iConSupport);
            pnlMenuBar.Controls.Add(iConSetting);
            pnlMenuBar.Controls.Add(grbPayroll_Fiance);
            pnlMenuBar.Controls.Add(grbManagement);
            pnlMenuBar.Controls.Add(grbOverviewMenu);
            pnlMenuBar.Controls.Add(lblMenuTittle);
            pnlMenuBar.Location = new Point(10, 9);
            pnlMenuBar.Margin = new Padding(3, 2, 3, 2);
            pnlMenuBar.Name = "pnlMenuBar";
            pnlMenuBar.Size = new Size(219, 743);
            pnlMenuBar.TabIndex = 0;
            // 
            // lblSupport
            // 
            lblSupport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSupport.AutoSize = true;
            lblSupport.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupport.ForeColor = Color.White;
            lblSupport.Location = new Point(62, 712);
            lblSupport.Name = "lblSupport";
            lblSupport.Size = new Size(70, 23);
            lblSupport.TabIndex = 8;
            lblSupport.Text = "Support";
            lblSupport.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSetting
            // 
            lblSetting.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSetting.AutoSize = true;
            lblSetting.Font = new Font("Inter", 12F);
            lblSetting.ForeColor = Color.White;
            lblSetting.Location = new Point(62, 681);
            lblSetting.Name = "lblSetting";
            lblSetting.Size = new Size(62, 23);
            lblSetting.TabIndex = 6;
            lblSetting.Text = "Setting";
            lblSetting.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iConSupport
            // 
            iConSupport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iConSupport.Location = new Point(32, 712);
            iConSupport.Margin = new Padding(3, 2, 3, 2);
            iConSupport.Name = "iConSupport";
            iConSupport.Size = new Size(25, 22);
            iConSupport.SizeMode = PictureBoxSizeMode.StretchImage;
            iConSupport.TabIndex = 7;
            iConSupport.TabStop = false;
            // 
            // iConSetting
            // 
            iConSetting.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iConSetting.Location = new Point(32, 680);
            iConSetting.Margin = new Padding(3, 2, 3, 2);
            iConSetting.Name = "iConSetting";
            iConSetting.Size = new Size(25, 22);
            iConSetting.SizeMode = PictureBoxSizeMode.StretchImage;
            iConSetting.TabIndex = 6;
            iConSetting.TabStop = false;
            // 
            // grbPayroll_Fiance
            // 
            grbPayroll_Fiance.BackColor = Color.Transparent;
            grbPayroll_Fiance.Controls.Add(iConSalaryStructure);
            grbPayroll_Fiance.Controls.Add(iConPayroll);
            grbPayroll_Fiance.Controls.Add(lblSalaryStructure);
            grbPayroll_Fiance.Controls.Add(lblPayroll);
            grbPayroll_Fiance.Font = new Font("Inter Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbPayroll_Fiance.ForeColor = Color.White;
            grbPayroll_Fiance.Location = new Point(4, 342);
            grbPayroll_Fiance.Margin = new Padding(3, 2, 3, 2);
            grbPayroll_Fiance.Name = "grbPayroll_Fiance";
            grbPayroll_Fiance.Padding = new Padding(3, 2, 3, 2);
            grbPayroll_Fiance.Size = new Size(210, 100);
            grbPayroll_Fiance.TabIndex = 2;
            grbPayroll_Fiance.TabStop = false;
            grbPayroll_Fiance.Text = "Payroll_Fianace";
            // 
            // iConSalaryStructure
            // 
            iConSalaryStructure.Location = new Point(27, 67);
            iConSalaryStructure.Margin = new Padding(3, 2, 3, 2);
            iConSalaryStructure.Name = "iConSalaryStructure";
            iConSalaryStructure.Size = new Size(25, 22);
            iConSalaryStructure.SizeMode = PictureBoxSizeMode.StretchImage;
            iConSalaryStructure.TabIndex = 5;
            iConSalaryStructure.TabStop = false;
            // 
            // iConPayroll
            // 
            iConPayroll.Location = new Point(27, 35);
            iConPayroll.Margin = new Padding(3, 2, 3, 2);
            iConPayroll.Name = "iConPayroll";
            iConPayroll.Size = new Size(25, 22);
            iConPayroll.SizeMode = PictureBoxSizeMode.StretchImage;
            iConPayroll.TabIndex = 4;
            iConPayroll.TabStop = false;
            // 
            // lblSalaryStructure
            // 
            lblSalaryStructure.AutoSize = true;
            lblSalaryStructure.Font = new Font("Inter", 12F);
            lblSalaryStructure.Location = new Point(58, 68);
            lblSalaryStructure.Name = "lblSalaryStructure";
            lblSalaryStructure.Size = new Size(130, 23);
            lblSalaryStructure.TabIndex = 1;
            lblSalaryStructure.Text = "Salary Structure";
            lblSalaryStructure.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPayroll
            // 
            lblPayroll.AutoSize = true;
            lblPayroll.Font = new Font("Inter", 12F);
            lblPayroll.Location = new Point(58, 35);
            lblPayroll.Name = "lblPayroll";
            lblPayroll.Size = new Size(62, 23);
            lblPayroll.TabIndex = 0;
            lblPayroll.Text = "Payroll";
            lblPayroll.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grbManagement
            // 
            grbManagement.BackColor = Color.Transparent;
            grbManagement.Controls.Add(iConContracts);
            grbManagement.Controls.Add(iconDepartments);
            grbManagement.Controls.Add(lblContracts);
            grbManagement.Controls.Add(iConEmployees);
            grbManagement.Controls.Add(lblDepartments);
            grbManagement.Controls.Add(lblEmployees);
            grbManagement.Font = new Font("Inter Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbManagement.ForeColor = Color.White;
            grbManagement.Location = new Point(4, 184);
            grbManagement.Margin = new Padding(3, 2, 3, 2);
            grbManagement.Name = "grbManagement";
            grbManagement.Padding = new Padding(3, 2, 3, 2);
            grbManagement.Size = new Size(210, 138);
            grbManagement.TabIndex = 2;
            grbManagement.TabStop = false;
            grbManagement.Text = "Management";
            // 
            // iConContracts
            // 
            iConContracts.Location = new Point(27, 100);
            iConContracts.Margin = new Padding(3, 2, 3, 2);
            iConContracts.Name = "iConContracts";
            iConContracts.Size = new Size(25, 22);
            iConContracts.SizeMode = PictureBoxSizeMode.StretchImage;
            iConContracts.TabIndex = 6;
            iConContracts.TabStop = false;
            // 
            // iconDepartments
            // 
            iconDepartments.Location = new Point(27, 68);
            iconDepartments.Margin = new Padding(3, 2, 3, 2);
            iconDepartments.Name = "iconDepartments";
            iconDepartments.Size = new Size(25, 22);
            iconDepartments.SizeMode = PictureBoxSizeMode.StretchImage;
            iconDepartments.TabIndex = 5;
            iconDepartments.TabStop = false;
            // 
            // lblContracts
            // 
            lblContracts.AutoSize = true;
            lblContracts.Font = new Font("Inter", 12F);
            lblContracts.Location = new Point(58, 100);
            lblContracts.Name = "lblContracts";
            lblContracts.Size = new Size(83, 23);
            lblContracts.TabIndex = 2;
            lblContracts.Text = "Contracts";
            lblContracts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iConEmployees
            // 
            iConEmployees.Location = new Point(27, 34);
            iConEmployees.Margin = new Padding(3, 2, 3, 2);
            iConEmployees.Name = "iConEmployees";
            iConEmployees.Size = new Size(25, 22);
            iConEmployees.SizeMode = PictureBoxSizeMode.StretchImage;
            iConEmployees.TabIndex = 4;
            iConEmployees.TabStop = false;
            // 
            // lblDepartments
            // 
            lblDepartments.AutoSize = true;
            lblDepartments.Font = new Font("Inter", 12F);
            lblDepartments.Location = new Point(58, 68);
            lblDepartments.Name = "lblDepartments";
            lblDepartments.Size = new Size(106, 23);
            lblDepartments.TabIndex = 1;
            lblDepartments.Text = "Departments";
            lblDepartments.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmployees
            // 
            lblEmployees.AutoSize = true;
            lblEmployees.Font = new Font("Inter", 12F);
            lblEmployees.Location = new Point(58, 35);
            lblEmployees.Name = "lblEmployees";
            lblEmployees.Size = new Size(93, 23);
            lblEmployees.TabIndex = 0;
            lblEmployees.Text = "Employees";
            lblEmployees.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grbOverviewMenu
            // 
            grbOverviewMenu.BackColor = Color.Transparent;
            grbOverviewMenu.Controls.Add(iConReport);
            grbOverviewMenu.Controls.Add(iConDashBoard);
            grbOverviewMenu.Controls.Add(lblReport);
            grbOverviewMenu.Controls.Add(lblDashboard);
            grbOverviewMenu.Font = new Font("Inter Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbOverviewMenu.ForeColor = Color.White;
            grbOverviewMenu.Location = new Point(4, 64);
            grbOverviewMenu.Margin = new Padding(3, 2, 3, 2);
            grbOverviewMenu.Name = "grbOverviewMenu";
            grbOverviewMenu.Padding = new Padding(3, 2, 3, 2);
            grbOverviewMenu.Size = new Size(210, 100);
            grbOverviewMenu.TabIndex = 1;
            grbOverviewMenu.TabStop = false;
            grbOverviewMenu.Text = "Overview";
            // 
            // iConReport
            // 
            iConReport.Location = new Point(27, 67);
            iConReport.Margin = new Padding(3, 2, 3, 2);
            iConReport.Name = "iConReport";
            iConReport.Size = new Size(25, 22);
            iConReport.SizeMode = PictureBoxSizeMode.StretchImage;
            iConReport.TabIndex = 3;
            iConReport.TabStop = false;
            // 
            // iConDashBoard
            // 
            iConDashBoard.Location = new Point(27, 35);
            iConDashBoard.Margin = new Padding(3, 2, 3, 2);
            iConDashBoard.Name = "iConDashBoard";
            iConDashBoard.Size = new Size(25, 22);
            iConDashBoard.SizeMode = PictureBoxSizeMode.StretchImage;
            iConDashBoard.TabIndex = 2;
            iConDashBoard.TabStop = false;
            // 
            // lblReport
            // 
            lblReport.AutoSize = true;
            lblReport.Font = new Font("Inter", 12F);
            lblReport.Location = new Point(58, 68);
            lblReport.Name = "lblReport";
            lblReport.Size = new Size(60, 23);
            lblReport.TabIndex = 1;
            lblReport.Text = "Report";
            lblReport.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Inter", 12F);
            lblDashboard.Location = new Point(58, 35);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(93, 23);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Dashboard";
            lblDashboard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMenuTittle
            // 
            lblMenuTittle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMenuTittle.Font = new Font("Inter SemiBold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuTittle.Location = new Point(0, 3);
            lblMenuTittle.Name = "lblMenuTittle";
            lblMenuTittle.Size = new Size(219, 42);
            lblMenuTittle.TabIndex = 0;
            lblMenuTittle.Text = "HyperionHR";
            lblMenuTittle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTopBar
            // 
            pnlTopBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Controls.Add(picUserAvatar);
            pnlTopBar.Controls.Add(lblWelcome);
            pnlTopBar.Location = new Point(234, 9);
            pnlTopBar.Margin = new Padding(3, 2, 3, 2);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1104, 45);
            pnlTopBar.TabIndex = 1;
            // 
            // picUserAvatar
            // 
            picUserAvatar.Location = new Point(868, 4);
            picUserAvatar.Margin = new Padding(3, 2, 3, 2);
            picUserAvatar.Name = "picUserAvatar";
            picUserAvatar.Size = new Size(44, 38);
            picUserAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picUserAvatar.TabIndex = 4;
            picUserAvatar.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(10, 13);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(132, 23);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome back, ";
            // 
            // cardTotalEmployees
            // 
            cardTotalEmployees.BackColor = Color.White;
            cardTotalEmployees.Location = new Point(234, 68);
            cardTotalEmployees.Margin = new Padding(3, 2, 3, 2);
            cardTotalEmployees.Name = "cardTotalEmployees";
            cardTotalEmployees.Size = new Size(219, 94);
            cardTotalEmployees.TabIndex = 2;
            // 
            // cardDepartments
            // 
            cardDepartments.BackColor = Color.White;
            cardDepartments.Location = new Point(473, 68);
            cardDepartments.Margin = new Padding(3, 2, 3, 2);
            cardDepartments.Name = "cardDepartments";
            cardDepartments.Size = new Size(219, 94);
            cardDepartments.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 221, 209);
            ClientSize = new Size(1350, 761);
            Controls.Add(cardDepartments);
            Controls.Add(cardTotalEmployees);
            Controls.Add(pnlTopBar);
            Controls.Add(pnlMenuBar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HyperionHR";
            WindowState = FormWindowState.Maximized;
            pnlMenuBar.ResumeLayout(false);
            pnlMenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iConSupport).EndInit();
            ((System.ComponentModel.ISupportInitialize)iConSetting).EndInit();
            grbPayroll_Fiance.ResumeLayout(false);
            grbPayroll_Fiance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iConSalaryStructure).EndInit();
            ((System.ComponentModel.ISupportInitialize)iConPayroll).EndInit();
            grbManagement.ResumeLayout(false);
            grbManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iConContracts).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconDepartments).EndInit();
            ((System.ComponentModel.ISupportInitialize)iConEmployees).EndInit();
            grbOverviewMenu.ResumeLayout(false);
            grbOverviewMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iConReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)iConDashBoard).EndInit();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUserAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenuBar;
        private Label lblMenuTittle;
        private GroupBox grbOverviewMenu;
        private GroupBox grbManagement;
        private Label lblDepartments;
        private Label lblEmployees;
        private Label lblReport;
        private Label lblDashboard;
        private GroupBox grbPayroll_Fiance;
        private Label lblSalaryStructure;
        private Label lblPayroll;
        private Label lblContracts;
        private PictureBox iConSalaryStructure;
        private PictureBox iConPayroll;
        private PictureBox iconDepartments;
        private PictureBox iConEmployees;
        private PictureBox iConReport;
        private PictureBox iConDashBoard;
        private PictureBox iConContracts;
        private Label lblSupport;
        private Label lblSetting;
        private PictureBox iConSupport;
        private PictureBox iConSetting;
        private Panel pnlTopBar;
        private PictureBox picUserAvatar;
        private Label lblWelcome;
        private Panel cardTotalEmployees;
        private Panel cardDepartments;
    }
}
