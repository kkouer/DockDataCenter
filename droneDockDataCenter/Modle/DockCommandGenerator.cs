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
    }
}
