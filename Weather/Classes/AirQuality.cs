using Newtonsoft.Json;

namespace Weather.Classes
{
    internal class AirQuality
    {
        [JsonProperty("co")]
        public float Co { get; set; }
        [JsonProperty("no2")]
        public float No2 { get; set; }
        [JsonProperty("o3")]
        public float O3 { get; set; }
        [JsonProperty("so2")]
        public float So2 { get; set; }
        [JsonProperty("pm2_5")]
        public float Pm25 { get; set; }
        [JsonProperty("pm10")]
        public float Pm10 { get; set; }
        [JsonProperty("us-epa-index")]
        public float UsEpaIndex { get; set; }
        [JsonProperty("gb-defra-index")]
        public float GbDefraIndex { get; set; }
        public override string ToString()
        {
            return Pm25.ToString();
        }
    }
}
