using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace droneDockDataCenter.Controls
{
    class GMapMarkerPoint : GMarkerGoogle
    {
        public string wpno = "";
        SizeF txtsize = SizeF.Empty;
        static Dictionary<string, Bitmap> fontBitmaps = new Dictionary<string, Bitmap>();
        static Font font;


        public GMapMarkerPoint(PointLatLng p, GMarkerGoogleType type, string wpno) : base(p, type)
        {
            this.wpno = wpno;
            if (font == null)
                font = SystemFonts.DefaultFont;


            if (!fontBitmaps.ContainsKey(wpno))
            {
                Bitmap temp = new Bitmap(100, 40, PixelFormat.Format32bppArgb);
                using (Graphics g = Graphics.FromImage(temp))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    txtsize = g.MeasureString(wpno, font);

                    g.DrawString(wpno, font, Brushes.Black, new PointF(0, 0));
                }
                fontBitmaps[wpno] = temp;
            }

        }

        public override void OnRender(Graphics g)
        {
            base.OnRender(g);
            var midw = LocalPosition.X + 10;
            var midh = LocalPosition.Y + 3;

            if (Overlay.Control.Zoom > 10 || IsMouseOver)
                g.DrawImageUnscaled(fontBitmaps[wpno], midw, midh);

        }
    }
}
