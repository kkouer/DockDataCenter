using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace droneDockDataCenter.Modle
{
    public class Gimbal
    {
        public Gimbal() { }
        public Gimbal(int id) { }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public float Roll { get; set; }
        public float Yaw { get; set; }
        public float Pitch { get; set; }

        public float Zoom { get; set; }

        public string VideoRtspAddress { get; set; }

    }
}
