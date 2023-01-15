using Newtonsoft.Json;

namespace Weather.Classes.Serialization.WeatherVisualCrossing
{
    public class ResponseWeatherVisualCrossing : WeatherVisualCrossingInfo
    {
    }

    public class WeatherVisualCrossingInfo
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }
        [JsonProperty("longitude")]
        public double Longitude { get; set; }
        [JsonProperty("resolvedAddress")]
        public string ResolvedAddress { get; set; } = null!;
        [JsonProperty("address")]
        public string Address { get; set; } = null!;
        [JsonProperty("timezone")]
        public string Timezone { get; set; } = null!;
        [JsonProperty("tzoffset")]
        public double Tzoffset { get; set; }

        [JsonProperty("days")]
        public Day[] Days { get; set; } = null!;

        [JsonProperty("stations")]
        public Dictionary<string, Station> Stations { get; set; } = null!;

        [JsonProperty("currentConditions")]
        public CurrentCondition CurrentCondition { get; set; } = null!;
    }

    public class Day : CurrentCondition
    {
        [JsonProperty("tempmax")]
        public double? Tempmax { get; set; }
        [JsonProperty("tempmin")]
        public double? Tempmin { get; set; }
        [JsonProperty("feelslikemax")]
        public double? Feelslikemax { get; set; }
        [JsonProperty("feelslikemin")]
        public double? Feelslikemin { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; } = null!;
    }

    public class Station
    {
        [JsonProperty("distance")]
        public double? Distance { get; set; }
        [JsonProperty("latitude")]
        public double? Latitude { get; set; }
        [JsonProperty("longitude")]
        public double? Longitude { get; set; }
        [JsonProperty("useCount")]
        public double? UseCount { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; } = null!;
        [JsonProperty("name")]
        public string Name { get; set; } = null!;
        [JsonProperty("quality")]
        public int? Quality { get; set; }
        [JsonProperty("contribution")]
        public double? Contribution { get; set; }

    }

    public class CurrentCondition
    {
        [JsonProperty("datetime")]
        public string Datetime { get; set; } = null!;
        [JsonProperty("datetimeEpoch")]
        public int DatetimeEpoch { get; set; }
        [JsonProperty("temp")]
        public double? Temp { get; set; }
        [JsonProperty("feelslike")]
        public double? Feelslike { get; set; }
        [JsonProperty("humidity")]
        public double? Humidity { get; set; }
        [JsonProperty("dew")]
        public double? Dew { get; set; }
        [JsonProperty("precip")]
        public double? Precip { get; set; }
        [JsonProperty("precipprob")]
        public double? Precipprob { get; set; }
        [JsonProperty("snow")]
        public double? Snow { get; set; }
        [JsonProperty("snowdepth")]
        public double? Snowdepth { get; set; }
        [JsonProperty("preciptype")]
        public string[]? Preciptype { get; set; }
        [JsonProperty("windgust")]
        public double? Windgust { get; set; }
        [JsonProperty("windspeed")]
        public double? Windspeed { get; set; }
        [JsonProperty("winddir")]
        public double? Winddir { get; set; }
        [JsonProperty("pressure")]
        public double? Pressure { get; set; }
        [JsonProperty("visibility")]
        public double? Visibility { get; set; }
        [JsonProperty("cloudcover")]
        public double? Cloudcover { get; set; }
        [JsonProperty("solarradiation")]
        public double? Solarradiation { get; set; }
        [JsonProperty("solarenergy")]
        public double? Solarenergy { get; set; }
        [JsonProperty("uvindex")]
        public double? Uvindex { get; set; }
        [JsonProperty("conditions")]
        public string Conditions { get; set; } = null!;
        [JsonProperty("icon")]
        public string Icon { get; set; } = null!;
        [JsonProperty("stations")]
        public string[] Stations { get; set; } = null!;
        [JsonProperty("source")]
        public string Source { get; set; } = null!;
        [JsonProperty("sunrise")]
        public string Sunrise { get; set; } = null!;
        [JsonProperty("sunriseEpoch")]
        public int SunriseEpoch { get; set; }
        [JsonProperty("sunset")]
        public string Sunset { get; set; } = null!;
        [JsonProperty("sunsetEpoch")]
        public int SunsetEpoch { get; set; }
        [JsonProperty("moonphase")]
        public double? Moonphase { get; set; }

    }
}
