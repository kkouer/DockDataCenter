using GMap.NET.MapProviders;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace droneDockDataCenter
{
    public partial class DockDetailPanel : UserControl
    {
        public DockDetailPanel()
        {
            InitializeComponent();
            initMapcontrol();
        }

        private void initMapcontrol()
        {
            gMapControl1.Manager.Mode = AccessMode.ServerAndCache;
            gMapControl1.MapProvider = GMapProviders.BingHybridMap;
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 21;
            gMapControl1.Zoom = 8;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.ShowCenter = false;
            gMapControl1.Position = new PointLatLng(22, 113);
            gMapControl1.MapScaleInfoEnabled = false;
        }
    }
}
