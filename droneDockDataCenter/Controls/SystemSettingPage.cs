using droneDockDataCenter.Modle;
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
        public event EventHandler SaveConfigRequested;

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
        }

        private void dSkinButtonSaveConfig_Click(object sender, EventArgs e)
        {
            // 触发DeleteRequested事件
            SaveConfigRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
