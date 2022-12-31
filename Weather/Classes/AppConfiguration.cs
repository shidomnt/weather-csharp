using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace Weather.Classes
{
    internal static class AppConfiguration
    {
        public static IConfigurationRoot GetConfigurationRoot()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!)
                .AddJsonFile("appsettings.json").Build();
        }

        public static string? GetAPIKey(string path)
        {
            var configuration = GetConfigurationRoot();
            return configuration[path];
        }
    }
}
