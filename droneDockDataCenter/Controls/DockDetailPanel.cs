using GMap.NET.MapProviders;
using GMap.NET;
using System;
using System.Windows.Forms;
using droneDockDataCenter.Modle;
using droneDockDataCenter.FFMpeg;
using System.Threading;
using System.Text;
using System.Drawing;

namespace droneDockDataCenter.Controls
{
    public partial class DockDetailPanel : UserControl
    {

        public string rtspAddress = @"https://mvvideo5.meitudata.com/571090934cea5517.mp4";
        public event EventHandler DeleteRequested;

        Gimbal gimbal;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 触发DeleteRequested事件
            DeleteRequested?.Invoke(this, EventArgs.Empty);
        }

        public DockDetailPanel(Dock dock)
        {
            InitializeComponent();
            initMapcontrol();

            initGimbalControl();
        }
        tstRtmp rtmp;// = new tstRtmp();
        Thread thPlayer;

        //初始化云台相关
        private void initGimbalControl()
        {
            gimbal = new Gimbal();
            
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

        private void dSkinButton2_Click(object sender, EventArgs e)
        {
            try
            {

                if (thPlayer != null)
                {
                    rtmp.Stop();
                    //thPlayer.Abort();
                    thPlayer = null;
                    //controlHostVideoPanel.Visible = false;
                    dSkinButton2.Enabled = true;
                    dSkinButton2.Text = "开始播放";
                    rtmp = null;
                }
                else
                {
                    rtmp = new tstRtmp();
                    thPlayer = new Thread(DeCoding);
                    thPlayer.IsBackground = true;
                    thPlayer.Priority = ThreadPriority.Highest;
                    thPlayer.Start();
                    dSkinButton2.Text = "停止播放";
                    dSkinButton2.Enabled = false;

                }
            }
            catch (Exception x) { MessageBox.Show(x.Message, "Error"); }
            finally { }
        }
        private unsafe void DeCoding()
        {
            try
            {
                Console.WriteLine("DeCoding run...");


                Bitmap oldBmp = null;


                // 更新图片显示
                tstRtmp.ShowBitmap show = (bmp) =>
                {
                    this.Invoke(new MethodInvoker(() =>
                    {

                        pictureBox1.Image = bmp;
                        if (oldBmp != null)
                        {

                            oldBmp.Dispose();
                            oldBmp = null;
                        }
                        oldBmp = bmp;

                    }));
                };

                rtmp.Start(show, rtspAddress);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("DeCoding exit");
                this.Invoke(new MethodInvoker(() =>
                {
                    dSkinButton2.Text = "开始播放";
                    dSkinButton2.Enabled = true;
                }));
            }
        }

    }
}
