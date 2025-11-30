using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Library_Management_System
{
    public class RoundedButtonControl : UserControl
    {
        private int borderRadius = 20;
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

        private string buttonText = "Button";
        public string ButtonText
        {
            get { return buttonText; }
            set { buttonText = value; this.Invalidate(); }
        }

        private int borderSize = 1; // 1px kenarlık
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }

        private Color borderColor = Color.White; // beyaz kenarlık
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        public RoundedButtonControl()
        {
            this.Size = new Size(120, 50);
            this.BackColor = Color.Transparent; // tamamen şeffaf
            this.ForeColor = Color.White; // yazı beyaz
            this.Font = new Font("Segoe UI", 10, FontStyle.Bold); // yazı kalın
            this.Cursor = Cursors.Hand;

            // Şeffaflık için stil
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Kenarlık için inset edilmiş dikdörtgen (bozuk piksel sorunu çözülür)
            Rectangle rect = new Rectangle(borderSize / 2, borderSize / 2,
                                           this.Width - borderSize, this.Height - borderSize);

            // Yuvarlatılmış köşe path'i oluştur
            GraphicsPath path = new GraphicsPath();
            int radius = borderRadius;

            path.StartFigure();
            path.AddArc(new Rectangle(rect.Left, rect.Top, radius, radius), 180, 90);
            path.AddArc(new Rectangle(rect.Right - radius, rect.Top, radius, radius), -90, 90);
            path.AddArc(new Rectangle(rect.Right - radius, rect.Bottom - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(rect.Left, rect.Bottom - radius, radius, radius), 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

            // Kenarlık çizimi
            if (borderSize > 0)
            {
                using (Pen pen = new Pen(borderColor, borderSize))
                {
                    pen.Alignment = PenAlignment.Inset; // kenarlık düzgün hizalanır
                    e.Graphics.DrawPath(pen, path);
                }
            }

            // Yazı
            TextRenderer.DrawText(e.Graphics, buttonText, this.Font, rect, this.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
