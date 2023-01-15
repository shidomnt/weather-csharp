using Newtonsoft.Json;
using Weather.Classes.Serialization.WeatherVisualCrossing;

namespace Weather.Classes.Serialization
{
    internal class ResponseCurrentWeatherApi
    {
        [JsonProperty("location")]
        public CurrentLocation Location { get; set; } = null!;

        [JsonProperty("current")]
        public CurrentWeather CurrentWeather { get; set; } = null!;

        [JsonIgnore]
        public WeatherVisualCrossingInfo? VisualCrossing { get; set; }

    }
}
