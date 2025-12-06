using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Library_Management_System
{
    public class GradientPanel : Panel
    {
        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }
        public float Angle { get; set; }
        // public float Radius { get; set; } = 1f;

        protected override void OnPaint(PaintEventArgs e)
        {
            //LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.TopColor=Color.Violet, this.BottomColor=Color.Indigo, this.Angle=50);
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.TopColor , this.BottomColor , this.Angle);

            Graphics g = e.Graphics;
            g.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }

    }
}