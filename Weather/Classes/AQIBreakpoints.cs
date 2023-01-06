using Newtonsoft.Json;

namespace Weather.Classes
{
    internal class AQIBreakpoints
    {
        [JsonProperty("O3_8h")]
        public Breakpoint O3 { get; set; }

        //[JsonProperty("O3_1h")]
        //public Breakpoint O3_1h { get; set; }

        [JsonProperty("Pm25")]
        public Breakpoint Pm25 { get; set; }

        [JsonProperty("Pm10")]
        public Breakpoint Pm10 { get; set; }

        [JsonProperty("Co")]
        public Breakpoint Co { get; set; }

        [JsonProperty("So2")]
        public Breakpoint So2 { get; set; }

        [JsonProperty("No2")]
        public Breakpoint No2 { get; set; }

        [JsonProperty("AQI")]
        public Breakpoint AQI { get; set; }
    }
    internal class Breakpoint
    {
        [JsonProperty("Good")]
        public string Good { get; set; }

        [JsonProperty("Moderate")]
        public string Moderate { get; set; }

        [JsonProperty("UnhealthyForSensitiveGroup")]
        public string UnhealthyForSensitiveGroup { get; set; }

        [JsonProperty("Unhealthy")]
        public string Unhealthy { get; set; }

        [JsonProperty("VeryUnhealthy")]
        public string VeryUnhealthy { get; set; }

        [JsonProperty("Hazardous")]
        public string? Hazardous { get; set; }

        [JsonProperty("Hazardous2")]
        public string? Hazardous2 { get; set; }
    }
}
