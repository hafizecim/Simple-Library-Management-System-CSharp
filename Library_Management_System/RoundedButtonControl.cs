using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Library_Management_System
{
    public class RoundedButtonControl : Button
    {
        private bool isHovered = false;

        // ---- Public Properties ----
        public int BorderRadius { get; set; } = 40;
        public int BorderSize { get; set; } = 2;
        public Color BorderColor { get; set; } = Color.White;
        public string ButtonText { get; set; } = "";

        public Color NormalBackColor { get; set; } = Color.Transparent;
        public Color HoverBackColor { get; set; } = Color.Violet;


        // ---- Constructor ----
        public RoundedButtonControl()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = NormalBackColor;

            this.MouseEnter += (s, e) =>
            {
                isHovered = true;
                this.BackColor = HoverBackColor;
                this.Invalidate();
            };

            this.MouseLeave += (s, e) =>
            {
                isHovered = false;
                this.BackColor = NormalBackColor;
                this.Invalidate();
            };
        }

        // ---- Rounded Path ----
        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curve = radius * 2F;

            path.AddArc(Rect.X, Rect.Y, curve, curve, 180, 90);
            path.AddArc(Rect.Width - curve, Rect.Y, curve, curve, 270, 90);
            path.AddArc(Rect.Width - curve, Rect.Height - curve, curve, curve, 0, 90);
            path.AddArc(Rect.X, Rect.Height - curve, curve, curve, 90, 90);

            path.CloseFigure();
            return path;
        }

        // ---- Painting ----
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            RectangleF rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath path = GetRoundPath(rect, BorderRadius);

            this.Region = new Region(path);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw border
            if (BorderSize > 0)
            {
                using (Pen pen = new Pen(BorderColor, BorderSize))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, path);
                }
            }

            // Draw text (center)
            TextRenderer.DrawText(
                e.Graphics,
                ButtonText,
                this.Font,
                this.ClientRectangle,
                this.ForeColor = Color.White,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter

            );
        }
    }
}