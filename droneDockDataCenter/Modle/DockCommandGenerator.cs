using droneDockDataCenter.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace droneDockDataCenter.Modle
{
    public class DockCommandGenerator
    {
        public static string GenerateCommand(string id, string command, string payload)
        {
            var commandObj = new
            {
                protocol_version = 0.1,
                type = "command",
                data = new
                {
                    id = id,
                    command = command,
                    paylod = payload
                }
            };
            string json = JsonConvert.SerializeObject(commandObj, Formatting.Indented);
            return json;
        }

        public static string GenerateWeatherCommand(string id, string command, DocksList docksList1)
        {
            var commandObj = new
            {
                protocol_version = 0.1,
                type = "command",
                data = new
                {
                    id = id,
                    command = command,
                    alerts = new
                    {
                        temperature = new 
                        {
                            low = docksList1.valueModControl2.NumMinValue.Value,
                            high = docksList1.valueModControl2.NumMaxValue.Value
                        },
                        rainfall = new
                        {
                            low = docksList1.valueModControl1.NumMinValue.Value,
                            high = docksList1.valueModControl1.NumMaxValue.Value
                        },
                        wind_speed = new
                        {
                            low = docksList1.valueModControl3.NumMinValue.Value,
                            high = docksList1.valueModControl3.NumMaxValue.Value
                        },
                        humidity = new
                        {
                            low = docksList1.valueModControl4.NumMinValue.Value,
                           high = docksList1.valueModControl4.NumMaxValue.Value
                        }
                    }
                }
            };
            string json = JsonConvert.SerializeObject(commandObj, Formatting.Indented);
            return json;
        }
    }
}
