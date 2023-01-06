using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Reflection;
using Weather.Forms;

namespace Weather.Classes
{
    internal static class AppConfiguration
    {
        public static Configuration? Configuration { get; set; }

        public static string PathFolder { get; set; }
        = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;

        public static async Task InitAsync()
        {
            var path = System.IO.Path.Combine(PathFolder, "appsettings.json");

            var check = File.Exists(path);
            if (!check)
            {
                var initConfiguration = new Configuration();
                initConfiguration.WeatherClient.WeatherApiURL = "https://api.weatherapi.com";
                await SetAsync(initConfiguration);

                var formGeneralSetting = new FormApiSetting();
                var result = formGeneralSetting.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var configuration = formGeneralSetting.Configuration;
                    await SetAsync(configuration);
                }
            }
        }

        public static Configuration Get()
        {
            if (Configuration is not null)
            {
                return Configuration;
            }
            return Configuration = new ConfigurationBuilder()
                .SetBasePath(PathFolder)
                .AddJsonFile("appsettings.json").Build()
                .Get<Configuration>()!;
        }

        public static string? GetAPIKey()
        {
            var configuration = Get();
            return configuration.WeatherClient.ApiKey;
        }

        public static string? GetBaseAPIUrl()
        {
            var configuration = Get();
            return configuration.WeatherClient.WeatherApiURL;
        }

        public static async Task SetAsync(Configuration configuration)
        {
            var json = JsonConvert.SerializeObject(configuration);

            var path = System.IO.Path.Combine(PathFolder, "appsettings.json");

            await File.WriteAllTextAsync(path, json, System.Text.Encoding.UTF8);
        }

        public static void Remove()
        {
            var path = System.IO.Path.Combine(PathFolder, "appsettings.json");

            var check = File.Exists(path);

            if (check)
            {
                File.Delete(path);
            }
        }
    }

    internal class Configuration
    {
        public WeatherClient WeatherClient { get; set; } = new();
    }

    internal class WeatherClient
    {
        public string ApiKey { get; set; } = string.Empty;
        public string WeatherApiURL { get; set; } = string.Empty;
    }
}
