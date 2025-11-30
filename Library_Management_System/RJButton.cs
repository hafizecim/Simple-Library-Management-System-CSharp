using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace Library_Management_System
{
    public class RJButton : Button
    {
        // Alanlar (Fields)
        private int borderSize = 2;
        private int borderRadius = 40;
        private Color borderColor = Color.White;

        // Özellikler (Properties)
        [Category("RJ Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            // Arka planı transparan yapmak için burayı Color.Transparent olarak ayarlayabilirsiniz.
            set { this.BackColor = value; }
        }

        [Category("RJ Code Advance")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        // Yapıcı (Constructor)
        public RJButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 2;
            this.Size = new Size(150, 40);
            this.BackColor = Color.Transparent; // Varsayılan dolgu rengi
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
            this.Invalidate();
        }

        // Metot: Yuvarlak Kenarlı Yol Oluşturma
        // Bu metot, köşelerdeki X sorununu çözmek için daha güvenilir bir yol çizer.
        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = radius * 2;
            RectangleF arcRect = new RectangleF(rect.Location, new SizeF(diameter, diameter));

            path.StartFigure();

            // Üst Sol (Top Left)
            path.AddArc(arcRect, 180, 90);

            // Üst Sağ (Top Right)
            arcRect.X = rect.Width - diameter;
            path.AddArc(arcRect, 270, 90);

            // Alt Sağ (Bottom Right)
            arcRect.Y = rect.Height - diameter;
            path.AddArc(arcRect, 0, 90);

            // Alt Sol (Bottom Left)
            arcRect.X = rect.X;
            path.AddArc(arcRect, 90, 90);

            path.CloseFigure();
            return path;
        }

        // *** OnPaint Metodu (Çizim İşlemi) ***
        // *** YENİ OnPaint Metodu (Sorun Çözüldü) ***
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Grafik nesnesini yüksek kaliteli çizim için ayarla
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = this.ClientRectangle;

            // Yarıçap > 1 ise yuvarlak köşeleri uygula
            if (borderRadius > 1)
            {
                // Yüzey ve kenarlık için tek bir yol oluştur
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                {
                    // 1. Düğme Yüzeyi (Dolgu)
                    using (SolidBrush brushSurface = new SolidBrush(this.BackColor))
                    {
                        pevent.Graphics.FillPath(brushSurface, pathSurface);
                    }

                    // 2. Bölgeyi Ayarlama (Görünür alanı yuvarlak yola sınırla)
                    this.Region = new Region(pathSurface);

                    // 3. Kenarlık (Border)
                    if (borderSize >= 1)
                    {
                        using (Pen penBorder = new Pen(borderColor, borderSize))
                        {
                            // Kenarlığı yolun merkezine hizala
                            penBorder.Alignment = PenAlignment.Center;

                            // Kenarlığı çiz
                            pevent.Graphics.DrawPath(penBorder, pathSurface);
                        }
                    }
                }
            }
            else // Normal kare düğme
            {
                // ... (Kare düğme mantığı, önceki kodunuzdaki gibi kalabilir)
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        // ... (Kalan metotlar aynı)

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.Parent != null) // Parent null değilse dinlemeye başla
            {
                this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
            }
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            // Ebeveyn rengi değiştiğinde yeniden çizim yap (Transparent arka plan için gerekli)
            this.Invalidate();
        }
    }
}