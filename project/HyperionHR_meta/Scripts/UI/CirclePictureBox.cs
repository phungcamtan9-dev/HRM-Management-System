using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HyperionHR_meta.Scripts.UI
{
    public class CirclePictureBox : PictureBox
    {
        public CirclePictureBox()
        {
            this.SizeMode = PictureBoxSizeMode.Zoom;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new Region(path);
        }
    }
}
