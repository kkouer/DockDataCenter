﻿using MQTTnet;
using MQTTnet.Client;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using droneDockDataCenter.Modle;
using System.Text.RegularExpressions;
using droneDockDataCenter.Controls;
using System.Xml;
using System.IO;
using DSkin.Forms;
using log4net;
using Newtonsoft.Json;

namespace droneDockDataCenter
{
    public partial class MainForm : DSkin.Forms.DSkinForm
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(MainForm));

        public IMqttClient mqttClient;
        public MqttClientOptions mqttClientOptions;

        public MqttFactory mqttFactory;

        public DockManager dockManager = new DockManager();

        public DroneManager droneManager = new DroneManager();

        public Response currentResponse = new Response();

        public DockDetailPanel dockDetailPanel = null;

        public string MqttServerAddress { get; set; } = "s567e716.ala.cn-hangzhou.emqxsl.cn";
        public string MqttServerPort { get; set; } = "8883";
        public string MqttServerUserName { get; set; } = "admin";
        public string MqttServerPassword { get; set; } = "123456";

        public string FTPServerAddress { get; set; } = "127.0.0.1";
        public string FTPServerUserName { get; set; } = "admin";
        public string FTPServerPassword { get; set; } = "123456";

        AppSettingInfo appSetting = new AppSettingInfo();


        void readAppConfig()
        {
            //读取配置
            xmlConfigFile(false, System.AppDomain.CurrentDomain.BaseDirectory + "config.xml");

            //mqtt
            if (!string.IsNullOrEmpty(appSetting.MQTTServerAddress))
            {
                MqttServerAddress = appSetting.MQTTServerAddress;
            }
            if (!string.IsNullOrEmpty(appSetting.MQTTServerPort))
            {
                MqttServerPort = appSetting.MQTTServerPort;
            }
            if (!string.IsNullOrEmpty(appSetting.MQTTServerUserName))
            {
                MqttServerUserName = appSetting.MQTTServerUserName;
            }
            if (!string.IsNullOrEmpty(appSetting.MQTTServerPassword))
            {
                MqttServerPassword = appSetting.MQTTServerPassword;
            }

            //ftp
            if (!string.IsNullOrEmpty(appSetting.FtpServerAddress))
            {
                FTPServerAddress = appSetting.FtpServerAddress;
            }
            if (!string.IsNullOrEmpty(appSetting.FtpServerUserName))
            {
                FTPServerUserName = appSetting.FtpServerUserName;
            }
            if (!string.IsNullOrEmpty(appSetting.FtpServerPassword))
            {
                FTPServerPassword = appSetting.FtpServerPassword;
            }

            logger.Info("read app config");
        }

        void saveAppConfig()
        {
            appSetting.MQTTServerAddress = MqttServerAddress;
            appSetting.MQTTServerPort = MqttServerPort;
            appSetting.MQTTServerUserName = MqttServerUserName;
            appSetting.MQTTServerPassword = MqttServerPassword;

            appSetting.FtpServerAddress = FTPServerAddress;
            appSetting.FtpServerUserName = FTPServerUserName;
            appSetting.FtpServerPassword = FTPServerPassword;

            xmlConfigFile(true, System.AppDomain.CurrentDomain.BaseDirectory + "config.xml");
            logger.Info("save app config");
        }
        private void xmlConfigFile(bool write, string filename)
        {
            bool exists = File.Exists(filename);

            if (write || !exists)
            {
                try
                {
                    XmlTextWriter xmlwriter = new XmlTextWriter(filename, Encoding.UTF8);
                    xmlwriter.Formatting = System.Xml.Formatting.Indented;

                    xmlwriter.WriteStartDocument();

                    xmlwriter.WriteStartElement("AppSetting");
                    try
                    {
                        xmlwriter.WriteStartElement("Config");
                        xmlwriter.WriteElementString("MQTTServerAddress", appSetting.MQTTServerAddress);
                        xmlwriter.WriteElementString("MQTTServerPort", appSetting.MQTTServerPort);
                        xmlwriter.WriteElementString("MQTTServerUserName", appSetting.MQTTServerUserName);
                        xmlwriter.WriteElementString("MQTTServerPassword", appSetting.MQTTServerPassword);

                        xmlwriter.WriteElementString("FtpServerAddress", appSetting.FtpServerAddress);
                        xmlwriter.WriteElementString("FtpServerUserName", appSetting.FtpServerUserName);
                        xmlwriter.WriteElementString("FtpServerPassword", appSetting.FtpServerPassword);


                        xmlwriter.WriteEndElement();
                    }
                    catch { }


                    xmlwriter.WriteEndElement();

                    xmlwriter.WriteEndDocument();
                    xmlwriter.Close();

                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            else
            {
                try
                {
                    using (XmlTextReader xmlreader = new XmlTextReader(filename))
                    {
                        while (xmlreader.Read())
                        {
                            xmlreader.MoveToElement();
                            try
                            {
                                switch (xmlreader.Name)
                                {
                                    case "Config":
                                        {
                                            AppSettingInfo settingInfo = new AppSettingInfo();
                                            while (xmlreader.Read())
                                            {
                                                bool dobreak = false;
                                                xmlreader.MoveToElement();
                                                switch (xmlreader.Name)
                                                {
                                                    case "MQTTServerAddress":
                                                        settingInfo.MQTTServerAddress = xmlreader.ReadString();
                                                        break;
                                                    case "MQTTServerPort":
                                                        settingInfo.MQTTServerPort = xmlreader.ReadString();
                                                        break;
                                                    case "MQTTServerUserName":
                                                        settingInfo.MQTTServerUserName = xmlreader.ReadString();
                                                        break;
                                                    case "MQTTServerPassword":
                                                        settingInfo.MQTTServerPassword = xmlreader.ReadString();
                                                        break;

                                                    case "FtpServerAddress":
                                                        settingInfo.FtpServerAddress = xmlreader.ReadString();
                                                        break;
                                                    case "FtpServerUserName":
                                                        settingInfo.FtpServerUserName = xmlreader.ReadString();
                                                        break;
                                                    case "FtpServerPassword":
                                                        settingInfo.FtpServerPassword = xmlreader.ReadString();
                                                        break;

                                                    case "Config":
                                                        appSetting = settingInfo;
                                                        break;

                                                }
                                                if (dobreak)
                                                    break;
                                            }
                                            string temp = xmlreader.ReadString();
                                        }
                                        break;
                                    case "xml":
                                        break;
                                    default:
                                        if (xmlreader.Name == "") // line feeds
                                            break;
                                        break;
                                }
                            }
                            catch (Exception ee) { Console.WriteLine(ee.Message); } // silent fail on bad entry
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine("Bad Appsetting File: " + ex.ToString()); } // bad config file


            }
        }


        public MainForm()
        {
            SetWelcomeformVisible(true);
            InitializeComponent();
            readAppConfig();
            initMqttClient();
            initDockList();
            logger.Info("MainForm init");
        }
        welcomeForm wf;
        void SetWelcomeformVisible(bool visible)
        {
            if (visible)
            {
                if (wf == null || wf.IsDisposed)
                {
                    wf = new welcomeForm();
                    wf.ShowDialog();
                    this.Refresh();
                }
                else
                    wf.Activate();
            }
            else
            {
                if (wf != null)
                {
                    wf.Close();
                }
            }

        }

        private void initDockList()
        {
            docksList1.DockItemDoubleClick += DocksList1_DockItemDoubleClick;
            docksList1.DockItemClick += DocksList1_DockItemClick;
            docksList1.DockCoverCloseCommand += DocksList1_DockCoverCloseCommand;
            docksList1.DockCoverOpenCommand += DocksList1_DockCoverOpenCommand;
            docksList1.DockHomingCommand += DocksList1_DockHomingCommand;
            docksList1.DockRestartCommand += DocksList1_DockRestartCommand;
            docksList1.FormatDataCommand += DocksList1_FormatDataCommand;
            docksList1.GridDebugCommand += DocksList1_GridDebugCommand;
            docksList1.WeaterSettingCommand += DocksList1_WeaterSettingCommand;

            docksList1.FTPUploadCommand += DocksList1_FTPUploadCommand;
            docksList1.DockUseRequestCommand += DocksList1_DockUseRequestCommand;
        }

        bool dockUse = false;
        private void DocksList1_DockUseRequestCommand(object sender, EventArgs e)
        {
            if (dockManager.CurrentDock == null)
                return;

            string payload = DockCommandGenerator.GenerateCommand(dockManager.CurrentDock.Id, "DockUse", dockUse?"use":"cancel");
            string topic = "dock/" + dockManager.CurrentDock.Id + "/command";

            publishCommand(topic, payload);
            logger.Info("dock: DockUse:" + (dockUse ? "use" : "cancel"));

            dockUse = !dockUse;
        }

        private void DocksList1_FTPUploadCommand(object sender, EventArgs e)
        {
            FTPClient.UploadFile(FTPServerAddress, FTPServerUserName, FTPServerPassword, System.Environment.CurrentDirectory + "\\logs\\logfile.log");
            
        }

        private void DocksList1_WeaterSettingCommand(object sender, EventArgs e)
        {
            if (dockManager.CurrentDock == null)
                return;

            string payload = DockCommandGenerator.GenerateWeatherCommand(dockManager.CurrentDock.Id, "set_alert_threshold_1", docksList1);
            string topic = "dock/" + dockManager.CurrentDock.Id + "/command";

            publishCommand(topic, payload);
            logger.Info("dock: WeaterSetting");
        }

        private void DocksList1_GridDebugCommand(object sender, EventArgs e)
        {
            if (dockManager.CurrentDock == null)
                return;
            string payload = DockCommandGenerator.GenerateCommand(dockManager.CurrentDock.Id, "GridDebug", "");
            string topic = "dock/" + dockManager.CurrentDock.Id + "/command";

            publishCommand(topic, payload);
            logger.Info("dock: GridDebug");
        }

        private void DocksList1_FormatDataCommand(object sender, EventArgs e)
        {
            if (dockManager.CurrentDock == null)
                return;
            string payload = DockCommandGenerator.GenerateCommand(dockManager.CurrentDock.Id, "FormatData", "");
            string topic = "dock/" + dockManager.CurrentDock.Id + "/command";

            publishCommand(topic, payload);
            logger.Info("dock: FormatData");
        }

        private void DocksList1_DockRestartCommand(object sender, EventArgs e)
        {
            if (dockManager.CurrentDock == null)
                return;
            string payload = DockCommandGenerator.GenerateCommand(dockManager.CurrentDock.Id, "Restart", "");
            string topic = "dock/" + dockManager.CurrentDock.Id + "/command";

            publishCommand(topic, payload);
            logger.Info("dock: restart");
        }

        private void DocksList1_DockHomingCommand(object sender, EventArgs e)
        {
            if (dockManager.CurrentDock == null)
                return;
            string payload = DockCommandGenerator.GenerateCommand(dockManager.CurrentDock.Id, "homing", "start");
            string topic = "dock/" + dockManager.CurrentDock.Id + "/command";

            publishCommand(topic, payload);
            logger.Info("dock Homing: start");
        }

        private void DocksList1_DockCoverOpenCommand(object sender, EventArgs e)
        {
            if (dockManager.CurrentDock == null)
                return;
            string payload = DockCommandGenerator.GenerateCommand(dockManager.CurrentDock.Id, "cover", "open");
            string topic = "dock/" + dockManager.CurrentDock.Id + "/command";

            publishCommand(topic, payload);
            logger.Info("dock Cover: open");
        }

        private void DocksList1_DockCoverCloseCommand(object sender, EventArgs e)
        {
            if (dockManager.CurrentDock == null)
                return;
            string payload = DockCommandGenerator.GenerateCommand(dockManager.CurrentDock.Id, "cover", "close");
            string topic = "dock/" + dockManager.CurrentDock.Id + "/command";

            publishCommand(topic, payload);
            logger.Info("dock Cover: close");
        }

        private void DocksList1_DockItemClick(Dock obj)
        {
            dockManager.CurrentDock = obj;
            this.docksList1.UpdateDockManager(dockManager);
        }

        //点击机库进入详情
        private void DocksList1_DockItemDoubleClick(Dock obj)
        {
            
            AddDockDetalPage(obj);
            logger.Info("double click on item id:"+obj.Id);
        }

        //进入详情页面
        private void AddDockDetalPage(Dock dock)
        {
            if (dockDetailPanel != null && !docksList1.Visible)
                return;

            docksList1.Visible = false;
            dockDetailPanel = new DockDetailPanel();
            dockDetailPanel.Dock = DockStyle.Fill;
            dockDetailPanel.DeleteRequested += DockDetailPanel_DeleteRequested;
            dockDetailPanel.TakeoffCommand += DockDetailPanel_TakeoffCommand;
            dockDetailPanel.RTLCommand += DockDetailPanel_RTLCommand;
            dockDetailPanel.GetWPsCommand += DockDetailPanel_GetWPsCommand;
            dockDetailPanel.SendWPsCommand += DockDetailPanel_SendWPsCommand;
            dockDetailPanel.GotoCommand += DockDetailPanel_GotoCommand;
            dockDetailPanel.GetRTSPUrlCommand += DockDetailPanel_GetRTSPUrlCommand;

            dockDetailPanel.DropCommand += DockDetailPanel_DropCommand;
            dockDetailPanel.StartMissionCommand += DockDetailPanel_StartMissionCommand;
            dockDetailPanel.ContinueMissionCommand += DockDetailPanel_ContinueMissionCommand;
            dockDetailPanel.PauseMissionCommand += DockDetailPanel_PauseMissionCommand;
            dockDetailPanel.AbortMissionCommand += DockDetailPanel_AbortMissionCommand;
            dockDetailPanel.SwitchOnOffCommand += DockDetailPanel_DroneSwitchOnOffCommand;
            dockDetailPanel.RequestLandingDockCommand += DockDetailPanel_RequestLandingDockCommand;
            dockDetailPanel.CommandFlightCommand += DockDetailPanel_CommandFlightCommand;




            this.panel1.Controls.Add(dockDetailPanel);
        }

        private void DockDetailPanel_CommandFlightCommand(object sender, EventArgs e)
        {
            if (droneManager.CurrentDrone == null)
                return;
            string payload = UAVCommandGenerator.GenerateCommCommand(droneManager.CurrentDrone.Id, "CommandFlight", dockDetailPanel.CommandFlight?"start":"stop");
            string topic = "drone/" + droneManager.CurrentDrone.Id + "/command";

            publishCommand(topic, payload);
            logger.Info($"CommandFlight "+ (dockDetailPanel.CommandFlight ? "start" : "stop"));
        }

        private void DockDetailPanel_RequestLandingDockCommand(object sender, EventArgs e)
        {
            if (droneManager.CurrentDrone == null)
                return;
            string payload = UAVCommandGenerator.GenerateCommCommand(droneManager.CurrentDrone.Id, "RequestLandingDock", "");
            string topic = "drone/" + droneManager.CurrentDrone.Id + "/command";

            publishCommand(topic, payload);
            logger.Info($"RequestLandingDock");
        }

        private void DockDetailPanel_DroneSwitchOnOffCommand(object sender, EventArgs e)
        {
            if (droneManager.CurrentDrone == null)
                return;
            string payload = UAVCommandGenerator.GenerateCommCommand(droneManager.CurrentDrone.Id,"DroneSwitch" , dockDetailPanel.DroneSwitchOn?"On": "Off");
            string topic = "drone/" + droneManager.CurrentDrone.Id + "/command";
            dockDetailPanel.DroneSwitchOn = !dockDetailPanel.DroneSwitchOn;
            publishCommand(topic, payload);
            logger.Info($"DroneSwitch:{dockDetailPanel.DroneSwitchOn}");
        }


        //发送航线
        private void DockDetailPanel_SendWPsCommand(object sender, EventArgs e)
        {
            if (droneManager.CurrentDrone == null)
                return;
            string payload = UAVCommandGenerator.GenerateWPListCommand(droneManager.CurrentDrone.Id, "SendWPs", dockDetailPanel.FlightWPs, dockDetailPanel.DefaultAlt);
            string topic = "drone/" + droneManager.CurrentDrone.Id + "/command";

            publishCommand(topic, payload);

            logger.Info($"SendWPs");
        }

        private void DockDetailPanel_AbortMissionCommand(object sender, EventArgs e)
        {
            if (droneManager.CurrentDrone == null)
                return;
            string payload = UAVCommandGenerator.GenerateCommCommand(droneManager.CurrentDrone.Id, "Mission", "abort");
            string topic = "drone/" + droneManager.CurrentDrone.Id + "/command";

            publishCommand(topic, payload);
            logger.Info($"Mission:abort");
        }

        private void DockDetailPanel_PauseMissionCommand(object sender, EventArgs e)
        {
            if (droneManager.CurrentDrone == null)
                return;
            string payload = UAVCommandGenerator.GenerateCommCommand(droneManager.CurrentDrone.Id, "Mission", "pause");
            string topic = "drone/" + droneManager.CurrentDrone.Id + "/command";

            publishCommand(topic, payload);
            logger.Info($"Mission:pause");
        }

        private void DockDetailPanel_ContinueMissionCommand(object sender, EventArgs e)
        {
            if (droneManager.CurrentDrone == null)
                return;
            string payload = UAVCommandGenerator.GenerateCommCommand(droneManager.CurrentDrone.Id, "Mission", "continue");
            string topic = "drone/" + droneManager.CurrentDrone.Id + "/command";

            logger.Info($"Mission:continue");
            publishCommand(topic, payload);
        }

        private void DockDetailPanel_StartMissionCommand(object sender, EventArgs e)
        {
            if (droneManager.CurrentDrone == null)
                return;
            string payload = UAVCommandGenerator.GenerateCommCommand(droneManager.CurrentDrone.Id, "Mission", "start");
            string topic = "drone/" + droneManager.CurrentDrone.Id + "/command";

            publishCommand(topic, payload);
            logger.Info($"Mission:start");
        }

        private void DockDetailPanel_DropCommand(object sender, EventArgs e)
        {
            if (droneManager.CurrentDrone == null)
                return;
            string payload = UAVCommandGenerator.GenerateCommCommand(droneManager.CurrentDrone.Id, "drop", "");
            string topic = "drone/" + droneManager.CurrentDrone.Id + "/command";

            publishCommand(topic, payload);
            logger.Info($"drop");
        }

        private void DockDetailPanel_GetRTSPUrlCommand(object sender, EventArgs e)
        {
            if (droneManager.CurrentDrone == null)
                return;
            string payload = UAVCommandGenerator.GenerateCommCommand(droneManager.CurrentDrone.Id, "Get_Gimbal_Info", "");
            string topic = "drone/" + droneManager.CurrentDrone.Id + "/command";

            publishCommand(topic, payload);
            logger.Info($"Get_Gimbal_Info");
        }

        private void DockDetailPanel_GetWPsCommand(object sender, EventArgs e)
        {
            if (droneManager.CurrentDrone == null)
                return;
            string payload = UAVCommandGenerator.GenerateCommCommand(droneManager.CurrentDrone.Id, "get_route", "");
            string topic = "drone/" + droneManager.CurrentDrone.Id + "/command";

            publishCommand(topic, payload);
            logger.Info($"get_route");
        }

        private void DockDetailPanel_GotoCommand(object sender, DockDetailPanel.GotoCommandEventArgs e)
        {
            if (droneManager.CurrentDrone == null)
                return;
            string payload = UAVCommandGenerator.GenerateGotoCommand(droneManager.CurrentDrone.Id, "goto", e.Long, e.Lat,e.Alt);
            string topic = "drone/" + droneManager.CurrentDrone.Id + "/command";

            publishCommand(topic, payload);
            logger.Info($"goto command: +Lng:{e.Long}  Lat:{e.Lat}  Alt:{e.Alt}");
        }

        private void DockDetailPanel_RTLCommand(object sender, EventArgs e)
        {
            if (droneManager.CurrentDrone == null)
                return;
            string payload = UAVCommandGenerator.GenerateCommCommand(droneManager.CurrentDrone.Id, "rtl", "");
            string topic = "drone/" + droneManager.CurrentDrone.Id + "/command";

            logger.Info($"rtl");
            publishCommand(topic, payload);
        }

        private void DockDetailPanel_TakeoffCommand(object sender, EventArgs e)
        {
            if (droneManager.CurrentDrone == null)
                return;
            string payload = UAVCommandGenerator.GenerateCommCommand(droneManager.CurrentDrone.Id, "takeoff","");
            string topic = "drone/" + droneManager.CurrentDrone.Id + "/command";

            publishCommand(topic, payload);
            logger.Info($"takeoff");
        }

        private void DockDetailPanel_DeleteRequested(object sender, EventArgs e)
        {
            // 删除触发DeleteRequested事件的UserControl
            if (sender is DockDetailPanel userControl)
            {
                this.Controls.Remove(userControl);
                userControl.Dispose();
            }
            this.docksList1.Visible = true;
        }

        private async void buttonConnAndSubscribe_Click(object sender, EventArgs e)
        {
            if(mqttClient == null)
            {
                return;
            }
            try
            {
                if (!mqttClient.IsConnected)
                {
                    await mqttClient.ConnectAsync(mqttClientOptions);

                    subscribeTopic($"dock/+/status");

                    subscribeTopic($"drone/+/status");

                    subscribeTopic($"dock/+/response");

                    subscribeTopic($"drone/+/response");
                }
                else
                {
                    await mqttClient.DisconnectAsync();
                }
            }
            catch (Exception ex)
            {
                this.textBoxStatus.Text = ($"连接到Broker失败：{ex.Message}");
                logger.Error( ex );
            }
        }

        private void initMqttClient()
        {
            mqttFactory = new MqttFactory();
            mqttClient = mqttFactory.CreateMqttClient();

            var tlsOptions = new MqttClientTlsOptions
            {
                //UseTls = true,
                IgnoreCertificateChainErrors = true,
                IgnoreCertificateRevocationErrors = true
            };

            mqttClientOptions = new MqttClientOptionsBuilder()
                .WithClientId("dataCenter")
                .WithTcpServer(MqttServerAddress, int.Parse(MqttServerPort)) // 这里替换成你的broker地址和端口
                .WithCredentials(MqttServerUserName, MqttServerPassword)   // 如果需要用户名和密码认证
                .WithTlsOptions(tlsOptions)
                .Build();

            mqttClient.ConnectedAsync += MqttClient_ConnectedAsync;

            mqttClient.ApplicationMessageReceivedAsync += MqttClient_ApplicationMessageReceivedAsync;

            mqttClient.DisconnectedAsync += MqttClient_DisconnectedAsync;
        }

        private Task MqttClient_DisconnectedAsync(MqttClientDisconnectedEventArgs arg)
        {
            this.BeginInvoke(new Action(() =>
            {
                if (arg.ClientWasConnected)
                {
                    this.textBoxStatus.Text = "已断开";
                    button1.Text = "连接";
                }
            }));
            return Task.CompletedTask;
        }

        private Task MqttClient_ApplicationMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs arg)
        {
            this.BeginInvoke(new Action(() =>
            {
                string json = Encoding.UTF8.GetString(arg.ApplicationMessage.PayloadSegment.Array);
                string Topic = arg.ApplicationMessage.Topic;
                string QoS = arg.ApplicationMessage.QualityOfServiceLevel.ToString();
                string Retained = arg.ApplicationMessage.Retain.ToString();
                
                this.textBoxStatus.Text = $"[接收] >> Topic:{Topic} QoS:{QoS} Retained:{Retained} json:{json}";

                HandleMessage(Topic, json);
            }));
            return Task.CompletedTask;
        }

        //根据topic来更新消息
        private void HandleMessage(string topic, string message)
        {
            string entity = null;

            switch (topic.Split('/')[0])
            {
                case "drone":
                    entity = "drone";
                    break;
                case "dock":
                    entity = "dock";
                    break;
                default:
                    Console.WriteLine("Unknown entity type.");
                    return;
            }

            // 提取id
            string id = ExtractDockIdFromTopic(entity, topic);

            switch (entity)
            {
                case "drone":
                    HandleDroneMessage(id, message);
                    break;
                case "dock":
                    HandleDockMessage(id, message);
                    break;
                default:
                    Console.WriteLine("Unknown entity type.");
                    break;
            }

            //处理response
            if (topic != null && topic.Split('/').Length > 2)
            {
                if (topic.Split('/')[2].Equals("response"))
                {
                    HandleResponseMessage(topic.Split('/')[0], message);
                }
            }
        }

        private string ExtractDockIdFromTopic(string entity, string topic)
        {
            // 动态生成正则表达式并从topic中提取entity的id
            Regex regex = new Regex($@"{entity}/(\w+)");
            Match match = regex.Match(topic);

            if (match.Success)
            {
                return match.Groups[1].Value;
            }

            return null;
        }

        private void HandleDroneMessage(string droneId, string message)
        {
            try
            {
                // 处理drone相关的消息，例如更新dock的状态等
                JsonMessage message1 = new JsonMessage { Id = droneId, JsonData = message };
                // 处理dock相关的消息，例如更新dock的状态等
                droneManager.UpdateOrAddDrone(message1);
                if (dockDetailPanel != null)
                    this.dockDetailPanel.UpdateDroneInfoOnView(droneManager);
            }
            catch (Exception ex)
            {

                logger.Error("Handle Drone Message error: " + ex);
            }
            
        }

        private void HandleDockMessage(string dockId, string message)
        {
            try
            {
                JsonMessage message1 = new JsonMessage { Id = dockId, JsonData = message };
                // 处理dock相关的消息，例如更新dock的状态等
                dockManager.UpdateOrAddDock(message1);

                this.docksList1.UpdateDockManager(dockManager);
            }
            catch (Exception ex)
            {
                logger.Error("Handle Dock Message error: " + ex);
            }
            
        }

        private void HandleResponseMessage(string type, string message)
        {
            try
            {
                // 处理response相关的消息
                currentResponse.UpdateFromJson(message);
                switch (type)
                {
                    case "dock":
                        switch (currentResponse.Command)
                        {
                            case "mission":
                                DSkinMessageBox.Show(currentResponse.Message,"mission");
                                logger.Info($"getResponse:Mission"+currentResponse.Message);
                                break;
                            case "dockWarning":
                                DSkinMessageBox.Show(currentResponse.Message, "DockWrning");
                                logger.Info($"getResponse:dockWarning" + currentResponse.Message);
                                break;
                            default:
                                break;
                        }
                        break;
                    case "drone":

                        switch (currentResponse.Command)
                        {
                            case "get_route":
                                //droneManager.CurrentDrone.Routes = currentResponse.Routes;
                                if (dockDetailPanel != null)
                                {
                                    this.dockDetailPanel.UpdateDroneRouterOnMap(currentResponse.Routes);
                                    logger.Info($"getResponse:get_route" + currentResponse.Message);
                                }
                                break;

                            case "Get_Gimbal_Info":
                                if (dockDetailPanel != null)
                                {
                                    this.dockDetailPanel.gimbal.ControlPort = currentResponse.ControlPort;
                                    this.dockDetailPanel.gimbal.ControlIP = currentResponse.ControlIP;
                                    this.dockDetailPanel.rtspAddress = currentResponse.RTSPAddress;
                                    logger.Info($"getResponse:Get_Gimbal_Info" + currentResponse.Message);
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }

                this.textBoxStatus.Text = $"[响应] >> Type:{type} ID:{currentResponse.Id} Message:{currentResponse.Message} time: {DateTime.Now.ToString("HH:mm:ss")}";
            }
            catch (Exception ex)
            {

                logger.Error("Handle Response Message error: " + ex);
            }
            

        }

        private Task MqttClient_ConnectedAsync(MqttClientConnectedEventArgs arg)
        {
            this.BeginInvoke(new Action(() =>
            {
                this.textBoxStatus.Text = "已连接";//arg.ConnectResult.ResultCode.ToString();
                button1.Text = "断开";
            }));
            return Task.CompletedTask;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string payload = "dangerous";
            //string topic = "test";

            //publishCommand(topic, payload);
            AddDockDetalPage(null);
        }

        
        //推送订阅消息
        private void publishCommand(string topic, string payload)
        {
            logger.Info("send command topic:" + topic);
            var applicationMessage = new MqttApplicationMessageBuilder()
                .WithPayload(payload)
                .WithTopic(topic)
                .Build();
            if (mqttClient == null || !mqttClient.IsConnected)
                return;
            Task<MqttClientPublishResult> task = mqttClient.PublishAsync(applicationMessage);
            task.Wait();
        }

        private void subscribeTopic(string topic)
        {
            var mqttSubscribeOptions = mqttFactory.CreateSubscribeOptionsBuilder()
                .WithTopicFilter(
                    filter =>
                    {
                        filter.WithTopic(topic);
                    })
                .Build();

            mqttClient.SubscribeAsync(mqttSubscribeOptions, CancellationToken.None);
            logger.Info($"subscribe topic:{topic}");
        }



        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveAppConfig();
        }

        SystemSettingPage settingPage;
        private void dSkinButton2_Click(object sender, EventArgs e)
        {
            if (settingPage == null)
            {
                settingPage = new SystemSettingPage();
                settingPage.Dock = DockStyle.Fill;
                settingPage.SaveConfigRequested += SettingPage_SaveConfigRequested;
                this.panel1.Controls.Add(settingPage);
                settingPage.BringToFront();

                settingPage.initConfig(appSetting);
            }
            else
            {
                settingPage.Visible = true;
                settingPage.BringToFront();
            }
        }

        private void SettingPage_SaveConfigRequested(object sender, AppSettingInfo info)
        {
            MqttServerAddress = info.MQTTServerAddress;
            MqttServerPort = info.MQTTServerPort ;
            MqttServerUserName = info.MQTTServerUserName;
            MqttServerPassword = info.MQTTServerPassword;
            FTPServerAddress = info.FtpServerAddress;
            FTPServerUserName = info.FtpServerUserName;
            FTPServerPassword = info.FtpServerPassword;
            DSkinMessageBox.Show("参数设置成功");
            settingPage.Visible = false;
            settingPage.SendToBack();
        }


    }
}
