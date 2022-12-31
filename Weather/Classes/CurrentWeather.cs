using Newtonsoft.Json;

namespace Weather.Classes
{
    internal class CurrentWeather
    {

        [JsonProperty("condition")]
        public WeatherCondition Condition { get; set; } = null!;
        [JsonProperty("air_quality")]
        public AirQuality AirQuality { get; set; } = null!;
        [JsonProperty("last_updated_epoch")]
        public int LastUpdatedEpoch { get; set; }
        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }
        [JsonProperty("temp_c")]
        public float TempC { get; set; }
        [JsonProperty("temp_f")]
        public float TempF { get; set; }
        [JsonProperty("is_day")]
        public int IsDay { get; set; }
        [JsonProperty("wind_mph")]
        public float WindMph { get; set; }
        [JsonProperty("wind_kph")]
        public float WindKph { get; set; }
        [JsonProperty("wind_degree")]
        public float WindDegree { get; set; }
        [JsonProperty("wind_dir")]
        public string WindDir { get; set; } = null!;
        [JsonProperty("pressure_mb")]
        public float PressureMb { get; set; }
        [JsonProperty("pressure_in")]
        public float PressureIn { get; set; }
        [JsonProperty("precip_mm")]
        public float PrecipMm { get; set; }
        [JsonProperty("precip_in")]
        public float PrecipIn { get; set; }
        [JsonProperty("humidity")]
        public float Humidity { get; set; }
        [JsonProperty("cloud")]
        public float Cloud { get; set; }
        [JsonProperty("feelslike_c")]
        public float FeelslikeC { get; set; }
        [JsonProperty("feelslike_f")]
        public float FeelslikeF { get; set; }
        [JsonProperty("vis_km")]
        public float VisKm { get; set; }
        [JsonProperty("vis_miles")]
        public float VisMiles { get; set; }
        [JsonProperty("uv")]
        public float Uv { get; set; }
        [JsonProperty("gust_mph")]
        public float GustMph { get; set; }
        [JsonProperty("gust_kph")]
        public float GustKph { get; set; }

    }
}
