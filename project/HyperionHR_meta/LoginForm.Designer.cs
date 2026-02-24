using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace HyperionHR_meta
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        /// <summary>
        /// Makeup Form:33
        /// </summary>
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] // bo gốc
        private static extern IntPtr CreateRoundRectRgn(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse);

        /// <summary>
        /// Kéo form
        /// </summary>
        [DllImport("user32.DLL")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLogin = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            label1 = new Label();
            btnLogin = new Button();
            lblForgotPassword = new Label();
            pnlPassword = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            picShowpass = new PictureBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            pnlEmail = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblLoginTittle1 = new Label();
            btnclose = new Button();
            pnlImage = new HyperionHR_meta.Scripts.MakeupScripts.RoundedPanel();
            imageLogin = new PictureBox();
            btnHide = new Button();
            pnlLogin.SuspendLayout();
            pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picShowpass).BeginInit();
            pnlEmail.SuspendLayout();
            pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageLogin).BeginInit();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.BorderRadius = 20;
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(lblForgotPassword);
            pnlLogin.Controls.Add(pnlPassword);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(pnlEmail);
            pnlLogin.Controls.Add(lblEmail);
            pnlLogin.Controls.Add(lblLoginTittle1);
            pnlLogin.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlLogin.Location = new Point(520, 26);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(480, 550);
            pnlLogin.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Inter Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(143, 162, 181);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(87, 513);
            label1.Name = "label1";
            label1.Size = new Size(302, 22);
            label1.TabIndex = 5;
            label1.Text = "\"Secure access powered by HyperionHR\"";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(131, 186, 255);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Inter Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(191, 391);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(95, 45);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.Font = new Font("Inter Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblForgotPassword.ImageAlign = ContentAlignment.MiddleRight;
            lblForgotPassword.Location = new Point(68, 347);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(138, 22);
            lblForgotPassword.TabIndex = 3;
            lblForgotPassword.Text = "Forgot password ?";
            lblForgotPassword.TextAlign = ContentAlignment.MiddleLeft;
            lblForgotPassword.Click += lblForgotPassword_Click;
            // 
            // pnlPassword
            // 
            pnlPassword.BackColor = Color.FromArgb(216, 228, 245);
            pnlPassword.BorderRadius = 20;
            pnlPassword.Controls.Add(picShowpass);
            pnlPassword.Controls.Add(txtPassword);
            pnlPassword.Location = new Point(68, 299);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Padding = new Padding(10);
            pnlPassword.Size = new Size(340, 45);
            pnlPassword.TabIndex = 1;
            // 
            // picShowpass
            // 
            picShowpass.Anchor = AnchorStyles.Right;
            picShowpass.Image = Properties.Resources.picShowpass;
            picShowpass.Location = new Point(301, 8);
            picShowpass.Name = "picShowpass";
            picShowpass.Size = new Size(30, 30);
            picShowpass.SizeMode = PictureBoxSizeMode.StretchImage;
            picShowpass.TabIndex = 5;
            picShowpass.TabStop = false;
            picShowpass.Click += picShowpass_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(216, 228, 245);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(10, 10);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(320, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ImageAlign = ContentAlignment.MiddleRight;
            lblPassword.Location = new Point(68, 264);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(122, 30);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password:";
            lblPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlEmail
            // 
            pnlEmail.BackColor = Color.FromArgb(216, 228, 245);
            pnlEmail.BorderRadius = 20;
            pnlEmail.Controls.Add(txtEmail);
            pnlEmail.Location = new Point(68, 216);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.Padding = new Padding(10);
            pnlEmail.Size = new Size(340, 45);
            pnlEmail.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BackColor = Color.FromArgb(216, 228, 245);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(11, 11);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 23);
            txtEmail.TabIndex = 0;
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ImageAlign = ContentAlignment.MiddleRight;
            lblEmail.Location = new Point(68, 181);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(74, 30);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLoginTittle1
            // 
            lblLoginTittle1.AutoSize = true;
            lblLoginTittle1.Font = new Font("Inter", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginTittle1.Location = new Point(68, 125);
            lblLoginTittle1.Name = "lblLoginTittle1";
            lblLoginTittle1.Size = new Size(90, 39);
            lblLoginTittle1.TabIndex = 0;
            lblLoginTittle1.Text = "Login";
            lblLoginTittle1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.Transparent;
            btnclose.FlatAppearance.BorderSize = 0;
            btnclose.FlatStyle = FlatStyle.Flat;
            btnclose.Font = new Font("Inter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose.Location = new Point(934, 0);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(40, 25);
            btnclose.TabIndex = 0;
            btnclose.Text = "x";
            btnclose.TextAlign = ContentAlignment.TopCenter;
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click_1;
            // 
            // pnlImage
            // 
            pnlImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlImage.BackColor = Color.Transparent;
            pnlImage.BorderRadius = 20;
            pnlImage.Controls.Add(imageLogin);
            pnlImage.Location = new Point(0, 0);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(530, 600);
            pnlImage.TabIndex = 1;
            // 
            // imageLogin
            // 
            imageLogin.Dock = DockStyle.Fill;
            imageLogin.Image = Properties.Resources.picLogin;
            imageLogin.Location = new Point(0, 0);
            imageLogin.Name = "imageLogin";
            imageLogin.Size = new Size(530, 600);
            imageLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            imageLogin.TabIndex = 0;
            imageLogin.TabStop = false;
            // 
            // btnHide
            // 
            btnHide.BackColor = Color.Transparent;
            btnHide.FlatAppearance.BorderSize = 0;
            btnHide.FlatStyle = FlatStyle.Flat;
            btnHide.Font = new Font("Inter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHide.Location = new Point(891, 0);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(40, 25);
            btnHide.TabIndex = 0;
            btnHide.Text = "-";
            btnHide.TextAlign = ContentAlignment.TopCenter;
            btnHide.UseVisualStyleBackColor = false;
            btnHide.Click += btnHide_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 228, 245);
            ClientSize = new Size(1000, 600);
            Controls.Add(btnHide);
            Controls.Add(btnclose);
            Controls.Add(pnlImage);
            Controls.Add(pnlLogin);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginForm_Load;
            MouseDown += LoginForm_MouseDown;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picShowpass).EndInit();
            pnlEmail.ResumeLayout(false);
            pnlEmail.PerformLayout();
            pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imageLogin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Scripts.MakeupScripts.RoundedPanel pnlLogin;
        private Scripts.MakeupScripts.RoundedPanel pnlImage;
        private PictureBox imageLogin;
        private Button btnclose;
        private Button btnHide;
        private Label lblLoginTittle1;
        private Label lblEmail;
        private Scripts.MakeupScripts.RoundedPanel pnlEmail;
        private TextBox txtEmail;
        private Scripts.MakeupScripts.RoundedPanel pnlPassword;
        private TextBox txtPassword;
        private Label lblPassword;
        private PictureBox picShowpass;
        private Label lblForgotPassword;
        private Button btnLogin;
        private Label label1;
    }
}