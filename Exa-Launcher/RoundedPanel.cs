using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exa_Launcher
{
    public class RoundedPanel : Panel
    {
        public int Radius { get; set; } = 30;

        public RoundedPanel()
        {
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, Radius, Radius, 180, 90);
            path.AddArc(Width - Radius, 0, Radius, Radius, 270, 90);
            path.AddArc(Width - Radius, Height - Radius, Radius, Radius, 0, 90);
            path.AddArc(0, Height - Radius, Radius, Radius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Pour un meilleur rendu des bords arrondis

            using (Pen pen = new Pen(this.BackColor, 1))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}
