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
using System.Diagnostics.Eventing.Reader;
using System.Collections.Concurrent;
using System.Collections.Generic;
using GMapRoute = GMap.NET.WindowsForms.GMapRoute;
using GMapMarker = GMap.NET.WindowsForms.GMapMarker;

namespace droneDockDataCenter.Controls
{
    public partial class DockDetailPanel : UserControl
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(DockDetailPanel));

        public string rtspAddress { get; set; } = @"rtmp://liteavapp.qcloud.com/live/liteavdemoplayerstreamid";
        //public string rtspAddress { get; set; } = @"rtsp://192.168.2.119:554/";
        //public string rtspAddress = @"rtmp://liteavapp.qcloud.com/live/liteavdemop";
        public event EventHandler DeleteRequested;
        public event EventHandler TakeoffCommand;
        public event EventHandler GetWPsCommand;
        public event EventHandler SendWPsCommand;
        public event EventHandler RTLCommand;
        public event EventHandler SwitchOnOffCommand;

        //申请降落机场
        public event EventHandler RequestLandingDockCommand;
        //指令飞行
        public event EventHandler CommandFlightCommand;

        public event EventHandler DropCommand;
        public event EventHandler StartMissionCommand;
        public event EventHandler PauseMissionCommand;
        public event EventHandler ContinueMissionCommand;
        public event EventHandler AbortMissionCommand;


        public event EventHandler GetRTSPUrlCommand;
        public event GotoCommandHandler GotoCommand;


        public delegate void GotoCommandHandler(object sender, GotoCommandEventArgs e);

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


        public Gimbal gimbal { get; set; }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 触发DeleteRequested事件
            DeleteRequested?.Invoke(this, EventArgs.Empty);
            //checkFormClosing();
            logger.Info("exit dockDetailPanel");
        }


        GMap.NET.WindowsForms.GMapMarker droneIcon;

        GMapOverlay marksOverlay = new GMapOverlay("marks");

        GMapOverlay linesOverlay = new GMapOverlay("lines");
        public GMapRoute FlightWPs { get { return flightlines; } set { flightlines = value; } }

        public int DefaultAlt { get; set; } = 20;

        GMapRoute flightlines = new GMapRoute("flightlines");
        List<PointLatLng> WPPoints = new List<PointLatLng>();

        GMapMarker areaMarker;

        public DockDetailPanel()
        {
            InitializeComponent();

            initMapcontrol();

            initGimbalControl();

        }


        RtspPlayer videoPlayer;

        //初始化云台相关
        private void initGimbalControl()
        {
            gimbal = new Gimbal();
            logger.Info("init gimbal");
        }

        private DSkin.Controls.DSkinContextMenuStrip DSkinContextMenuStrip;
        private async void initMapcontrol()
        {
            gMapControl1.Manager.Mode = AccessMode.ServerAndCache;
            await Task.Run(() =>
            {
                gMapControl1.MapProvider = GMapProviders.BingHybridMap;
            });
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 21;
            gMapControl1.Zoom = 8;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.ShowCenter = false;
            gMapControl1.Position = new PointLatLng(22, 113);
            gMapControl1.MapScaleInfoEnabled = false;

            gMapControl1.Overlays.Add(marksOverlay);
            gMapControl1.Overlays.Add(linesOverlay);
            DSkinContextMenuStrip = new DSkin.Controls.DSkinContextMenuStrip();
            DSkinContextMenuStrip.Items.Add("飞到这里");
            DSkinContextMenuStrip.Items.Add("开始规划");
            DSkinContextMenuStrip.Items.Add("停止规划");
            DSkinContextMenuStrip.Items.Add("清除任务");
            DSkinContextMenuStrip.Items[0].Click += FlyToHereCommand_Click;
            DSkinContextMenuStrip.Items[1].Click += StartPlanningCommand_Click;
            DSkinContextMenuStrip.Items[2].Click += StopPlanningCommand_Click;
            DSkinContextMenuStrip.Items[3].Click += CleanMission_Click;
            gMapControl1.MouseDown += GMapControl1_MouseDown;
            gMapControl1.MouseUp += GMapControl1_MouseUp;

            //规划路线
            flightlines = new GMapRoute(WPPoints, "flightlines");
            flightlines.Stroke = new Pen(Color.FromArgb(150, Color.Red), 3);
            linesOverlay.Routes.Add(flightlines);

            logger.Info("init map");
        }


        int WPIndex = 1;
        private void GMapControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isPlannMode && e.Button == MouseButtons.Left)
            {
                PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);

                areaMarker = new GMapMarkerPoint(new PointLatLng(point.Lat, point.Lng),
                        GMap.NET.WindowsForms.Markers.GMarkerGoogleType.yellow, WPIndex.ToString()); ;
                linesOverlay.Markers.Add(areaMarker);
                flightlines.Points.Add(new PointLatLng(point.Lat, point.Lng));

                gMapControl1.Zoom++;
                gMapControl1.Zoom--;
                WPIndex++;
            }
        }

        private void CleanMission_Click(object sender, EventArgs e)
        {
            WPIndex = 1;
            linesOverlay.Markers.Clear();
            flightlines.Points.Clear();
            gMapControl1.Zoom++;
            gMapControl1.Zoom--;
        }

        //是否规划航点
        bool isPlannMode = false;

        private void StartPlanningCommand_Click(object sender, EventArgs e)
        {
            isPlannMode = true;
            DSkinMessageBox.Show("在地图点击绘制航点。");
        }

        private void StopPlanningCommand_Click(object sender, EventArgs e)
        {
            isPlannMode = false;
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
                if (DSkinMessageBox.Show("Fly to Lng:" + GotoCommandLocation.Lng + " Lat:" + GotoCommandLocation.Lat + " ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // 触发DeleteRequested事件
                    GotoCommand?.Invoke(this, new GotoCommandEventArgs(GotoCommandLocation.Lat, GotoCommandLocation.Lng, 20));
                    logger.Info("Fly to here click");
                }
            }
        }


        private CancellationTokenSource cancellationTokenSource;
        private void dSkinButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoPlayer == null)
                {
                    cancellationTokenSource = new CancellationTokenSource();
                    videoPlayer = new RtspPlayer();
                    videoPlayer.ShowBitmap += Rtmp_ShowBitmap;
                    Task.Run(() =>
                    {
                        videoPlayer.Start(rtspAddress);
                    }, cancellationTokenSource.Token);
                    dSkinButton2.Text = "Stop";
                    logger.Info($"Play rtsp video address: {rtspAddress}");
                }
                else
                {
                    videoPlayer.ShowBitmap -= Rtmp_ShowBitmap;
                    cancellationTokenSource?.Cancel();
                    videoPlayer.Stop();
                    pictureBox1.Image = null;
                    videoPlayer = null;
                    dSkinButton2.Text = "Play";
                    logger.Info("Stop rtsp video");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error");
                logger.Error(x.Message);
            }
        }

        private void Rtmp_ShowBitmap(Bitmap bitmap)
        {
            try
            {
                if (pictureBox1.InvokeRequired)
                {
                    pictureBox1.Invoke(new Action(() =>
                    {
                        SetBitmap(bitmap);
                    }));
                }
                //else
                //{
                //    SetBitmap(bitmap);
                //}
            }
            catch (ObjectDisposedException)
            {
                // PictureBox 控件已释放，不执行任何操作
            }
        }

        private void SetBitmap(Bitmap bitmap)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose(); // 释放之前的图像资源
            }
            pictureBox1.Image = bitmap;

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

        public void UpdateDroneRouterOnMap(List<route_data> routes)
        {
            linesOverlay.Markers.Clear();
            flightlines.Points.Clear();
            foreach (route_data route in routes)
            {
                areaMarker = new GMapMarkerPoint(new PointLatLng(route.Latitude, route.Longitude), 
                    GMap.NET.WindowsForms.Markers.GMarkerGoogleType.yellow, route.WaypointIndex.ToString()); ;
                linesOverlay.Markers.Add(areaMarker);
                flightlines.Points.Add(new PointLatLng(route.Latitude,route.Longitude));
            }
            gMapControl1.ZoomAndCenterMarkers("lines");
        }

        public void UpdateDroneInfoOnView(DroneManager droneManager)
        {
            if (droneManager == null || droneManager.CurrentDrone == null)
            {
                return;
            }
            TBDroneId = "ID: " + droneManager.CurrentDrone.Id;
            TBDroneBattery = "电量: " + droneManager.CurrentDrone.Battery;
            TBDroneMode = "飞行模式: " + droneManager.CurrentDrone.Mode;
            TBDroneThrottle = "油门: " + droneManager.CurrentDrone.Throttle;
            TBDroneGroundSpeed = "地速: " + droneManager.CurrentDrone.GroundSpeed;

            this.hudControl1.Airspeed = (int)droneManager.CurrentDrone.AirSpeed;
            this.hudControl1.RollAngle = droneManager.CurrentDrone.Attitude.Roll;
            this.hudControl1.YawAngle = droneManager.CurrentDrone.Attitude.Heading;
            this.hudControl1.PitchAngle = droneManager.CurrentDrone.Attitude.Pitch;
            this.hudControl1.Altitude = (int)droneManager.CurrentDrone.Alt_rel;


            //update droneIcon

            PointLatLng dronePoint = new PointLatLng(droneManager.CurrentDrone.Position.Latitude, droneManager.CurrentDrone.Position.Longitude);
            float yaw = droneManager.CurrentDrone.Attitude.Heading;


            droneIcon = new GMapMarkerDrone(dronePoint, yaw, 0, 0, 0);
            //droneIcon.Tag = dronePoint.Lng.ToString("0.000000") + " " + dronePoint.Lat.ToString("0.000000");
            marksOverlay.Markers.Clear();
            marksOverlay.Markers.Add(droneIcon);
            if(dSkinCheckBoxFollowDrone.Checked)
                gMapControl1.ZoomAndCenterMarkers("marks");

            logger.Info("UpdateDroneInfoOnView");

        }

        private void dSkinButtonTkoff_Click(object sender, EventArgs e)
        {
            // 触发TakeoffCommand事件
            TakeoffCommand?.Invoke(this, EventArgs.Empty);
        }

        private void dSkinButtonRTL_Click(object sender, EventArgs e)
        {
            // 触发RTLCommand事件
            RTLCommand?.Invoke(this, EventArgs.Empty);
        }

        private Process _ffmpegProcess;
        private bool _isRecording;
        private string _outputFileName;
        string directoryPath = "Records";

        public void StartRecording(string rtspUrl, string outputFileName)
        {
            if (_ffmpegProcess != null && !_ffmpegProcess.HasExited)
            {
                logger.Error("Recording is already in progress.");
            }



            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
                logger.Info("Records created.");
            }
            else
            {
                logger.Info("Records 存在.");
            }

            _outputFileName = directoryPath + Path.DirectorySeparatorChar + outputFileName; // Save the output file name

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
                _ffmpegProcess = null;
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

        private void dSkinButton4_Click(object sender, EventArgs e)
        {
            GetWPsCommand?.Invoke(this, EventArgs.Empty);
        }


        private void dSkinTabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (dSkinTabControl1.SelectedIndex == 0)
            {
                dSkinGroupBoxDroneStatus.Visible = true;
                dSkinTableLayoutPanelDroneCMD.Visible = true;
                dSkinTableLayoutPanelGimbal.Visible = false;
            }
            else if (dSkinTabControl1.SelectedIndex == 1)
            {
                dSkinGroupBoxDroneStatus.Visible = false;
                dSkinTableLayoutPanelDroneCMD.Visible = false;
                dSkinTableLayoutPanelGimbal.Visible = true;
            }
        }

        private void dSkinButton10_Click(object sender, EventArgs e)
        {
            GetRTSPUrlCommand?.Invoke(this, EventArgs.Empty);
        }

        private void dSkinButton5_MouseDown(object sender, MouseEventArgs e)
        {
            gimbal.ControlUp();
            logger.Info("gimbal up");

        }

        private void StopMove_MouseUp(object sender, MouseEventArgs e)
        {
            gimbal.ControlStop();
            logger.Info("gimbal stop");

        }

        private void StopZoom_MouseUp(object sender, MouseEventArgs e)
        {
            gimbal.ControlStopZoom();
            logger.Info("gimbal stop zooom");
        }

        private void dSkinButton8_MouseDown(object sender, MouseEventArgs e)
        {
            gimbal.ControlRight();
            logger.Info("gimbal right");

        }

        private void dSkinButton7_MouseDown(object sender, MouseEventArgs e)
        {
            gimbal.ControlLeft();
            logger.Info("gimbal left");

        }

        private void dSkinButton6_MouseDown(object sender, MouseEventArgs e)
        {
            gimbal.ControlDown();
            logger.Info("gimbal down");

        }

        private void dSkinButton9_MouseDown(object sender, MouseEventArgs e)
        {
            gimbal.ControlCenter();
            logger.Info("gimbal center");
        }

        private void dSkinButton11_Click(object sender, EventArgs e)
        {
            if (gimbal!=null && !gimbal.IsConnected)
            {
                gimbal.connectViaTCP();
            }
            else
            {
                gimbal.disconnectViaTCP();
            }

            if (gimbal.IsConnected)
                dSkinButton11.Text = "Dis Conn";
            else
                dSkinButton11.Text = "Conn";
        }

        private void dSkinButton12_MouseDown(object sender, MouseEventArgs e)
        {
            gimbal.ControlZoomIn();
            logger.Info("gimbal zoom in");
        }

        private void dSkinButton13_MouseDown(object sender, MouseEventArgs e)
        {
            gimbal.ControlZoomOut();
            logger.Info("gimbal zoom out");
        }

        private void dSkinButton17_Click(object sender, EventArgs e)
        {
            DropCommand?.Invoke(this, EventArgs.Empty);
        }

        private void dSkinButton14_Click(object sender, EventArgs e)
        {
            StartMissionCommand?.Invoke(this, EventArgs.Empty);
        }

        private void dSkinButton15_Click(object sender, EventArgs e)
        {
            PauseMissionCommand?.Invoke(this, EventArgs.Empty);
        }

        private void dSkinButton16_Click(object sender, EventArgs e)
        {
            ContinueMissionCommand?.Invoke(this, EventArgs.Empty);
        }

        private void dSkinButton18_Click(object sender, EventArgs e)
        {
            AbortMissionCommand?.Invoke(this, EventArgs.Empty);
        }

        private void dSkinButton19_Click(object sender, EventArgs e)
        {
            SendWPsCommand?.Invoke(this, EventArgs.Empty);
            isPlannMode = false;
        }
        public bool DroneSwitchOn { get; set; }

        public bool CommandFlight { get; set; }
        private void dSkinButton20_Click(object sender, EventArgs e)
        {
            SwitchOnOffCommand?.Invoke(this, EventArgs.Empty);
        }

        private void dSkinButton21_Click(object sender, EventArgs e)
        {
            RequestLandingDockCommand?.Invoke(this, EventArgs.Empty);
        }

        private void dSkinButton23_Click(object sender, EventArgs e)
        {
            CommandFlightCommand?.Invoke(this, EventArgs.Empty);
            CommandFlight = !CommandFlight;
        }
    }
}
