using OpenQA.Selenium;
using SwagLabsLoginTests.Pages;
using SwagLabsLoginTests.Drivers;
using FluentAssertions;
using SwagLabsLoginTests.Utils;
using Serilog;

namespace SwagLabsLoginTests.Tests
{
    public class LoginPageTestEmptyCredentials : BaseLoginPageTest
    {
        [Theory]
        [InlineData("Chrome")]
        [InlineData("Firefox")]
        [InlineData("Edge")]
        public void TestLoginFormWithEmptyCredentials_ShowsUsernameRequiredError(string browserType)
        {
            TestLogger.Initialize();
            Log.Information("UC-1: Test Login form with empty credentials");

            Log.Information("Starting test for browser {BrowserType}", browserType);
            InitializeDriver(browserType);
            var loginPage = new LoginPage(driver!);

            Log.Information("Opening the login page.");
            loginPage.Open();

            Log.Information("Entering username and password.");
            loginPage.InputUsername("any_username");
            loginPage.InputPassword("any_password");

            Log.Information("Clearing username and password.");
            loginPage.ClearUsername();
            loginPage.ClearPassword();

            Log.Information("Clicking the login button.");
            loginPage.ClickLoginButton();

            string errorMessage = loginPage.GetErrorMessage();
            Log.Information("ErrorMessage: {errorMessage}", errorMessage);

            errorMessage.Should().Be("Epic sadface: Username is required");
            Log.Information("Test completed successfully.");
            Log.CloseAndFlush();
        }
    }
}
