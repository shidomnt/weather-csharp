using Newtonsoft.Json;
namespace Weather.Classes.Serialization
{
    //"name": "Hanoi",
    //"region": "",
    //"country": "Vietnam",
    //"lat": 21.03,
    //"lon": 105.85,
    //"tz_id": "Asia/Bangkok",
    //"localtime_epoch": 1672396541,
    //"localtime": "2022-12-30 17:35"
    internal class CurrentLocation
    {
        [JsonProperty("name")]
        public string Name { get; set; } = null!;

        [JsonProperty("region")]
        public string Region { get; set; } = null!;

        [JsonProperty("country")]
        public string Country { get; set; } = null!;

        [JsonProperty("lat")]
        public float Lat { get; set; }

        [JsonProperty("lon")]
        public float Lon { get; set; }

        [JsonProperty("tz_id")]
        public string TzId { get; set; } = null!;

        [JsonProperty("localtime_epoch")]
        public int LocalTimeEpoch { get; set; }

        [JsonProperty("localtime")]
        public DateTime LocalTime { get; set; }


    }
}
