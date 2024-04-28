using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace droneDockDataCenter.Controls
{
    public class GMapMarkerBase : GMapMarker
    {
        public static bool DisplayCOG = true;
        public static bool DisplayHeading = true;
        public static bool DisplayNavBearing = true;
        public static bool DisplayRadius = true;
        public static bool DisplayTarget = true;
        public static int length = 500;

        public GMapMarkerBase(PointLatLng pos) : base(pos)
        {
        }
    }

    public class GMapMarkerDrone : GMapMarkerBase
    {
        static readonly System.Drawing.Size SizeSt =
            new System.Drawing.Size(global::droneDockDataCenter.Properties.Resources.planetracker.Width,
                global::droneDockDataCenter.Properties.Resources.planetracker.Height);

        float heading = 0;
        float cog = -1;
        float target = -1;
        float nav_bearing = -1;

        public GMapMarkerDrone(PointLatLng p, float heading, float cog, float nav_bearing, float target)
            : base(p)
        {
            this.heading = heading;
            this.cog = cog;
            this.target = target;
            this.nav_bearing = nav_bearing;
            Size = SizeSt;
        }

        public override void OnRender(Graphics g)
        {
            var temp = g.Transform;
            g.TranslateTransform(LocalPosition.X, LocalPosition.Y);

            g.RotateTransform(-Overlay.Control.Bearing);


            try
            {
                g.RotateTransform(heading);
            }
            catch
            {
            }

            g.DrawImageUnscaled(global::droneDockDataCenter.Properties.Resources.planetracker,
                Size.Width / -2,
                Size.Height / -2);


            g.Transform = temp;
            if (Tag != null)
            {
                g.DrawString(Tag.ToString(), new Font(FontFamily.GenericMonospace, 10, FontStyle.Bold), Brushes.Red, -18,
                     -45);
            }
        }
    }
}
