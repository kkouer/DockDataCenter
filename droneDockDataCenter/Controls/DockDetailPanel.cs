using GMap.NET.MapProviders;
using GMap.NET;
using System;
using System.Windows.Forms;
using droneDockDataCenter.Modle;
using droneDockDataCenter.FFMpeg;
using System.Threading;
using System.Text;
using System.Drawing;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsPresentation;
using DSkin.Forms;
using log4net;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace droneDockDataCenter.Controls
{
    public partial class DockDetailPanel : UserControl
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(DockDetailPanel));

        public string rtspAddress = @"rtmp://liteavapp.qcloud.com/live/liteavdemoplayerstreamid";
        public event EventHandler DeleteRequested;
        public event EventHandler TakeoffCommand;
        public event EventHandler RTLCommand;
        public event GotoCommandHandler GotoCommand;
        
        
        public delegate void GotoCommandHandler(object  sender, GotoCommandEventArgs e);

        // 定义指点飞行事件参数类
        public class GotoCommandEventArgs : EventArgs
        {
            public double Lat { get; }
            public double Long { get; }

            public double Alt { get; set; }

            public GotoCommandEventArgs(double lat, double lon, double alt)
            {
                Lat = lat;
                Long = lon;
                Alt = alt;
            }
        }


        Gimbal gimbal;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 触发DeleteRequested事件
            DeleteRequested?.Invoke(this, EventArgs.Empty);
            logger.Info("exit dockDetailPanel");
        }


        GMap.NET.WindowsForms.GMapMarker droneIcon;

        GMapOverlay marksOverlay = new GMapOverlay("marks");


        public DockDetailPanel()
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
            logger.Info("init gimbal");
        }

        private DSkin.Controls.DSkinContextMenuStrip DSkinContextMenuStrip;
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

            gMapControl1.Overlays.Add(marksOverlay);

            DSkinContextMenuStrip = new DSkin.Controls.DSkinContextMenuStrip();
            DSkinContextMenuStrip.Items.Add("Fly to here");
            DSkinContextMenuStrip.Items[0].Click += FlyToHereCommand_Click;
            gMapControl1.MouseDown += GMapControl1_MouseDown;
            logger.Info("init map");
        }
        PointLatLng GotoCommandLocation;
        private void GMapControl1_MouseDown(object sender, MouseEventArgs e)
        {
            // 检查是否是鼠标右击事件
            if (e.Button == MouseButtons.Right)
            {
                // 获取鼠标在地图上的经纬度坐标
                PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                GotoCommandLocation = point;

                // 在指定位置显示上下文菜单
                DSkinContextMenuStrip.Show(gMapControl1, e.Location);
            }
        }

        private void FlyToHereCommand_Click(object sender, EventArgs e)
        {
            if (GotoCommandLocation != null)
            {
               if( DSkinMessageBox.Show("Fly to Lng:"+ GotoCommandLocation.Lng + " Lat:" + GotoCommandLocation.Lat +" ?", "Confirm",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // 触发DeleteRequested事件
                    GotoCommand?.Invoke(this, new GotoCommandEventArgs(GotoCommandLocation.Lat,GotoCommandLocation.Lng,20));
                    logger.Info("Fly to here click");
                }
            }
        }

        private void dSkinButton2_Click(object sender, EventArgs e)
        {
            try
            {

                if (thPlayer != null)
                {
                    rtmp.Stop();
                    //thPlayer.Abort();
                    //thPlayer = null;
                    //controlHostVideoPanel.Visible = false;
                    dSkinButton2.Text = "Play";
                    rtmp = null;
                    logger.Info("Stop rtsp video");
                }
                else
                {
                    rtmp = new tstRtmp();
                    thPlayer = new Thread(DeCoding);
                    thPlayer.IsBackground = true;
                    thPlayer.Priority = ThreadPriority.Highest;
                    thPlayer.Start();
                    dSkinButton2.Text = "Stop";
                    logger.Info("Play rtsp video");

                }
            }
            catch (Exception x) 
            { 
                MessageBox.Show(x.Message, "Error"); 
                logger.Error(x.Message);
            }
            finally { }
        }

        

        private unsafe void DeCoding()
        {
            try
            {
                Console.WriteLine("DeCoding run...");


                Bitmap oldBmp = null;

                
                // 更新图片显示
                tstRtmp.ShowBitmapDelegate show = (bmp) =>
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
                    dSkinButton2.Text = "Play";
                    dSkinButton2.Enabled = true;
                }));
            }
        }


        public string TBDroneId
        {

            set { dSkinLabel1.Text = value; }

        }
        public string TBDroneBattery
        {

            set { dSkinLabel2.Text = value; }

        }
        public string TBDroneMode
        {

            set { dSkinLabel3.Text = value; }

        }
        public string TBDroneThrottle
        {

            set { dSkinLabel4.Text = value; }

        }

        public string TBDroneGroundSpeed
        {

            set { dSkinLabel5.Text = value; }

        }

        public void UpdateDroneInfoOnView(DroneManager droneManager)
        {
            if(droneManager == null || droneManager.CurrentDrone == null)
            {
                return;
            }
            TBDroneId = "ID: "+droneManager.CurrentDrone.Id;
            TBDroneBattery = "Battery: " + droneManager.CurrentDrone.Battery;
            TBDroneMode = "Flight mode: " +droneManager.CurrentDrone.Mode;
            TBDroneThrottle = "Throttle: "+droneManager.CurrentDrone.Throttle;
            TBDroneGroundSpeed = "Ground Speed: " + droneManager.CurrentDrone.GroundSpeed;

            this.hudControl1.Airspeed = (int)droneManager.CurrentDrone.AirSpeed;
            this.hudControl1.RollAngle = droneManager.CurrentDrone.Attitude.Roll;
            this.hudControl1.YawAngle = droneManager.CurrentDrone.Attitude.Heading;
            this.hudControl1.PitchAngle = droneManager.CurrentDrone.Attitude.Pitch;
            this.hudControl1.Altitude = (int)droneManager.CurrentDrone.Alt_rel;


            //update droneIcon

            PointLatLng dronePoint = new PointLatLng(droneManager.CurrentDrone.Position.Latitude,droneManager.CurrentDrone.Position.Longitude);
            float yaw = droneManager.CurrentDrone.Attitude.Heading;


            droneIcon = new GMapMarkerDrone(dronePoint, yaw, 0, 0, 0);
            //droneIcon.Tag = dronePoint.Lng.ToString("0.000000") + " " + dronePoint.Lat.ToString("0.000000");
            marksOverlay.Markers.Clear();
            marksOverlay.Markers.Add(droneIcon);
            gMapControl1.ZoomAndCenterMarkers("marks");

            logger.Info("UpdateDroneInfoOnView");

        }

        private void dSkinButtonTkoff_Click(object sender, EventArgs e)
        {
            // 触发DeleteRequested事件
            TakeoffCommand?.Invoke(this, EventArgs.Empty);
        }

        private void dSkinButtonRTL_Click(object sender, EventArgs e)
        {
            // 触发DeleteRequested事件
            RTLCommand?.Invoke(this, EventArgs.Empty);
        }

        private Process _ffmpegProcess;
        private bool _isRecording;
        private string _outputFileName;

        public void StartRecording(string rtspUrl, string outputFileName)
        {
            if (_ffmpegProcess != null && !_ffmpegProcess.HasExited)
                throw new InvalidOperationException("Recording is already in progress.");

            _outputFileName = outputFileName; // Save the output file name

            string arguments = $"-i {rtspUrl} -c copy {_outputFileName}";

            _ffmpegProcess = new Process();
            _ffmpegProcess.StartInfo.FileName = "FFMpeg/ffmpeg.exe";
            _ffmpegProcess.StartInfo.Arguments = arguments;
            _ffmpegProcess.ErrorDataReceived += Ffmpeg_ErrorDataReceived;
            _ffmpegProcess.StartInfo.UseShellExecute = false;
            _ffmpegProcess.StartInfo.RedirectStandardError = true;
            _ffmpegProcess.StartInfo.RedirectStandardInput = true;
            _ffmpegProcess.StartInfo.CreateNoWindow = true;
            _ffmpegProcess.Start();
            _ffmpegProcess.BeginErrorReadLine();

            _isRecording = true;
            
        }

        private void Ffmpeg_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine(e.Data);
        }

        public void StopRecording()
        {
            if (!_isRecording)
                return;

            if (_ffmpegProcess != null && !_ffmpegProcess.HasExited)
            {
                _ffmpegProcess.StandardInput.WriteLine("q");
                _ffmpegProcess.Close();
                _ffmpegProcess.Dispose();
            }
            _isRecording = false;
        }


        private void dSkinButton3_Click(object sender, EventArgs e)
        {
            _outputFileName = $"record_{DateTime.Now:yyyyMMddHHmmss}.mp4";
            if (!_isRecording)
            {

                 StartRecording(rtspAddress, _outputFileName);
                dSkinButton3.Text = "Stop Rec";
            }
            else
            {
                StopRecording();
                dSkinButton3.Text = "Start Rec";

            }
        }
    }
}
