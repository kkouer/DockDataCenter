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
                    Weather = new
                    {
                        RainMax = docksList1.valueModControl1.NumMaxValue.Value,
                        RainMin = docksList1.valueModControl1.NumMinValue.Value,

                        TemptureMax = docksList1.valueModControl2.NumMaxValue.Value,
                        TemptureMin = docksList1.valueModControl2.NumMinValue.Value,

                        WindSpeedMax = docksList1.valueModControl3.NumMaxValue.Value,
                        WindSpeedMin = docksList1.valueModControl3.NumMinValue.Value,

                        HumidityMax = docksList1.valueModControl4.NumMaxValue.Value,
                        HumidityMin = docksList1.valueModControl4.NumMinValue.Value,
                    }
                }
            };
            string json = JsonConvert.SerializeObject(commandObj, Formatting.Indented);
            return json;
        }
    }
}
