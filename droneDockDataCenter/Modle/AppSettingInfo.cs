using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace droneDockDataCenter.Modle
{
    public struct AppSettingInfo
    {
        //mqtt相关
        public string MQTTServerAddress;
        public string MQTTServerPort;
        public string MQTTServerUserName;
        public string MQTTServerPassword;

        //云台相关
        public string GimbalControlIP;
        public string GimbalControlPort;
        public string GimbalRTSPAddress;
    }
}
