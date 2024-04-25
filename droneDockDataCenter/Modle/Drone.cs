using GMap.NET;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace droneDockDataCenter.Modle
{
    public class Drone
    {
        public Drone() { }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("location")]
        public Location Position  { get; set; }

        [JsonProperty("groundSpeed")]
        public float Speed { get; set; }
        [JsonProperty("altitude")]
        public float Alt { get; set; }


    }

    public class Location
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }
        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }


}
