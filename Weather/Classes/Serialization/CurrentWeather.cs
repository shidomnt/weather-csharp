using Exportable.Attribute;
using Newtonsoft.Json;
namespace Weather.Classes.Serialization
{
    internal class CurrentWeather
    {
        [Exportable(HeaderName = "Điều kiện thời tiết", Position = 1)]
        [JsonProperty("condition")]
        public WeatherCondition Condition { get; set; } = null!;

        [Exportable(HeaderName = "AQI", Position = 2)]
        [JsonProperty("air_quality")]
        public AirQualityData AirQuality { get; set; } = null!;

        [Exportable(IsIgnored = true)]
        [JsonProperty("last_updated_epoch")]
        public int LastUpdatedEpoch { get; set; }

        [Exportable(HeaderName = "Cập nhật lúc", Position = 3, TypeValue = Exportable.Models.FieldValueType.Date, Format = "dd-MM-yyyy hh:mm:ss AM/PM")]
        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }

        [Exportable(HeaderName = "Nhiệt độ (C)", Position = 4)]
        [JsonProperty("temp_c")]
        public float TempC { get; set; }

        [Exportable(HeaderName = "Nhiệt độ (F)", IsIgnored = true)]
        [JsonProperty("temp_f")]
        public float TempF { get; set; }


        [Exportable(HeaderName = "Ngày", IsIgnored = true, TypeValue = Exportable.Models.FieldValueType.Numeric)]
        [JsonProperty("is_day")]
        public int IsDay { get; set; }

        [Exportable(HeaderName = "Tốc độ gió (mile/h)", IsIgnored = true)]
        [JsonProperty("wind_mph")]
        public float WindMph { get; set; }

        [Exportable(HeaderName = "Tốc độ gió (km/h)", Position = 6)]
        [JsonProperty("wind_kph")]
        public float WindKph { get; set; }

        [Exportable(HeaderName = "Hướng gió (độ)", IsIgnored = true)]
        [JsonProperty("wind_degree")]
        public float WindDegree { get; set; }

        [Exportable(HeaderName = "Hướng gió", Position = 7)]
        [JsonProperty("wind_dir")]
        public string WindDir { get; set; } = null!;

        [Exportable(HeaderName = "Áp suất(mbar)", Position = 8)]
        [JsonProperty("pressure_mb")]
        public float PressureMb { get; set; }

        [Exportable(HeaderName = "Áp suất(in)", IsIgnored = true)]
        [JsonProperty("pressure_in")]
        public float PressureIn { get; set; }

        [Exportable(HeaderName = "Lượng mưa(mm)", Position = 9)]
        [JsonProperty("precip_mm")]
        public float PrecipMm { get; set; }

        [Exportable(HeaderName = "Lượng mưa(in)", IsIgnored = true)]
        [JsonProperty("precip_in")]
        public float PrecipIn { get; set; }

        [Exportable(HeaderName = "Độ ẩm", Position = 10)]
        [JsonProperty("humidity")]
        public float Humidity { get; set; }

        [Exportable(HeaderName = "Mây che phủ(%)", Position = 11)]
        [JsonProperty("cloud")]
        public float Cloud { get; set; }

        [Exportable(HeaderName = "Cảm giác như(C)", Position = 5)]
        [JsonProperty("feelslike_c")]
        public float FeelslikeC { get; set; }

        [Exportable(HeaderName = "Cảm giác như(F)", IsIgnored = true)]
        [JsonProperty("feelslike_f")]
        public float FeelslikeF { get; set; }

        [Exportable(HeaderName = "Tầm nhìn(km)", Position = 13)]
        [JsonProperty("vis_km")]
        public float VisKm { get; set; }

        [Exportable(HeaderName = "Tầm nhìn(mile)", IsIgnored = true)]
        [JsonProperty("vis_miles")]
        public float VisMiles { get; set; }

        [Exportable(HeaderName = "Chỉ số UV", Position = 14)]
        [JsonProperty("uv")]
        public float Uv { get; set; }

        [Exportable(HeaderName = "Gió giật(mile/h)", IsIgnored = true)]
        [JsonProperty("gust_mph")]
        public float GustMph { get; set; }

        [Exportable(HeaderName = "Gió giật(km/h)", Position = 15)]
        [JsonProperty("gust_kph")]
        public float GustKph { get; set; }

    }
}
