using OpenQA.Selenium;
using SwagLabsLoginTests.Pages;
using SwagLabsLoginTests.Drivers;
using FluentAssertions;
using Serilog;
using SwagLabsLoginTests.Utils;
using OpenQA.Selenium.Support.UI;

namespace SwagLabsLoginTests.Tests
{
    public class LoginPageTestValidCredentials : BaseLoginPageTest
    {
        [Theory]
        [MemberData(nameof(BrowserTestData.GetBrowserTestData), MemberType = typeof(BrowserTestData))]
        public void TestLoginFormWithCredentials_ShowsSwagLabsTitleInTheDashboard(string browserType, string username)
        {
            TestLogger.Initialize();

            Log.Information("UC-3 Test Login form with credentials by passing Username & Password");

            Log.Information("Starting test for browser {BrowserType}", browserType);
            InitializeDriver(browserType);
            var loginPage = new LoginPage(driver!);

            Log.Information("Opening the login page.");
            loginPage.Open();

            Log.Information("Entering username and password.");
            loginPage.InputUsername(username);
            loginPage.InputPassword("secret_sauce");

            Log.Information("Clicking the login button.");
            loginPage.ClickLoginButton();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2))
            {
                PollingInterval = TimeSpan.FromSeconds(0.25),
                Message = "Page title has not been found"
            };

            string pageTitle = wait.Until(driver => driver.FindElement(By.ClassName("app_logo"))).Text;
            Log.Information("Title: {pageTitle} in the dashboard", pageTitle);

            pageTitle.Should().Be("Swag Labs");
            Log.Information("Test completed successfully.");
            Log.CloseAndFlush();
        }
    }
}

