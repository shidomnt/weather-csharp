using Newtonsoft.Json;

namespace Weather.Classes
{
    //text": "Có Mây",
    //"icon": "//cdn.weatherapi.com/weather/64x64/night/116.png",
    //"code": 1003
    internal class WeatherCondition
    {
        [JsonProperty("text")]
        public string Text { get; set; } = null!;
        [JsonProperty("day")]
        public string Day { get; set; } = null!;
        [JsonProperty("night")]
        public string Night { get; set; } = null!;
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; } = null!;

        public override string ToString()
        {
            return Text;
        }
    }
}
