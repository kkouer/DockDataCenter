using droneDockDataCenter.Modle;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace droneDockDataCenter.Controls
{
    public partial class SystemSettingPage : UserControl
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(SystemSettingPage));

        public delegate void ConfigDelegateHandler(object sender, AppSettingInfo appSetting);

        public event ConfigDelegateHandler SaveConfigRequested;


        AppSettingInfo currentSettings = new AppSettingInfo();

        public SystemSettingPage()
        {
            InitializeComponent();
        }

        public void initConfig(AppSettingInfo appSetting)
        {
            if (!string.IsNullOrEmpty(appSetting.MQTTServerAddress))
            {
                dSkinTextBox1.Text = appSetting.MQTTServerAddress;
            }
            if (!string.IsNullOrEmpty(appSetting.MQTTServerPort))
            {
                dSkinTextBox2.Text = appSetting.MQTTServerPort;
            }
            if (!string.IsNullOrEmpty(appSetting.MQTTServerUserName))
            {
                dSkinTextBox3.Text = appSetting.MQTTServerUserName;
            }
            if (!string.IsNullOrEmpty(appSetting.MQTTServerPassword))
            {
                dSkinTextBox4.Text = appSetting.MQTTServerPassword;
            }
            logger.Info("initConfig");

        }

        private void dSkinButtonSaveConfig_Click(object sender, EventArgs e)
        {
            logger.Info("initConfig");

            currentSettings.MQTTServerAddress = dSkinTextBox1.Text;
            currentSettings.MQTTServerPort = dSkinTextBox2.Text;
            currentSettings.MQTTServerUserName = dSkinTextBox3.Text;
            currentSettings.MQTTServerPassword = dSkinTextBox4.Text;
            // 触发SaveRequested事件
            SaveConfigRequested?.Invoke(this, currentSettings);
            logger.Info("SaveConfigRequested");
        }
    }
}
