using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace droneDockDataCenter.Modle
{
    /// <summary>
    /// 机库类
    /// </summary>
    public class Dock
    {
        public Dock() { }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        //舱盖开关状态
        public bool SwitchOpened { get; set; }
        public Drone theDrone { get; set; } = null;




    }
}
