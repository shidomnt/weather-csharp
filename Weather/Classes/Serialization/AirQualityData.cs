using Newtonsoft.Json;
using Weather.Helpers;

namespace Weather.Classes.Serialization
{
    internal class AirQualityData
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
        public int UsEpaIndex { get; set; }
        [JsonProperty("gb-defra-index")]
        public int GbDefraIndex { get; set; }
        public override string ToString()
        {
            return AQIHelper.CalculateTotalAQI(this).Value.ToString();
        }

    }
}
