using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace droneDockDataCenter.Modle
{
    /// <summary>
    /// 响应类,用来解析响应json
    /// </summary>
    public class Response
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("command")]
        public string Command { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("route_data")]
        public List<route_data> Routes { get; set; }

        public void UpdateFromJson(string json)
        {
            var root = JsonConvert.DeserializeObject<ResponseJsonRoot>(json);

            if (root != null && root.Data != null)
            {
                if (root.Type.Equals("response"))
                {
                    this.Status = root.Data.Status;
                    this.Command = root.Data.Command;
                    this.Message = root.Data.Message;
                    this.Routes = root.Data.Routes;
                    this.Id = root.Data.Id;
                }
            }
        }
    }

    public class route_data
    {

        [JsonProperty("waypoint")]
        public int WaypointIndex {  get; set; }
        [JsonProperty("latitude")]
        public double Latitude { get; set; }
        [JsonProperty("longitude")]
        public double Longitude { get; set; }
        [JsonProperty("altitude")]
        public double Altitude { get; set; }
    }

    public class ResponseJsonRoot
    {
        [JsonProperty("protocol_version")]
        public string ProtocolVersion { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("data")]
        public Response Data { get; set; }
    }
}
