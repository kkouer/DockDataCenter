using MQTTnet;
using MQTTnet.Client;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using droneDockDataCenter.Modle;
using System.Text.RegularExpressions;
using droneDockDataCenter.Controls;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using DSkin.Forms;
using log4net;

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

        public DockDetailPanel dockDetailPanel = null;

        public string MqttServerAddress { get; set; } = "s567e716.ala.cn-hangzhou.emqxsl.cn";
        public string MqttServerPort { get; set; } = "8883";
        public string MqttServerUserName { get; set; } = "admin";
        public string MqttServerPassword { get; set; } = "123456";

        AppSettingInfo appSetting = new AppSettingInfo();


        void readAppConfig()
        {
            //读取配置
            xmlConfigFile(false, System.AppDomain.CurrentDomain.BaseDirectory + "config.xml");

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

        }

        void saveAppConfig()
        {
            appSetting.MQTTServerAddress = MqttServerAddress;
            appSetting.MQTTServerPort = MqttServerPort;
            appSetting.MQTTServerUserName = MqttServerUserName;
            appSetting.MQTTServerPassword = MqttServerPassword;

            xmlConfigFile(true, System.AppDomain.CurrentDomain.BaseDirectory + "config.xml");
        }
        private void xmlConfigFile(bool write, string filename)
        {
            bool exists = File.Exists(filename);

            if (write || !exists)
            {
                try
                {
                    XmlTextWriter xmlwriter = new XmlTextWriter(filename, Encoding.UTF8);
                    xmlwriter.Formatting = Formatting.Indented;

                    xmlwriter.WriteStartDocument();

                    xmlwriter.WriteStartElement("AppSetting");
                    try
                    {
                        xmlwriter.WriteStartElement("Config");
                        xmlwriter.WriteElementString("MQTTServerAddress", appSetting.MQTTServerAddress);
                        xmlwriter.WriteElementString("MQTTServerPort", appSetting.MQTTServerPort);
                        xmlwriter.WriteElementString("MQTTServerUserName", appSetting.MQTTServerUserName);
                        xmlwriter.WriteElementString("MQTTServerPassword", appSetting.MQTTServerPassword);


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
            InitializeComponent();
            initMqttClient();
            initDockList();
            readAppConfig();
            logger.Info("MainForm init");
        }

        private void initDockList()
        {
            docksList1.DockItemDoubleClick += DocksList1_DockItemDoubleClick;
            docksList1.DockItemClick += DocksList1_DockItemClick;
            docksList1.DockCoverCloseCommand += DocksList1_DockCoverCloseCommand;
            docksList1.DockCoverOpenCommand += DocksList1_DockCoverOpenCommand;
        }

        private void DocksList1_DockCoverOpenCommand(object sender, EventArgs e)
        {
            if (dockManager.CurrentDock == null)
                return;
            string payload = DockCommandGenerator.GenerateCommand(dockManager.CurrentDock.Id, "cover", "open");
            string topic = "dock/" + dockManager.CurrentDock.Id + "/command";

            publishCommand(topic, payload);
        }

        private void DocksList1_DockCoverCloseCommand(object sender, EventArgs e)
        {
            if (dockManager.CurrentDock == null)
                return;
            string payload = DockCommandGenerator.GenerateCommand(dockManager.CurrentDock.Id, "cover", "close");
            string topic = "dock/" + dockManager.CurrentDock.Id + "/command";

            publishCommand(topic, payload);
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
            dockDetailPanel.GotoCommand += DockDetailPanel_GotoCommand;
            this.panel1.Controls.Add(dockDetailPanel);
        }

        private void DockDetailPanel_GotoCommand(object sender, DockDetailPanel.GotoCommandEventArgs e)
        {
            if (droneManager.CurrentDrone == null)
                return;
            string payload = UAVCommandGenerator.GenerateCommand(droneManager.CurrentDrone.Id, "goto", e.Long, e.Lat,e.Alt);
            string topic = "drone/" + droneManager.CurrentDrone.Id + "/command";

            publishCommand(topic, payload);
        }

        private void DockDetailPanel_RTLCommand(object sender, EventArgs e)
        {
            if (droneManager.CurrentDrone == null)
                return;
            string payload = UAVCommandGenerator.GenerateCommand(droneManager.CurrentDrone.Id, "rtl", 0, 0, 0);
            string topic = "drone/" + droneManager.CurrentDrone.Id + "/command";

            publishCommand(topic, payload);
        }

        private void DockDetailPanel_TakeoffCommand(object sender, EventArgs e)
        {
            if (droneManager.CurrentDrone == null)
                return;
            string payload = UAVCommandGenerator.GenerateCommand(droneManager.CurrentDrone.Id, "takeoff", 0, 0, 0);
            string topic = "drone/" + droneManager.CurrentDrone.Id + "/command";

            publishCommand(topic, payload);
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
                UseTls = true,
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
                    this.textBoxStatus.Text = "Disconnected";
                    button1.Text = "Connect";
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
            // 处理drone相关的消息，例如更新dock的状态等
            JsonMessage message1 = new JsonMessage { Id = droneId, JsonData = message };
            // 处理dock相关的消息，例如更新dock的状态等
            droneManager.UpdateOrAddDrone(message1);
            if (dockDetailPanel != null)
                this.dockDetailPanel.UpdateDroneInfoOnView(droneManager);
        }

        private void HandleDockMessage(string dockId, string message)
        {
            JsonMessage message1 = new JsonMessage { Id = dockId, JsonData = message };
            // 处理dock相关的消息，例如更新dock的状态等
            dockManager.UpdateOrAddDock(message1);

            this.docksList1.UpdateDockManager(dockManager);
        }

        private Task MqttClient_ConnectedAsync(MqttClientConnectedEventArgs arg)
        {
            this.BeginInvoke(new Action(() =>
            {
                this.textBoxStatus.Text = "Connected";//arg.ConnectResult.ResultCode.ToString();
                button1.Text = "Disconnect";
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

        private void SettingPage_SaveConfigRequested(object sender, EventArgs e)
        {
            saveAppConfig();
            DSkinMessageBox.Show("Setting saved successfully");
            settingPage.Visible = false;
            settingPage.SendToBack();
        }
    }
}
