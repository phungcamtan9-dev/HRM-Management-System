using HyperionHR_meta.Scripts.Class.System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyperionHR_meta
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // chống giật
        }

        // ===========
        // Makeup Form
        // ===========
        private void LoginForm_Load(object sender, EventArgs e)
        {



            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25)); //Bo gốc
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e) // Kéo form
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        protected override CreateParams CreateParams //Shadow effect
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x00020000; // CS_DROPSHADOW
                return cp;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e) //Gradient
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                ColorTranslator.FromHtml("#9BC1FF"),
                ColorTranslator.FromHtml("#9BC1FF"),
                   LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            pnlEmail.BackColor = ColorTranslator.FromHtml("#B9D3FF");
            txtEmail.BackColor = ColorTranslator.FromHtml("#B9D3FF");
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            pnlEmail.BackColor = Color.FromArgb(216, 228, 245);
            txtEmail.BackColor = Color.FromArgb(216, 228, 245);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            pnlPassword.BackColor = ColorTranslator.FromHtml("#B9D3FF");
            txtPassword.BackColor = ColorTranslator.FromHtml("#B9D3FF");
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            pnlPassword.BackColor = Color.FromArgb(216, 228, 245);
            txtPassword.BackColor = Color.FromArgb(216, 228, 245);
        }

        private void picShowpass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = ColorTranslator.FromHtml("#6AA9F5");
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = ColorTranslator.FromHtml("#83BAFF");
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (HRSystem.Instance.Login(txtEmail.Text, txtPassword.Text))
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại tài khoản hoặc mật khẩu !","Đăng nhập thất bại",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gáng nhớ đi ba !!!");
        }
    }
}
