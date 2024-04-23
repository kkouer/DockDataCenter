using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace droneDockDataCenter.Modle
{
    public class Drone
    {
        public Drone() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public  PointLatLng Position  { get; set; }
        public List<PointLatLng> WayPoints { get; set; }



    }
}
