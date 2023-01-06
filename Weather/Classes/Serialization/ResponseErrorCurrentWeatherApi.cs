using Newtonsoft.Json;
namespace Weather.Classes.Serialization
{
    internal class ResponseErrorCurrentWeatherApi
    {
        [JsonProperty("error")]
        public ErrorBody Error { get; set; }
    }

    internal class ErrorBody
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public int Message { get; set; }
    }
}
