using GMap.NET.MapProviders;
using GMap.NET;
using MQTTnet;
using MQTTnet.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace droneDockDataCenter
{
    public partial class MainForm : Form
    {
        public IMqttClient mqttClient;
        public MqttClientOptions mqttClientOptions;

        public MqttFactory mqttFactory;

        public MainForm()
        {
            InitializeComponent();
            initMqttClient();
        }

        

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (mqttClient != null)
                {
                    await mqttClient.ConnectAsync(mqttClientOptions);
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
            }));
            return Task.CompletedTask;
        }

        private Task MqttClient_ConnectedAsync(MqttClientConnectedEventArgs arg)
        {
            this.BeginInvoke(new Action(() =>
            {
                this.textBox1.Text = arg.ConnectResult.ToString();
            }));
            return Task.CompletedTask;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string payload = "dangerous";
            string topic = "test";
            var applicationMessage = new MqttApplicationMessageBuilder()
                .WithPayload(payload)
                .WithTopic(topic)
                .Build();
            if (mqttClient == null || !mqttClient.IsConnected)
                return;
            Task<MqttClientPublishResult> task = mqttClient.PublishAsync(applicationMessage);
            task.Wait();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var mqttSubscribeOptions = mqttFactory.CreateSubscribeOptionsBuilder()
                .WithTopicFilter(
                    f =>
                    {
                        f.WithTopic("test1");
                    })
                .Build();

            mqttClient.SubscribeAsync(mqttSubscribeOptions, CancellationToken.None);
        }
    }
}
