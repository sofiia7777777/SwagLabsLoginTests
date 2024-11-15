using System;
using System.Collections.Generic;

namespace SwagLabsLoginTests.Drivers
{
   public static class BrowserTestData
    {
        public static IEnumerable<object[]> GetBrowserTestData()
        {
            var browsers = new[] { "Chrome", "Firefox", "Edge" };
            var users = new[]
            {
            "standard_user",
            "problem_user",
            "performance_glitch_user",
            "error_user",
            "visual_user"
            };

            foreach (var browser in browsers)
            {
                foreach (var user in users)
                {
                    yield return new object[] { browser, user };
                }
            }
        }
    }
}
