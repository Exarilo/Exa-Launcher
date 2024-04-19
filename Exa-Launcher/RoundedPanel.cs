using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.ComponentModel;

namespace Exa_Launcher
{
    public class RoundedPanel : Panel
    {
        public int Radius { get; set; } = 30;
        private int scrollOffset = 0;
        private const int scrollStep = 30;
        private bool allowVerticalScrolling = false;

        [Browsable(true)]
        public bool AllowVerticalScrolling
        {
            get { return allowVerticalScrolling; }
            set
            {
                allowVerticalScrolling = value;
                if (allowVerticalScrolling)
                    this.MouseWheel += RoundedPanel_MouseWheel;
                else
                    this.MouseWheel -= RoundedPanel_MouseWheel;
            }
        }

        public RoundedPanel()
        {
            this.DoubleBuffered = true;
            if (allowVerticalScrolling)
                this.MouseWheel += RoundedPanel_MouseWheel;
        }

        private void RoundedPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            int scrollAmount = e.Delta < 0 ? scrollStep : -scrollStep;
            scrollOffset = Math.Max(0, scrollOffset + scrollAmount);
            this.AutoScrollPosition = new Point(0, scrollOffset);
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            this.VerticalScroll.Maximum = this.Height;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle clipRect = new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height);
            e.Graphics.SetClip(clipRect);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, Radius, Radius, 180, 90);
            path.AddArc(Width - Radius - 1, 0, Radius, Radius, 270, 90);
            path.AddArc(Width - Radius - 1, Height - Radius - 1, Radius, Radius, 0, 90);
            path.AddArc(0, Height - Radius - 1, Radius, Radius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(this.BackColor, 1))
            {
                e.Graphics.DrawPath(pen, path);
            }

            e.Graphics.ResetClip();
            e.Graphics.TranslateTransform(0, -Math.Min(scrollOffset, this.DisplayRectangle.Height - this.ClientRectangle.Height));
            base.OnPaint(e);
        }
    }
}