using Newtonsoft.Json;

namespace Weather.Classes
{
    internal class ResponseCurrentWeatherApi
    {
        [JsonProperty("location")]
        public Location Location { get; set; } = null!;

        [JsonProperty("current")]
        public CurrentWeather CurrentWeather { get; set; } = null!;
    }
}
