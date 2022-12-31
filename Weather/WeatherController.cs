using Exportable.Engines.Excel;
using Newtonsoft.Json;
using System.Web;
using Weather.Classes;

namespace Weather
{
    internal class WeatherController
    {

        public string? ApiKey { get; set; }

        public WeatherController()
        {
            var apiKey = AppConfiguration.GetAPIKey("ApiKey:Default");
            if (apiKey is null) throw new Exception("Khong tim thay api key trong appsettings.json");
            ApiKey = apiKey;
        }

        public async Task<ResponseCurrentWeatherApi?>
            GetCurrentWeather(string queryName)
        {
            //var url = $"https://api.weatherapi.com/v1/current.json?key={ApiKey}&lang=vi&aqi=yes&q=hanoi";

            var builder = new UriBuilder("https://api.weatherapi.com");
            builder.Path = "v1/current.json";
            builder.Port = -1;

            var query = HttpUtility.ParseQueryString(builder.Query);
            query["key"] = ApiKey;
            query["lang"] = Language.vi.ToString();
            query["aqi"] = "yes";
            query["q"] = queryName;

            builder.Query = query.ToString();

            var url = builder.ToString();

            var httpClient = new HttpClient();

            var responseBody = await httpClient.GetStringAsync(url);
            var result = JsonConvert
                .DeserializeObject<ResponseCurrentWeatherApi>(responseBody);
            return result;

        }

        public async Task<List<Location>?>
            GetLocations(string locationNameQuery)
        {
            // https://api.weatherapi.com/v1/search.json?key=aed204a3b40a4db9b2690016223012&q=lond
            var httpClient = new HttpClient();

            var builder = new UriBuilder
                ("https://api.weatherapi.com");
            builder.Port = -1;
            builder.Path = "v1/search.json";

            var query = HttpUtility.ParseQueryString(builder.Query);
            query["key"] = ApiKey;
            query["q"] = locationNameQuery;

            builder.Query = query.ToString();

            var url = builder.ToString();

            var response = await httpClient.GetStringAsync(url);
            var result = JsonConvert
                    .DeserializeObject<List<Location>>(response);
            return result;


        }

        public async Task<string> ExportToExcel(CurrentWeather currentWeather, Location location, string pathToFolder)
        {
            IExcelExportEngine engine = new ExcelExportEngine();
            var list = new List<CurrentWeather>();
            list.Add(currentWeather);
            engine.SetFormat(ExcelVersion.XLS);
            engine.AddData(list);
            var stream = engine.Export();
            var path = pathToFolder + $"\\{location.Name}-{location.LocalTimeEpoch}.xls";
            using var file = new FileStream(
                path,
                FileMode.Create,
                FileAccess.Write
                );
            await stream.CopyToAsync(file);
            return path;
        }

        enum Language
        {
            vi,
            ja,
            ru,
            ko,
            de
        }
    }
}
