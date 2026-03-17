using HyperionHR_meta.Scripts.Class.System;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace HyperionHR_meta
{
    public partial class MainForm : Form
    {
        //Khai báo toàn cục:
        HRSystem system = HRSystem.Instance;


        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // chống giật


        }

        /// <summary>
        /// Làm đẹp form
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            
    




            //Load giao diện ban đầu
            LoadGiaoDien();
            BoGocAvatar();
        }

        public void BoGocAvatar()//Bo gốc avatar
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

        protected override void OnPaintBackground(PaintEventArgs e) //Gradient
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

        public string GetGreeting() // check buổi
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

        //Panel control
        public void LoadGiaoDien()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25)); //Bo gốc
            lblWelcome.Text = $"{GetGreeting()}, {system.CurrentUser.Username}"; //Chào người dùng
            lblDateTime.Text = $"Hôm nay là {DateTime.Now.ToString("dddd, MMMM dd, yyyy")}"; //Hiện ngày tháng trên welcomebar

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

                    //ẩn
                    pnlSideBar_Employee.Visible = false;
                    pnlBottomSideBar_Employee.Visible = false;

                    break;

                case Role.HR:
                    //hiện                    
                    pnlSideBar_HR.Visible = true;
                    pnlBottomSideMenu.Visible = true;

                    //ẩn
                    icoBaoTriHeThong.Visible = false;
                    pnlSideBar_Employee.Visible = false;
                    pnlBottomSideBar_Employee.Visible = false;

                    break;

                case Role.Manager:
                    //hiện                    
                    pnlSideBar_HR.Visible = true;
                    pnlBottomSideMenu.Visible = true;

                    //ẩn
                    icoBaoTriHeThong.Visible = false;
                    pnlSideBar_Employee.Visible = false;
                    pnlBottomSideBar_Employee.Visible = false;

                    break;

                case Role.Employee:
                    //hiện
                    pnlSideBar_Employee.Visible = true;
                    pnlBottomSideBar_Employee.Visible = true;
                    
                    //ẩn
                    icoBaoTriHeThong.Visible = false;
                    pnlSideBar_HR.Visible = false;
                    pnlBottomSideMenu.Visible = false;

                    break;
            }
        }

        /// <summary>
        /// Thao tác cơ bản
        /// </summary>
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

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            pnlDashboard.BackColor = ColorTranslator.FromHtml("#D9E5FF");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) //Upadte dữ liệu khi đóng file và xác nhận thoát 
        {
            HRSystem.Instance.Save("hrsystem.json");

            DialogResult result = MessageBox.Show("Dữ liệu của bạn đã được cập nhật, xác nhận thoát ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) e.Cancel = false;
            else e.Cancel = true;
        }





    }
}
