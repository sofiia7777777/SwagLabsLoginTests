using System.Collections.Generic;

namespace Core
{
    public static class BrowserTestData
    {
        public static IEnumerable<object[]> GetBrowserTestData()
        {
            var browser = ConfigurationLoader.GetBrowser();

            yield return new object[] { browser };
        }

        public static IEnumerable<object[]> GetBrowserAndUserNameTestData()
        {
            var browser = ConfigurationLoader.GetBrowser();

            var users = new[]
            {
                "standard_user",
                "problem_user",
                "performance_glitch_user",
                "error_user",
                "visual_user"
            };


            foreach (var user in users)
            {
                yield return new object[] { browser, user };
            }
        }
    }
}
