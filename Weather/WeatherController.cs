using Exportable.Engines.Excel;
using Newtonsoft.Json;
using System.Web;
using Weather.Classes;
using Weather.Classes.Serialization;
using Weather.Classes.Serialization.WeatherVisualCrossing;
using Weather.Constants;
using Weather.Exceptions;

namespace Weather
{
    internal class WeatherController
    {

        public string? ApiKey { get; }

        public string BaseUrl { get; }

        public WeatherController()
        {
            var apiKey = AppConfiguration.GetAPIKey();
            var baseUrl = AppConfiguration.GetBaseAPIUrl();
            if (string.IsNullOrEmpty(apiKey)) throw new ApiKeyNotFoundException();
            if (string.IsNullOrEmpty(baseUrl)) throw new BaseApiUrlNotFoundException();
            ApiKey = apiKey;
            BaseUrl = baseUrl;
        }

        public async Task<ResponseCurrentWeatherApi?>
            GetCurrentWeatherAsync(string queryName)
        {
            var builder = new UriBuilder(BaseUrl);
            builder.Path = "v1/current.json";
            builder.Port = -1;

            var query = HttpUtility.ParseQueryString(builder.Query);
            query["key"] = ApiKey;
            query["lang"] = Language.vi.ToString();
            query["aqi"] = "yes";
            query["q"] = queryName;

            var currentVisualCrossing = await GetCurrentWeatherVisualCrossingAsync(queryName);

            if (currentVisualCrossing is not null)
            {
                query["q"] = $"{currentVisualCrossing.Latitude},{currentVisualCrossing.Longitude}";
            }

            builder.Query = query.ToString();

            var url = builder.ToString();

            var httpClient = new HttpClient();

            var responseBody = await httpClient.GetStringAsync(url);

            var result = JsonConvert
                .DeserializeObject<ResponseCurrentWeatherApi>(responseBody);


            if (result is not null)
                result.VisualCrossing = currentVisualCrossing;

            return result;

        }

        public async Task<ResponseWeatherVisualCrossing?>
            GetCurrentWeatherVisualCrossingAsync(string name)
        {
            var builder = new UriBuilder("https://weather.visualcrossing.com/");
            builder.Path = $"VisualCrossingWebServices/rest/services/timeline/{name}/today";
            builder.Port = -1;

            var query = HttpUtility.ParseQueryString(builder.Query);
            query["key"] = "RS45MUK6NYERNTN7C5MAQMC5Z";
            query["unitGroup"] = "metric";
            query["include"] = "current";
            query["contentType"] = "json";

            builder.Query = query.ToString();
            var url = builder.ToString();
            var httpClient = new HttpClient();

            var responseBody = await httpClient.GetStringAsync(url);
            var result = JsonConvert
                .DeserializeObject<ResponseWeatherVisualCrossing>(responseBody);

            return result;

        }

        public async Task<List<CurrentLocation>?>
            GetLocationsAsync(string locationNameQuery)
        {
            var httpClient = new HttpClient();

            var builder = new UriBuilder
                (BaseUrl);
            builder.Port = -1;
            builder.Path = "v1/search.json";

            var query = HttpUtility.ParseQueryString(builder.Query);
            query["key"] = ApiKey;
            query["q"] = locationNameQuery;

            builder.Query = query.ToString();

            var url = builder.ToString();

            var response = await httpClient.GetStringAsync(url);
            var result = JsonConvert
                    .DeserializeObject<List<CurrentLocation>>(response);
            return result;

        }

        public async Task<string> ExportToExcelAsync(CurrentWeather currentWeather, string path)
        {
            IExcelExportEngine engine = new ExcelExportEngine();
            var list = new List<CurrentWeather>();
            list.Add(currentWeather);
            engine.SetFormat(ExcelVersion.XLS);
            engine.AddData(list);
            var stream = engine.Export();
            using var file = new FileStream(
                path,
                FileMode.Create,
                FileAccess.Write
                );
            await stream.CopyToAsync(file);
            return path;
        }
    }
}
