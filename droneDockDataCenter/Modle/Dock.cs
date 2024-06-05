using System;
using Newtonsoft.Json;

namespace droneDockDataCenter.Modle
{
    /// <summary>
    /// 机库类
    /// </summary>
    public class Dock
    {
        public Dock() { }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("firmware_version")]
        public string FirmwareVersion { get; set; }
        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }
        [JsonProperty("cover_status")]
        public string CoverStatus { get; set; }
        [JsonProperty("charging_status")]
        public string ChargingStatus { get; set; }
        [JsonProperty("weather_data")]
        public WeatherData WeatherData { get; set; }

        public Drone drone { get; set; }

        // 更新Dock实例的方法
        public void UpdateFromJson(string json)
        {
            var root = JsonConvert.DeserializeObject<DockJsonRoot>(json);

            if (root != null && root.Data != null)
            {
                if (root.Type.Equals("status"))
                {
                    this.Id = root.Data.Id;
                    this.FirmwareVersion = root.Data.FirmwareVersion;
                    this.LastUpdated = root.Data.LastUpdated;
                    this.CoverStatus = root.Data.CoverStatus;
                    this.ChargingStatus = root.Data.ChargingStatus;
                    this.WeatherData = root.Data.WeatherData;
                }
            }
        }

        public bool IsOnLine()
        {
            // 获取当前时间
            DateTime currentTime = DateTime.Now;

            // 计算时间差
            TimeSpan timeDifference = currentTime - LastUpdated;

            // 判断时间差是否超过5秒
            return timeDifference.TotalSeconds <= 5;
        }
    }

    public class WeatherData
    {
        [JsonProperty("temperatureOutside")]
        public double TemperatureOutside { get; set; }

        [JsonProperty("temperatureInside")]
        public double TemperatureInside { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        [JsonProperty("wind_direction")]
        public int WindDirection { get; set; }

        [JsonProperty("waterlogging")]
        public int Waterlogging { get; set; }

        [JsonProperty("shake")]
        public int Shake { get; set; }
    }



}
