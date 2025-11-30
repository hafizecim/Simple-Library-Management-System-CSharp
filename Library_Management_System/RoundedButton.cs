using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Library_Management_System
{
    public class RoundedButton : Button
    {
        private int borderRadius = 20;

        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = this.ClientRectangle;

            GraphicsPath path = new GraphicsPath();
            int radius = borderRadius;

            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(rect.Width - radius, 0, radius, radius), -90, 90);
            path.AddArc(new Rectangle(rect.Width - radius, rect.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, rect.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

            // Button yazısı ortalanmış şekilde çizilsin
            TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, rect, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
