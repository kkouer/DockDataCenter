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
        public static string GenerateCommand(string id, string command, double latitude, double longitude, double altitude)
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
    }
}
