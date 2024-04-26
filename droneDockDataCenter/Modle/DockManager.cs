using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace droneDockDataCenter.Modle
{
    public class DockManager
    {
        public List<Dock> docks = new List<Dock>();

        public Dock CurrentDock { get; set; }


        // 更新或添加Dock实例的方法
        public void UpdateOrAddDock(JsonMessage message)
        {
            Dock existingDock = docks.Find(d => d.Id == message.Id);
            if (existingDock != null)
            {
                existingDock.UpdateFromJson(message.JsonData); // 更新现有的Dock实例
            }
            else
            {
                Dock newDock = new Dock();
                newDock.UpdateFromJson(message.JsonData); // 创建并初始化新的Dock实例
                docks.Add(newDock); // 添加到列表
            }

        }

        public void UpdateDroneStatus(JsonMessage message)
        {
            
        }
    }

    // 解析JSON数据的根对象
    public class DockJsonRoot
    {
        [JsonProperty("protocol_version")]
        public string ProtocolVersion { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("data")]
        public Dock Data { get; set; }
    }
   



    // 模拟收到的JSON消息
    public class JsonMessage
    {
        public string Id { get; set; }
        public string JsonData { get; set; }
    }

}
