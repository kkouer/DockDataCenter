using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace droneDockDataCenter.Modle
{
    public class DroneManager
    {
        public List<Drone> drones = new List<Drone>();

        public Drone CurrentDrone { get; set; }

        // 更新或添加Dock实例的方法
        public void UpdateOrAddDrone(JsonMessage message)
        {
            
            Drone existingDrone = drones.Find(d => d.Id == message.Id);
            if (existingDrone != null)
            {
                existingDrone.UpdateFromJson(message.JsonData); // 更新现有的Drone实例
                CurrentDrone = existingDrone;
            }
            else
            {
                Drone newDrone = new  Drone();
                newDrone.UpdateFromJson(message.JsonData); // 创建并初始化新的Drone实例
                drones.Add(newDrone); // 添加到列表
            }


        }

    }
}
