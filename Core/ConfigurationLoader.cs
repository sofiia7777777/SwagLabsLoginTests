using Microsoft.Extensions.Configuration;

namespace Core
{
    public static class ConfigurationLoader
    {
        private static readonly IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("configuration.json", optional: false, reloadOnChange: true)
           .Build();

        public static string GetBrowser()
        {
            var browser = configuration["Browser"];

            if (string.IsNullOrEmpty(browser))
            {
                throw new KeyNotFoundException("Browser configuration is missing or empty.");
            }

            return browser;
        }
    }
}
