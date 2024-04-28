using GMap.NET;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace droneDockDataCenter.Modle
{
    public class Drone
    {
        public Drone() { }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("battery")]
        public int Battery { get; set; }
        [JsonProperty("flightMode")]
        public string Mode { get; set; }
        [JsonProperty("location")]
        public Location Position  { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("groundSpeed")]
        public float GroundSpeed { get; set; }
        [JsonProperty("target_groundSpeed")]
        public float TargetGroundSpeed { get; set; }
        [JsonProperty("airSpeed")]
        public float AirSpeed { get; set; }
        [JsonProperty("target_airSpeed")]
        public float TargetAirSpeed { get; set; }
        [JsonProperty("altitude")]
        public float Alt { get; set; }
        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }
        [JsonProperty("real_height")]
        public float Alt_rel {  get; set; }
        [JsonProperty("throttle")]
        public int Throttle { get; set; }
        [JsonProperty("attitude")]
        public Attitude Attitude { get; set; }

        // 更新Dock实例的方法
        public void UpdateFromJson(string json)
        {
            var root = JsonConvert.DeserializeObject<DroneJsonRoot>(json);

            if (root != null && root.Data != null)
            {
                this.Id = root.Data.Id;
                this.LastUpdated = DateTime.Parse(root.Data.LastUpdated.ToString("yyyy-MM-ddTHH:mm:ssZ"));
                this.Position = root.Data.Position;
                this.GroundSpeed = root.Data.GroundSpeed;
                this.Alt = root.Data.Alt;
                this.Battery = root.Data.Battery;
                this.Mode = root.Data.Mode;
                this.Status = root.Data.Status;
                this.Alt_rel = root.Data.Alt_rel;
                this.AirSpeed = root.Data.AirSpeed;
                this.Attitude = root.Data.Attitude;
                this.Throttle = root.Data.Throttle;
                this.TargetAirSpeed = root.Data.TargetAirSpeed;
                this.TargetGroundSpeed = root.Data.TargetGroundSpeed;
            }
        }
    }

    public class DroneJsonRoot
    {
        [JsonProperty("protocol_version")]
        public string ProtocolVersion { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("data")]
        public Drone Data { get; set; }
    }


    public class Location
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }
        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class Attitude
    {
        [JsonProperty("pitch")]
        public float Pitch { get; set; }
        [JsonProperty("roll")] 
        public float Roll { get; set; }

        [JsonProperty("heading")] 
        public float Heading { get; set; }
    }


}
