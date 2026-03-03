using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace HyperionHR_meta
{
    public partial class MainForm : Form
    {
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
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25)); //Bo gốc
            //Hiện ngày tháng trên welcomebar
            lblDateTime.Text = $"Hôm nay là {DateTime.Now.ToString("dddd, MMMM dd, yyyy")}";
            //Chào người dùng
            lblWelcome.Text = $"{GetGreeting()}, ";
        }

        protected override void OnPaintBackground(PaintEventArgs e) //Gradient
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                ColorTranslator.FromHtml("#FBFCFF"),
                ColorTranslator.FromHtml("#9CC1FA"),
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

    }
}
