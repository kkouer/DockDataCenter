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

namespace droneDockDataCenter
{
    public partial class MainForm : DSkin.Forms.DSkinForm
    {
        public IMqttClient mqttClient;
        public MqttClientOptions mqttClientOptions;

        public MqttFactory mqttFactory;

        public DockManager dockManager = new DockManager();

        public DroneManager droneManager = new DroneManager();

        public MainForm()
        {
            InitializeComponent();
            initMqttClient();
            initDockList();
        }

        private void initDockList()
        {
            docksList1.DockItemDoubleClick += DocksList1_DockItemDoubleClick;
            docksList1.DockItemClick += DocksList1_DockItemClick;
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
            docksList1.Visible = false;
            DockDetailPanel dockDetailPanel = new DockDetailPanel(dock);
            dockDetailPanel.Dock = DockStyle.Fill;
            dockDetailPanel.DeleteRequested += DockDetailPanel_DeleteRequested;
            this.panel1.Controls.Add(dockDetailPanel);
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

        private async void button1_Click(object sender, EventArgs e)
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
                }
                else
                {
                    await mqttClient.DisconnectAsync();
                }
            }
            catch (Exception ex)
            {
                this.textBox1.Text = ($"连接到Broker失败：{ex.Message}");
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
                .WithTcpServer("s567e716.ala.cn-hangzhou.emqxsl.cn", 8883) // 这里替换成你的broker地址和端口
                .WithCredentials("admin", "123456")   // 如果需要用户名和密码认证
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
                    this.textBox1.Text = "Disconnected";
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
                
                this.textBox1.Text = $"[接收] >> Topic:{Topic} QoS:{QoS} Retained:{Retained} json:{json}";

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
                this.textBox1.Text = "Connected";//arg.ConnectResult.ResultCode.ToString();
                button1.Text = "Disconnect";
            }));
            return Task.CompletedTask;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string payload = "dangerous";
            string topic = "test";

            publishCommand(topic, payload);
            
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


    }
}
