using GMap.NET.WindowsForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace droneDockDataCenter.Modle
{
    public class UAVCommandGenerator
    {
        public static string GenerateGotoCommand(string id, string command, double latitude, double longitude, double altitude)
        {
            var commandObj = new
            {
                protocol_version = 0.1,
                type = "command",
                data = new
                {
                    id = id,
                    command = command,
                    target = new
                    {
                        latitude = latitude,
                        longitude = longitude,
                        altitude = altitude
                    }
                }
            };
            string json = JsonConvert.SerializeObject(commandObj, Formatting.Indented);
            return json;
        }

        public static string GenerateCommCommand(string id, string command, string param)
        {
            var commandObj = new
            {
                protocol_version = 0.1,
                type = "command",
                data = new
                {
                    id = id,
                    command = command,
                    param = param
                }
            };
            string json = JsonConvert.SerializeObject(commandObj, Formatting.Indented);
            return json;
        }


        public static string GenerateWPListCommand(string id, string command, GMapRoute wps, int defaultAlt)
        {
            var waypoints = new List<object>();

            foreach (var point in wps.Points)
            {
                var waypoint = new {
                    Latitude = point.Lat,
                    Longitude = point.Lng,
                    Altitude = defaultAlt
                };
                waypoints.Add(waypoint);
            }
            var commandObj = new
            {
                protocol_version = 0.1,
                type = "command",
                data = new
                {
                    id = id,
                    command = command,
                    waypoints = waypoints
                }
            };
            string json = JsonConvert.SerializeObject(commandObj, Formatting.Indented);
            return json;
        }
    }
}
